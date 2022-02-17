using System;
using System.Collections.Generic;
using System.Text;
using HomeWorkSNSTask1.Extention;

namespace HomeWorkSNSTask1.Models
{
    class Student
    {
        public string Fullname { get; set; }    

        public string GroupNo { get; set; }

        public int Age { get; set; }

        public Student(string fullname,string groupno)
        {

            while (fullname.CheckGroupNo() != true)
            {
                Console.WriteLine("Adi Daxil edin");
                fullname = Console.ReadLine();

                if (fullname.CheckFullname()==true)
                {
                    break;
                }
                
                

            }
            Console.WriteLine("Ad duz daxil edildi");
            Fullname = fullname;








            while (!groupno.CheckGroupNo())
            {
                Console.WriteLine("grup no duzgun daxil et");
                groupno = Console.ReadLine();


            }
            Console.WriteLine("Grup No duz daxil edildi");
            GroupNo = groupno;
        }



    }
}
