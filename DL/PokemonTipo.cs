using System;
using System.Collections.Generic;

namespace DL;

public partial class PokemonTipo
{
    public int IdPokemonTipo { get; set; }

    public int? IdPokemon { get; set; }

    public int? IdTipo { get; set; }

    public virtual Pokemon? IdPokemonNavigation { get; set; }

    public virtual Tipo? IdTipoNavigation { get; set; }
}
