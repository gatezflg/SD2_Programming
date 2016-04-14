using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class Transaction
    {

        int _transactionId { set; get; }
        string _transactionType { set; get; }
        public Member _customer { set; get; }
        int _customerFee { set; get; }
        int _rentalFee { set; get; }
        int _lateFee { set; get; }

        public Transaction( int transID, string transType, Member customer, int customerFee, int rentalFee, int lateFee)
        {

            this._transactionId = transID;
            this._transactionType = transType;
            this._customer = customer;
            this._customerFee = customerFee;
            this._rentalFee = rentalFee;
            this._lateFee = lateFee;

        }




    }
}
