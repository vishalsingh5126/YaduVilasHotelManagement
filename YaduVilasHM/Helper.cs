using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YaduVilasHM.Models;

namespace YaduVilasHM
{
    public class Helper
    {
        public static bool ValidateTextFields(List<string> lstInput)
        {
            foreach (var item in lstInput)
            {
                if (item == "" || item == null)
                    return false;
            }
            return true;
        }
        public static bool ValidateDateRange(DateTime fromDate, DateTime toDate, string stringInput)
        {
            if(toDate.Subtract(fromDate).Days>0 && stringInput!=null && stringInput != "")
                return true;
            return false;
        }
    }
}
