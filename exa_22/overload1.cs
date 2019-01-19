//函数的重载(overload)
/*可以在同一个范围内对相同的函数名有多个定义。
  函数的定义必须彼此不同，可以是参数列表中的参数类型不同，也可以是参数个数不同。
  注意：用来区分同一个函数的不同类型（可用来重载）的只能是输入函数的类型或者个数，不能是返回类型，
  所以，不能重载只有返回类型不同的函数声明。
  但是，对于同一个函数的不同类型，返回类型和修饰符可以不同。*/
using System;
namespace overload1_td {
	class ov {
		public void print(int i) {
			Console.WriteLine("i:{0}",i);
		}
		public void print(double l) {
			Console.WriteLine("l:{0}",l);
		}
		public void print(string s) {
			Console.WriteLine("string:{0}",s);
		}
		public int print() {
			Console.WriteLine("Hello,world");
    		return 0;
		}
		static void Main(string[] args) {
			ov OV1 = new ov();
			OV1.print(5);
			OV1.print(2.0);
			OV1.print("hw");
			OV1.print();
			Console.ReadLine();
		}
	}
}



