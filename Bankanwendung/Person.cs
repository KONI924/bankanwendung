using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bankanwendung
{
    public class Person
    {
        private string firstName = "";

        private string GetFirstName()
        {
            return firstName;
        }

        private void SetFirstName(string value)
        {
            firstName = value;
        }

        private string lastname = "";

        private string GetLastName()
        {
            return lastname;
        }

        private void SetLastName(string value)
        {
            lastname = value;
        }

        private DateTime birth = new DateTime(1, 1, 1);

        public DateTime GetBirth()
        {
            return birth;
        }

        public void SetBirth(DateTime value)
        {
            birth = value;
        }

        private string address = "";

        public string GetAddress()
        {
            return address;
        }

        public void SetAddress(string value)
        {
            address = value;
        }

        public Person(string lastname, string firstname, DateTime birth, string address)
        {
            this.SetFirstName(firstname);
            this.SetLastName(lastname);
            this.SetBirth(birth);
            this.SetAddress(address);
        }

        public Person()
        {

        }
    }
        
}
