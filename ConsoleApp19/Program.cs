using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp19
{
    delegate int call();
    delegate void call2();

    

    class Program
    {
        
        static void Main(string[] args)
        {
          
            //delegate co tham so
            call f1 = new call(onclick);
            var a = f1();
            //action deletage ko co kieu tra ve 
            call2 f2 = callback;
         

            f2();

            
            Console.Write(a);
          
            Console.ReadKey();
        }

      static  public void callback()
        {
            Console.WriteLine("goi ne");
      
        }

        static  public int onclick( )
        {
          
            return 100;
        }
    }
}
