namespace DAL.Migrations
{
    using Entities;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity.Migrations;

    internal sealed class Configuration : DbMigrationsConfiguration<DAL.QuanLyThueDiaDBContext>
    {
        const string ONHOLD = "OnHold";
        const string ONSHELF = "OnShelf";
        const string RENTED = "Rented";
        const string STATUSGOOD = "Good";
        const string STATUSDAMAGE = "Damage";
        const string UNPAID = "Unpaid";
        const string COMPLETE = "Completed";
        const string INCOMPLETE = "Incompleted";
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            
        }

        protected override void Seed(DAL.QuanLyThueDiaDBContext context)
        {

            // Loại đĩa
            var lstDiskType = new List<DiskType>
            {
                new DiskType { TypeName = "Movie", LateFee = 7000, Price = 20000, TimeRented = 15 },
                new DiskType { TypeName = "Game", LateFee = 7000, Price = 20000, TimeRented = 15},
            };

            // Tiêu Đề
            var lstTitle = new List<Title>
            {
                new Title { IdDiskType = 1, NameTitle = "Jujutsu Kaisen 1" },
                new Title { IdDiskType = 1, NameTitle = "Jujutsu Kaisen 2" },
                new Title { IdDiskType = 1, NameTitle = "Jujutsu Kaisen 3" },
                new Title { IdDiskType = 1, NameTitle = "Jujutsu Kaisen 4" },
                new Title { IdDiskType = 2, NameTitle = "Genshin Impact 1" },
                new Title { IdDiskType = 2, NameTitle = "Genshin Impact 2" },
                new Title { IdDiskType = 2, NameTitle = "Genshin Impact 3" },
                new Title { IdDiskType = 2, NameTitle = "Genshin Impact 4" },
            };
            //Bản sao
            var lstDisk = new List<Disk>{
                new Disk { IdTitle = 1, DiskStatus = STATUSGOOD, DiskRentalStatus = ONSHELF },
                new Disk { IdTitle = 2, DiskStatus = STATUSGOOD, DiskRentalStatus = ONSHELF },
                new Disk { IdTitle = 2, DiskStatus = STATUSGOOD, DiskRentalStatus = ONSHELF },
                new Disk { IdTitle = 2, DiskStatus = STATUSGOOD, DiskRentalStatus = ONSHELF },
                new Disk { IdTitle = 2, DiskStatus = STATUSGOOD, DiskRentalStatus = ONSHELF },
                new Disk { IdTitle = 2, DiskStatus = STATUSGOOD, DiskRentalStatus = ONSHELF },
                new Disk { IdTitle = 2, DiskStatus = STATUSGOOD, DiskRentalStatus = ONSHELF },
                new Disk { IdTitle = 2, DiskStatus = STATUSGOOD, DiskRentalStatus = ONSHELF },
                new Disk { IdTitle = 4, DiskStatus = STATUSGOOD, DiskRentalStatus = ONSHELF },
                new Disk { IdTitle = 1, DiskStatus = STATUSGOOD, DiskRentalStatus = ONSHELF },
                new Disk { IdTitle = 2, DiskStatus = STATUSDAMAGE, DiskRentalStatus = ONSHELF },
                new Disk { IdTitle = 3, DiskStatus = STATUSDAMAGE, DiskRentalStatus = ONSHELF },
                new Disk { IdTitle = 4, DiskStatus = STATUSDAMAGE, DiskRentalStatus = ONSHELF },
                new Disk { IdTitle = 1, DiskStatus = STATUSGOOD, DiskRentalStatus = ONSHELF },
                new Disk { IdTitle = 1, DiskStatus = STATUSGOOD, DiskRentalStatus = ONSHELF },
                new Disk { IdTitle = 2, DiskStatus = STATUSGOOD, DiskRentalStatus = ONSHELF },
                new Disk { IdTitle = 3, DiskStatus = STATUSGOOD, DiskRentalStatus = ONSHELF },
                new Disk { IdTitle = 4, DiskStatus = STATUSGOOD, DiskRentalStatus = ONSHELF },
                new Disk { IdTitle = 1, DiskStatus = STATUSGOOD, DiskRentalStatus = ONSHELF },
                new Disk { IdTitle = 1, DiskStatus = STATUSGOOD, DiskRentalStatus = ONSHELF },
            };
            //Khách hàng
            var lstCustomer = new List<Customer>
            {
                new Customer { Address = "Gò Vấp", CustomerName = "Dương Chí Hiếu", PhoneNumber = "0961059599" },
                new Customer { Address = "Hồ Chí Minh", CustomerName = "Hoàng Anh", PhoneNumber = "0961059599" },
                new Customer { Address = "Thủ Đức", CustomerName = "Đoàn Văn Hùng", PhoneNumber = "0961059599" },
                new Customer { Address = "Quận 5", CustomerName = "Nguyễn Duy Tân", PhoneNumber = "0961059599" },
            };

            // Danh sách thuê
            var lstListRented = new List<ListRented>
            {
               new ListRented { IdDisk = 1, IdCustomer = 1, LateFee = 7000, ExpectedReturnDate = DateTime.Now, ActualReturnDate = DateTime.Now, RentalDate = DateTime.Now, StatusOnBill = UNPAID },
               new ListRented { IdDisk = 2, IdCustomer = 2, LateFee = 7000, ExpectedReturnDate = DateTime.Now, ActualReturnDate = DateTime.Now, RentalDate = DateTime.Now, StatusOnBill = UNPAID },
               new ListRented { IdDisk = 3, IdCustomer = 3, LateFee = 7000, ExpectedReturnDate = DateTime.Now, ActualReturnDate = DateTime.Now, RentalDate = DateTime.Now, StatusOnBill = UNPAID },
               new ListRented { IdDisk = 4, IdCustomer = 4, LateFee = 7000, ExpectedReturnDate = DateTime.Now, ActualReturnDate = DateTime.Now, RentalDate = DateTime.Now, StatusOnBill = UNPAID },
               new ListRented { IdDisk = 5, IdCustomer = 1, LateFee = 7000, ExpectedReturnDate = DateTime.Now, ActualReturnDate = DateTime.Now, RentalDate = DateTime.Now, StatusOnBill = UNPAID },
               new ListRented { IdDisk = 1, IdCustomer = 2, LateFee = 7000, ExpectedReturnDate = DateTime.Now, ActualReturnDate = DateTime.Now, RentalDate = DateTime.Now, StatusOnBill = UNPAID },
               new ListRented { IdDisk = 2, IdCustomer = 3, LateFee = 7000, ExpectedReturnDate = DateTime.Now, ActualReturnDate = DateTime.Now, RentalDate = DateTime.Now, StatusOnBill = UNPAID },
               new ListRented { IdDisk = 1, IdCustomer = 4, LateFee = 7000, ExpectedReturnDate = DateTime.Now, ActualReturnDate = DateTime.Now, RentalDate = DateTime.Now, StatusOnBill = UNPAID },
            };
            //Danh sách đặt trước
            var lstListTitlePreOrder = new List<ListTitlePreOrder>
            {
                new ListTitlePreOrder { IdCustomer = 1, IdTitle = 2, NumberOfDisk = 3, StatusProcess = COMPLETE },
                new ListTitlePreOrder { IdCustomer = 2, IdTitle = 2, NumberOfDisk = 3, StatusProcess = INCOMPLETE },
                new ListTitlePreOrder { IdCustomer = 3, IdTitle = 2, NumberOfDisk = 3, StatusProcess = INCOMPLETE },
                new ListTitlePreOrder { IdCustomer = 4, IdTitle = 2, NumberOfDisk = 3, StatusProcess = INCOMPLETE },
                new ListTitlePreOrder { IdCustomer = 1, IdTitle = 2, NumberOfDisk = 3, StatusProcess = INCOMPLETE },
            };
            //Chi Tiết Đặt Trước
            var lstDetailPreOrder = new List<DetailPreOrder>
            {
                new DetailPreOrder { IdCustomer = 1, IdListTitlePreOrder = 1, IdDisk = 2,Accepted=false },
                new DetailPreOrder { IdCustomer = 1, IdListTitlePreOrder = 1, IdDisk = 3,Accepted=false },
                new DetailPreOrder { IdCustomer = 1, IdListTitlePreOrder = 1, IdDisk = 4,Accepted=false },
            };
            //Update database first
            lstCustomer.ForEach(x => context.Customers.AddOrUpdate(x));
            lstDiskType.ForEach(x => context.DiskTypes.AddOrUpdate(x));
            context.SaveChanges();
            lstTitle.ForEach(x => context.Titles.AddOrUpdate(x));
            context.SaveChanges();
            lstDisk.ForEach(x => context.Disks.AddOrUpdate(x));
            context.SaveChanges();
            lstListRented.ForEach(x => context.ListRenteds.AddOrUpdate(x));
            lstListTitlePreOrder.ForEach(x => context.ListTitlePreOrders.Add(x));
            context.SaveChanges();
            lstDetailPreOrder.ForEach(x => context.DetailPreOrders.AddOrUpdate(x));
            context.SaveChanges();
        }
    }
}
