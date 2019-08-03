namespace Models.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ChildCards",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FullName = c.String(nullable: false),
                        DateBirth = c.String(nullable: false),
                        PlaceBirth = c.String(nullable: false),
                        Address = c.String(nullable: false),
                        NumberAccount = c.String(nullable: false),
                        FullNameParents = c.String(nullable: false),
                        HomePhoneNumber = c.String(nullable: false),
                        CellPhoneNumber = c.String(nullable: false),
                        Mail = c.String(nullable: false),
                        Notes = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ChildOrders",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Date = c.String(nullable: false),
                        FullName = c.String(nullable: false),
                        Status = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.MainCleanings",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        HoldingPlace = c.String(nullable: false),
                        PlannedDate = c.String(nullable: false),
                        NameDisinfectant = c.String(nullable: false),
                        FactDate = c.String(nullable: false),
                        Executor = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.MainCompetitions",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        DateCompetition = c.String(nullable: false),
                        Fullname = c.String(nullable: false),
                        Group = c.Int(nullable: false),
                        NameCompetition = c.String(nullable: false),
                        Storage = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.MainEquipments",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        DateEquipment = c.String(nullable: false),
                        StatusEquipment = c.String(nullable: false),
                        Problems = c.String(nullable: false),
                        DateProblems = c.String(nullable: false),
                        RepairPerson = c.String(nullable: false),
                        EndStatus = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.MainItems",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        NameItem = c.String(nullable: false),
                        ItemNumber = c.String(nullable: false),
                        Quantity = c.Int(nullable: false),
                        DateItem = c.String(nullable: false),
                        NumberAct = c.String(nullable: false),
                        Notes = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.MainOrders",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        NameOrder = c.String(nullable: false),
                        DateOrder = c.String(nullable: false),
                        Status = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.MainRequests",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        RequestDate = c.String(nullable: false),
                        RequestTime = c.String(nullable: false),
                        RequestContent = c.String(nullable: false),
                        RequestApplicant = c.String(nullable: false),
                        AdmissionTime = c.String(nullable: false),
                        Notes = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.PersonnelOrders",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Position = c.String(nullable: false),
                        FullName = c.String(nullable: false),
                        Date = c.String(nullable: false),
                        Status = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.PersonnelVacations",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Position = c.String(nullable: false),
                        FullName = c.String(nullable: false),
                        PersonnelNumber = c.String(nullable: false),
                        CountDay = c.Int(nullable: false),
                        PlanDate = c.String(nullable: false),
                        FactDate = c.String(nullable: false),
                        Notes = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Login = c.String(nullable: false),
                        Password = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Users");
            DropTable("dbo.PersonnelVacations");
            DropTable("dbo.PersonnelOrders");
            DropTable("dbo.MainRequests");
            DropTable("dbo.MainOrders");
            DropTable("dbo.MainItems");
            DropTable("dbo.MainEquipments");
            DropTable("dbo.MainCompetitions");
            DropTable("dbo.MainCleanings");
            DropTable("dbo.ChildOrders");
            DropTable("dbo.ChildCards");
        }
    }
}
