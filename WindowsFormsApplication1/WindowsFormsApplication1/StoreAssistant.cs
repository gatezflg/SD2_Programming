using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class StoreAssistant:Employee
    {
        //MAY BE NEED TO CHANGE ATTRIBUTES OR FUNCTIONS TO PUBLIC OR PRIVATE ????
        string _password { set; get; }
    

                public StoreAssistant(int id, string name, string surname, string address, int phoneNr, string password)
              :base(id,name,surname,address,phoneNr)

                 {
                    
                    this._password = password;
                }


    }
}
