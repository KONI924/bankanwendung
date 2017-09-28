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
    }
}