//sizeof运算符

using System;

namespace sizeof_ts {
	class sizeof_me {
		static public void Main (string[] args) {
			Console.WriteLine("sizeof(int):{0}",sizeof(int));
			Console.WriteLine("sizeof(double):{0}",sizeof(double));
			Console.WriteLine("sizeof(bool):{0}",sizeof(bool));
			Console.ReadKey();
		}
	}
}