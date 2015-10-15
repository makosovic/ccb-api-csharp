using System.Text;
using RestSharp.Extensions;
using System.Collections.Generic;

namespace ChurchCommunityBuilder.Api.Util {
    public class FormValuesBuilder {
        private StringBuilder _sb = new StringBuilder();
        private Dictionary<string, string> _dict = new Dictionary<string, string>();
        private bool _hasValues = false;

        public FormValuesBuilder Add(string name, object value) {
            if (this._hasValues) {
                this._sb.Append("&");
            }

            if (!_dict.ContainsKey(name)) {
                _dict.Add(name, StringExtensions.UrlEncode(string.Format("{0}", value)));
            }

            this._sb.Append(name).Append("=").Append(StringExtensions.UrlEncode(string.Format("{0}", value)));
            this._hasValues = true;
            return this;
        }

        public override string ToString() {
            return this._sb.ToString();
        }

        public Dictionary<string, string> ToDictionary() {
            return this._dict;
        }
    }
}
