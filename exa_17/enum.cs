//枚举类型,值类型
//枚举有点像struct和class关键字，它是利用基本类型声明一个新类型，这个新类型的具体化的值只可能是枚举成员
//
using System;

namespace enum_ts {
    public enum  gender: int {
            male,female
    } //声明一个枚举类型

    class enum_me {
        int x = new int((int)1);
        static void Main(string[] args) {
            gender se = gender.male; //值类型的具体化
            gender se3 = new gender(); //引用类型的实例化
            
            int se2 = (int)gender.male;
            se3 = gender.female;

            
            Console.WriteLine("gender:{0}",se);
            Console.WriteLine("gender:{0}",se2);
            Console.WriteLine("gender:{0}",se3);
            Console.ReadLine();
        }
    }
}