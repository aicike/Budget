﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entity;
using Business.Commons;
using System.IO;
using System.Web;

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

        /// <summary>
        /// 查询登陆账号是否已存在
        /// </summary>
        /// <param name="Name"></param>
        /// <returns>True:存在；false 不存在</returns>
        public bool GetUnameIsOnly(string AccountNumber)
        {
            var list = List().Where(a => a.AccountNumber == AccountNumber);
            if (list.Count() > 0)
            {
                return true;
            }
            else {
                return false;
            }
        }
        /// <summary>
        /// 查询原始密码是否正确
        /// </summary>
        /// <param name="UID"></param>
        /// <param name="pwd"></param>
        /// <returns></returns>
        public bool GetPwdIsRight(int UID, string pwd)
        {
            var item = List().Where(a => a.ID == UID && a.AccountPwd == pwd).FirstOrDefault();
            if (item != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// 修改密码
        /// </summary>
        /// <param name="UID"></param>
        /// <param name="PWD"></param>
        /// <returns></returns>
        public Result Up_Pwd(int UID, string PWD)
        {
            Result result = new Result();
            string sql = string.Format("update CompanyAccount set  AccountPwd = '{1}' where ID={0} ", UID, PWD);
            var cnt = base.SqlExecute(sql);
            if (cnt > 0)
            {
                result.HasError = false;
            }
            else
            {
                result.HasError = true;
            }
            return result;
        }

        /// <summary>
        /// 修改头像
        /// </summary>
        /// <param name="ImgUrl"></param>
        /// <param name="w"></param>
        /// <param name="h"></param>
        /// <param name="x1"></param>
        /// <param name="y1"></param>
        /// <param name="tw"></param>
        /// <param name="th"></param>
        /// <returns></returns>
        public Result Up_Image(string ImgUrl,int AccountID, int w, int h, int x1, int y1, int tw, int th)
        {
            Result result = new Result();
            var imagePath = Common.GetAccountPath(AccountID)+"/"+ImgUrl.Substring(ImgUrl.LastIndexOf('\\')+1);
            ToolImage.SuperGetPicThumbnailJT(ImgUrl,HttpContext.Current.Server.MapPath(imagePath), 70,w,h,x1,y1,tw,th, System.Drawing.Drawing2D.SmoothingMode.HighQuality, System.Drawing.Drawing2D.CompositingQuality.HighQuality, System.Drawing.Drawing2D.InterpolationMode.High);
            if (File.Exists(imagePath))
            {
                File.Delete(imagePath);
            }
            string sql = string.Format("update CompanyAccount set HeadPortrait = '{1}' where ID = {0}", AccountID, imagePath);
            var cnt = base.SqlExecute(sql);
            if (cnt <= 0)
            {
                result.HasError = true;
            }
            return result;
        }

        /// <summary>
        /// 移除头像
        /// </summary>
        /// <param name="AccountID"></param>
        /// <returns></returns>
        public Result Del_Image(int AccountID)
        {
            Result result = new Result();
            string sql = string.Format("update CompanyAccount set HeadPortrait = '' where ID = {0}", AccountID);
            var cnt = base.SqlExecute(sql);
            if (cnt <= 0)
            {
                result.HasError = true;
            }
            return result;
        }
    }
}
