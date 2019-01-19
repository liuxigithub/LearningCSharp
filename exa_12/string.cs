//string的使用,变量作用域
using System;

namespace string_ts {
	public class ts {
	 	static public void write() {    //静态方法只能访问静态成员
	 		string str1 = "string defined in str";
			Console.WriteLine("string={0}",str1);
		}
		static public void Main(string[] args) {
			string str1 = "string defined in Main";
			write(); 
			Console.WriteLine("string={0}",str1);
			Console.WriteLine("string length={0}",str1.Length);
			Console.ReadLine();
		}
	}
}