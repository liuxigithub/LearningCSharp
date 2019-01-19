//字符串：在C#中，可以用字符数组来表示字符串。但是更常见的做法是使用string来声明一人个字符串的实例。
//string是字符串类，所以它属于引用类型，只能用引用类型的具体化方法。
//string类的快速实例化方法为： string a = "Hello world"

using System;
namespace str {
	class string_me {
		static void Main(string[] args) {
		/*字符串类的实例化方法*/
			//快速实例化,本质上也是引用类型的实例化
			string str1 = "Hello, world";
			//标准的类的方法实例化，构造函数的参数为一个char类型的数组
			char[] str_temp = {'H','W'}; //数组的快速实例化
			string str2 = new string(str_temp);//标准的类的实例化，输入参数是一个字符型数组

		/*可以利用string的方法生成其它的字符串*/
			string str3, str4, str5; //声明一个字符串类的引用
			//字符串的引用或实例相加表示字符串的连接
			str3 = str1 + str2; //引用连接
			str4 = "Hello,"+" "+"world"; // 常量连接,也可以多个连接
			str5 = str1 + "good"; //引用和常量连接
			//Join方法可以连接一个字符串数组
			string str6;
			string[] str6_temp = {"Hello","world"};
			str6 = String.Join("",str6_temp);

		//打印
			Console.WriteLine("{0}",str1);
			Console.WriteLine("{0}",str2);
			Console.WriteLine("{0}",str3);
			Console.WriteLine("{0}",str4);
			Console.WriteLine("{0}",str5);
			Console.WriteLine("{0}",str6);

		/*字符串类的方法演示*/  /* ref: https://msdn.microsoft.com/zh-cn/library/system.string(v=vs.110).aspx */
			//字符串比较
			string str7 = "Hello,World", str7_temp = "Hello,World";
			if (String.Compare(str7,str7_temp)==0) {
				Console.WriteLine(str7+" and "+str7_temp+ " is equal");
			}
			else {
				Console.WriteLine(str7+" and "+str7_temp+ " is not equal");
			}

			//字符串查找
			string str8 = "This is a test", str8_temp = "test";
			if (str8.Contains(str8_temp)) {
				Console.WriteLine("the sequence test is found");
			}
			else {
				Console.WriteLine("the sequence test is not found");
			}

			//提取子字符串
			string str9 = "My name is Liuxi" ;
			Console.WriteLine(str9+": "+str9.Substring(12));



		/*字符串的其它技巧, ref: https://msdn.microsoft.com/zh-cn/library/362314fe.aspx */
			//+和+=运算符可以用来连接字符串(实例或常量都可)，但要注意的是这会创建一个新对象(十分重要)。==和!=可以直接比较string对象(而不是引用)的值。
			string str10 = "hello", str10_temp = "h";
			str10_temp +="ello";//这将创建一个新对象，并引用
			Console.WriteLine(str10==str10_temp);//a==b直接用于字符串对象的比较
			Console.WriteLine((object)str10 == (object)str10_temp);//比较对象是否相同,因为是不同的对象，所以是false

			//[] 运算符可以用于对 string 的各个字符的只读访问
			string str11 = "Hello,world";
			char str11_temp;
			str11_temp = str11[0];//只读访问字符串
			Console.WriteLine(str11_temp);


			Console.ReadLine();

		}
	}
}