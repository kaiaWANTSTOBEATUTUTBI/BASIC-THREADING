﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Basic_Threading
{
    class MyThreadClass
    {
        public void Thread1()
        {

            for (int LoopCount = 0; LoopCount < 6; LoopCount++) { 
           
                    Thread thread = Thread.CurrentThread;
                    Console.WriteLine("Name of Thread: " + thread.Name + " = " + LoopCount);
                    Thread.Sleep(1500);
               
            }
        }
    }
}
