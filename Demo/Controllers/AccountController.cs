﻿using Demo.Common;
using Demo.Entities.Contract;
using Demo.Entities.V1;
using Demo.Infrastructure;
using Demo.Pages;
using Demo.Services.Contract;
using System;
using System.Web;
using System.Web.Mvc;
using static Demo.Infrastructure.Enums;

namespace Demo.Controllers
{
    public class AccountController : Controller
    {
        #region Fields
        private readonly AbstractUserServices usersService;
        //private readonly AbstractOrganizationsServices abstractOrganizationsServices;
        #endregion

        #region Ctor
        public AccountController(AbstractUserServices usersService)
        {
            this.usersService = usersService;
        }
        #endregion

        #region Methods
        [HttpGet]
        [ActionName(Actions.LogIn)]
        public ActionResult LogIn()
        {
            if (TempData["openPopup"] != null)
                ViewBag.openPopup = TempData["openPopup"];
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [ActionName(Actions.LogIn)]
        public ActionResult LogIn(User objmodel)
        {
            SuccessResult<AbstractUser> userData = usersService.Login(objmodel.Email, objmodel.Password);
            if (userData != null && userData.Code == 200 && userData.Item != null)
            {
                Session.Clear();
                ProjectSession.UserID = userData.Item.Id;
                ProjectSession.UserName = userData.Item.FirstName + " " + userData.Item.LastName;
                HttpCookie cookie = new HttpCookie("UserLogin");
                cookie.Values.Add("Id", objmodel.Id.ToString());
                cookie.Expires = DateTime.Now.AddHours(5);
                Response.Cookies.Add(cookie);
                return RedirectToAction(Actions.Index, Pages.Controllers.Dashboard, new { Area = "" });
            }
            else
            {
                ViewBag.openPopup = CommonHelper.ShowAlertMessageToastr(MessageType.danger.ToString(), Messages.InValidCredential);
            }
            return View();
        }

        [AllowAnonymous]
        [ActionName(Actions.Logout)]
        public ActionResult Logout()
        {
            Session.Clear();
            Session.Abandon();
            Response.Cache.SetExpires(DateTime.UtcNow.AddMinutes(-1));
            Response.Cache.SetCacheability(HttpCacheability.NoCache);
            Response.Cache.SetNoStore();
            return RedirectToAction(Actions.LogIn, Pages.Controllers.Account, new { Area = "" });
        }

        [HttpGet]
        [ActionName(Actions.ResetPSW)]
        public ActionResult ResetPSW(string Id = null)
        {
            if (TempData["openPopup"] != null)
                ViewBag.openPopup = TempData["openPopup"];
            ViewBag.userid = ConvertTo.Base64Decode(Id);
            ViewBag.userid = 9;
            return View();
        }

        [HttpGet]
        [ActionName(Actions.Success)]
        public ActionResult Success()
        {
            if (TempData["openPopup"] != null)
                ViewBag.openPopup = TempData["openPopup"];
            return View();
        }
        #endregion
    }
}