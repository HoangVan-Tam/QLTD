namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;

    public partial class init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Customers",
                c => new
                {
                    IdCustomer = c.Int(nullable: false, identity: true),
                    Address = c.String(),
                    CustomerName = c.String(),
                    PhoneNumber = c.String(),
                })
                .PrimaryKey(t => t.IdCustomer);

            CreateTable(
                "dbo.ListRenteds",
                c => new
                {
                    IdListRented = c.Int(nullable: false, identity: true),
                    IdDisk = c.Int(),
                    IdCustomer = c.Int(),
                    LateFee = c.Double(),
                    RentalDate = c.DateTime(),
                    ExpectedReturnDate = c.DateTime(),
                    ActualReturnDate = c.DateTime(),
                    StatusOnBill = c.String(),
                })
                .PrimaryKey(t => t.IdListRented)
                .ForeignKey("dbo.Customers", t => t.IdCustomer)
                .ForeignKey("dbo.Disks", t => t.IdDisk)
                .Index(t => t.IdDisk)
                .Index(t => t.IdCustomer);

            CreateTable(
                "dbo.Disks",
                c => new
                {
                    IdDisk = c.Int(nullable: false, identity: true),
                    IdTitle = c.Int(),
                    DiskRentalStatus = c.String(),
                    DiskStatus = c.String(),
                })
                .PrimaryKey(t => t.IdDisk)
                .ForeignKey("dbo.Titles", t => t.IdTitle)
                .Index(t => t.IdTitle);

            CreateTable(
                "dbo.Titles",
                c => new
                {
                    IdTitle = c.Int(nullable: false, identity: true),
                    IdDiskType = c.Int(),
                    NameTitle = c.String(),
                    TotalDiskOnShelf = c.Int(),
                })
                .PrimaryKey(t => t.IdTitle)
                .ForeignKey("dbo.DiskTypes", t => t.IdDiskType)
                .Index(t => t.IdDiskType);

            CreateTable(
                "dbo.DiskTypes",
                c => new
                {
                    IdDiskType = c.Int(nullable: false, identity: true),
                    TypeName = c.String(),
                    TimeRented = c.Int(),
                    LateFee = c.Double(),
                    Price = c.Double(),
                })
                .PrimaryKey(t => t.IdDiskType);

            CreateTable(
                "dbo.ListTitlePreOrders",
                c => new
                {
                    IdListTitlePreOrder = c.Int(nullable: false, identity: true),
                    IdCustomer = c.Int(),
                    IdTitle = c.Int(),
                    NumberOfDisk = c.Int(),
                    StatusProcess = c.String(),
                })
                .PrimaryKey(t => t.IdListTitlePreOrder)
                .ForeignKey("dbo.Customers", t => t.IdCustomer)
                .ForeignKey("dbo.Titles", t => t.IdTitle)
                .Index(t => t.IdCustomer)
                .Index(t => t.IdTitle);

            CreateTable(
                "dbo.DetailPreOrders",
                c => new
                {
                    IdDetailPreOrder = c.Int(nullable: false, identity: true),
                    IdCustomer = c.Int(),
                    IdDisk = c.Int(),
                    Accepted = c.Boolean(),
                    IdListTitlePreOrder = c.Int(),
                })
                .PrimaryKey(t => t.IdDetailPreOrder)
                .ForeignKey("dbo.Customers", t => t.IdCustomer)
                .ForeignKey("dbo.Disks", t => t.IdDisk)
                .ForeignKey("dbo.ListTitlePreOrders", t => t.IdListTitlePreOrder)
                .Index(t => t.IdCustomer)
                .Index(t => t.IdDisk)
                .Index(t => t.IdListTitlePreOrder);
            // xu li khi them dia thi kiem tra thu cap nhat so luong dia
            Sql(@"CREATE TRIGGER [dbo].[trigger_insert_disk] ON [dbo].[Disks]
                FOR INSERT
                AS
                BEGIN
	                declare @idTitle int
	                declare @count int
	                select top 1 @idTitle=IdTitle from inserted
	                select @count=COUNT(*) from Disks where @idTitle=IdTitle and DiskRentalStatus='OnShelf'
	                update Titles set TotalDiskOnShelf=@count where IdTitle=@idTitle
                END");
            Sql(@"CREATE TRIGGER [dbo].[insert_disk] ON [dbo].[Disks]
                FOR INSERT
                AS
                BEGIN
	                declare @idTitle int
	                declare @idListTitlePreOrder int
	                declare @idCustomer int
	                declare @idDisk int
	                declare @StatusRented nvarchar(max)
	                select top 1 @idTitle=i.IdTitle,@idDisk=i.IdDisk,@StatusRented=i.DiskRentalStatus from inserted i
		                IF @StatusRented!='OnShelf'
		                return
	                select top 1 @idListTitlePreOrder=IdListTitlePreOrder,@idCustomer=IdCustomer from ListTitlePreOrders where IdTitle=@idTitle and NumberOfDisk>0 and StatusProcess='Incompleted'
	                IF @idListTitlePreOrder is not null
		                BEGIN
		                insert into DetailPreOrders values(@idCustomer,@idDisk,0,@idListTitlePreOrder)
		                update Disks set DiskRentalStatus='OnHold' where @idDisk=IdDisk
		                END
                END");
            Sql(@"CREATE TRIGGER [dbo].[add_lst_rented] ON [dbo].[ListRenteds]
                    FOR INSERT
                    AS
                    BEGIN
	                    declare @idDisk int
	                    declare @ActualReturnDate datetime
	                    declare @StatusOnBill nvarchar(max)
	                    select top 1 @idDisk=i.IdDisk,@ActualReturnDate=i.ActualReturnDate,@StatusOnBill=i.StatusOnBill from inserted i
	                    IF @ActualReturnDate is null and @StatusOnBill is null
	                    update Disks set DiskRentalStatus='Rented' where IdDisk=@idDisk
                    END");
            Sql(@"CREATE TRIGGER [dbo].[update_lst_rented_return] ON [dbo].[ListRenteds]
					FOR UPDATE
					AS
					BEGIN
	
						declare @ActualReturnDateDelete datetime
						declare @ActualReturnDate datetime
						declare @StatusOnBillDelete nvarchar(max)
						declare @idListRented int
						declare @idDisk int
						declare @expecteddate datetime
						select top 1 @idDisk=IdDisk,@idListRented=d.IdListRented,@ActualReturnDateDelete=d.ActualReturnDate,@StatusOnBillDelete=d.StatusOnBill,@expecteddate=d.ExpectedReturnDate from deleted d
						
						select top 1 @ActualReturnDate=i.ActualReturnDate from inserted i
						IF @ActualReturnDateDelete is null
						BEGIN
							
							update Disks set DiskRentalStatus='OnShelf' where @idDisk=IdDisk
							
							declare @status nvarchar(max)
							IF @expecteddate<@ActualReturnDate set @status='Unpaid'
							ELSE set @status='Nope'
							update ListRenteds set StatusOnBill=@status where IdListRented=@idListRented

						END
                        END");
            Sql(@" CREATE TRIGGER insert_detail_preorder ON DetailPreOrders
                    FOR INSERT
                    AS
                    BEGIN
	                    declare @IdListTitlePreOrder int
	                    select top 1 @IdListTitlePreOrder=i.IdListTitlePreOrder from inserted i
	                    update ListTitlePreOrders set NumberOfDisk=NumberOfDisk-1 where IdListTitlePreOrder=@IdListTitlePreOrder
	                    declare @count int
	                    select top 1 @count=NumberOfDisk from ListTitlePreOrders where @IdListTitlePreOrder=IdListTitlePreOrder
	                    IF @count =0
	                    update ListTitlePreOrders set StatusProcess='Completed' where IdListTitlePreOrder=@IdListTitlePreOrder
                    END");
            Sql(@"CREATE TRIGGER [dbo].[update_disk] ON [dbo].[Disks]
                FOR UPDATE
                AS
                BEGIN
	                declare @count int
	                declare @idTitle int
	                declare @idListTitlePreOrder int
	                declare @idCustomer int
	                declare @idDisk int
	                declare @StatusRented nvarchar(max)
	                select top 1 @idTitle=i.IdTitle,@idDisk=i.IdDisk,@StatusRented=i.DiskRentalStatus from inserted i
		                IF @StatusRented!='OnShelf'
		                return
	                select top 1 @idListTitlePreOrder=IdListTitlePreOrder,@idCustomer=IdCustomer from ListTitlePreOrders where IdTitle=@idTitle and NumberOfDisk>0 and StatusProcess='Incompleted'
	                IF @idListTitlePreOrder is not null
		                BEGIN
		                insert into DetailPreOrders values(@idCustomer,@idDisk,0,@idListTitlePreOrder)
		                update Disks set DiskRentalStatus='OnHold' where @idDisk=IdDisk
		                select @count=COUNT(*) from Disks where @idTitle=IdTitle and DiskRentalStatus='OnShelf'
		                update Titles set TotalDiskOnShelf=@count where IdTitle=@idTitle
		                END
                END");
        }

        public override void Down()
        {
            DropForeignKey("dbo.ListTitlePreOrders", "IdTitle", "dbo.Titles");
            DropForeignKey("dbo.DetailPreOrders", "IdListTitlePreOrder", "dbo.ListTitlePreOrders");
            DropForeignKey("dbo.DetailPreOrders", "IdDisk", "dbo.Disks");
            DropForeignKey("dbo.DetailPreOrders", "IdCustomer", "dbo.Customers");
            DropForeignKey("dbo.ListTitlePreOrders", "IdCustomer", "dbo.Customers");
            DropForeignKey("dbo.ListRenteds", "IdDisk", "dbo.Disks");
            DropForeignKey("dbo.Titles", "IdDiskType", "dbo.DiskTypes");
            DropForeignKey("dbo.Disks", "IdTitle", "dbo.Titles");
            DropForeignKey("dbo.ListRenteds", "IdCustomer", "dbo.Customers");
            DropIndex("dbo.DetailPreOrders", new[] { "IdListTitlePreOrder" });
            DropIndex("dbo.DetailPreOrders", new[] { "IdDisk" });
            DropIndex("dbo.DetailPreOrders", new[] { "IdCustomer" });
            DropIndex("dbo.ListTitlePreOrders", new[] { "IdTitle" });
            DropIndex("dbo.ListTitlePreOrders", new[] { "IdCustomer" });
            DropIndex("dbo.Titles", new[] { "IdDiskType" });
            DropIndex("dbo.Disks", new[] { "IdTitle" });
            DropIndex("dbo.ListRenteds", new[] { "IdCustomer" });
            DropIndex("dbo.ListRenteds", new[] { "IdDisk" });
            DropTable("dbo.DetailPreOrders");
            DropTable("dbo.ListTitlePreOrders");
            DropTable("dbo.DiskTypes");
            DropTable("dbo.Titles");
            DropTable("dbo.Disks");
            DropTable("dbo.ListRenteds");
            DropTable("dbo.Customers");
        }
    }
}
