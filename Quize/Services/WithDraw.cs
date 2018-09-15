// A Hello World! program in C#.
using System;
namespace Services
{
    public class WithDraw 
    {
        public static void Main() 
        {            
        }
        
        public int WithdrawCalculate(int total,int payment)
        {
            var sum = payment - total;
            return sum;
            
        }
        
         public int[] WithdrawCalculateback(int total,int payment)
        {
            var sum = payment - total;
            int amount = 0;
            int[] result = new int[9];
            
            if (sum / 1000 != 0)
            {
                amount = sum / 1000;
                sum = sum % 1000;
                result[0] = amount;
            }

            if (sum / 500 != 0)
            {
                amount = sum / 500;
                sum = sum % 500;
                result[1] = amount;

            }

            if (sum / 100 != 0)
            {
                amount = sum / 100;
                sum = sum % 100;
                result[2] = amount;

            }

            if (sum / 50 != 0)
            {
                amount = sum / 50;
                sum = sum % 50;
                result[3] = amount;

            }

            if (sum / 20 != 0)
            {
                amount = sum / 20;
                sum = sum % 20;
                result[4] = amount;

            }

            if (sum / 10 != 0)
            {
                amount = sum / 10;
                sum = sum % 10;
                result[5] = amount;

            }

            if (sum / 5 != 0)
            {
                amount = sum / 5;
                sum = sum % 5;
                result[6] = amount;

            }

            if (sum / 2 != 0)
            {
                amount = sum / 2;
                sum = sum % 2;
                result[7] = amount;

            }

            if (sum / 1 != 0)
            {
                amount = sum / 1;
                sum = sum % 1;
                result[8] = amount;
                
            }

//            if (payment==total)
//            {
//                return 0;
//
//            }
            
            return result;

           
            
            
        }
        
    }
}