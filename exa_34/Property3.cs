/*自动实现属性*/
/*自动实现属性是一种非常简单的属性，它并不需要显示地定义由set和get访问器的实现方式，
  而是让编译器自动提供底层字段去实现set和get访问器（对get就是返回，对set就是赋值）*/
/*特别注意的是：自动实现属性仍然是通过set和get访问器来实现的（只要是属性就不能绕过访问器），
               只是系统会自动提供字段，比如属性 ：
               public int Num{get;set;},
               系统会完善为：
               public int Num {
                   get {
                       return num ;}
                   set {
                       num = value }
                }
               其中num是隐藏的。 从这个角度来看，自动实现属性相当于字段  */
/*与普通属性不同，自动实现属性不能是只读或只写属性，在任何情况下，都必须同时指定set和get访问器 */

/*属性(常规或者自动)可以用对象初始化器初始化，这各字段是一样的。*/

using System;

namespace property3 {
    class PropertyTest {
        public string Name {get;set;} //自动实现属性的声明
        public void @Test() {
            Name = "Liu xi";
        }
    }
    class PropertyTest2 {   //自动实现属性
        public string Str {get;set;}
        public int Num {get;set;}
    }
    class PropertyTest3 {   //常规属性
        double x;
        public double X {
            get {
                return x;
            }
            set {
                x = value;
            }
        }
    }
    class main {
        static void Main(string[] args) {
            PropertyTest ts1 = new PropertyTest();
            ts1.@Test(); //写入自动实现属性
            Console.WriteLine("Name:{0}",ts1.Name);//引用自动实现属性
            PropertyTest2 ts2 = new PropertyTest2{Str = "Test",Num = 0}; //对象初始化器对自动属性的初始化，注意，这里是大括号
            Console.WriteLine("Str:{0},Num:{1}",ts2.Str,ts2.Num);
            PropertyTest3 ts3 = new PropertyTest3{X = 3.14}; //对象初始化器对常规属性的初始化，注意，这里是大括号
            Console.WriteLine(ts3.X);
            Console.ReadLine();
        }
    }
}