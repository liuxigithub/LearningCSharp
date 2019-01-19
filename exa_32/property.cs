/*属性（Property）*/
/*属性是类，结构的接口的命名成员，属性是域（Field）的扩展*/
/*声明属性后，一旦出现属性名，都将引发相应的访问器的调用*/
/*属性都有访问器，它本质上是一种方法：
1.get访问器本质上相当于必须返回属性类型的方法（接收为void),所以一定要return一个可隐式转换为属性类型的表达式.
2.set 访问器类似于返回类型为void的方法,但会接收一个属性类型的隐含参数value(这个值由属性传递的).*/
/*根据set和get访问器是否存在，属性可分为只读，只写和读/写属性，
  只读属性作为赋值目标时会导致编译错误
  只写属性只能作为赋值的目标，否则在表达式中引用只写属性也会导致编译错误*/
/*特别注意：
  属性和字段一样，可以在类中直接被访问，但是即使是在类中访问，它也是通过set和get访问器实现的，而不是直接赋值*/

using System;

    namespace PropertyDemo        { 
        public class ProperTest {
        public double sec;
        public double Hour {  //定义Hour属性
            get {             //get访问器
                return sec/3600.0;
            }
            set {            //set访问器
                sec = value*3600.0;
            }
        }
        public void ts() {
            Hour = 3.0; //属性和字段一样，可以在类内使用(虽然意大不大),但是即使在类中使用，也是通过set和get访问器实现的
        }
             
    }

        public class main {
            public static void Main(string[] args) {
                double hour;
                ProperTest MyClass = new ProperTest();
                MyClass.Hour = 12.0;
                hour = MyClass.Hour;
                Console.WriteLine("MyClass.sec: {0}",MyClass.sec);
                Console.WriteLine("MyClass.Hour: "+hour.ToString());
                
                MyClass.ts();
                Console.WriteLine("MyClass.Hour: {0}",MyClass.Hour);
                Console.WriteLine("MyClass.sec: {0}",MyClass.sec);
                Console.ReadLine();
          }
      }
  }
