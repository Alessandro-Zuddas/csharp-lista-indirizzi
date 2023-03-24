using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_lista_indirizzi

{
    public record Indirizzo
    {
        public string name;
        public string surname;
        public string street;
        public string city;
        public string province;
        public string zipCode;

        public Indirizzo(string name, string surname, string street, string city, string province, string zipCode)
        {
            this.name = name;
            this.surname = surname;
            this.street = street;
            this.city = city;
            this.province = province;
            this.zipCode = zipCode;
        }


    }
}
