//计算阶乘
using System;

namespace jc_ts {
	class jc {
		public int jiecheng(int n) {
			int res;
			if (n==1) {
				res = 1;
			}
			else {
				res = n*jiecheng(n-1);
			}
			return res;
		}
		static public void Main(string[] args) {
			int N;
			jc r = new jc();
			Console.WriteLine("input an integer:");
			N = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("res: {0}",r.jiecheng(N));
			Console.ReadLine();
		}
	}
}