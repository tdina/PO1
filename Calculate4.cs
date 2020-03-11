using System;

namespace PO_LAB1
{
    public class Calculate4
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="n1"></param>
        /// <param name="n2"></param>
        /// <returns></returns>
        public static double Add(double n1, double n2)
        {
            return n1 + n2;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="n1"></param>
        /// <param name="n2"></param>
        /// <returns></returns>
public static double Subtract(double n1, double n2)
        {
            return n1 - n2;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="n1"></param>
        /// <param name="n2"></param>
        /// <returns></returns>
        public static double Multiply(double n1, double n2)
        {
            return n1 * n2;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="n1"></param>
        /// <param name="n2"></param>
        /// <returns></returns>
        public static double Divide(double n1, double n2)
        {
            return n1 / n2;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="n1"></param>
        /// <param name="n2"></param>
        /// <returns></returns>
        public static double SqrtX(double n1, double n2)
        {
            return Math.Pow(n1, (1 / n2));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="n1"></param>
        /// <param name="n2"></param>
        /// <returns></returns>
        public static double DegreeN(double n1, double n2)
        {
            return Math.Pow(n1, n2);
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="n1"></param>
        /// <returns></returns>
        public static double Sqrt(double n1)
        {
            return Math.Sqrt(n1);
        }
/// <summary>
/// 
/// </summary>
/// <param name="n1"></param>
/// <returns></returns>
        public static double Square(double n1)
        {
            return Math.Pow(n1, 2.0);
        }
/// <summary>
/// 
/// </summary>
/// <param name="n1"></param>
/// <returns></returns>
        public static double Factorial(double n1)
        {
            double f = 1;
            for (int i = 1; i <= n1; i++)
                f *=(double)i;
            return f;
        }

        public static double GetSin(double n1)
        {
            return Math.Sin(n1);
        }

        public static double getcos(double n1)
        {
            return Math.Cos(n1);
        }

        public static double GetTan(double n1)
        {
            return Math.Tan(n1);
        }

        public static double GetExp(double n1)
        {
            return Math.Exp(n1);
        }

        //public static double GetRound(double n1)
        //{
        //    return math.round(n1);
        //}

    }
}