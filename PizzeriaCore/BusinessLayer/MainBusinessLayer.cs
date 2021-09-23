using PizzeriaCore.Entity;
using PizzeriaCore.IRepository;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzeriaCore.BusinessLayer
{


    public class MainBusinessLayer: IBusinessLayer
    {
        //metodo per leggere da file le pizze ed estrarle
        /* public List<Pizza> GetAllPizze()
         {
             const string path = @"C:\Users\noemi.more\Desktop\Avanade Girls\WEEK9\Esercizi\Esercizio1Week9\Esercizio1Week9\MenuPizzeria";

             string menu = string.Empty;

             using (StreamReader sr = new StreamReader(path))
             {
                 menu = sr.ReadToEnd();
             }

             var righe = menu.Split("\r\n");

             List<Pizza> pizze = new List<Pizza>();

             foreach (var riga in righe)
             {
                 var pizzaArray = riga.Split("-");

                 Pizza pizza = new Pizza(); //creazione oggetto
                 pizza.NomePizza = pizzaArray[0].Trim();
                 pizza.NomePizza = pizzaArray[2].Trim();
                 List<Pizza> ingredienti = new List<Pizza>();
                 var ingredientiArray = pizzaArray[1].Split(",");
                 foreach (var ingrediente in ingredientiArray)
                 {
                     ingredienti.Add(ingrediente.Trim());
                 }
                 pizza.Ingredienti = ingredienti;

                 pizze.Add(pizza);
             }

             return pizze;
         }
        */



        private readonly IRepositoryPizze pizzeRepo;
        private readonly IRepositoryIngredienti ingredientiRepo;
        private readonly IRepositoryPizzeIngredienti pizzeIngredientiRepo;

        //costruttore dei repository come input

        public MainBusinessLayer(IRepositoryPizze pizze, IRepositoryIngredienti ingredienti, IRepositoryPizzeIngredienti pizzeIngredienti)
        {
            pizzeRepo = pizze;
            ingredientiRepo = ingredienti;
            pizzeIngredientiRepo = pizzeIngredienti;
        }


        public List<Ingrediente> FetchIngredienti()
        {
            return ingredientiRepo.Fetch();
        }

        public List<Pizza> FetchPizze()
        {
            const string path = @"C:\Users\noemi.more\Desktop\Avanade Girls\WEEK9\Esercizi\Esercizio1Week9\Esercizio1Week9\MenuPizzeria";

            string menu = string.Empty;

            using (StreamReader sr = new StreamReader(path))
            {
                menu = sr.ReadToEnd();
            }

            var righe = menu.Split("\r\n");

            List<Pizza> pizze = new List<Pizza>();

            foreach (var riga in righe)
            {

                var ingredienti = ingredientiRepo.Fetch();
                var pizzeIngredienti = pizzeIngredientiRepo.Fetch();
                return pizzeRepo.Fetch(ingredienti, pizzeIngredienti);
                /*var pizzaArray = riga.Split("-");

                Pizza pizza = new Pizza(); //creazione oggetto
                pizza.NomePizza = pizzaArray[0].Trim();
                pizza.NomePizza = pizzaArray[2].Trim();
                List<Pizza> ingredienti = new List<Pizza>();
                var ingredientiArray = pizzaArray[1].Split(",");
                foreach (var ingrediente in ingredientiArray)
                {
                    ingredienti.Add(Ingrediente.Trim());
                }
                pizza.Ingredienti = ingredienti;

                pizze.Add(pizza);
            }

            return pizze;
            */
            }
    }

}

