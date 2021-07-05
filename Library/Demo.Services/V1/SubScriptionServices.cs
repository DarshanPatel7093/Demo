using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Demo.Common;
using Demo.Common.Paging;
using Demo.Data.Contract;
using Demo.Entities.Contract;
using Demo.Services.Contract;

namespace Demo.Services.V1
{
    public class SubScriptionServices : AbstractSubScriptionServices
    {
        private AbstractSubScriptionDao abstractSubScriptionDao;

        public SubScriptionServices (AbstractSubScriptionDao abstractSubScriptionDao)
        {
            this.abstractSubScriptionDao = abstractSubScriptionDao;
        }

        public override PagedList<AbstractSubScription> SubscriptionAll(string Key)
        {
            return this.abstractSubScriptionDao.SubscriptionAll(Key);
        }

        public override PagedList<AbstractSubScription> SubscriptionSelectAll(PageParam pageParam, string search)
        {
            return this.abstractSubScriptionDao.SubscriptionSelectAll(pageParam, search);
        }
        public override SuccessResult<AbstractSubScription> SubScriptionUpsert(AbstractSubScription abstractSubScription)
        {
            return this.abstractSubScriptionDao.SubScriptionUpsert(abstractSubScription);
        }
        public override SuccessResult<AbstractSubScription> SubScriptionById(int Id)
        {
            return this.abstractSubScriptionDao.SubScriptionById(Id);
        }

    }
}
