/* 
 * c#预处理指令
 * 预处理指令只能单独成行，由于预处理指令不是程序语句,所以后面不需要加分号
 *
 * #define : 定义一个符号。在预处理中，如果某符号被定义，则它的值为true,如果没被定义，则这的值为false.
 *           这个指令仅用于定义符号，并不代表宏。
 *
 * #if,#else,#elif,#endif :  测试符号是否为真的控制结构。符号表达式中可以包含 !,==,!=,&&,||运算符，也可包含圆括号。
 *
 * #line: 它可以让您修改编译器的行数以及（可选地）输出错误和警告的文件名。
 *
 * #error: 它允许从代码的指定位置生成一个错误。
 *
 * #warning: 它允许从代码的指定位置生成一级警告。
 *
 * #region, #endregion: 它可以让您在使用 Visual Studio Code Editor 的大纲特性时，指定一个可展开或折叠的代码块。
 */

#define ABC
#define abc
//#define ERR
using System;

namespace preproccess_ts {
    class main {
        public static void Main(string[] args) {
            #if ABC    //测试 #if
                Console.WriteLine("Test #if");
            #endif
            
            #if temp  
                Console.WriteLine("temp");
            #elif abc  //测试 #elif
                Console.WriteLine("Test #else"); 
            #endif

            #warning test warning

            #if ERR
                #error test error //测试#error
            #endif

            #region    //测试#region
                Console.WriteLine("Test #region");
            #endregion
            Console.ReadLine();                
        }
    }
}