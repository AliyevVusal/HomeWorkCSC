using System;
using HomeWorkSNSTask1.Extention;
using HomeWorkSNSTask1.Models;
namespace HomeWorkSNSTask1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("FullNamenizi daxil edin!");
            string fullname = Console.ReadLine();
            
            Console.WriteLine("Qrup nomrenizi daxil edin");
            string groupno = Console.ReadLine();
            Student student1 = new Student(fullname,groupno);
            
            
            

        }            
    }
}
