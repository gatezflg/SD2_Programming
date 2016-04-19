using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;



namespace WindowsFormsApplication1
{         [Serializable]
   public class StoreAssistant:Employee
    {
     

     

        //MAY BE NEED TO CHANGE ATTRIBUTES OR FUNCTIONS TO PUBLIC OR PRIVATE ????
       public string _password { set; get; }

    
                public StoreAssistant(int id, string name, string surname, string address, int phoneNr, string password)
              :base(id,name,surname,address,phoneNr)

                 {
                    
                    this._password = password;
                }




                public static void writeAssistants()
                {


                    BinaryFormatter b4mater = new BinaryFormatter();
                    FileStream assistantsFile = new FileStream("assistants.bin", FileMode.OpenOrCreate, FileAccess.Write);
                   b4mater.Serialize(assistantsFile, Program.staffList) ;
                    assistantsFile.Close();

                }


       public static void readAssistants()
                {


                    BinaryFormatter b4mater = new BinaryFormatter();
                    FileStream assistantsFile = new FileStream("assistants.bin", FileMode.Open, FileAccess.Read);
                    Program.staffList = b4mater.Deserialize(assistantsFile) as ArrayList;
                    assistantsFile.Close();

                }



    }
}
