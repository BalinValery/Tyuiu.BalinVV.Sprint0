using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tyuiu.BalinVV.Sprint0.Task7.V0.Lib
{
    public class DataService
    {
        public static int[] AdditionArrays(int[] numOne, int[] numTwo)
        {
            int[] resualtArray = new int[5];
            for (var i = 0; i < numOne.Length; i++)
            {
                resualtArray[i] = numOne[i] + numTwo[i];
            }
            return resualtArray;
        }
    }
}
