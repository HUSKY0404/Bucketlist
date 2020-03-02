using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bucketlist_Business.Business
{
    public class BucketListItem
    {
        //velden
        private int _id;
        private string _naam;
        private string _omschrijving;
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
        public string omschrijving
        {
            get { return _omschrijving; }
            set { value = _omschrijving; }
        }
        //contructor
        public BucketListItem(int id, string naam, string omschrijving)
        {
            _id = id;
            _naam = naam;
            _omschrijving = omschrijving;
        }
        public BucketListItem(string naam, string omschrijving)
        {
            _naam = naam;
            _omschrijving = omschrijving;
        }
        //methodes
        public override string ToString()
        {
            return _id + ": " + _naam + " | " + _omschrijving;
        }
    }
}
