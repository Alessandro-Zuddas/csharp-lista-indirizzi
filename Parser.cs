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
            using var input = File.OpenText("..\\..\\..\\addresses.csv");
            var addresses = new List<Indirizzo>();
            input.ReadLine();

            while (true)
            {
                string? line = input.ReadLine();

                if (line == null)
                {
                    return addresses;
                }

                var chunks = line.Split(',');

                var name = chunks[0];
                var surname = chunks[1];
                var street = chunks[2];
                var city = chunks[3];
                var province = chunks[4];
                var zipCode = chunks[5];

                var address = new Indirizzo(name, surname, street, city, province, zipCode);
                addresses.Add(address);
            }


        }

        public static void Write(IEnumerable<Indirizzo> indirizzo)
        {
            using var output = File.CreateText("..\\..\\..\\addresses.csv");
        }
    }
}
