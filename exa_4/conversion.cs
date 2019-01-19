/*强制类型转换*/

using System;



namespace conversion_ts {

	class conversion {

		static public void Main(string[] args) {

			double i, s;

			s = 2.5;

			i = (int) s; //强制类型转换

			Console.WriteLine("s = {0}",s);

			Console.WriteLine("i = {0}",i);

			Console.WriteLine("ToString(s):{0}",s.ToString());

			Console.ReadLine();

		}

	}

}
