using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entity;

namespace Business
{
    public class ProfitLossReality_DetailModel : BaseModel<ProfitLossReality_Detail>
    {
        /// <summary>
        /// 删除明细数据
        /// </summary>
        /// <param name="MainID"></param>
        /// <returns></returns>
        public Result DelInfo_ByMainID(int MainID, int week)
        {
            Result result = new Result();
            string sql = "delete ProfitLossReality_Detail where ProfitLossReality_MainID = " + MainID + " and Week=" + week;
            base.SqlExecute(sql);
            return result;
        }


        /// <summary>
        /// 根据年份ID 公司ID 获取上报数据
        /// </summary>
        /// <param name="YearID"></param>
        /// <param name="CID"></param>
        /// <returns></returns>
        public List<ProfitLossReality_Detail> GetInfo_ByCID_YID(int YearID, int CID)
        {
            var list = List().Where(a => a.ParticularYearID == YearID && a.CompanyID == CID ).ToList();
            return list;
        }
    }
}
