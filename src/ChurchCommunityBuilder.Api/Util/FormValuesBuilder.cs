using System.Text;

namespace ChurchCommunityBuilder.Api.Util {
    public class FormValuesBuilder {
        private StringBuilder _sb = new StringBuilder();
        private bool _hasValues = false;

        public FormValuesBuilder Add(string name, object value) {
            if (this._hasValues) {
                this._sb.Append("&");
            }

            this._sb.Append(name).Append("=").Append(RestSharp.Contrib.HttpUtility.UrlEncode(string.Format("{0}", value)));
            this._hasValues = true;
            return this;
        }

        public override string ToString() {
            return this._sb.ToString();
        }
    }
}
