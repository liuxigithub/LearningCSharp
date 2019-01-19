/*旨在说明值类型与引用类型的具体化方式，因为在C#中一切皆对象，所以值类型(如int,double,结构等)和引用类型(如自定义类，字符串，数组等)都是类的实例，都是可以被引用的方式实例化的。
但是对于值类型来说，因为其用得比较多，而且不用建立引用关系，所以值类型的类可以直接用值类型来具体化的，如int a。

对于字符串来说，虽然是引用类型，但是用得较多，所以也可快速实例化。*/
using System;

namespace int_me {
	class me {
		static void Main(string[] args) {
			int a;  //值类型实例化，a是值类型，a存储在内存中，注意此时并不是声明一个int的引用
			/*声明语句："类型 标号" 对于值类型也说，是直接就具体化了，而对于引用类型来说，是声明一个引用*/
			int b = new int();  //标准地对类int实例化(引用实例化)，b是引用类型，b存储在堆栈中
			a = 1;
			b = 2;
			string AB = "AB"; //字符串虽然是类，只能用引用实例化，但用得较多，所以可以用快速实例化，有些像值实例化
			Console.WriteLine("a = {0}",a);
			Console.WriteLine("b = {0}",b);
			Console.WriteLine("AB = {0}",AB);
			Console.ReadLine();
		}
	}
}

