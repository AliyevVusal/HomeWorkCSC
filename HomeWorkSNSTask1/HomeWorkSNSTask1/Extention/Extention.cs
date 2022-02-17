using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWorkSNSTask1.Extention
{
    static class Extention
    {

        public static bool CheckGroupNo(this string groupno)
        {

                if (groupno.Length != 4)
                {
                    
                return false;
                }
               
                        bool[] Chek = new bool[4];
                        int count = 0;
                        for (int i = 0; i < groupno.Length; i++)
                        {
                            if (char.IsUpper(groupno[i]) && i == 0)
                            {
                                Chek[count] = true;
                                count++;
                            }
                            else if (char.IsDigit(groupno[i]))
                            {
                                Chek[count] = true;
                                count++;
                            }
                            
                        }
                        if (count == 4)
                        {
                            return true;

                        }
                        else 
                        {
                        return false;
                        }
        }


        public static bool CheckFullname(this string fullname)
        {
            int temp = 0;
            for (int i = 0; i < fullname.Length; i++)
            {

                

                if (char.IsUpper(fullname[i]) && i == 0)
                {
                    temp++;
                }
                else if (char.IsWhiteSpace(fullname[i]))
                {
                    temp++;
                    if (char.IsUpper(fullname[i + 1]))
                    {
                        temp++;
                    }
                }
               
                
            }
            if (temp == 3)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}