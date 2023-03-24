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

                if (chunks.Length < 6) continue;

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

        public static void Write(IEnumerable<Indirizzo> addresses)
        {
            using var output = File.CreateText("..\\..\\..\\output.txt");
            output.WriteLine("Lista indirizzi: ");

            foreach ( var address in addresses)
            {
                output.WriteLine();
                output.WriteLine("----Indirizzo----");
                output.WriteLine($"Name: {address.name}");
                output.WriteLine($"Surname: {address.surname}");
                output.WriteLine($"Street: {address.street}");
                output.WriteLine($"City: {address.city}");
                output.WriteLine($"Province: {address.province}");
                output.WriteLine($"ZIP Code: {address.zipCode}");
            }
        }
    }
}
