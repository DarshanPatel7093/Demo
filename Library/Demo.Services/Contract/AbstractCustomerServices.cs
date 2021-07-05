using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Demo.Common;
using Demo.Common.Paging;
using Demo.Entities.Contract;

namespace Demo.Services.Contract
{
    public abstract class AbstractCustomerServices : AbstractBaseService
    {
        public abstract SuccessResult<AbstractCustomer> CustomerUpsert(AbstractCustomer abstractCustomer);

        public abstract SuccessResult<AbstractCustomer> CustomerByDeviceId(string DeviceId, string DeviceToken = "");

        public abstract PagedList<AbstractCustomer> CustomerSelectAll(PageParam pageParam, string search, string StartDate = "", string EndDate = "", int StandardId = 0, int IsBlock = 0, int IsDemo = 0, string GroupName = "", string Type = "", string City = "", string ExpiryStartDate = "", string ExpiryEndDate = "", string SchoolName = "");

        public abstract bool CustomerActiveInActive(int Id);

        public abstract bool CustomerDelete(int Id);

        public abstract SuccessResult<AbstractCustomer> CustomerUpdateWebSide(AbstractCustomer abstractCustomer);

        public abstract SuccessResult<AbstractCustomer> CustomerById(int Id);

        public abstract PagedList<AbstractCustomer> CustomerSelectAllForNotification(string Ids = "");

    }
}
