using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Collections;

namespace WindowsFormsApplication1
{
    [Serializable]
    public class AccountTransaction
    {

        //ass
        int rentalFee, lateFee, memberFee;
        string transactionType;
        Member member;
        public AccountTransaction(int rentalfee, int latefee, int memberfee, string transactionType, Member member)
        {
            this.rentalFee = rentalfee;
            this.lateFee = latefee;
            this.memberFee = memberfee;
            this.member = member;
            this.transactionType = transactionType;
        }
        public Member Member
        {
            get
            {
                return member;
            }
            set
            {
                member = value;
            }
        }
        public int RentalFee
        {
            get
            {
                return rentalFee;
            }
            set
            {
                rentalFee = value;
            }
        }
        public int LateFee
        {
            get
            {
                return lateFee;
            }
            set
            {
                lateFee = value;
            }
        }
        public int MemberFee
        {
            get
            {
                return memberFee;
            }
            set
            {
                memberFee = value;
            }
        }
        public string TransactionType
        {
            get
            {
                return transactionType;
            }
            set
            {
                transactionType = value;
            }
        }
        public static void ReadTransactionList()
        {
            FileInfo aFile = new FileInfo("Transaction.bin");
            if (aFile.Exists)
            {
                BinaryFormatter bformatter = new BinaryFormatter();
                FileStream transactionFile = new FileStream("Transaction.bin", FileMode.Open, FileAccess.Read);
                Program.transactionList = bformatter.Deserialize(transactionFile) as ArrayList;
                transactionFile.Close();
            }
        }
        public static void WriteTransactionList()
        {
            BinaryFormatter bformatter = new BinaryFormatter();
            FileStream transactionFile = new FileStream("Transaction.bin", FileMode.OpenOrCreate, FileAccess.Write);
            bformatter.Serialize(transactionFile, Program.transactionList);
            transactionFile.Close();
        }

        public static void ReadIndividualTransactionList()
        {
            FileInfo aFile = new FileInfo("individualTransactionList.bin");
            if (aFile.Exists)
            {
                BinaryFormatter bformatter = new BinaryFormatter();
                FileStream individualTransactionFile = new FileStream("individualTransactionList.bin", FileMode.Open, FileAccess.Read);
                Program.individualTransList = bformatter.Deserialize(individualTransactionFile) as ArrayList;
                individualTransactionFile.Close();
            }

        }
        public static void writeIndividualTransactionList()
        {
            BinaryFormatter bformatter = new BinaryFormatter();
            FileStream individualTransactionFile = new FileStream("individualTransactionList.bin", FileMode.OpenOrCreate, FileAccess.Write);
            bformatter.Serialize(individualTransactionFile, Program.individualTransList);
            individualTransactionFile.Close();

        }
    }
}

