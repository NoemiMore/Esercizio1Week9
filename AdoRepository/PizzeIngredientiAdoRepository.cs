using PizzeriaCore.Entity;
using PizzeriaCore.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoRepository
{
    class PizzeIngredientiAdoRepository : IRepositoryPizzeIngredienti
    {
        const string connectionString = @"Data Source = (localdb)\MSSQLLocalDB;" +
                                     "Initial Catalog = DemoAdo;" +
                                     "Integrated Security = true;";


        public List<PizzeIngredienti> Fetch()
        {
            throw new NotImplementedException();
        }
    }
}
