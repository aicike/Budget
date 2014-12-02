using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entity;

namespace Business
{
    public class ProfitLossReality_MainModel : BaseModel<ProfitLossReality_Main>
    {
        /// <summary>
        /// 根据年份ID，月，公司ID获取 实际主表信息
        /// </summary>
        /// <param name="YearID"></param>
        /// <param name="Month"></param>
        /// <param name="CID"></param>
        /// <returns></returns>
        public ProfitLossReality_Main GetRM_ByYID_Month_CID(int YearID, int Month, int CID)
        {
            var item = base.List().Where(a => a.CompanyID == CID && a.Month == Month && a.ParticularYearID == YearID).FirstOrDefault();
            return item;
        }
        /// <summary>
        /// 上报月份实际损益
        /// </summary>
        /// <param name="YearID"></param>
        /// <param name="Month"></param>
        /// <param name="CID"></param>
        /// <param name="Report"></param>
        /// <returns></returns>
        public Result SetReport(int YearID, int Month, int CID, bool Report)
        {
            Result result = new Result();
            string sql = string.Format("update ProfitLossReality_Main set IsReport = [0] where  CompanyID=[1] and ParticularYearID=[2] and Month=[3]",
                        Report, CID, YearID, Month);
            base.SqlExecute(sql);
            return result;
        }
    }
}
