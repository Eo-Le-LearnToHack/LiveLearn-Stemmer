using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiveLearn20220615
{
    internal class MethodValidation
    {
        public int IsAnInt(string numInput)
        {
            int numOutput;
            string newInput;
            bool isANumber;
            isANumber = Int32.TryParse(numInput, out numOutput);

            if (isANumber == true)
            {
                return Convert.ToInt32(numOutput);
            }

            else
            {
                do
                {
                    Console.Write("This is not an integer. Please enter an integer:\t");
                    newInput = Console.ReadLine();
                    isANumber = Int32.TryParse(newInput, out numOutput);
                    
                } while (!isANumber);
                return Convert.ToInt32(numOutput);
            }
        }

    }
}
