﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using DataTables.Mvc;
using Demo.Common;
using Demo.Common.Paging;
using Demo.Entities.Contract;
using Demo.Entities.V1;
using Demo.Infrastructure;
using Demo.Pages;
using Demo.Services.Contract;
using static Demo.Infrastructure.Enums;
namespace Demo.Controllers
{
    public class ExamChapterController : BaseController
    {
        #region Fields

        private readonly AbstractExamChapterServices abstractExamChapterServices;
        private readonly AbstractExamSubjectServices abstractExamSubjectServices;
        private readonly AbstractExamServices abstractExamServices;
        #endregion

        #region Ctor

        public ExamChapterController(AbstractExamChapterServices abstractExamChapterServices, AbstractExamSubjectServices abstractExamSubjectServices, AbstractExamServices abstractExamServices)
        {
            this.abstractExamChapterServices = abstractExamChapterServices;
            this.abstractExamSubjectServices = abstractExamSubjectServices;
            this.abstractExamServices = abstractExamServices;
        }

        #endregion

        #region Methods
        public ActionResult Index()
        {
            if (TempData["openPopup"] != null)
                ViewBag.openPopup = TempData["openPopup"];
            ViewBag.Exam = BindExamDropdown();
            ViewBag.Subject = BindSubjectDropdown();
            return View();
        }

        [HttpGet]
        public ActionResult Manage(string ChapterKey = "",string SubjectKey = "")
        {
            AbstractExamChapter objModel = null;
            if(ChapterKey != "" && SubjectKey != "") { 
                objModel = abstractExamChapterServices.ExamChapterById(ChapterKey, SubjectKey).Item;
            }
            ViewBag.Subject = BindSubjectDropdown();
            return View(objModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [ActionName(Actions.BindExamChapter)]
        public JsonResult BindExamChapter([ModelBinder(typeof(DataTablesBinder))] IDataTablesRequest requestModel,string SubjectKey = "")
        {
            try
            {
                int totalRecord = 0;
                int filteredRecord = 0;
                PageParam pageParam = new PageParam();
                pageParam.Offset = requestModel.Start;
                pageParam.Limit = requestModel.Length;
                string Search = requestModel.Search.Value;
                var model = abstractExamChapterServices.ExamChapterSelectAll(pageParam, Search, SubjectKey);
                totalRecord = (int)model.TotalRecords;
                filteredRecord = (int)model.TotalRecords;
                return Json(new DataTablesResponse(requestModel.Draw, model.Values, filteredRecord, totalRecord), JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            {
                return Json(new object[] { null }, JsonRequestBehavior.AllowGet);
            }
        }


        [HttpPost]
        [ValidateInput(false)]
        [ValidateAntiForgeryToken]
        [ActionName(Actions.ExamChapterAddEdit)]
        public ActionResult ExamChapterAddEdit(ExamChapter examChapter)
        {
            var user = abstractExamChapterServices.ExamChapterUpsert(examChapter);
            if(user.Code == 200)
            {
                TempData["openPopup"] = CommonHelper.ShowAlertMessageToastr(MessageType.success.ToString(), user.Message);
            }
            else
            {
                TempData["openPopup"] = CommonHelper.ShowAlertMessageToastr(MessageType.warning.ToString(), user.Message);
            }
            
            return RedirectToAction(Actions.Index, Pages.Controllers.ExamChapter, new { Area = "" });
        }

        [HttpPost]
        [ActionName(Actions.Delete)]
        public JsonResult Delete(string ChapterKey = "", string SubjectKey = "")
        {
            var result = abstractExamChapterServices.ExamChapterDelete(ChapterKey,SubjectKey);
            TempData["openPopup"] = CommonHelper.ShowAlertMessageToastr(MessageType.success.ToString(), "Exam chapter deleted successfully");
            return Json(1, JsonRequestBehavior.AllowGet);
        }

        public IList<SelectListItem> BindExamDropdown()
        {
            PageParam pageParam = new PageParam();
            pageParam.Offset = 0;
            pageParam.Limit = 0;
            var model = abstractExamServices.ExamSelectAll(pageParam, "");
            List<SelectListItem> items = new List<SelectListItem>();
            foreach (var category in model.Values)
            {
                if(category.IsSubject == 1)
                {
                    items.Add(new SelectListItem() { Text = category.Name.ToString(), Value = category.ExamKey.ToString() });
                }
                
            }
            return items;
        }

        public IList<SelectListItem> BindSubjectDropdown()
        {
            PageParam pageParam = new PageParam();
            pageParam.Offset = 0;
            pageParam.Limit = 0;
            var model = abstractExamSubjectServices.ExamSubjectSelectAll(pageParam, "");
            List<SelectListItem> items = new List<SelectListItem>();
            foreach (var category in model.Values)
            {
                items.Add(new SelectListItem() { Text = category.SubjectName.ToString(), Value = category.SubjectKey.ToString() });
            }
            return items;
        }
        #endregion
    }
}
