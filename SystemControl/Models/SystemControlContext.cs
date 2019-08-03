using System.Data.Entity;
using Models.ChildModels;
using Models.MainModels;
using Models.PersonnelModels;

namespace Models
{
    public class SystemControlContext : DbContext
    {
        public SystemControlContext() : base("DbConnection")
        {

        }

        public DbSet<User> Users { get; set; }

        public DbSet<ChildOrder> ChildOrders { get; set; }

        public DbSet<ChildCard> ChildCards { get; set; }

        public DbSet<PersonnelOrder> PersonnelOrders { get; set; }

        public DbSet<PersonnelVacation> PersonnelVacations { get; set; }

        public DbSet<MainCleaning> MainCleanings { get; set; }

        public DbSet<MainCompetition> MainCompetitions  { get; set; }

        public DbSet<MainEquipment> MainEquipments { get; set; }

        public DbSet<MainItem> MainItems { get; set; }

        public DbSet<MainOrders> MainOrderses { get; set; }

        public DbSet<MainRequest> MainRequests { get; set; }
    }
}