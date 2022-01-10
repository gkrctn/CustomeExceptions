using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomeExceptions
{
    public class MyCustomExpection : Exception
    {
        string isim;

        public override string Message
        {
            get
            {
                return "Girdiğiniz isim : " + isim + "....A ile başlayan isim girmeyiniz";
            }
        }
        public override string HelpLink
        {
            get
            {
                return "www.google.com";
            }
            set
            {
                base.HelpLink = value;
            }
        }
        public MyCustomExpection(string isim)
        {
            this.isim = isim;
        }
            



    }
}
