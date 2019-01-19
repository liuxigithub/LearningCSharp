//数组类
using System;  
public class Matirx{  
    int[,] ary=new int[100,100];  
    int row;  int line;    
    public Matirx(){
    }        //无参构造函数   }    
    public Matirx(int r,int l){      //有参构造函数    
        row=r;   line=l;   
        for(int i=0;i<row;i++)    
            for(int j=0;j<line;j++)     
                ary[i,j]=i+1;
    }    
    public void print(){       //输出函数    
        for(int i=0;i<row;i++){    
            Console.WriteLine();    
            for(int j=0;j<line;j++)     
            Console.Write("{0} , ",ary[i,j]);   
        }   
        Console.WriteLine();  
    }     
    public void transpose(){      //矩阵的转置函数    
        int[,] b=new int[100,100];   
            for(int i=0;i<row;i++)    
                for(int j=0;j<line;j++) {     
                    b[i,j]=ary[i,j];    
                }   
            for(int i=0;i<row;i++)    
                for(int j=0;j<line;j++)     
                    ary[i,j]=b[j,i]; 
    }     
    public void add(Matirx x){      //矩阵的相加    
        for(int i=0;i<row;i++)    
            for(int j=0;j<line;j++)    
                ary[i,j]=ary[i,j]+x.ary[i,j];  
    }  
}

class Test{  
    public static void Main(){   
        int m,n;   
        Matirx a,b;   
        Console.WriteLine("输入行数："); 
        m=Convert.ToInt32(Console.ReadLine());   
        Console.WriteLine("输入列数："); 
        n=Convert.ToInt32(Console.ReadLine());   
        a=new Matirx(m,n);   
        b=new Matirx(m,n); 
        Console.WriteLine("默认原始矩阵A为：");   
        a.print(); 
        a.transpose(); 
        Console.WriteLine("默认矩阵转置后为：");   
        a.print(); 
        Console.WriteLine("默认原始矩阵B为：");   
        b.print();
        a.add(b); 
        Console.WriteLine("矩阵A转置后和B相加后的矩阵为");   a.print(); 
        Console.ReadLine();   
    } 
} 