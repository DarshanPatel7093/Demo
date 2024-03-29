﻿using System;
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
    public class UserServices : AbstractUserServices
    {
        private AbstractUserDao abstractUsersDao;

        public UserServices (AbstractUserDao abstractUsersDao)
        {
            this.abstractUsersDao = abstractUsersDao;
        }

        public override SuccessResult<AbstractUser> Login(string Email, string Password)
        {
            return this.abstractUsersDao.Login(Email, Password);
        }

        //public override SuccessResult<AbstractUsers> VerifyEmail(string email)
        //{
        //    return this.abstractUsersDao.VerifyEmail(email);
        //}

        ////public override int UserPasswordUpdate(AbstractUsers abstractUsers)
        ////{
        ////    return this.abstractUsersDao.UserPasswordUpdate(abstractUsers);
        ////}

        //public override PagedList<AbstractUsers> SelectAll(PageParam pageParam, string search)
        //{
        //    return this.abstractUsersDao.SelectAll(pageParam, search);
        //}

        //public override PagedList<AbstractUsers> TopFiveUserFlatsSelectAll()
        //{
        //    return this.abstractUsersDao.TopFiveUserFlatsSelectAll();
        //}

        //public override PagedList<AbstractUsers> GetMembers(PageParam pageParam, string search)
        //{
        //    return this.abstractUsersDao.GetMembers(pageParam, search);
        //}

        //public override SuccessResult<AbstractUsers> Select(int id)
        //{
        //    return this.abstractUsersDao.Select(id);
        //}

        //public override SuccessResult<AbstractUsers> InsertUpdateUsers(AbstractUsers abstractusers)
        //{
        //    SuccessResult<AbstractUsers> result = this.abstractUsersDao.InsertUpdateUsers(abstractusers);
        //    return result;
        //}

        //public override SuccessResult<AbstractUsers> UsersChangePassword(AbstractUsers abstractusers)
        //{
        //    SuccessResult<AbstractUsers> result = this.abstractUsersDao.UsersChangePassword(abstractusers);
        //    return result;
        //}

        //public override bool Delete(int id)
        //{
        //    return this.abstractUsersDao.Delete(id);
        //}

        ////public override PagedList<AbstractUsers> MenuSelectAll()
        ////{
        ////    return this.abstractUsersDao.MenuSelectAll();
        ////}

        //public override bool ChangeStatusByTableName(string Table, int Id)
        //{
        //    return this.abstractUsersDao.ChangeStatusByTableName(Table, Id);
        //}

        //public override PagedList<string> GetUsersDeviceToken()
        //{
        //    return this.abstractUsersDao.GetUsersDeviceToken();
        //}

        //public override SuccessResult<AbstractUsers> SelectChairman()
        //{
        //    return this.abstractUsersDao.SelectChairman();
        //}


        //public override PagedList<AbstractUsers> GetMembersByflatId(int flatid)
        //{
        //    return this.abstractUsersDao.GetMembersByflatId(flatid);
        //}
    }
}
