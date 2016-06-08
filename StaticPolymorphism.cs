using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Basic_C_Sharp
{
    public class StaticPolymorphism
    {
        //Static polymorphism in C# is Method overloading and its is checked by complier.
        public int Add(int a)
        {
            return a + 10;
        }
        public float Add(float f)
        {
            return f + 10;
        }
        public float Add(int a,float f)
        {
            return a + f;
        }
        public float Add(float f,int a)
        {
            return a + f;
        }
    }
}
