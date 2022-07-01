using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopWorking
{
    class Customer
    {
        //Field
        //private string _firstName;  //field tanımlama

        //Propert
        /*public string FirstName
        {
            get { return "Mr. " + _firstName; }
            set { _firstName = value; }
        }*/
        //Üstteki şekil eski versiyon olarak kullanılırmış

        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }
    }
}
