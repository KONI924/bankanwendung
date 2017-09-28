using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bankanwendung
{
    public class Bank
    {
        private List<Credit> list;
        public List<Credit> List { get => list; set => list = value; } 
    }
}
