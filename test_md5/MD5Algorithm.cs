//using UnityEngine;
using System;
//using UnityEditor;
using System.Text;
using System.Collections;
using System.Security.Cryptography;
//namespace test_md5
//{


    public class MD5Algorithm
    {

        static string password = "12345678";

        /// <summary>
        /// 16位MD5加密
        /// </summary>
        /// <param name="password"></param>
        /// <returns></returns>
        public static string MD5Encrypt16(string password)
        {
            var md5 = new MD5CryptoServiceProvider();
            byte[] aa = new byte[512];
            byte[] bb = new byte[512];
            aa = Encoding.Default.GetBytes(password);
            bb = md5.ComputeHash(aa);
             
            string t2 = BitConverter.ToString(md5.ComputeHash(Encoding.Default.GetBytes(password)));
            t2 = t2.Replace("-", "");
            return t2;
        }

        /// <summary>
        /// 32位MD5加密
        /// </summary>
        /// <param name="password"></param>
        /// <returns></returns>
        public static string MD5Encrypt32(string password)
        {
            string cl = password;
            string pwd = "";
            MD5 md5 = MD5.Create(); //实例化一个md5对像
            // 加密后是一个字节类型的数组，这里要注意编码UTF8/Unicode等的选择　
            byte[] s = md5.ComputeHash(Encoding.UTF8.GetBytes(cl));
            // 通过使用循环，将字节类型的数组转换为字符串，此字符串是常规字符格式化所得
            for (int i = 0; i < s.Length; i++)
            {
                // 将得到的字符串使用十六进制类型格式。格式后的字符是小写的字母，如果使用大写（X）则格式后的字符是大写字符 
                pwd = pwd + s[i].ToString("X");
            }
            return pwd;
        }


        //64位的MD5加密
        public static string MD5Encrypt64(string password)
        {
            string cl = password;
            //string pwd = "";
            MD5 md5 = MD5.Create(); //实例化一个md5对像
            // 加密后是一个字节类型的数组，这里要注意编码UTF8/Unicode等的选择　
            byte[] s = md5.ComputeHash(Encoding.UTF8.GetBytes(cl));
            return Convert.ToBase64String(s);
        }


       // [MenuItem("MD5/16位MD5加密")]
        static void MD5of16Bytes()
        {
            string pw = MD5Encrypt16(password);
         //   Debug.Log("MD5-16Bytes : " + pw);
        }

      //  [MenuItem("MD5/32位MD5加密")]
        static void MD5of32Bytes()
        {
            string pw = MD5Encrypt32(password);
          //  Debug.Log("MD5-32Bytes : " + pw);
        }

       // [MenuItem("MD5/64位MD5加密")]
        static void MD5of64Bytes()
        {
            string pw = MD5Encrypt64(password);
         //   Debug.Log("MD5-64Bytes : " + pw);
        }

    }



