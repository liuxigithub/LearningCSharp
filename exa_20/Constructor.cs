/*用来说明构造函数和析构函数用法*/

//类的 构造函数 是类的一个特殊的成员函数，当创建类的新对象时执行。
//构造函数的名称与类的名称完全相同，它没有任何返回类型。

//类的 析构函数 是类的一个特殊的成员函数，当类的对象超出范围时执行。
//析构函数的名称是在类的名称前加上一个波浪形（~）作为前缀，它不返回值，也不带任何参数。
//析构函数用于在结束程序（比如关闭文件、释放内存等）之前释放资源。析构函数不能继承或重载。

using System;

namespace consturctor_ts {
    class GetArea {
        private double length, width, area;
        public GetArea(double x, double y)  { //构造函数，可以带参数
            length = x;
            width = y;
            Console.WriteLine("已收到长和宽的值");
        }  

        public double CalArea() {
            area = length*width;
            return area;
        }  
        ~GetArea() {   //析构函数，不能有访问修饰符
            Console.WriteLine("销毁对象");
        } 
        
    }

    class main {
        static void Main(string[] args) {
            double x=2.0, y=3.0,area;
            GetArea ts1 = new GetArea(x,y); //实例化，事实上就是调用构造函数
            area = ts1.CalArea();
            Console.WriteLine("length={0},width={1},the area is :{2}",x,y,area);
            Console.ReadLine();
        }
    }
}