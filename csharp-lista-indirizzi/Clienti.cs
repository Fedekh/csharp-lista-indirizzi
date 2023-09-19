using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_lista_indirizzi
{
    public class Clienti
    {
        private string Name { get; set; }
        private string Lastname { get; set; }
        private string Address { get; set; }
        public string City { get; set; }
        public string Province { get; set; }
        public string Zip { get; set; }

        public Clienti(string name, string lastname, string address, string city, string province, string zip)
        {
            this.Name = name;
            this.Lastname = lastname;
            this.Address = address;
            this.City = city;
            this.Province = province;
            this.Zip = zip;
        }

        public override string ToString() //sovrascriviamo il metodo di c#
        {
            return $"\n\t-Nome:i {this.Name}\n\t-Cognome: {this.Lastname}\n\t-Via: {this.Address}\n\t-Citta: {this.City}\n\t-Provincia: {this.Province}\n\t-CAP: {this.Zip}";
        }
    }
}




