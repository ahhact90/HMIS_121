using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Security.Cryptography;

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
        public string tonghop_chiphi_bhyt(long Media)
        {
            var sql = "select his_tonghop_chiphi_bhyt({0})";
            sql = string.Format(sql, Media);
            return ExecuteQuery(sql).Rows[0][0].ToString(); ;
        }

        ///// <summary>
        ///// Ham giai ma
        ///// </summary>
        ///// <param name="toDecrypt"></param>
        ///// <param name="key"></param>
        ///// <param name="useHashing"></param>
        ///// <returns></returns>
        //public string Decrypt(string toDecrypt, string key, bool useHashing)
        //{
        //    byte[] buffer;
        //    byte[] buffer2;
        //    string str;
        //Label_002B:
        //    buffer2 = Convert.FromBase64String(toDecrypt);
        //    bool flag = !useHashing;
        //    int expressionStack_3F_0 = 1;
        //    if (expressionStack_3F_0 == 0)
        //    {
        //    }
        //    int num = 3;
        //Label_0010:
        //    switch (num)
        //    {
        //        case 0:
        //        case 1:
        //            {
        //                TripleDESCryptoServiceProvider provider2 = new TripleDESCryptoServiceProvider
        //                {
        //                   Key = buffer,
        //                   Mode = CipherMode.ECB,
        //                   Padding = PaddingMode.PKCS7
        //                };
        //                byte[] bytes = provider2.CreateDecryptor().TransformFinalBlock(buffer2, 0, buffer2.Length);
        //                str = Encoding.UTF8.GetString(bytes);
        //                num = 4;
        //                goto Label_0010;
        //            }
        //        case 2:
        //            buffer = new MD5CryptoServiceProvider().ComputeHash(Encoding.UTF8.GetBytes(key));
        //            num = 0;
        //            goto Label_0010;

        //        case 3:
        //            if (flag)
        //            {
        //                buffer = Encoding.UTF8.GetBytes(key);
        //                num = 1;
        //            }
        //            else
        //            {
        //                num = 2;
        //            }
        //            goto Label_0010;

        //        case 4:
        //            return str;
        //    }
        //    goto Label_002B;
        //}
        /// <summary>
        /// Ham ma hoa du lieu
        /// </summary>
        /// <param name="toEncrypt"></param>
        /// <param name="key"></param>
        /// <param name="useHashing"></param>
        /// <returns></returns>
        public string Encrypt(string toEncrypt, string key, bool useHashing)
        {
            byte[] bytes;
            byte[] buffer2;
            string str;
        Label_002B:
            buffer2 = Encoding.UTF8.GetBytes(toEncrypt);
            bool flag = !useHashing;
            int num = 4;
            var hashmd5 = new MD5CryptoServiceProvider();
            var keyArray = hashmd5.ComputeHash(Encoding.UTF8.GetBytes(key));
        Label_0010:
            switch (num)
            {
                case 0:
                    bytes = new MD5CryptoServiceProvider().ComputeHash(Encoding.UTF8.GetBytes(key));
                    num = 1;
                    goto Label_0010;

                case 1:
                case 4:
                    {
                        TripleDESCryptoServiceProvider provider2 = new TripleDESCryptoServiceProvider
                        //{
                        //    Key = bytes,
                        //    Mode = CipherMode.ECB,
                        //    Padding = PaddingMode.PKCS7
                        //};
                        { Key = keyArray, Mode = CipherMode.ECB, Padding = PaddingMode.PKCS7 };

                        byte[] inArray = provider2.CreateEncryptor().TransformFinalBlock(buffer2, 0, buffer2.Length);
                        str = Convert.ToBase64String(inArray, 0, inArray.Length);
                        num = 2;
                        goto Label_0010;
                    }
                case 2:
                    return str;
                    //goto Label_0010;
                   // return null;

                case 3:
                    {
                        int expressionStack_4D_0 = 1;
                        if (expressionStack_4D_0 == 0)
                        {
                        }
                        if (!flag)
                        {
                            num = 0;
                        }
                        else
                        {
                            bytes = Encoding.UTF8.GetBytes(key);
                            num = 4;
                        }
                        goto Label_0010;
                    }
            }
            goto Label_002B;
        }


        public static string Encrypt1(string key, string content)
        {
            var toEncryptArray = Encoding.UTF8.GetBytes(content);
            var hashmd5 = new MD5CryptoServiceProvider();
            var keyArray = hashmd5.ComputeHash(Encoding.UTF8.GetBytes(key));
            var tdes = new TripleDESCryptoServiceProvider { Key = keyArray, Mode = CipherMode.ECB, Padding = PaddingMode.PKCS7 };
            var cTransform = tdes.CreateEncryptor();
            var resultArray = cTransform.TransformFinalBlock(toEncryptArray, 0, toEncryptArray.Length);
            return Convert.ToBase64String(resultArray, 0, resultArray.Length);
        }
        #endregion       
    }
}
