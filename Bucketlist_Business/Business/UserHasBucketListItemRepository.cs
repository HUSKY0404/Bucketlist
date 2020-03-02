using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bucketlist_Business.Business
{
    class UserHasBucketListItemRepository
    {
        //Velden
        private List<UserHasBucketListItem> _userHasBucketListItemLijst = new List<UserHasBucketListItem>();
        //eigenschappen
        public List<UserHasBucketListItem> userHasBucketListItemLijst
        {
            get { return _userHasBucketListItemLijst; }
            set { _userHasBucketListItemLijst = value; }
        }
        //constructor
        //methods
        public void addUserHasBucketListItemToRepository(UserHasBucketListItem userHasBucketListItem)
        {
            _userHasBucketListItemLijst.Add(userHasBucketListItem);
        }
    }
}
