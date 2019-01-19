/* 
 * 双个数求最大值,用来说明方法的使用
 * 成员函数和成员方法的作用域都是块作用域（也就是在类内部起作用）,访问修饰符是用来说明它的实例能否访问它的。
 * 下面的ts方法就是用来说明类中的方法是可以相互访问的，ts方法中能访问FindMax方法。
 */
 
using System;

namespace CalculatorApplication
{
   class NumberManipulator
   {
      public int FindMax(int num1, int num2)
      {
         /* 局部变量声明 */
         int result;

         if (num1 > num2)
            result = num1;
         else
            result = num2;

         return result;
      }

      public int ts(int num1, int num2) {
          return FindMax(num1, num2); //FindMax方法能作用到此处
      }

   }

   class main {
     static void Main(string[] args)
      {
         /* 局部变量定义 */
         int a = 100;
         int b = 200;
         int ret;
         NumberManipulator n = new NumberManipulator();
         
         //调用 ts 方法
         ret = n.ts(a, b);
         Console.WriteLine("最大值是： {0}", ret );
         Console.ReadLine();
      }
   }
}