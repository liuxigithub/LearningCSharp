//运算符的重载
using System;
namespace or_op {
    class vector {
        public double x, y;
        public vector(double x1, double y1) {
            x = x1;
            y = y1;
        }
        public vector() {  //构造函数的重载
            
        }
        public static vector operator +(vector lhs, vector rhs) { //vector+vector的重载
            /*vector result = new vector();
            result.x = lhs.x + rhs.x;
            result.y = lhs.y + rhs.y;
            return result;*/
            return new vector(lhs.x + rhs.x,lhs.y + rhs.y);
        }
        public static vector operator +(double lhs, vector rhs) { //double+vector的重载
            /*vector result = new vector();
            result.x = lhs+rhs.x;
            result.y = lhs+rhs.y;
            return result;*/
            return new vector(lhs+rhs.x,lhs+rhs.y);
        }
        public static vector operator +(vector lhs,double rhs) { //vector+double的重载
            /*vector result = new vector();
            result.x = lhs.x+rhs;
            result.y = lhs.y+rhs;
            return result;*/
            return new vector(lhs.x+rhs,lhs.y+rhs);

        }
    }

    class main {
        static void Main(string[] args) {
            vector v1 = new vector(1.0,3.0);
            vector v2 = new vector(2.0,8.0);
            vector v3 = new vector();
            vector v4 = new vector();
            vector v5 = new vector();
            v4 = 2.0+v1;
            v5 = v1 + 3.0;
            Console.WriteLine("v1={0},{1};v2={2},{3}",v1.x,v1.y,v2.x,v2.y);
            Console.WriteLine("v1+v2={0},{1}",v3.x,v3.y);
            Console.WriteLine("2.0+v1={0},{1}",v4.x,v4.y);
            Console.WriteLine("v1+3.0={0},{1}",v5.x,v5.y);
            Console.ReadLine();                     
            
            
        }
    }
}