﻿namespace BreakoutMonoGame
{
    using System;

    public static class Program
    {
        [STAThread]
        static void Main()
        {
            using (var game = new BreakoutGame())
            {
                game.Run();
            }
        }
    }
}
