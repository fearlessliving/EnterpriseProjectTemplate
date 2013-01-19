using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using EPT.DAL.DomainClasses;

namespace EPT.DAL.Mappings
{
    public class TransactionHistoryArchiveMap : EntityTypeConfiguration<TransactionHistoryArchive>
    {
        public TransactionHistoryArchiveMap()
        {
            // Primary Key
            this.HasKey(t => t.TransactionID);

            // Properties
            this.Property(t => t.TransactionID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.TransactionType)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.RowVersion)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(8)
                .IsRowVersion();

            // Table & Column Mappings
            this.ToTable("TransactionHistoryArchive", "Production");
            this.Property(t => t.TransactionID).HasColumnName("TransactionID");
            this.Property(t => t.ProductID).HasColumnName("ProductID");
            this.Property(t => t.ReferenceOrderID).HasColumnName("ReferenceOrderID");
            this.Property(t => t.ReferenceOrderLineID).HasColumnName("ReferenceOrderLineID");
            this.Property(t => t.TransactionDate).HasColumnName("TransactionDate");
            this.Property(t => t.TransactionType).HasColumnName("TransactionType");
            this.Property(t => t.Quantity).HasColumnName("Quantity");
            this.Property(t => t.ActualCost).HasColumnName("ActualCost");
            this.Property(t => t.ModifiedDate).HasColumnName("ModifiedDate");
            this.Property(t => t.RowVersion).HasColumnName("RowVersion");
        }
    }
}