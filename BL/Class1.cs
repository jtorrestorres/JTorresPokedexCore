namespace BL
{
    public class Pokemon
    {
        public static ML.Result GetAll()
        { //prueba git
            ML.Result result = new ML.Result();

            using (DL.JtorresPokedexCoreContext context = new DL.JtorresPokedexCoreContext())
            {
                var listaMateriasLinq = (from pokemonDB in context.Pokemons
                                         select pokemonDB).ToList();

                if (listaMateriasLinq.Count > 0)
                {
                    result.Objects = new List<object>();

                    foreach (var materia in listaMateriasLinq)
                    {

                     

                    }

                    result.Correct = true;
                }
                else
                {
                    result.Correct = false;
                    result.ErrorMessage = "No se encontraron registros";
                }
            }

            return result;

        }


        public static ML.Result GetById()
        { //prueba git
            ML.Result result = new ML.Result();

            using (DL.JtorresPokedexCoreContext context = new DL.JtorresPokedexCoreContext())
            {
                var listaMateriasLinq = (from pokemonDB in context.Pokemons
                                         select pokemonDB).ToList();

                if (listaMateriasLinq.Count > 0)
                {
                    result.Objects = new List<object>();

                    foreach (var materia in listaMateriasLinq)
                    {



                    }

                    result.Correct = true;
                }
                else
                {
                    result.Correct = false;
                    result.ErrorMessage = "No se encontraron registros";
                }
            }

            return result;

        }

    }
}
