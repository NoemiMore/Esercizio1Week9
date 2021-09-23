using PizzeriaCore.BusinessLayer;
using PizzeriaCore.Entity;
using System;
using System.Collections.Generic;

namespace Esercizio1Week9
{
    class Program
    {
        //repository mock
        private static readonly IBusinessLayer bl = new MainBusinessLayer(new RepositoryPizzeMock(), new RepositoryIngredientiMock(), new RepositoryPizzeIngredientiMock());
        static void Main(string[] args)
        {
            bool continua = true;
            while (continua)
            {
                int scelta = SchermoMenu();
                continua = AnalizzaScelta(scelta);
            }
        }

        private static int SchermoMenu()
        {
            Console.WriteLine("******************Menu****************");
            //Funzionalità sulle pizze
            
            Console.WriteLine("1. Visualizza il Menu");
            Console.WriteLine("2. Fai il tuo ordine");
            Console.WriteLine("3. Scegli la tua pizza per ingrediente");
            Console.WriteLine("4. Visualizza scontrino"); 
          
           
            //Exit
            Console.WriteLine("\n0. Exit");
            Console.WriteLine("********************************************");


            int scelta;
            Console.Write("Inserisci scelta: ");
            while (!int.TryParse(Console.ReadLine(), out scelta) || scelta < 0 || scelta >4)
            {
                Console.Write("\nScelta errata. Inserisci scelta corretta: ");
            }
            return scelta;

        }
        private static bool AnalizzaScelta(int scelta)
        {
            Console.Write("Inserisci scelta: ");
                while (!int.TryParse(Console.ReadLine(), out scelta) || scelta < 0 || scelta > 3)
                {
                    Console.Write("\nScelta errata. Inserisci scelta corretta: ");
                }
            switch (scelta)
            {
                case 1:
                    VisualizzaMenu();
                    break;
                case 2:
                    IlTuoOrdine();
                    break;
                case 3:
                    PizzaForIngrediente();
                    break;
                case 4:
                    ContoOrdine();
                    break;
                
                case 0:
                    return false;
            }
            return true;
        }

        private static void PizzaForIngrediente()
        {
            List<Ingrediente> ingredienti = bl.FetchIngredienti();
            int scelta;

            StampaIngredienti(ingredienti);
          
        }

        private static void StampaIngredienti(List<Ingrediente> ingredienti)
        {
            foreach (var ingrediente in ingredienti)
            {
                Console.WriteLine($"Premi {ingrediente.IdIngrediente}per selezionare {ingrediente.NomeIngrediente});
            }
        }

        private static void ContoOrdine()
        {
            throw new NotImplementedException();
        }

        private static void IlTuoOrdine()
        { 
        }

        private static void VisualizzaMenu()
        {
           
            List<Pizza> pizze = bl.FetchPizze();
            StampaPizze(pizze);
            
           

        }

        private static void StampaPizze(List<Pizza> pizze)
        {
            foreach (var pizza in pizze)
            {
                Console.WriteLine(pizza.ToString());
            }
        }
    }
    }
    
    

