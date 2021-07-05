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
    public abstract class AbstractExamQuestionServices : AbstractBaseService
    {
        public abstract SuccessResult<AbstractExamQuestion> ExamQuestionUpsert(AbstractExamQuestion abstractExamQuestion);

        public abstract PagedList<AbstractExamQuestion> ExamQuestionSelectAll(PageParam pageParam, string search, string ExamKey = "", string SubjectKey = "", string ChapterKey = "");

        public abstract bool QuestionDelete(int Id);

        //public abstract SuccessResult<AbstractExamQuestion> ExamQuestionById(string QuestionKey, string ExamKey);
    }
}
