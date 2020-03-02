using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bucketlist_Business.Business
{
    class UsersRepository
    {
        //Velden
        private List<User> _userLijst = new List<User>();
        //eigenschappen
        public List<User> userLijst
        {
            get { return _userLijst; }
            set { _userLijst = value;  }
        }
        //constructor
        //methods
        public void addUserToRepository(User user)
        {
            _userLijst.Add(user);
        }
    }
}
