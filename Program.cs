﻿using System;
using XSockets.Core.Common.Socket;
using XSockets.Plugin.Framework;

namespace SampleServer
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var container = Composable.GetExport<IXSocketServerContainer>())
            {
                container.Start();
                Console.ReadLine();
            }
        }
    }
}
