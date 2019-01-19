//明晰实例与对象的关系：实例是对操作对象的引用。
//试验带参数的new.
using System;

namespace ref_ts {
	class ref_me {
		public int ts = 0;
		public void prin() {

			Console.WriteLine("ts: {0}",ts);
		}
	}
   	class main {
   		static public void Main(string[] args) {
   			ref_me abc, ABC; //创建一个类ref_me的引用abc和ABC
   			ABC = new ref_me(); //创建一个类ref_me的对象，并用引用ABC指向这个对象.
   			/*上面的二句可以用一句初始化语句来完成：
   			   ref_me ABC = new ref_me(); 左边是创建引用，右边是创建对象，等号完成连接，
   			   这三步包含了实例化的全过程 */
   			abc = ABC; //引用赋值，abc和ABC都指向同一个对象。
   			new ref_me();//测试创建一个对象，但不接收其引用。

		   	abc.prin();
		   	abc.ts = 1;
		   	abc.prin();
		   	ABC.prin();
		   	ABC.ts = 2;
		   	ABC.prin();
		   	abc.prin();
		   	Console.ReadLine();
   		}
   	}
}


