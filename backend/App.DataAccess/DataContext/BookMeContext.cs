using System;
using System.Collections.Generic;
using App.DataAccess.Entities;
using Microsoft.EntityFrameworkCore;

namespace App.DataAccess.DataContext
{
    /// <summary>
    /// The <see cref="BookMeContext"/> class represents the database context for the BookMe application.
    /// It inherits from <see cref="DbContext"/> and manages the entity sets for books, orders, and users.
    /// </summary>
    public partial class BookMeContext : DbContext
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BookMeContext"/> class.
        /// </summary>
        /// <param name="options">The options to configure the <see cref="DbContext"/>.</param>
        public BookMeContext(DbContextOptions<BookMeContext> options)
            : base(options)
        {
        }

        /// <summary>
        /// Gets or sets the <see cref="DbSet{Book}"/> representing the collection of books in the database.
        /// </summary>
        public virtual DbSet<Book> Books { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="DbSet{Order}"/> representing the collection of orders in the database.
        /// </summary>
        public virtual DbSet<Order> Orders { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="DbSet{User}"/> representing the collection of users in the database.
        /// </summary>
        public virtual DbSet<User> Users { get; set; }

        /// <summary>
        /// Configures the model relationships and constraints for the entities.
        /// </summary>
        /// <param name="modelBuilder">The <see cref="ModelBuilder"/> used to configure the model.</param>
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configure the Book entity
            modelBuilder.Entity<Book>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PK_AllBooks");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");
                entity.Property(e => e.Author)
                    .HasMaxLength(35)
                    .HasColumnName("author");
                entity.Property(e => e.Category)
                    .HasMaxLength(30)
                    .HasColumnName("category");
                entity.Property(e => e.Img)
                    .HasMaxLength(300)
                    .HasColumnName("img");
                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .HasColumnName("name");
                entity.Property(e => e.Price)
                    .HasColumnType("money")
                    .HasColumnName("price");
                entity.Property(e => e.Publishing)
                    .HasMaxLength(30)
                    .HasColumnName("publishing");
                entity.Property(e => e.PublishingYear).HasColumnName("publishingYear");
                entity.Property(e => e.Qty)
                    .HasDefaultValue(1)
                    .HasColumnName("qty");
                entity.Property(e => e.Titel)
                    .HasMaxLength(1000)
                    .HasColumnName("titel");
            });

            // Configure the Order entity
            modelBuilder.Entity<Order>(entity =>
            {
                entity.Property(e => e.OrderId).ValueGeneratedNever();
                entity.Property(e => e.OrderDate).HasColumnType("datetime");
                entity.Property(e => e.TotalAmount).HasColumnType("money");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Orders_Users");
            });

            // Configure the User entity
            modelBuilder.Entity<User>(entity =>
            {
                entity.Property(e => e.UserId).ValueGeneratedNever();
                entity.Property(e => e.Email).HasMaxLength(40);
                entity.Property(e => e.FullName).HasMaxLength(50);
                entity.Property(e => e.Password).HasMaxLength(20);
                entity.Property(e => e.UserName).HasMaxLength(30);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        /// <summary>
        /// A partial method for additional model configuration.
        /// </summary>
        /// <param name="modelBuilder">The <see cref="ModelBuilder"/> used for additional configuration.</param>
        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
