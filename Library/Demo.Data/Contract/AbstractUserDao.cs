﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Demo.Common;
using Demo.Common.Paging;
using Demo.Entities.Contract;

namespace Demo.Data.Contract
{
   public abstract class AbstractUserDao : AbstractBaseDao
    {
        public abstract SuccessResult<AbstractUser> Login(string Email, string Password);

        //public abstract SuccessResult<AbstractUsers> VerifyEmail(string email);        

        //public abstract PagedList<AbstractUsers> SelectAll(PageParam pageParam, string search);

        //public abstract PagedList<AbstractUsers> TopFiveUserFlatsSelectAll();

        //public abstract PagedList<AbstractUsers> GetMembers(PageParam pageParam, string search);

        //public abstract SuccessResult<AbstractUsers> Select(int id);

        //public abstract SuccessResult<AbstractUsers> InsertUpdateUsers(AbstractUsers abstractusers);

        //public abstract SuccessResult<AbstractUsers> UsersChangePassword(AbstractUsers abstractusers);

        //public abstract bool Delete(int id);

        ////public abstract int UserPasswordUpdate(AbstractUsers abstractUsers);

        ////public abstract PagedList<AbstractUsers> MenuSelectAll();

        //public abstract bool ChangeStatusByTableName(string Table, int Id);

        //public abstract PagedList<string> GetUsersDeviceToken();

        //public abstract PagedList<AbstractUsers> GetMembersByflatId(int flatid);

        //public abstract SuccessResult<AbstractUsers> SelectChairman();
    }
}
