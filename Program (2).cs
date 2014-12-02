using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 练习
{
    class Program
    {
        
        static void Main2(string[] args)
        {
            
            string s="";
            
            while (true)
            {
                Console.WriteLine("请输入一个数（输入q结束）");
                s = Console.ReadLine();
                if (s == "q")
                {
                    Console.WriteLine("结束");
                   
                    break;
                }
                else
                {
                    try
                    {
                        int a = int.Parse(s);
                        bool b=zhishu(a);
                        if (b)
                        {
                            Console.WriteLine("{0}不是质数",a);
                        }
                        else
                        {
                            Console.WriteLine("{0}是质数",a);
                        }
                        Console.ReadKey();
                    }
                    catch
                    {
                        Console.WriteLine("输入错误，请重新输入");
                    }
                }
            }
            Console.ReadKey();
            
        }

        static bool zhishu(int a)
        {
            bool flag1 = false;
            for (int i = 2; i < a;i++ )
            {
                if (a % i == 0)
                {
                    flag1 = true;
                    break;
                }
            }
            return flag1;
        }
    }
}
