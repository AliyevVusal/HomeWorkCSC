using System;
using HomeWorkCSCTaks2.Extention;
namespace HomeWorkCSCTaks2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Task 1
            //Console.WriteLine("--cut ve tek eded yolanisi--");
            //Console.WriteLine("Yoxladiginiz ededi daxil edin");
            //int.TryParse(Console.ReadLine(), out int a);
            //Console.WriteLine("Eded Cuturse True eks halda False");
            //Console.WriteLine(a.IsEven());
            
            //Task 2
            Console.WriteLine("Indexsi tapib array yigan program");
            Console.WriteLine("arrayinizi daxil edin");
            int[] arr = { 3, 1, 3, 1, 2, 1, 2 };
            int b = 1;

            int[] art = arr.methodGetValueIndexes(b);
            foreach (int item in art)
            {
                Console.WriteLine(item);
            }
        }
    }
}
