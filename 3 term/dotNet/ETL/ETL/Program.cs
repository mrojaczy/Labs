﻿using ETL.ServiceManager;

namespace ETL
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            var move = new Move();
            move.Run();
        }
    }
}