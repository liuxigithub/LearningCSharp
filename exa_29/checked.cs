/*cheked 和 unchecked 关键字*/
/* C#并不会主动发现并抛出数值溢出的异常，如果用checked关键字，就可以抛出这个异常了 */
/* checked的用法： 1.checked(exp), 2. checked {}  */
/*相应地，unchecked的用法： 1.unchecked(exp), 2. unchecked {}  */
using System;
namespace check_ts {
    class check_me {
        public static void Main(string[] args) {
            int x = 2147483647;
            int z;
            try {
                z = checked(x+100); //测试checked
            }
            catch (OverflowException exc) {
                Console.WriteLine("Test checked:"+exc.ToString());
            }

            try {
                z = unchecked(x+100);//测试unchecked,默认情况下就是不检测的
                Console.WriteLine("Test unchecked: should be shown");
            }
            catch (OverflowException) {
                Console.WriteLine("Test unchecked: should not be shown");
            }
            Console.ReadLine();
        }
    }
}
