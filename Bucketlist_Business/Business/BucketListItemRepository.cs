using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bucketlist_Business.Business
{
    class BucketListItemRepository
    {
        //Velden
        private List<BucketListItem> _bucketListItemLijst = new List<BucketListItem>();
        //eigenschappen
        public List<BucketListItem> bucketListItemLijst
        {
            get { return _bucketListItemLijst; }
            set { _bucketListItemLijst = value; }
        }
        //constructor
        //methods
        public void addBucketListItemToRepository(BucketListItem bucketlistItem)
        {
            _bucketListItemLijst.Add(bucketlistItem);
        }
    }

}
