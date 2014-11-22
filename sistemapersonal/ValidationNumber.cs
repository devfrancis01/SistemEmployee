using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace sistemapersonal
{
   public class ValidationNumber
    {
        public static bool Numbers(char e)
        {
            string ValadationCaracter = "0123456789-\b";
            bool Exist;
            Exist = ValadationCaracter.Contains(e);
            if (Exist == true)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
