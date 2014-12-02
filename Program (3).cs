using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 后方交会
{
    class Program
    {
        static void Main3(string[] args)
        {
            #region 获取原始数据
            //输入比例尺分母
            Console.WriteLine("输入比例尺分母");
            double m = Convert.ToDouble(Console.ReadLine());
            //输入摄影机主距
            Console.WriteLine("输入摄影机主距");
            double f = Convert.ToDouble(Console.ReadLine());
            //计算航高H
            double H=m*f;

            //输入已知点个数
            Console.WriteLine("输入已知点个数");
            int n = Convert.ToInt32(Console.ReadLine());

            //输入像点坐标
           double [] x=new double [n] ;
           double [] y = new double[n];
           double [] X = new double[n];
           double [] Y = new double[n];
           double [] Z = new double[n];

            for (int i = 1; i <=n;i++ )
            {
                Console.WriteLine("输入x{0}的坐标",i);
                string a=Console.ReadLine();
                x[i] = Convert.ToDouble(a);

                Console.WriteLine("输入y{0}的坐标", i);
                string b = Console.ReadLine();
                x[i] = Convert.ToDouble(b);

                Console.WriteLine("输入X{0}的坐标", i);
                string c = Console.ReadLine();
                x[i] = Convert.ToDouble(c);

                Console.WriteLine("输入Y{0}的坐标", i);
                string d = Console.ReadLine();
                x[i] = Convert.ToDouble(d);

                Console.WriteLine("输入Z{0}的坐标", i);
                string e = Console.ReadLine();
                x[i] = Convert.ToDouble(e);

            }
            # endregion

            # region 确定未知数的初始值
            double φ = w = κ = 0;

            # endregion
        }
    }
}
