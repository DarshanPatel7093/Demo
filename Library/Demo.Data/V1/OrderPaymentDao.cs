﻿using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Demo.Common;
using Demo.Common.Paging;
using Demo.Data.Contract;
using Demo.Entities.Contract;
using Demo.Entities.V1;

namespace Demo.Data.V1
{
    public class OrderPaymentDao : AbstractOrderPaymentDao
    {
        //public override SuccessResult<AbstractOrderDetails> OrderDetailsUpsert(AbstractOrderDetails abstractOrderDetails)
        //{
        //    SuccessResult<AbstractOrderDetails> users = null;
        //    var param = new DynamicParameters();
        //    param.Add("@CustomerId", abstractOrderDetails.CustomerId, dbType: DbType.Int32, direction: ParameterDirection.Input);
        //    param.Add("@SubscriptionId", abstractOrderDetails.SubscriptionId, dbType: DbType.Int32, direction: ParameterDirection.Input);

        //    using (SqlConnection con = new SqlConnection(Configurations.ConnectionString))
        //    {
        //        var task = con.QueryMultiple(SQLConfig.OrderDetailsUpsert, param, commandType: CommandType.StoredProcedure);
        //        users = task.Read<SuccessResult<AbstractOrderDetails>>().SingleOrDefault();
        //        users.Item = task.Read<OrderDetails>().SingleOrDefault();
        //    }
        //    return users;
        //}

    }
}
