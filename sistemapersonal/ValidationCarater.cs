using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace sistemapersonal
{
   public class ValidationCarater
    {
       public static bool Caracter(char e)
       {
           string allowedCaracter = "abcdefghijklmnopqrstuvwxyz@.0123456789_~+()#-";
           bool Exists;
           Exists = allowedCaracter.Contains(e);
           if (Exists == true)
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
