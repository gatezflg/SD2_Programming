using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class Game
    {

        string _nameOfGame { set; get; }
        string _genre { set; get; }
        string _gameId { set; get; }
        int _nrOfCopies { set; get; }
        string _descripition { set; get; }

        bool _status { set; get; }


        public Game(string name,string genre, string id, string description, int numOfCds, bool status)
        {
            this._nameOfGame = name;
            this._genre = genre;
            this._gameId = id;
            this._nrOfCopies = numOfCds;
            this._descripition = description;
            this._status = status;
        }


        public Game(string name, string id)// for adding as order in Catalogue
        {
            this._nameOfGame = name;
            this._gameId = id;
           
        }





    }
}
