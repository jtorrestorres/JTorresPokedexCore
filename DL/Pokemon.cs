using System;
using System.Collections.Generic;

namespace DL;

public partial class Pokemon
{
    public int IdPokemon { get; set; }

    public string? Nombre { get; set; }

    public virtual ICollection<PokemonTipo> PokemonTipos { get; set; } = new List<PokemonTipo>();
}
