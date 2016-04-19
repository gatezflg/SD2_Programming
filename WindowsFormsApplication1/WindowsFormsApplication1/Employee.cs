using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
     [Serializable]
    public abstract class Employee : Person //abstract class for staff and managers
    {
        DateTime _dateHired { set; get; } 

          public Employee(int id, string name, string surname, string address, int phoneNr)
            : base(id, name, surname, address, phoneNr)
          {
              
          this._dateHired = DateTime.Now;
          }
          


    }
}
//MAY BE NEED TO CHANGE ATTRIBUTES OR FUNCTIONS TO PUBLIC OR PRIVATE ????