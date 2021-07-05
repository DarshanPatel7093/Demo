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
    public class ExamStandardServices : AbstractExamStandardServices
    {
        private AbstractExamStandardDao abstractExamStandardDao;

        public ExamStandardServices(AbstractExamStandardDao abstractExamStandardDao)
        {
            this.abstractExamStandardDao = abstractExamStandardDao;
        }
        public override SuccessResult<AbstractExamStandard> ExamStandardUpsert(AbstractExamStandard abstractExam)
        {
            return this.abstractExamStandardDao.ExamStandardUpsert(abstractExam);
        }
        public override PagedList<AbstractExamStandard> ExamStandardSelectAll(PageParam pageParam, string search)
        {
            return this.abstractExamStandardDao.ExamStandardSelectAll(pageParam, search);
        }
        public override bool ExamStandardDelete(string StandardKey)
        {
            return this.abstractExamStandardDao.ExamStandardDelete(StandardKey);
        }
        public override SuccessResult<AbstractExamStandard> ExamStandardById(string StandardKey)
        {
            return this.abstractExamStandardDao.ExamStandardById(StandardKey);
        }
    }
}
