using System;
using Xunit;
using System.Collections.Generic;
using Services;

namespace Tests
{
    public class ConsecutiveTest
    {
        private Consecutive svc;
        
        [Theory]
        [InlineData(3,new double[]{1,2})]
        [InlineData(63,new double[]{31,32})]
        [InlineData(99,new double[]{49,50})]
        public void TestByOddNumber(double sum,double[] actrual)
        {
            svc = new Consecutive();
            var result = svc.ConsecutiveFromSum(sum);
            Assert.Equal(actrual,result);
        }

        [Theory]
        [InlineData(10,new double[]{1,2,3,4})]
        [InlineData(20,new double[]{2,3,4,5,6})]
        [InlineData(46,new double[]{10,11,12,13})]
        [InlineData(50,new double[]{11,12,13,14})]
        [InlineData(100000000000,new double[]{19999999998,19999999999,20000000000,20000000001,20000000002})]
        public void TestByAddNumber(double sum,double[] actrual)
        {
            svc = new Consecutive();
            var result = svc.ConsecutiveFromSum(sum);
            Assert.Equal(actrual,result);
        }
        
        [Theory]
        [InlineData(-1,null)]
        [InlineData(0,null)]
        [InlineData(1,null)]
        [InlineData(2,null)]
        [InlineData(4,null)]
        public void TestByImposibleNumber(double sum,double[] actrual)
        {
            svc = new Consecutive();
            var result = svc.ConsecutiveFromSum(sum);
            Assert.Equal(actrual,result);
        }
        
    }
}
