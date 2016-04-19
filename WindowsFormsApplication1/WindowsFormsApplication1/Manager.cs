using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    [Serializable]
    public class Manager:Employee
    {


        string _password;
          public Manager(int id, string name, string surname, string address, int phoneNr, string pass)
            : base(id, name, surname, address, phoneNr) 
          {
              this._password = pass;
          }
    }
}
