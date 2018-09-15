using System;
using System.Collections.Generic;

namespace Services
{
    public class Consecutive
    {
        public double[] ConsecutiveFromSum(double numbersum)
        {
            int totalNum = 2;
            double middle = 0;
            double[] resultlist;
            if(numbersum == 4 || numbersum == 1 || numbersum <= 0 || numbersum == 2)
            {
                return null;                
            }
            if (numbersum % 2 != 0)
            {
                resultlist = new double[2];
                var start = Math.Floor(numbersum / 2);
                resultlist[0] = start;
                resultlist[1] = start+1;
            }
            else
            {
                while (true)
                {
                    double result = 0;
                    middle = numbersum / totalNum;
                    resultlist = new double[totalNum];
                    if (middle % 1 == 0.5)
                    {
                        var a = new int[] { 2, 3 };
                        double startnum = (middle + 0.5) - (totalNum / 2);
                        var count = 0;
                        for (double i = startnum; i < startnum + totalNum; i++)
                        {
                            result += i;
                            resultlist[count] = i;
                            count++;
                        }
                    }
                    else if (middle % 1 == 0)
                    {
                        double startnum = middle - (totalNum / 2);
                        var count = 0;
                        for (double i = startnum; i < startnum + totalNum; i++)
                        {
                            result += i;
                            resultlist[count] = i;
                            count++;
                        }
                    }
                    if (result == numbersum)
                    {
                        break;
                    }
                    totalNum++;
                }
            }
            return resultlist;
        }
    }
}
