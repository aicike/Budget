using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entity;

namespace Business
{
    public class Expenses_DetailModel : BaseModel<Expenses_Detail>
    {
        /// <summary>
        /// 根据公司ID 与年份 获取费用预算
        /// </summary>
        /// <param name="CID">公司ID</param>
        /// <param name="YearID">年份ID</param>
        /// <returns></returns>
        public List<Expenses_Detail> GetDetailed_ByCompanyID(int CID, int YearID)
        {
            var list = List().Where(a => a.CompanyID == CID && a.Expenses_Main.ParticularYearID == YearID).OrderBy(a => a.Month).ToList();
            return list;
        }
    }
}
