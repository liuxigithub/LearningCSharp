//数组的使用 
//数组是引用类型,只能用引用类型的实例化
//数组的实质：同时具体化一个数据类型的多个实体,能够用的具体化方式由所需的数据类型决定
//要注意值类型和引用类型数组化的时候不太一样。引用类型要分别对组内的元素实例化，而值类型就不了。但二者都要用引用的方式实例化。
using System;

namespace array {
	class arr {
		static public void Main(string[] args) {
			/*值类型的数组初始化*/
			int[] a; //声明一个值类型数组的引用，只需要一个引用的单元。
			int[] aa = new int[5]; //引用类型方法实例化一个值类型数组,实例化后会自动赋值
			a = aa; //让a也引用上面的那个数组，值类型的引用数组可以直接赋值，因为事实上值类型数组只需要一个位置就可确定
			int[] B = new int[5] {0,1,2,3,4}; //引用类型方法实例化一个值类型数组，并赋值
			int[] A = {0,1,2,3,4}; //特殊方法，声明时直接引用后面的数组。

			int[] b = new int[5]; //再用一次主流方法
			for(int i=0;i<5;i++) {
				b[i] = i;
			}


			for (int j=0;j<5;j++) {
				Console.WriteLine("a[{0}]={1}",j,a[j]);
			}
			for (int j=0;j<5;j++) {
				Console.WriteLine("A[{0}]={1}",j,A[j]);
			}
			for (int j=0;j<5;j++) {
				Console.WriteLine("b[{0}]={1}",j,b[j]);
			}
			for (int j=0;j<5;j++) {
				Console.WriteLine("B[{0}]={1}",j,B[j]);
			}

			/*对象数组初始化,注意：要对每个元素分别实例化*/
			hw[] C = new hw[3]; //将hw类实例化成3个对象，用数组C的3个元素准备来引用这三个对象，但还没有建立起这种引用关系
			/*下面分别建立引用关系，构成实例的数组*/
			for (int i=0;i<3;i++) {
				C[i] = new hw();
			}
			//输出
			for (int i=0;i<3;i++) {
				C[i].print();
			}
			Console.ReadLine();

		}
	}
	class hw {
		public void print() {
			Console.WriteLine("Hello,World");
		}
	}


}