using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChurchCommunityBuilder.Api.Realms {
    public class ProcessRealm: BaseRealm {
        public ProcessRealm(string churchCode, string username, string password)
            : base(churchCode, username, password) {

        }

        private ChurchCommunityBuilder.Api.Processes.Sets.Processes _processesSet;

        #region Sets
        public ChurchCommunityBuilder.Api.Processes.Sets.Processes Processes {
            get {
                if (_processesSet == null) {
                    _processesSet = new Processes.Sets.Processes(string.Format(API_URL, base.ChurchCode), base.UserName, base.Password);
                }

                return _processesSet;
            }
        }
        #endregion Sets
    }
}
