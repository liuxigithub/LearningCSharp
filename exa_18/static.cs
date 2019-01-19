//说明静态成员与静态方法
/*静态成员与静态方法都属于类，而不属于实例，实例化时不实例化静态变量
  静态变量与静态方法都通过类名来访问，而不是实例名

  静态方法只能访问类(而不是实例)的静态成员，不能访问类(而不是实例)的非静态成员。
  非静态方法可以访问类的静态成员，也可以访问类的非静态成员；
  静态方法不能使用实例来调用，只能使用类名来调用。
  ref: http://zhidao.baidu.com/link?url=VTAocbfy3m8vB9xA5dQeaFDr1hXLHxq7EvRN91EGOWoKF0XT_O_W9rwclG2i9IjfAOO9bo3mbG1u0yv5Xs_T-q 

  访问级别修包饰符只是用来修饰类的成员变量和成员函数的，不能描述局域变量
  static 只是用来修饰类的成员变量和成员函数的，不能修饰局域变量
  操作性的语句只能在方法里面，不能在类里面或者命名空间里面

  class，enum和struct有一个共同特点，就是它们都是创建新类型的关键词。
  命名空间中只能出现创建新类型的语句，所以class,enum和struct可以出现在命名空间中，其它的比如局域变量就不能。
  当然作为值类，编译器可能会允许enum和struct声明在方法里面，但最好不那样做*/

using System; 

namespace TestStatic {
	int xxx=3;
	class StaticTest {
 		int x;
        static int y;
 		public StaticTest(int a,int b) {
        	x = a;
    		y = b;
 		}
 		public void SimplePrint() {
    		Console.WriteLine("x="+x+",y="+y);
 		}
 		public static void StaticPrint() {
      		Console.WriteLine("y={0}",y);
     		//  Console.WriteLine("x={0}",x);   //静态方法中不能使用非静态成员
    	}
	}

    class Test {

        static void Main(string[] args) {
			// int x22;
        	StaticTest st = new StaticTest(10,23);
            st.SimplePrint();
            //st.StaticPrint();        //静态方法不能使用实例来调用
            StaticTest.StaticPrint();
            Console.ReadLine();
    	}
 	} 
}