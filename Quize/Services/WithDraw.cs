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
        
         public int WithdrawCalculateback(int total,int payment)
        {
            var sum = payment - total;
            int amount = 0;
            int[] result = new int[8];
            
            if (payment / 1000 != 0)
            {
                amount = payment / 1000;
                payment = payment % 1000;
                result[0] = amount;
            }

            if (payment / 500 != 0)
            {
                amount = payment / 500;
                payment = payment % 500;
                result[1] = amount;

            }

            if (payment / 100 != 0)
            {
                amount = payment / 100;
                payment = payment % 100;
                result[2] = amount;

            }

            if (payment / 50 != 0)
            {
                amount = payment / 50;
                payment = payment % 50;
                result[3] = amount;

            }

            if (payment / 20 != 0)
            {
                amount = payment / 20;
                payment = payment % 20;
                result[4] = amount;

            }

            if (payment / 10 != 0)
            {
                amount = payment / 10;
                payment = payment % 10;
                result[5] = amount;

            }

            if (payment / 5 != 0)
            {
                amount = payment / 5;
                payment = payment % 5;
                result[6] = amount;

            }

            if (payment / 2 != 0)
            {
                amount = payment / 2;
                payment = payment % 2;
                result[7] = amount;

            }

            if (payment / 1 != 0)
            {
                amount = payment / 1;
                payment = payment % 1;
                result[8] = amount;
                
            }

            if (payment==total)
            {
                return 0;

            }

            foreach (int data in result)
            {
                return(data);
            }
            
            return sum;
            
        }
        
    }
}