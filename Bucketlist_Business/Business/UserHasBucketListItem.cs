using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bucketlist_Business.Business
{
    public class UserHasBucketListItem
    {
        //velden
        private int _idUser;
        private int _idBucketListItem;
        private string _naamGebruiker;
        private string _naambucketListItem;
        private string _leeftijd;
        private bool _algedaan;
        //eigenschappen
        public int idUser
        {
            get { return _idUser; }
        }
        public int idBucketListItem
        {
            get { return _idBucketListItem; }
        }
        public string naamGebruiker
        {
            get { return _naamGebruiker; }
            set { value = _naamGebruiker; }
        }
        public string naamBucketListItem
        {
            get { return _naambucketListItem; }
            set { value = _naambucketListItem; }
        }
        public string leeftijd
        {
            get { return _leeftijd; }
            set { value = _leeftijd; }
        }
        public bool algedaan
        {
            get { return _algedaan; }
            set { value = _algedaan; }
        }
        //constructors
        public UserHasBucketListItem(string naamuser, string naambucketlistitem, string leeftijd, bool algedaan)
        {
            naamuser = _naamGebruiker;
            naambucketlistitem = _naambucketListItem;
            leeftijd = _leeftijd;
            algedaan = _algedaan;
        }
        //methodes
        public override string ToString()
        {
            return naamGebruiker + ": " + naamBucketListItem + " op " + leeftijd + " | " + algedaan;
        }
    }
}
