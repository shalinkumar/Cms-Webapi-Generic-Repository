using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace ApiHandiCrafts.Contract.Models.Mapping
{
    public class AdminInformationMap : EntityTypeConfiguration<AdminInformation>
    {
        public AdminInformationMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.FirstName)
                .HasMaxLength(20);

            this.Property(t => t.LastName)
                .HasMaxLength(20);

            this.Property(t => t.Company)
                .HasMaxLength(20);

            this.Property(t => t.Phone)
                .HasMaxLength(12);

            this.Property(t => t.Address1)
                .HasMaxLength(40);

            this.Property(t => t.Address2)
                .HasMaxLength(40);

            this.Property(t => t.Country)
                .HasMaxLength(10);

            this.Property(t => t.State)
                .HasMaxLength(20);

            this.Property(t => t.City)
                .HasMaxLength(20);

            this.Property(t => t.Zip)
                .HasMaxLength(15);

            this.Property(t => t.CreatedBy)
                .HasMaxLength(50);

            this.Property(t => t.ModifiedBy)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("AdminInformation");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.FirstName).HasColumnName("FirstName");
            this.Property(t => t.LastName).HasColumnName("LastName");
            this.Property(t => t.Company).HasColumnName("Company");
            this.Property(t => t.TaxId).HasColumnName("TaxId");
            this.Property(t => t.Phone).HasColumnName("Phone");
            this.Property(t => t.Address1).HasColumnName("Address1");
            this.Property(t => t.Address2).HasColumnName("Address2");
            this.Property(t => t.Country).HasColumnName("Country");
            this.Property(t => t.State).HasColumnName("State");
            this.Property(t => t.City).HasColumnName("City");
            this.Property(t => t.Zip).HasColumnName("Zip");
            this.Property(t => t.Comments).HasColumnName("Comments");
            this.Property(t => t.Created).HasColumnName("Created");
            this.Property(t => t.CreatedBy).HasColumnName("CreatedBy");
            this.Property(t => t.Modified).HasColumnName("Modified");
            this.Property(t => t.ModifiedBy).HasColumnName("ModifiedBy");
        }
    }
}
