using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzeriaCore.Entity
{
   public class PizzeIngredienti
    {
        public int IdCodePizza { get; set; }
        public int IdCodeIngrediente { get; set; }



        public PizzeIngredienti(int idPizza, int idIngrediente)
        {
            IdCodePizza = idPizza;
            IdCodeIngrediente = idIngrediente;
        }

        //FK CON PIZZA
        public int IdPizza { get; set; }
        public Pizza Pizza { get; set; }

        //fk con Ingrediente
        public int IdIngrediente { get; set; }
        public Ingrediente Ingrediente { get; set; }

        public override string ToString()
        {
            return $"Codice Ingrediente: {IdIngrediente}\tCodice Pizza: {IdPizza}\n";
        }

    }
}
