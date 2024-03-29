﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Demo.Common;
using Demo.Common.Paging;
using Demo.Entities.Contract;

namespace Demo.Services.Contract
{
    public abstract class AbstractOrderDetailsServices : AbstractBaseService
    {
        public abstract SuccessResult<AbstractOrderDetails> OrderDetailsUpsert(AbstractOrderDetails abstractOrderDetails);

        public abstract SuccessResult<AbstractOrderDetails> OrderStatusUpdate(int OrderId, string Status, string RazorpayPaymentId = "", string RazorpaySignature = "");

        public abstract SuccessResult<AbstractOrderDetails> OrderDetailsById(int OrderId);

        public abstract PagedList<AbstractOrderDetails> OrderDetailsByCustomer(int CustomerId);

        public abstract SuccessResult<AbstractOrderDetails> OrderDetailsUpdateSignaturePaymentId(int OrderId, string RazorpayOrderID);

        public abstract PagedList<AbstractOrderDetails> OrderDetailsByCustomerWeb(PageParam pageParam, int CustomerId, string Search = "");

    }
}
