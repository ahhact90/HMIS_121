﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DAL
{
    public class FPub : BaseDAL, UTL.IBaseDAL
    {
        #region Implement
        public int Count()
        {
            throw new NotImplementedException();
        }

        public bool Delete(string id)
        {
            throw new NotImplementedException();
        }

        public object GetByKey(object key)
        {
            throw new NotImplementedException();
        }

        public bool Insert(object obj)
        {
            throw new NotImplementedException();
        }

        public DataTable Search(string name)
        {
            throw new NotImplementedException();
        }

        public DataTable Select()
        {
            throw new NotImplementedException();
        }

        public DataTable Select(object obj)
        {
            throw new NotImplementedException();
        }

        public DataSet Select_non()
        {
            throw new NotImplementedException();
        }

        public DataSet Select_non2(string n)
        {
            throw new NotImplementedException();
        }

        public DataSet Select_non3(DateTime to, DateTime from)
        {
            throw new NotImplementedException();
        }

        public bool Update(object obj)
        {
            throw new NotImplementedException();
        }
        #endregion
        #region FPub_Fee
        public string Close_Media_Fee(long Media)
        {
            var sql = "select * from his_fee_close_med('{0}|1|')";
            sql = string.Format(sql,Media);
            return ExecuteQuery(sql).Rows[0][0].ToString();;           
        }
        public string Open_Media_Fee(long Media)
        {
            var sql = "select * from his_fee_close_med('{0}|0|')";
            sql = string.Format(sql, Media);
            return ExecuteQuery(sql).Rows[0][0].ToString(); ;
        }
        
        #endregion       
    }
}
