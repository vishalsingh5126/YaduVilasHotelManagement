using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
