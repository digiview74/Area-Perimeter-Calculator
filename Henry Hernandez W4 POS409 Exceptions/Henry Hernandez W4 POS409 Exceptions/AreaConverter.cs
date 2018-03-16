using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Henry_Hernandez_W4_POS409_Exceptions
{
    class AreaConverter
    {
        public int getPerimeter(int num1, int num2)
        {
            int answer; 
            answer = ((2 * num1) + (2 * num2)); // calculates perimeter
            return answer; 
        }
       public int getArea(int num1, int num2)
        {
            int answer;
            answer = ((num1 * num2)); // calculates area
            return answer;
        }
    }
}
