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
        public Result DelInfo_ByMainID(int MainID)
        {
            Result result = new Result();
            string sql = "delete ProfitLossReality_Detail where ProfitLossReality_MainID = " + MainID;
            base.SqlExecute(sql);
            return result;
        }

    }
}
