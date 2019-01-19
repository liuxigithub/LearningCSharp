/*命名空间定义了一个声明区域，它提供了将一组名称与另一组名称进行区分的方法。*/
/*其目标是保证在一个命名空间中声明的类的名称与另一个命名空间中声明的相同的类的名称不冲突*/
/*命名空间解决了命名资源的问题*/
/*命名空间中的成员包括：类，结构，枚举（这三种是构建新数据类型的东西），接口，委托和命名空间*/
/*如果程序没有声明命名空间，就会默认使用全局命名空间，但是这样做并不可取*/
/*命名空间可以嵌套*/
/*using命令： 1. using namespace :这表示引入命名空间之后，就会引入所有定义在该空间中的成员，并且能够不加限定地使用它们。
              2. using alias = namespace: 它的作用是为命名空间取一个别名*/
/*空间别名限定符"::" :用于别名命名空间的引用*/
/*尽管命名空间可以帮助避免名称冲突，但却不能完全消除这种冲突，如果在两个不同的命名空间中声明了相同的成员，而程序又同时
   引入了这两个命名空间，就会发生名称冲突，这种情况下，就不得不用别名的方式来解决问题了*/


using System;
using hw2;
using HW4 = hw4;

namespace hw1 {
    class chw1 {
        public void pf1() {
            Console.WriteLine("Hello,World 1");
        }
    }
}

namespace hw2 {
    class chw2 {
        public void pf2() {
            Console.WriteLine("Hello, World 2");
        }
    }
}

namespace hw3 {  //用来说明命名空间的嵌套
    class chw3 {
        public void pf3() {
            Console.WriteLine("Hello, World 3");
        }
    }

    namespace hw3_in {
        class chw3_in {
            public void pf3_in() {
            Console.WriteLine("Hello, World 3_in");
            }
        }
    }
}

namespace hw4 {
    class chw2 {
        public void pf4() {
            Console.WriteLine("Hello,World 4");
        }
    }
}

public class main {
    public static void Main(string[] args) { // 使用全局命名空间
    hw1.chw1 h1 = new hw1.chw1(); // 没有用using，所以要带全称地引用这个类
    chw2 h2 = new chw2(); //用了using,所以可以直接引用chw2这个类
    hw3.chw3 h3 = new hw3.chw3();
    hw3.hw3_in.chw3_in h3_in = new hw3.hw3_in.chw3_in();//hw3_in是hw3的嵌套命名空间，
    /*值得注意的是，子命名空间中的成员并不属于父命名空间，只能逐级引用，如上面的，并不能写成hw3.chw3_in h3_in*/
    HW4::chw2 h4_1 = new HW4::chw2();  //别名限定符
    HW4.chw2 h4_2 = new HW4.chw2(); //别名也可使用通常的.限定符

    h1.pf1();
    h2.pf2();
    h3.pf3();
    h3_in.pf3_in();
    h4_1.pf4();
    h4_1.pf4();
    Console.ReadLine();
    }
}
