﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    public class LoopUtilities
    {
        public static void Repeat(int count, Action action)
        {
            for (int i = 0; i < count; i++)
            {
                action();
            }
        }
     }
}
