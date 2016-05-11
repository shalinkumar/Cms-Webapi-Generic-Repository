using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using ApiHandiCrafts.Contract.Models.Mapping;

namespace ApiHandiCrafts.Contract.Models
{
    public partial class HandiCraftsContext : DbContext
    {
        static HandiCraftsContext()
        {
            Database.SetInitializer<HandiCraftsContext>(null);
        }

        public HandiCraftsContext()
            : base("Name=HandiCraftsContext")
        {
        }

        public DbSet<AdminInformation> AdminInformations { get; set; }
        public DbSet<ContactUs> ContactUs { get; set; }
        public DbSet<CustomerInformation> CustomerInformations { get; set; }
        public DbSet<PageContentDesign> HomePageContents { get; set; }
        public DbSet<LoginInformation> LoginInformations { get; set; }
        public DbSet<Products> Products { get; set; }
        public DbSet<Template> Templates { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new AdminInformationMap());
            modelBuilder.Configurations.Add(new ContactUMap());
            modelBuilder.Configurations.Add(new CustomerInformationMap());
            modelBuilder.Configurations.Add(new HomePageContentMap());
            modelBuilder.Configurations.Add(new LoginInformationMap());
            modelBuilder.Configurations.Add(new Product_LampsMap());
            modelBuilder.Configurations.Add(new TemplateMap());
        }
    }
}
