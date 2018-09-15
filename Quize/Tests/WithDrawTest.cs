using System;
using Xunit;
using Services;
namespace Tests
{
    public class WithDrawTest
    {
        WithDraw svc;

        [Fact]
        public void Testwithdraw()
        {
            var cal = 1000-250;
            

            Assert.Equal(750, cal);
        }
       
        [Theory]
        [InlineData (650, 1000,350)]
        [InlineData (200, 1000,800)]
        [InlineData (450, 500,50)]
       public void TestWithDraw(int total,int payment ,int resual)
       {
           svc = new WithDraw();
           var sum = svc.WithdrawCalculate(total,payment);
           Assert.Equal(resual, sum);
        }
        
        [Theory]
        [InlineData (1500, 2000,500,new int[]{1,2,0,0,0,0,0,0,0})]
       public void TestWithDrawbank(int total,int payment ,int resual,int[] bank)
       {
           svc = new WithDraw();
           var sum = svc.WithdrawCalculateback(total,payment);
           Assert.Equal(resual, sum);
        }
        
        
    }
}
