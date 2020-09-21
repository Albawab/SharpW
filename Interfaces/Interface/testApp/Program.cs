// <copyright file="Program.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace HenE.TestApp
{
    using System;
    using HenE.InterfaceCommunicate.Interfaces;

    /// <summary>
    /// Program.
    /// </summary>
    internal static class Program
    {
        private static void Main(string[] args)
        {
            ILogger logger = new FileLogger();

           // logger?.Log("Iets");

            Console.ReadLine();

            GameController controller = new GameController(new Bord());

            controller.Start();
            Console.ReadLine();
        }
    }
}
