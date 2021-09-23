using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzeriaCore.IRepository
{
  public interface IRepository<T>
    {
        public List<T> Fetch();
       
       // public T GetById(int id);

    }
}
