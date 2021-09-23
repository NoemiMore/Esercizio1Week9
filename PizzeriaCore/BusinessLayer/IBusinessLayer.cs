using PizzeriaCore.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzeriaCore.BusinessLayer
{
  public  interface IBusinessLayer
    {
        //metodo per prendere tutte le pizze e visualizzarle
       
        List<Pizza> FetchPizze();
        List<Ingrediente> FetchIngredienti();
    }
}
