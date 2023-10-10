using AppLivrosApi.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AppLivrosApi.Data.NovaPasta;

public class BookMap : IEntityTypeConfiguration<Book>
{
    public void Configure(EntityTypeBuilder<Book> builder)
    {
        // Tabela
        builder.ToTable("Book");

        // Chave Primária
        builder.HasKey(x => x.Id);

        // Identity
        builder.Property(x => x.Id)
            .ValueGeneratedOnAdd();

        // Propriedades
        builder.Property(x => x.Title)
            .IsRequired()
            .HasColumnName("Title")
            .HasColumnType("NVARCHAR")
            .HasMaxLength(80);

        builder.Property(x => x.Description)
            .IsRequired()
            .HasColumnName("Description")
            .HasColumnType("NVARCHAR")
            .HasMaxLength(300);

        builder.Property(x => x.Author)
            .IsRequired()
            .HasColumnName("Author")
            .HasColumnType("NVARCHAR")
            .HasMaxLength(80);

        builder.Property(x => x.ImageUrl)
            .IsRequired()
            .HasColumnName("ImageUrl")
            .HasColumnType("NVARCHAR")
            .HasMaxLength(300);

        builder.Property(x => x.PageTotal)
            .IsRequired()
            .HasColumnName("PageTotal")
            .HasColumnType("INT");

        builder.Property(x => x.Check)
           .IsRequired()
           .HasColumnName("Check")
           .HasColumnType("BOOL");

        builder.Property(x => x.PageIndex)
            .IsRequired()
            .HasColumnName("PageIndex")
            .HasColumnType("INT");

        builder.Property(x => x.CategoryId)
            .IsRequired()
            .HasColumnName("CategoryId")
            .HasColumnType("INT");
    }
}
