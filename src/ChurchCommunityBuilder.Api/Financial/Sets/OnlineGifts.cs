using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChurchCommunityBuilder.Api.Financial.Entity;
using ChurchCommunityBuilder.Api.Entity;

namespace ChurchCommunityBuilder.Api.Financial.Sets
{
    public class OnlineGifts : BaseApiSet<OnlineGift>
    {
        public OnlineGifts(string baseUrl, string username, string password) : base(baseUrl, username, password) { }

        public IChurchCommunityBuilderResponse<OnlineGift> Create(OnlineGift entity)
        {
            var result = this.Execute("online_giving_insert_gift", entity.GetFormValues(), entity.GetFormDictionary());
            return result;
        }
    }
}
