using System;
using System.IO;
using System.Collections.Generic;
using ExerciciosSecao14_04_01.Entities;

namespace ExerciciosSecao14_04_01
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Erich\Cursos\C# Completo 2019 com Programacao Orientada Objeto\projetos\ExerciciosSecao14-04-01\Arquivos\in.txt";
            string pathNew = @"C:\Erich\Cursos\C# Completo 2019 com Programacao Orientada Objeto\projetos\ExerciciosSecao14-04-01\Arquivos\in2.txt";

            try
            {
                using(StreamReader sr = File.OpenText(path))
                {
                    List<string> list = new List<string>();
                    while (!sr.EndOfStream)
                    {
                        list.Add(sr.ReadLine());
                    }
                    list.Sort();
                    foreach(string str in list)
                    {
                        Console.WriteLine(str);
                    }
                }

                using(StreamReader sr = File.OpenText(pathNew))
                {
                    List<Employee> emp = new List<Employee>();
                    while (!sr.EndOfStream)
                    {
                        emp.Add(new Employee(sr.ReadLine()));
                    }
                    emp.Sort();
                    foreach(Employee employee in emp)
                    {
                        Console.WriteLine(employee.ToString());
                    }
                }
            } catch (IOException e)
            {
                Console.WriteLine("ERROR: " + e.Message);
            }
        }
    }
}
