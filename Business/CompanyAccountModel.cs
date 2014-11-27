﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entity;

namespace Business
{
    public class CompanyAccountModel : BaseModel<CompanyAccount>
    {
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
    }
}
