using System;
using System.Text;

namespace ExampleProject
{
    class Program
    {
        public static void Main(String[] args)
        {
            int i = 0;
            for(; ; )
            {
                if(i < 4)
                {
                    System.Diagnostics.Debug.WriteLine(i.ToString());
                    i++;
                }
            }
        }
    }
}
