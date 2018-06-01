namespace MainForm.Model.EF
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class QLKDbContext : DbContext
    {
        public QLKDbContext()
            : base("name=QLKDbContext")
        {
        }

        public virtual DbSet<Account> Accounts { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<DeliveryNote> DeliveryNotes { get; set; }
        public virtual DbSet<DeliveryNoteDetail> DeliveryNoteDetails { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<Material> Materials { get; set; }
        public virtual DbSet<Permission> Permissions { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<ReceiptNote> ReceiptNotes { get; set; }
        public virtual DbSet<ReceiptNoteDetail> ReceiptNoteDetails { get; set; }
        public virtual DbSet<Storage> Storages { get; set; }
        public virtual DbSet<Storage_Material> Storage_Material { get; set; }
        public virtual DbSet<Supplier> Suppliers { get; set; }
        public virtual DbSet<TypeMaterial> TypeMaterials { get; set; }
        public virtual DbSet<TypeProduct> TypeProducts { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Account>()
                .Property(e => e.PassWord)
                .IsUnicode(false);

            modelBuilder.Entity<Customer>()
                .Property(e => e.Phone)
                .IsUnicode(false);

            modelBuilder.Entity<DeliveryNoteDetail>()
                .Property(e => e.Price)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Employee>()
                .Property(e => e.Phone)
                .IsUnicode(false);

            modelBuilder.Entity<Employee>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<Material>()
                .Property(e => e.Price)
                .HasPrecision(18, 0);

            modelBuilder.Entity<ReceiptNoteDetail>()
                .Property(e => e.Price)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Request>()
                .Property(e => e.IntoMoney)
                .HasPrecision(18, 0);

            modelBuilder.Entity<RequestDetail>()
                .Property(e => e.Price)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Supplier>()
                .Property(e => e.Phone)
                .IsUnicode(false);
        }
    }
}
