// <copyright file="WriteTextFile.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace HenE.TestApp
{
    using System.IO;

    /// <summary>
    /// Schrijf de txt op.
    /// </summary>
    public class WriteTextFile
    {
        /// <summary>
        /// Write de text .
        /// </summary>
        /// <param name="text">De text.</param>
        public void WriteText(string text)
        {
            File.WriteAllText("Log.txt", text);
        }
    }
}
