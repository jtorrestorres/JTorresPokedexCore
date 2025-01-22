using System;
using System.Collections.Generic;

namespace DL;

public partial class Tipo
{
    public int IdTipo { get; set; }

    public string? Nombre { get; set; }

    public virtual ICollection<PokemonTipo> PokemonTipos { get; set; } = new List<PokemonTipo>();
}
