using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace DL;

public partial class JtorresPokedexCoreContext : DbContext
{
    public JtorresPokedexCoreContext()
    {
    }

    public JtorresPokedexCoreContext(DbContextOptions<JtorresPokedexCoreContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Pokemon> Pokemons { get; set; }

    public virtual DbSet<PokemonTipo> PokemonTipos { get; set; }

    public virtual DbSet<Tipo> Tipos { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=.; Database=JTorresPokedexCore; TrustServerCertificate=True; Trusted_Connection=True; User ID=sa; Password=pass@word1;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Pokemon>(entity =>
        {
            entity.HasKey(e => e.IdPokemon).HasName("PK__Pokemon__08D9A59949CAD608");

            entity.ToTable("Pokemon");

            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<PokemonTipo>(entity =>
        {
            entity.HasKey(e => e.IdPokemonTipo).HasName("PK__PokemonT__71D566C2419CC6B8");

            entity.ToTable("PokemonTipo");

            entity.HasOne(d => d.IdPokemonNavigation).WithMany(p => p.PokemonTipos)
                .HasForeignKey(d => d.IdPokemon)
                .HasConstraintName("FK__PokemonTi__IdPok__145C0A3F");

            entity.HasOne(d => d.IdTipoNavigation).WithMany(p => p.PokemonTipos)
                .HasForeignKey(d => d.IdTipo)
                .HasConstraintName("FK__PokemonTi__IdTip__15502E78");
        });

        modelBuilder.Entity<Tipo>(entity =>
        {
            entity.HasKey(e => e.IdTipo).HasName("PK__Tipo__9E3A29A58690C330");

            entity.ToTable("Tipo");

            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
