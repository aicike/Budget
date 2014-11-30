using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entity;

namespace Business
{
    public class CompanyAccountModel : BaseModel<CompanyAccount>
    {
        /// <summary>
        /// 公司登陆
        /// </summary>
        /// <param name="userName"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public Result Login(string userName, string password)
        {
            string pwd = DESEncrypt.Encrypt(password);
            var obj = List().Where(a => a.AccountNumber == userName && a.AccountPwd == pwd).FirstOrDefault();
            Result result = new Result();
            if (obj == null)
            {
                result.Error = "账号或密码错误。";
            }
            else
            {
                result.Entity = obj;
            }
            return result;
        }

        /// <summary>
        /// 根据公司ID 获取用户
        /// </summary>
        /// <param name="CID">公司ID</param>
        /// <returns></returns>
        public List<CompanyAccount> GetAccount_BYCID(int CID)
        {
            var list = List().Where(a => a.CompanyID == CID).ToList();
            return list;
        }
    }
}
