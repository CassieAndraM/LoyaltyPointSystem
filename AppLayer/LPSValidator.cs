using System;
using System.Collections.Generic;
using System.Text;

namespace AppLayer
{
    public class LPSValidator
    {
        public static bool ValidateLoginUser(string data)
        {
            return data.Length == 15 && data.StartsWith("20") && data.EndsWith("BN-0");
        }
    }
}
