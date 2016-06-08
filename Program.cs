using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Basic_C_Sharp
{
    public class Program
    {
        public void Main(string[] args)
        {
            //let check diff secenarioe of static polymorphism

            //create Object
            StaticPolymorphism obj = new StaticPolymorphism();
            //then lets call overloaded methods

            Console.WriteLine( obj.Add(5)+""); // this can call 2 methods add(int) and add(float) one
            //but since for add(float) reurires implicit conversion therfore it will call add(int)            

            Console.WriteLine(obj.Add(5.0f)+""); // this will call add(float) method

            // obj.Add(5.0f, 5.0f); //since no overloaded method is having two float parmeter hence it is giving complie time error
            //as early said method overloading is checked by complier 

            //obj.Add(5, 5);// this can call both add(int,float) and add(float,int) but since for both atleast one implicit
            //conversion is required so they both are equally good matches and complier cannot declare the best match
            //hence it is thorwing complie time error.

            //now let run and check

        }
    }
}
