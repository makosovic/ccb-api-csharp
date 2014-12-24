using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChurchCommunityBuilder.Api.Entity;

namespace ChurchCommunityBuilder.Api.Entity {
    public class Response {
        public Request Request { get; set; }
        public string Service { get; set; }
        public string ServiceAction { get; set; }
    }
}
