﻿using System;


namespace Day8
{
    class MyExceptionUsage
    {

        public static void Main()
        {
            try
            {
                throw new MyExceptionClass("RAJESH");
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception caught here" + e.ToString());
            }
            Console.WriteLine("LAST STATEMENT");
        }

    }
}
