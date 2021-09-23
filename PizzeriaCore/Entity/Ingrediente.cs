using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzeriaCore.Entity
{
   public class Ingrediente
    {
        public int IdIngrediente { get; set; }
        public string NomeIngrediente { get; set; }

        public Ingrediente(int id, string nome)
        {
            IdIngrediente = id;
            NomeIngrediente = nome;
        }

        public override string ToString()
        {
            return $"Codice Ingrediente: {IdIngrediente}\tNome Ingrediente: {NomeIngrediente}\n";
    }
}
