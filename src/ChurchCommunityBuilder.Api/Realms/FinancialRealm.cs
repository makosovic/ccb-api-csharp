using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChurchCommunityBuilder.Api.Realms {
   public class FinancialRealm : BaseRealm {
        public FinancialRealm(string churchCode, string username, string password)
            : base(churchCode, username, password) {
        }

        #region Properties
        private ChurchCommunityBuilder.Api.Financial.Sets.Accounts _accountSet;
        private ChurchCommunityBuilder.Api.Financial.Sets.OnlineGifts _onlineGiftSet;
        private ChurchCommunityBuilder.Api.Financial.Sets.Batches _batchesSet;
        #endregion Properties

        #region Sets
        public ChurchCommunityBuilder.Api.Financial.Sets.Accounts Accounts {
            get {
                if (_accountSet == null) {
                    _accountSet = new Financial.Sets.Accounts(string.Format(API_URL, base.ChurchCode), base.UserName, base.Password);
                }

                return _accountSet;
            }
        }

        public ChurchCommunityBuilder.Api.Financial.Sets.OnlineGifts OnlineGifts {
            get {
                if (_onlineGiftSet == null) {
                    _onlineGiftSet = new Financial.Sets.OnlineGifts(string.Format(API_URL, base.ChurchCode), base.UserName, base.Password);
                }

                return _onlineGiftSet;
            }
        }

        public ChurchCommunityBuilder.Api.Financial.Sets.Batches Batches {
            get {
                if (_batchesSet == null) {
                    _batchesSet = new Financial.Sets.Batches(string.Format(API_URL, base.ChurchCode), base.UserName, base.Password);
                }

                return _batchesSet;
            }
        }
        #endregion Sets
    }
}
