using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bankanwendung
{
    public class Customer : Person
    {
        public int CustumNr { get; set; } = -1;
        public bool Creditworth { get => creditworth; set => creditworth = value; }

        public Customer(int custNr)
        {
            CustumNr = custNr;
        }
        private bool creditworth = false;
        public Customer() : base() { }

        public Customer(string lastName, string firstName, DateTime birthday, string adress, int custNr, bool creditworth) : base(lastName, firstName, birthday, adress)
        {
            this.CustumNr = custNr;
            this.Creditworth = creditworth;
        }
    }
}
