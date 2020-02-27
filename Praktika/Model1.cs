namespace Praktika
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<Заказ> Заказ { get; set; }
        public virtual DbSet<Заказанные_изделия> Заказанные_изделия { get; set; }
        public virtual DbSet<Изделие> Изделие { get; set; }
        public virtual DbSet<Пользователь> Пользователь { get; set; }
        public virtual DbSet<Склад_ткани> Склад_ткани { get; set; }
        public virtual DbSet<Склад_фурнитуры> Склад_фурнитуры { get; set; }
        public virtual DbSet<Ткань> Ткань { get; set; }
        public virtual DbSet<Факт_поступления_материалов> Факт_поступления_материалов { get; set; }
        public virtual DbSet<Фурнитура> Фурнитура { get; set; }
        public virtual DbSet<Фурнитура_изделия> Фурнитура_изделия { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Заказ>()
                .Property(e => e.Стоимость)
                .HasPrecision(10, 2);

            modelBuilder.Entity<Изделие>()
                .HasMany(e => e.Заказанные_изделия)
                .WithRequired(e => e.Изделие)
                .HasForeignKey(e => e.Артикул_изделия)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Изделие>()
                .HasMany(e => e.Фурнитура_изделия)
                .WithRequired(e => e.Изделие)
                .HasForeignKey(e => e.Артикул_изделия)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Изделие>()
                .HasMany(e => e.Ткань)
                .WithMany(e => e.Изделие)
                .Map(m => m.ToTable("Ткани изделия").MapLeftKey("Артикул изделия").MapRightKey("Артикул ткани"));

            modelBuilder.Entity<Пользователь>()
                .HasMany(e => e.Заказ)
                .WithRequired(e => e.Пользователь)
                .HasForeignKey(e => e.Заказчик)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Ткань>()
                .Property(e => e.Цена)
                .HasPrecision(10, 2);

            modelBuilder.Entity<Ткань>()
                .HasMany(e => e.Склад_ткани)
                .WithRequired(e => e.Ткань)
                .HasForeignKey(e => e.Артикул_ткани)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Фурнитура>()
                .Property(e => e.Цена)
                .HasPrecision(10, 2);

            modelBuilder.Entity<Фурнитура>()
                .HasMany(e => e.Склад_фурнитуры)
                .WithRequired(e => e.Фурнитура)
                .HasForeignKey(e => e.Артикул_фурнитуры)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Фурнитура>()
                .HasMany(e => e.Фурнитура_изделия)
                .WithRequired(e => e.Фурнитура)
                .HasForeignKey(e => e.Артикул_фурнитуры)
                .WillCascadeOnDelete(false);
        }
    }
}
