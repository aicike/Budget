using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entity;

namespace Business
{
    /// <summary>
    /// 损益预算 明细主表 MODEL
    /// </summary>
    public class ProfitLoss_MainModel : BaseModel<ProfitLoss_Main>
    {

        /// <summary>
        /// 更改上报
        /// </summary>
        /// <param name="IsReport"> true 上报，false 取消上报</param>
        /// <param name="PMID"> 主表ID</param>
        /// <returns></returns>
        public Result UpdateReport(bool IsReport,int PMID)
        {
            Result result = new Result();
            string sql = string.Format("update ProfitLoss_Main set IsReport = '{0}' where ID={1}", IsReport, PMID);
            base.SqlExecute(sql);
            return result;
        }

        /// <summary>
        /// 根据年份ID 获取明细主表数据
        /// </summary>
        /// <param name="YearID"></param>
        /// <returns></returns>
        public List<ProfitLoss_Main> GetMainInfo_ByYearID(int YearID)
        {
            var list = base.List().Where(a => a.ParticularYearID == YearID).ToList();
            return list;
        }
    }
}
