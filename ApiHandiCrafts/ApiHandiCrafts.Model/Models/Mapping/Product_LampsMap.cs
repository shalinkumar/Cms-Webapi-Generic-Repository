using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace ApiHandiCrafts.Contract.Models.Mapping
{
    public class Product_LampsMap : EntityTypeConfiguration<Products>
    {
        public Product_LampsMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.ContentType)
                .HasMaxLength(50);

            this.Property(t => t.Title)
                .HasMaxLength(50);

            this.Property(t => t.ImageSrc)
                .HasMaxLength(50);

            this.Property(t => t.ItamName)
                .HasMaxLength(50);

            this.Property(t => t.ItemCode)
                .HasMaxLength(50);

            this.Property(t => t.CreatedBy)
                .HasMaxLength(50);

            this.Property(t => t.ModifiedBy)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Products");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.ContentType).HasColumnName("ContentType");
            this.Property(t => t.Title).HasColumnName("Title");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.ImageSrc).HasColumnName("ImageSrc");
            this.Property(t => t.ItamName).HasColumnName("ItamName");
            this.Property(t => t.ItemCode).HasColumnName("ItemCode");
            this.Property(t => t.ItemPrice).HasColumnName("ItemPrice");
            this.Property(t => t.ItemReview).HasColumnName("ItemReview");
            this.Property(t => t.Created).HasColumnName("Created");
            this.Property(t => t.CreatedBy).HasColumnName("CreatedBy");
            this.Property(t => t.Modified).HasColumnName("Modified");
            this.Property(t => t.ModifiedBy).HasColumnName("ModifiedBy");
        }
    }
}
