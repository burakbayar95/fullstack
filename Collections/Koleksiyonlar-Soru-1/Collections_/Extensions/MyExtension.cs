using System;
using System.Collections.Generic;
using System.Text;

namespace Collections_.Extensions
{
    
        public static class MyExtension
        {
            public static bool NumberCheck(this string text)
            {
                foreach (char chr in text)
                {
                    if (!Char.IsNumber(chr)) return false;
                }
                return true;
            }
        }
    }

