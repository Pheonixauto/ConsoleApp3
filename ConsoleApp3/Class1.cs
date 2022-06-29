using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public class Class1
    {
        public Class1()
        {

        }
        int[] number = { 1, 2, 3, 4, 4, 3, 4, 7, 5, 9, 8, 11,34, 35,35 };

        int a = 0;
        int b = 0;

        public void cacula()
        {
            foreach(int i in number) // Tìm số lớn nhất
            {
                if(i!=0 && i > a)
                {
                    a = i;
                    
                }
            }
            foreach(int i in number) // Tìm số lớn thứ 2
            {
                if (i!=0 && i > b && i!=a)
                {
                   b= i;
                }
            }         
            Console.WriteLine($"SecondMax is : {b}");
        }


        public void IfElse()
        {
            for(int i = 0; i <=5; i++)
            {
                if (i == 4)
                {
                    continue;
                }
                Console.WriteLine(i); // in ra 0,1,2,3,5
            }
        }


     
       

    }
}
