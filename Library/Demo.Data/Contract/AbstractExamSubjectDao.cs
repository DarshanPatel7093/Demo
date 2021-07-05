using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Demo.Common;
using Demo.Common.Paging;
using Demo.Entities.Contract;

namespace Demo.Data.Contract
{
   public abstract class AbstractExamSubjectDao : AbstractBaseDao
    {
        public abstract SuccessResult<AbstractExamSubject> ExamSubjectUpsert(AbstractExamSubject abstractExamSubject);

        public abstract PagedList<AbstractExamSubject> ExamSubjectSelectAll(PageParam pageParam, string search, string ExamKey = "");

        public abstract bool ExamSubjectDelete(string ExamKey, string SubjectKey);

        public abstract SuccessResult<AbstractExamSubject> ExamSubjectById(string ExamKey, string SubjectKey);
    }
}
