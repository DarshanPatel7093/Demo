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
    public class ExamChapterServices : AbstractExamChapterServices
    {
        private AbstractExamChapterDao abstractExamChapterDao;

        public ExamChapterServices(AbstractExamChapterDao abstractExamChapterDao)
        {
            this.abstractExamChapterDao = abstractExamChapterDao;
        }

        public override SuccessResult<AbstractExamChapter> ExamChapterUpsert(AbstractExamChapter abstractExamChapter)
        {
            return this.abstractExamChapterDao.ExamChapterUpsert(abstractExamChapter);
        }

        public override PagedList<AbstractExamChapter> ExamChapterSelectAll(PageParam pageParam, string search,string SubjectKey ="")
        {
            return this.abstractExamChapterDao.ExamChapterSelectAll(pageParam, search, SubjectKey);
        }

        public override bool ExamChapterDelete(string ChapterKey, string SubjectKey)
        {
            return this.abstractExamChapterDao.ExamChapterDelete(ChapterKey, SubjectKey);
        }

        public override SuccessResult<AbstractExamChapter> ExamChapterById(string ChapterKey, string SubjectKey)
        {
            return this.abstractExamChapterDao.ExamChapterById(ChapterKey, SubjectKey);
        }
    }
}
