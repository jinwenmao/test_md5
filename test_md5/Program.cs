using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//using MD5Algorithm;

namespace test_md5
{
    class Program
    {
        static void Main(string[] args)
        {
            //MD5Algorithm a;
            string str = "金文茂";
            string str16;
            string str32;
            string str64;
            str16= MD5Algorithm.MD5Encrypt16(str);
            str32 = MD5Algorithm.MD5Encrypt32(str);
            str64 = MD5Algorithm.MD5Encrypt64(str);
           //MD5Algorithm.ReferenceEquals()
        }

    }
}


