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
    public class OrderPaymentServices : AbstractOrderPaymentServices
    {
        private AbstractOrderPaymentDao abstractOrderPaymentDao;

        public OrderPaymentServices(AbstractOrderPaymentDao abstractOrderPaymentDao)
        {
            this.abstractOrderPaymentDao = abstractOrderPaymentDao;
        }

        //public override SuccessResult<AbstractOrderDetails> OrderDetailsUpsert(AbstractOrderDetails abstractOrderDetails)
        //{
        //    return this.abstractOrderDetailsDao.OrderDetailsUpsert(abstractOrderDetails);
        //}
        
    }
}
