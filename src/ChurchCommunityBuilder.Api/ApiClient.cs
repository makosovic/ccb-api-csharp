using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;
using ChurchCommunityBuilder.Api.Realms;

namespace ChurchCommunityBuilder.Api {
    public class ApiClient {
        #region Declarations
        private PeopleRealm _peopleRealm;
        private ProcessRealm _processRealm;
        private FinancialRealm _financialRealm;
        #endregion Declarations

        public ApiClient(string churchCode, string username, string password) {
            this._peopleRealm = new PeopleRealm(churchCode, username, password);
            this._processRealm = new ProcessRealm(churchCode, username, password);
            this._financialRealm = new FinancialRealm(churchCode, username, password);
        }

        public PeopleRealm People { get { return _peopleRealm; } }
        public ProcessRealm Processes { get { return _processRealm; } }
        public FinancialRealm Financials { get { return _financialRealm; } }
    }

    public enum ContentType {
        XML = 1,
        JSON = 2
    }
}
