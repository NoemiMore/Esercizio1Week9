using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercizio1Week9
{
    class ScriviOrdine
    {


        internal static void WriteOrder()
        {
            const string path = @"C:\Users\noemi.more\Desktop\Avanade Girls\WEEK9\Esercizi\Esercizio1Week9\Esercizio1Week9\OrdineUtente";

            using (StreamWriter sw1 = new StreamWriter(path))
            {
                sw1.WriteLine("");
            }

            using (StreamWriter sw2 = new StreamWriter(path, true))
            {
                sw2.WriteLine("");
            }
        }
    }
}
