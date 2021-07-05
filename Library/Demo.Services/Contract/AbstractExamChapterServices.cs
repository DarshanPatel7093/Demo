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
    public abstract class AbstractExamChapterServices : AbstractBaseService
    {
        public abstract SuccessResult<AbstractExamChapter> ExamChapterUpsert(AbstractExamChapter abstractExamChapter);

        public abstract PagedList<AbstractExamChapter> ExamChapterSelectAll(PageParam pageParam, string search,string SubjectKey="");

        public abstract bool ExamChapterDelete(string ChapterKey, string SubjectKey);

        public abstract SuccessResult<AbstractExamChapter> ExamChapterById(string ChapterKey, string SubjectKey);
    }
}
