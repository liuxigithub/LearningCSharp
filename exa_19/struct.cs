//结构的使用
//struct关键字用于创建结构
/*结构是值类型，既可以用值类型具体化，也可以用结构型实例化，
但是由于用值类型具体化时，不能应用结构的方法，所以建议还是用引用实例化。*/

using System;

namespace struct_ts {
    struct book {
        public string title;
        public string author;

        public void getvalue(string t,string a) {
            title = t;
            author = a;
        }

        public void disp() {
            Console.WriteLine("{0},{1}",title,author);
        }
    }

    class str_me {

        static void Main(string[] args) {
            book bk1; //值类型的具体化
            book bk2 = new book();//引用类型的实例化
            bk1.title = "book1";
            bk1.author = "author1";
            //bk1.getvalue("book2","autor2"); //bk1是用值类型具体化的，所以不能用结构的方法

            bk2.getvalue("book2","author2");

            bk1.disp();
            bk2.disp();
            Console.ReadLine();
        }
    }
}