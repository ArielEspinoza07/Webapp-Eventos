using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;

namespace Test.Models
{
    public class Crypto
    {
        public static string encrypt(string passwd){
            byte[] data = System.Text.Encoding.ASCII.GetBytes(passwd);
            data = new System.Security.Cryptography.SHA256Managed().ComputeHash(data);
            String hash = System.Text.Encoding.ASCII.GetString(data);
            return hash;
        }
    }
}