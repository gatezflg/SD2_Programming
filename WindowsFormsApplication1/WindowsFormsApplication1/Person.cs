using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
     [Serializable]
   public abstract class Person // abstract class 
    {

        //MAY BE NEED TO CHANGE ATTRIBUTES OR FUNCTIONS TO PUBLIC OR PRIVATE ????
       public int _id { set; get; }
       public string _name { set; get; }
       public string _surname { set; get; }

       public string _address { set; get; }

       public int _phoneNr { set; get; }


       public Person(int id, string name, string surname, string address, int phoneNr)
       {
           this._name = name;
           this._surname  = surname;
           this._id = id;
           this._address = address;
           this._phoneNr = phoneNr;
       }







    }
}
