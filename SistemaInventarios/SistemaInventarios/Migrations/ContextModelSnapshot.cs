﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SistemaInventarios.Models;

namespace SistemaInventarios.Migrations
{
    [DbContext(typeof(Context))]
    partial class ContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.8-servicing-32085")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("SistemaInventarios.Models.Marca", b =>
                {
                    b.Property<int>("MarcaId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("NombreMarca")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.HasKey("MarcaId");

                    b.ToTable("Marca");
                });

            modelBuilder.Entity("SistemaInventarios.Models.Productos", b =>
                {
                    b.Property<int>("ProdctoId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CantidadProducto");

                    b.Property<int>("MarcaId");

                    b.Property<string>("NombreProducto")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<decimal>("PrecioProducto");

                    b.HasKey("ProdctoId");

                    b.HasIndex("MarcaId");

                    b.ToTable("Productos");
                });

            modelBuilder.Entity("SistemaInventarios.Models.Productos", b =>
                {
                    b.HasOne("SistemaInventarios.Models.Marca", "Marca")
                        .WithMany("Productos")
                        .HasForeignKey("MarcaId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
