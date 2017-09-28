using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bankanwendung
{
    class Consultant : Person
    {
        public int ConsulNr{get; set;} = -1;
        public Consultant() : base() { }
        public Consultant(string lastName, string firstName, DateTime birth, string address, int consulNr) : base(lastName, firstName, birth, address)
        {
            this.ConsulNr = consulNr;
        }

        private List<Credit> list;
        public List<Credit> List { get => list; set => list = value; }


        // manuelles anlegen von Kundenberatern

        // Consultant("Mustermann", "Max", DateTime(02,09,1978), "Am Ring 24, 12345 Wiesloch", 1)
    }
}