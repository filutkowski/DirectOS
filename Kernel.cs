﻿using System;
using System.Collections.Generic;
using System.Text;
using Sys = Cosmos.System;

namespace YountoOs_v2
{
    public class Kernel : Sys.Kernel
    {

        protected override void BeforeRun()
        {
            Console.WriteLine("DirectOs (YountoOs 2.0) booted successfully. Type a line of text to get it echoed back.");
        }

        protected override void Run()
        {
            Console.Write("Input: ");
            var input = Console.ReadLine();
            Console.Write("Text typed: ");
            Console.WriteLine(input);
        }
    }
}
