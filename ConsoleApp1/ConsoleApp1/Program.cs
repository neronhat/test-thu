using System;

namespace ConsoleApp1
{
    public delegate void choan(conthu convat);
    public  class Program
    {
       

        //public void chothuan(conthu conthu)
        //{
        //    Console.WriteLine("cho {0} an", conthu.Ten);
        //}
       

        static void Main(string[] args)
        {
            conthu h1 = new conthu();
            h1.Ten = Console.ReadLine();
            hanhdong hd = new hanhdong();
             choan an = null;

            an += h1.chothuan;

            an(h1);

            Console.ReadKey();
        }
    }



  public  class conthu
    {
        public string Ten { get; set; }

        public void chothuan(conthu conthu)
        {
            Console.WriteLine("cho {0} an", conthu.Ten);
        }


    }


  public  class conheo:conthu
    {
       

    }

  public  class hanhdong
    {
        //public delegate void choan(conthu convat);

        //public void chothuan(conthu conthu )
        //{
        //    Console.WriteLine("cho {0} an", conthu.Ten);
        //}
        
      
    }
    
}
