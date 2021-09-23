using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercizio1Week9
{
    class LeggiMenu
    {
        internal static void ReadFromFile()
        {
            const string path = @"C:\Users\noemi.more\Desktop\Avanade Girls\WEEK9\Esercizi\Esercizio1Week9\Esercizio1Week9\MenuPizzeria";

            using (StreamReader sr = new StreamReader(path))
            {
                
                    string contenuto = sr.ReadToEnd();
                
            }



        }
    }
}
