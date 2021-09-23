using PizzeriaCore.Entity;
using PizzeriaCore.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryMock
{
    public class RepositoryPizzeMock : IRepositoryPizze
    {
        //lista statica
        public static List<Pizza> pizze = new List<Pizza>()
        {
             new Pizza (1,"Margherita", 5),
             new Pizza (2, "Funghi",6),
             new Pizza (3, "Crostino", 6.50),
             new Pizza(4, "Boscaiola", 7)
        };

        public List<Pizza> Fetch(List<Ingrediente> ingredienti, List<PizzeIngredienti> pizzeIngredienti)
        {
            throw new NotImplementedException();
        }

        public List<Pizza> Fetch()
        {
            throw new NotImplementedException();
        }
    }
}
