/*类的继承*/
/*简单地讲，继承就是继承类中继承了基类中的类成员（成员函数和成员变量）*/

using System;

namespace inheritance_ts {
    class base_me { //基类
        public double length, width;
        public base_me (double x, double y){
            length = x;
            width = y;
        }
        public double area() {
            return length*width;
        }
    }

    class cf: base_me { //继承类
        public cf(double x, double y): base(x,y) { //继承类中基类的初始化
            
        }
        public double cf_2() {
            return 2*(length+width);
        }
    }

    class main {
        static void Main(string[] args) {
            double length=2.0, width=3.0;
            double myarea, mycf;
            cf mycal = new cf(length,width);
            mycf = mycal.cf_2();
            myarea = mycal.area();
            Console.WriteLine("测试类的继承");
            Console.WriteLine("mycf = {0}",mycf);
            Console.WriteLine("myarea = {0}",myarea);
            Console.ReadLine();
                
        }
    }
    
}