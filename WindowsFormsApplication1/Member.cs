using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace WindowsFormsApplication1
{
    [Serializable]
    public class Member: Person
    {
        


        private bool isReserved;
        double _money { get; set; }

        public int SignUpDate { get; set; }
        public int balance { get; set; }


        public Member(int id, string name, string surname, string address, int phoneNr, bool isReserved)
            : base(id, name, surname, address, phoneNr) { }
       
          
          public static void write_Member_To_File()
        {
            BinaryFormatter bformatter1 = new BinaryFormatter();
            FileStream memberFile = new FileStream("member.bin", FileMode.OpenOrCreate, FileAccess.Write);
            bformatter1.Serialize(memberFile, Program.memberList);
            memberFile.Close();


        }

        public static void read_members()
          {
              FileInfo aFile = new FileInfo("member.bin");
            if (aFile.Exists)
            {
                BinaryFormatter bformatter1 = new BinaryFormatter();
                FileStream memberFile = new FileStream("member.bin", FileMode.OpenOrCreate, FileAccess.Read);
                Program.memberList = bformatter1.Deserialize(memberFile) as ArrayList;
                memberFile.Close();
            }

          }

        public bool ISReserved
        {
            get 
            {
                return isReserved;
            }
            set
            {
                isReserved = value;
            }

        }


    }
}
