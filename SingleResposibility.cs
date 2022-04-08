using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SOLIDPrinciples
{   //More simply, each class should solve only one problem
    //Utilizing this principle makes code easier to test and maintain, it makes software easier to implement,
    //and it helps to avoid unanticipated side-effects of future changes.
    public class SingleResposibility
    {
        public SingleResposibility()
        {
           // bool rtn = validateEmail(email);
            
        }

        public bool validateEmail(string email)
        {
            bool rtn = false;

            // string patternStrict = ConfigurationManager.AppSettings["regexmail"];

            MatchCollection mc = Regex.Matches(email, "\\w+([-+.]\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*");
            string mail = "";
            for (int i = 0; i < mc.Count; i++)
            {
                mail = mc[0].ToString();
            }

            if (mail != "")
            {
                rtn = true;
            }


            return rtn;
        }
    }
}
