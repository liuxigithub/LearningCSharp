/*流类，常用的：文件流类FileStream,流写入类StreamWriter,流读取类StreamReader*/

using System;
using System.IO; //文件与流的类
using System.Text; //包含编码类的命名空间

namespace StreamTest {
    class LiuStream {

        public static void Main(string[] args) {
            string filea = @".\filea.txt";
            byte[] hw = Encoding.UTF8.GetBytes("你好，世界"); //将字符串转化为UTF8编码
            FileStream fs = File.Create(filea);  //建立文件
            fs.Write(hw,0,hw.Length); //写入文件
            fs.Flush();
            fs.Close();  //关闭文件流
            fs.Dispose(); //释放所有该流的资源

            byte[] read = new byte[hw.Length]; 
            FileStream fs2 = new FileStream(filea, FileMode.Open, FileAccess.Read, FileShare.Read);    
            fs2.Read(read,0,hw.Length); //以二进制读取流
            fs2.Close();
            fs.Dispose();
            
            string output = Encoding.UTF8.GetString(read); //转码
            Console.WriteLine(output);

            Console.WriteLine("\n测试StreamWriter开始");
            StreamWriter fs3 = new StreamWriter(filea,true); //StreamWriter 类，更方便文件写入的类
            fs3.WriteLine();
            fs3.WriteLine("Hello,World");
            fs3.Flush();
            fs3.Dispose();
            Console.WriteLine("测试StreamWriter结束");
            

            Console.WriteLine("\n测试StreamReader开始");
            StreamReader fs4 = new StreamReader(filea);  //StreamReader类，更方便文件的读取
            string read1, read2;
            read1 = fs4.ReadLine();
            read2 = fs4.ReadLine();

            Console.WriteLine("read1:"+read1);
            Console.WriteLine("read2:"+read2);
            
            Console.WriteLine("测试StreamReader结束");
            Console.WriteLine(fs4.ToString());            
            Console.ReadLine();
            
        }
    }
}