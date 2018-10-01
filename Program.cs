using System;
using System.Collections.Generic;
namespace Boxing_Unboxing
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            List<object> ListObject = new List<object>();
            ListObject.Add(7);
            ListObject.Add(28);
            ListObject.Add(-1);
            ListObject.Add(true);
            ListObject.Add("chair");
            for (int i = 0; i < ListObject.Count; i++)
            {
                System.Console.Write(ListObject[i] +" ");
                if(ListObject[i] is int){
                    sum = sum + (int)ListObject[i];
                }
            }
            System.Console.WriteLine("\n" + sum);
            
            // object value = 5;
            // if(value is int){
            //     System.Console.WriteLine("it works");

            // }else{
            //     System.Console.WriteLine("not working");
            // }
        }
    }
}
