//引用参数的使用
using System;

namespace ref_ts {
	class ref_me {
		public void swap(ref int a, ref int b) {
			int temp;
			temp = a;
			a = b;
			b = temp;
			return;
		}
		static public void Main(string[] args) {
			int a = 10, b = 20;
			Console.WriteLine("交换前，a = {0}, b = {1}",a,b);
			ref_me sw = new ref_me();
			sw.swap(ref a, ref b);
			Console.WriteLine("交换后，a = {0}, b = {1}",a,b);
			Console.ReadLine();
		}
	}
}