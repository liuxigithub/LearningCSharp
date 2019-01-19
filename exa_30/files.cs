/*文件和流*/
/*文件是一个存储在磁盘中带有指定名称和目录路径的数据集合。当打开文件进行读写时，它变成一个 流。*/
/*从根本上说，流是通过通信路径传递的字节序列。有两个主要的流：输入流 和 输出流。输入流用于从文件读取数据（读操作），输出流用于向文件写入数据（写操作）。*/
/*System.IO命名空间中提供了多种类型，用于进行文件和流的读写操作。*/

/*System.IO中的常用类：
File类: 静态类，基本的文件处理操作，不能写入
Directory: 静态类，文件夹的基本操作
*/
using System;
using System.IO;

namespace StudyFile {
    class studyfile {
        public static void Main(string[] args) {
            /*测试文件类File*/
            string file1 =  @".\filea.txt";
            string file2 = @".\fileb\fileb.txt";
            string file3 = @".\filec.txt";
            string TextRead;
            if (File.Exists(file2))  {//判断文件存在的方法
                File.Copy(file1,file2,true);  //复制文件
                Console.WriteLine("copy success!");
            }
            else {
                File.Create(file2);
                File.Copy(file1,file2,true);
                Console.WriteLine("creat and copy success!");
            }

            //File.Create(file3);
            if (File.Exists(file3))  { 
                File.Delete(file3); //文件的删除
            }
              
            TextRead  = File.ReadAllText(file1); //读取文件
            Console.WriteLine(TextRead);
            Console.ReadLine();

            /*测试文件夹类Directory*/
            string DirTest = @"directory test";
            File.GreatDirectory(DirTest);// 创建文件夹
            WriteLine("文件夹创建成功");
        }
    }
}