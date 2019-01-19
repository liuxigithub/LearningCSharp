/*接口的使用*/
/*接口定义了所有类继承接口时应遵遁的语法合同，接口定义了语法合同“是什么”的部分，派生类定义了语法合同"怎么办"部分。*/
/*接口定义了属性，方法，事件和索引器，这些都是接口的成员*/
/*成员只包含接口的声明，成员的定义是派生类的责任，接口是接供了派生类应遵循的语法结构*/

/*接口中所有的方法均默认为public,但并不允许使用访问说明符进行显式的声明*/
/*实现接口的方法必须声明为public*/

using System;
namespace Cal {
    public interface CalArea {
        void GetArea(); //接口中声明子类中的方法，接口中所有的方法均默认为public,但并不允许使用访问说明符进行显式的声明
    }
    public class  MyCal : CalArea {
        double length;
        double width;
        public double area;
        public MyCal(double x, double y) {
            length = x;
            width = y;
        }
        public void GetArea() {  //在子类中实现方法
            area = length*width;  
        }
    }

    public class main {
        public static void Main(string[] args) {
            double x = 2.0, y = 3.0;
            MyCal my = new MyCal(x,y);
            my.GetArea();
            Console.WriteLine("length={0},width={1}",x,y);
            Console.WriteLine("area = {0}",my.area);
            Console.ReadLine();
        
        }
    }
}
