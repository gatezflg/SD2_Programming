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
        public Member _member { set; get; }
        int _memberFee { set; get; }
        int _rentalFee { set; get; }
        int _lateFee { set; get; }

        public Transaction( int transID, string transType, Member member, int memberFee, int rentalFee, int lateFee)
        {

            this._transactionId = transID;
            this._transactionType = transType;
            this._member = member;
            this._memberFee = memberFee;
            this._rentalFee = rentalFee;
            this._lateFee = lateFee;

        }




    }
}
