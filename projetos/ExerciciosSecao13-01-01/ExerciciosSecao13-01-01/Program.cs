﻿using System;
using System.IO;
using ExerciciosSecao13_01_01.Entities;

namespace ExerciciosSecao13_01_01
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Enter file full path: ");
                string sourceFilePath = Console.ReadLine();
                string[] lines = File.ReadAllLines(sourceFilePath);

                string sourceFolderPath = Path.GetDirectoryName(sourceFilePath);
                string targetFolderPath = sourceFolderPath + @"\out";
                string targetFilePath = targetFolderPath + @"\sumary.csv";

                Directory.CreateDirectory(targetFolderPath);

                using (StreamWriter sw = File.AppendText(targetFilePath))
                {
                    foreach (string line in lines)
                    {
                        string[] fields = line.Split(',');
                        string name = fields[0];
                        double price = double.Parse(fields[1]);
                        int quantity = int.Parse(fields[2]);

                        Product prod = new Product(name, price, quantity);

                        sw.WriteLine(prod.Name + ", $" + prod.Total().ToString("F2"));
                    }
                }

            }
            catch (UnauthorizedAccessException e)
            {
                Console.WriteLine("ERROR: " + e.Message);
            }
            catch (IOException e)
            {
                Console.WriteLine("ERROR: " + e.Message);
            }
        }
    }
}
