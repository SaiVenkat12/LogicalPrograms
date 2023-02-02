using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    public class CouponNumber
    {
        public static void CouponGenerator()
        {
            int n;
            int count = 0;
            int k = 0;
            Random random= new Random();

            Console.WriteLine("Enter how many Coupons Needed :");
            n=Convert.ToInt32(Console.ReadLine());
            int [] Coupon=new int[n];
            while(k<n)
            {
                int rand=random.Next(1,1000);
                count++;
                int check=Array.IndexOf(Coupon, rand);
                if(check==-1)
                {
                    Coupon[k] = rand;
                    k++;
                }                
            }
            Console.WriteLine("Unique Coupon Numbers are ");
            foreach (int i in Coupon)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Count of Random Numbers needed is " + count);
        }
    }
}
