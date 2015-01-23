using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
using ChurchCommunityBuilder.Api.Attributes;
using System.Xml.Serialization;

namespace ChurchCommunityBuilder.Api.Entity {
    public class BaseEntity {
        public Dictionary<string, string> ToDictionary() {
            var ret = new Dictionary<string, string>();
            var props = this.GetType().GetProperties();

            foreach (PropertyInfo p in props) {
                if (IsRightType(p.PropertyType)) {
                    object value = p.GetValue(this, null);
                    if (value != null && value.ToString() != string.Empty) {// null means the property won't be the part of search parameters
                        //ret.Add(GetKey(p), value.ToString());
                        DateTime? d = value as Nullable<DateTime>;
                        if (d != null) { // DateTime need special handling for converting to string.
                            string format = GetFormat(p);
                            ret.Add(GetKey(p), d.Value.ToString(format == null ? "yyyy-MM-dd" : format));
                        }
                        else {
                            ret.Add(GetKey(p), value.ToString());
                        }
                    }
                }
                else {
                    var message = "All the properties in the DataAccess query object have to be nullable primitive or nullabel datetime or nullable enum or string, property \"" + p.Name + "\" has type : " + p.PropertyType.ToString();
                    throw new ChurchCommunityBuilder.Api.Exceptions.PropertyNotAllowedException(message);
                }
            }
            return ret;
        }

        private string GetKey(PropertyInfo pi) {
            object[] pa = pi.GetCustomAttributes(typeof(XmlElementAttribute), false);
            return pi.Name;
        }

        private string GetFormat(PropertyInfo pi) {
            object[] pa = pi.GetCustomAttributes(typeof(QOAttribute), false);
            return pa.Length == 0 ? null : ((QOAttribute)pa[0]).Format;
        }

        private bool IsRightType(Type t) {
            if (t.IsGenericType && t.GetGenericTypeDefinition() == typeof(Nullable<>)) {
                Type[] types = t.GetGenericArguments();
                if (types.Length != 1) // we only take one argument nullable type.
                    return false;
                else
                    t = types[0];
            }

            return AllowedType(t);
        }

        private bool AllowedType(Type t) {
            return t == typeof(string) || t == typeof(DateTime) || t == typeof(TimeSpan) || t == typeof(decimal) || t.IsPrimitive || t.IsEnum;
        }
    }
}
