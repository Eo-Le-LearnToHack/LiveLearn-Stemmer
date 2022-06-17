using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiveLearn20220615
{
    internal class MethodValidation
    {
        public int IsANumber(string numInput)
        {
            int numOutput;
            bool isANumber;
            isANumber = Int32.TryParse(numInput, out numOutput);

            if (isANumber == true)
            {
                return Convert.ToInt32(numOutput);
            }
            else
            {
                Console.WriteLine("This is not a number. Please enter a number.");
                string newInput;
                newInput = Console.ReadLine();
                IsANumber(newInput);
                return Convert.ToInt32(numOutput);
            }
        }


    }
}
