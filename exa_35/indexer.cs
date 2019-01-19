/*
 * 索引器（indexer)
 *
 * 索引器是类或结构的成员，它可以使用户像访问数组一样访问成员
 *
 * 索引器本质上也是一种方法：(index可作为数组指标)
 
 *           get访问器： index列表----->索引器的返回类型（所以要有return）
 *           set访问器： index列表+value(由于索引器的赋值得到)------>void 
 *   与属性相比，就相当于在输入中加入了index列表
 *
 * 需要注意的是：
 *      index不必是整型，可以是任意类型
 *      属性强调的是它是类的成员，而索引器则强调的是它对类成员的访问
 *      索引器允许重载,相反属性不可以
 *      索引器必须为实例成员(即不能声明为static),但属性可以
 *      索引器不是一个变量，因此不能作为ref参数或out参数传递出去
 */

using System;

namespace Indexer {
  class IndexerTest {
    int age;
    public string this[string index] {  //索引器声明
      get {
        return index+" : "+age.ToString();
      }
      set {
        age = Convert.ToInt32(value);
        
            
      }
    }
  }
  class main {
    static void Main(string[] args) {
      string age = "26";
      string temp = "temp";
      IndexerTest ts = new IndexerTest();
      ts[temp] = age; // 使用set访问器
      Console.WriteLine(ts["Liuxi"]); //使用get访问器
      Console.ReadLine();
    }
  }
}
