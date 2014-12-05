using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entity;

namespace Business
{
    /// <summary>
    /// 损益预算系数
    /// </summary>
    public class ProfitLoss_CoefficientModel : BaseModel<ProfitLoss_Coefficient>
    {

        /// <summary>
        /// 根据公司ID 获取损益预算系数
        /// </summary>
        /// <param name="CID"></param>
        /// <returns></returns>
        public ProfitLoss_Coefficient GetCoefficient_ByCID(int CID)
        {
            var item = base.List().Where(a => a.CompanyID == CID).FirstOrDefault();
            return item;
        }
         /// <summary>
        /// 根据公司ID 获取是否有损益预算系数
        /// </summary>
        /// <param name="CID"></param>
        /// <returns></returns>
        public bool GetIsData_ByCID(int CID)
        {
            var list = List().Where(a => a.CompanyID == CID);
            if (list.Count()>0)
            {
                return true;
            }
            else {
                return false;
            }
        }
    }
}
