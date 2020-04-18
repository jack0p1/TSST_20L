﻿using System;
using System.IO;

namespace ManagementSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            string workingDirectory = Environment.CurrentDirectory;
            string R1Path = Path.Combine(Directory.GetParent(workingDirectory).Parent.Parent.Parent.FullName, @"DataStructures", "R1_tables.properties");
            string R2Path = Path.Combine(Directory.GetParent(workingDirectory).Parent.Parent.Parent.FullName, @"DataStructures", "R2_tables.properties");
            string R3Path = Path.Combine(Directory.GetParent(workingDirectory).Parent.Parent.Parent.FullName, @"DataStructures", "R3_tables.properties");
            string R4Path = Path.Combine(Directory.GetParent(workingDirectory).Parent.Parent.Parent.FullName, @"DataStructures", "R4_tables.properties");
            ManagementSystem managementSystem = new ManagementSystem(R1Path, R2Path, R3Path, R4Path);
            managementSystem.Start();
        }
    }
}
