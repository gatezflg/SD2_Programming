using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class Catalogue : Game
    {

        //bool _isIn, _isOut, _isReserved, _isDamaged;

        bool _isRented { set; get; }
        bool _isReserved { set; get; }
        bool _isDamaged { set; get; }


        string _CdId;
        DateTime _dateAdded;
        DateTime _dateReserved { set; get; }
        DateTime _dateSended { set; get; }
        DateTime _dateReturnet { set; get; }


        //Member _customer;
        //Game _cd;


        public Catalogue(string cdName, string gameId, string cdId)
            : base(cdName, gameId)
        {
            this._CdId = cdId; // make it random generated as many times as many copies exist in class Game
            this._dateAdded = DateTime.Now;
            this._isRented = false;
            this._isReserved = false;
            this._isDamaged = false;
        }



    }
}