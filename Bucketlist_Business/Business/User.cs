using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bucketlist_Business
{
    public class User
    {
        //velden
        private int _id;
        private string _naam;
        private string _paswoord;
        //eigenschappen
        public int id
        {
            get { return _id; }
        }
        public string naam
        {
            get { return _naam; }
            set { value = _naam; }
        }
        public string paswoord
        {
            get { return _paswoord; }
            set { value = _paswoord; }
        }
        //contructor
        public User(int id, string naam, string paswoord)
        {
            _id = id;
            _naam = naam;
            _paswoord = paswoord;
        }
        public User(string naam, string paswoord)
        {
            _naam = naam;
            _paswoord = paswoord;
        }
        //methodes
        public override string ToString()
        {
            return _id + ": " + _naam;
        }
    }
}
