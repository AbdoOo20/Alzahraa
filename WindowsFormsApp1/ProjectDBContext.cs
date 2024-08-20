using System.Data.Entity;


namespace DBOfAlzahraaProject
{
    public class ProjectDBContext : DbContext
    {
        public ProjectDBContext() : base("name = SampleData") { }

        public virtual DbSet<Project> Projects { get; set; }
        public virtual DbSet<Client> Clients { get; set; }
        public virtual DbSet<BuyOperation> BuyOperations { get; set; }
        public virtual DbSet<PhoneNumber> PhoneNumbers { get; set; }
        public virtual DbSet<Installment> Installments { get; set; }
        public virtual DbSet<InstallmentOfProject> InstallmentOfProjects { get; set; }
        public virtual DbSet<DatesOfInstallment> DatesOfInstallments { get; set; }
        public virtual DbSet<DatesOfInstallmentOfProject> DatesOfInstallmentOfProjects { get; set; }
        public virtual DbSet<Notification> Notifications { get; set; }


    }
}
