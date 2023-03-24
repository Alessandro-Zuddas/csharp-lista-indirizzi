using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_lista_indirizzi
{
    public static class Parser
    {
        public static IEnumerable<Indirizzo> Read()
        {
            using var input = File.OpenText("addresses.csv");

            input.ReadLine();
        }

        public static void Write(IEnumerable<Indirizzo> indirizzo)
        {
            using var output = File.CreateText("addresses.csv");
        }
    }
}
