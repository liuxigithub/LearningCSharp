/*异常处理*/
/*异常处理是在程序执行期间出现的问题。异常处理供了一种把程序控制权从某个部分转移到另一个部分的方式*/
/*异常处理建立在四个关键词上：try, catch, finally,throw*/
/*
   try: 一个 try 块标识了一个将被激活的特定的监控异常的代码块，后跟一个或多个catch(try和catch必须连用)。
        如果出现异常，则抛出异常，如果没有，则直接执行catch块后面的语句
   catch: 捕获并处理异常
   throw: 当问题出现时，程序抛出一个异常 
   finally 块用于执行给定的语句，不管异常是否被抛出都会执行. finally块必须紧接在try-catch块之后。
*/
/*异常处理的最大优点之一是，它允许程序对错误做出响应并继续执行*/
/*一个try块能够嵌套在另一个try块中。内层try块中产生的异常如果未被相关联的catch子句捕获，就会传递到外层try块中*/

using System;

namespace exception_ts {
    class exp_ts {
        public static void Main(string[] args) {
            int[] x = {1,2,3}, y = {0,1,2,3};
            int z;
            for(int i = 0;i<4;i++) {
                try {   //监控代码块
                    z = x[i]/y[i];
                    Console.WriteLine("{0}/{1}={2}",x[i],y[i],z);                
                }
                catch(DivideByZeroException) {
                    Console.WriteLine("divide zero err: {0}/{1}",x[i],y[i]);
                }
                catch(IndexOutOfRangeException Exp) { //类型后面可以带参数
                    Console.WriteLine(Exp);
                }
                finally {
                    Console.WriteLine("Test finally");
                }
            }
            Console.WriteLine();
            //测试throw
            try {
                throw new OutOfMemoryException(); //抛出一个异常对象
            }
            catch(OutOfMemoryException A) { 
                Console.WriteLine(A);
                Console.WriteLine("Test throw");
                
            }
            Console.ReadLine();
       } 
    }
}
