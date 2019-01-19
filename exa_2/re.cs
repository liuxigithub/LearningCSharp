/*计算矩形面积*/
using System;

namespace rectangle_ts {
	class execution {
		static void Main(string[] args) {
        	rectangle r = new rectangle();
        	r.init();
        	r.show();
        	Console.ReadKey();
    	}
	}

	class rectangle {
		//成员变量
		double length, width;

		public void init() {
			length = 1.0;
			width = 2.0;
		}

		public double cal() {
            return length*width;
		}

		public void show() {
			Console.WriteLine("length:{0}",length);
			Console.WriteLine("width:{0}",width);
			Console.WriteLine("area:{0}",cal());
		}

	}
}