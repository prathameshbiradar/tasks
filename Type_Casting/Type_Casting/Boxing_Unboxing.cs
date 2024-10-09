using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Type_Casting
{
     class Boxing_Unboxing
    {
        public static void Main(String[] args) {

            int i = 10;
            object a = i; //Boxing Conversion, In this value type is converted into reference type 
             i = (int)a;// Unboxing conversion , In this reference type is converted into value type.
        
        }
    }
}
