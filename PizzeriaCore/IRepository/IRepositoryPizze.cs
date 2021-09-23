using PizzeriaCore.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzeriaCore.IRepository
{
  public interface IRepositoryPizze : IRepository<Pizza>
    {
        public List<Pizza> Fetch(List<Ingrediente> ingredienti, List<PizzeIngredienti> pizzeIngredienti);
    }
}
