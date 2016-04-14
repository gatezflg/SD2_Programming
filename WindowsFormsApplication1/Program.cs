using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Collections;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace WindowsFormsApplication1
{
    static class Program
    {


        static public ArrayList gameList = new ArrayList();
        static public ArrayList gameCatalogue = new ArrayList();

        static public ArrayList staffList = new ArrayList();
        static public ArrayList memberList = new ArrayList();
        static public ArrayList transactionList = new ArrayList();
        static public ArrayList individualTransList = new ArrayList();
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new staffMember());
        }
    }
}
