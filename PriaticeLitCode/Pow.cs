using System;
namespace PriaticeLitCode
{
    public class Pow
    {
        public Pow()
        {
        }


        public static float PowNum(int num,int pow)
        {
            if (pow==0)
                return 1;
            if (pow < 0)
                return 1 / PowNum(num, -pow);//转成正数再参与计算
            if (pow%2==0)//2的倍数
               return   PowNum(num, pow /2)* PowNum(num,pow/2);
            return num* PowNum(num,pow-1); //pow-1 进行偶数求 然后多出一个num
        }


    }
}
