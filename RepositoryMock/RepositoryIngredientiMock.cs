using PizzeriaCore.Entity;
using PizzeriaCore.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryMock
{
   public class RepositoryIngredientiMock: IRepositoryIngredienti
    {
        public static List<Ingrediente> Ingredienti = new List<Ingrediente>()
        {
            new Ingrediente{IdIngrediente=1, NomeIngrediente="Pomodoro"},
            new Ingrediente{IdIngrediente=2, NomeIngrediente="Mozzarella"},
            new Ingrediente{IdIngrediente=3, NomeIngrediente="Funghi"},
            new Ingrediente{IdIngrediente=4, NomeIngrediente="Speak"}
        };

        public Ingrediente GetById(int id)
        {
            return GetAll().FirstOrDefault(i => i.IdIngrediente == id);
        }

        public List<Ingrediente> GetAll()
        {
            return Ingredienti.ToList();
        }

        
        

        public Ingrediente GetById(int id)
        {
            return GetAll().FirstOrDefault(i => i.IdIngrediente == id);
        }
    }
}
