using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzeriaCore.Entity
{
  public  class Pizza
    {public int IdPizza { get; set; }
        public string NomePizza { get; set; }
        public List<string> Ingredienti { get; set; } = new List<string>();
        public double PrezzoPizza { get; set; }


        public Pizza(int id, string nome, List<string> ingredienti, double prezzo)
        {
            IdPizza = id;
            NomePizza = nome;
            Ingredienti = ingredienti;
            PrezzoPizza = prezzo;
        }

        public Pizza()
        {

        }

        //metodo per stampa  pizza
        public override string ToString()
        {
            return $"Codice Pizza:{IdPizza}\tNome: {NomePizza}\tIngredienti:{Ingredienti}\tPrezzo:{PrezzoPizza}";
        }


    }
}
