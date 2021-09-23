using PizzeriaCore.Entity;
using PizzeriaCore.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoRepository
{
    class PizzaAdoRepository : IRepositoryPizze
    {
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
