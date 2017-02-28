using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Rextester
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Solution solu=new Solution();
            int result=solu.ClimbStairs(5);
            Console.WriteLine(result);
        }
    }
    
    public class Solution {
        public int ClimbStairs(int n) {
            if(n==0)
            {
                return 0;
            }else if(n==1)
            {
                return 1;
            }else if(n==2)
            {
                return 2;
            }else
            {
                int allWays=0;
                int twoStairs=1;
                int oneStair=2;
                for(var i=2;i<n;i++)
                {
                  //Fobonacci, the ways to reach stair n = (the ways to reach n-1) + (the ways to reach n-2)
                  allWays=twoStairs+oneStair;
                  //for next around
                  twoStairs=oneStair;
                  oneStair=allWays;
                }
                
                return allWays;
            }
            
        }
    }
}
