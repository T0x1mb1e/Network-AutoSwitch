﻿using System;

namespace Tulpep.NetworkAutoSwitch.Service
{
    static class Logging
    {
        public static void WriteMessage(string text, params object[] args)
        {
            Console.WriteLine(DateTime.Now + "\t" + string.Format(text, args));
        }
    }
}
