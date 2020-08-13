using Editity_Framework.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

namespace Editity_Framework
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>(){new Student() { id = 0, idRk = 1, naam = "Abdul", adress = new StudentAdress() { Id = 0, HuisNummer = 40, Postcode = "2402cz", Straat = "Keizershof", WoonPlats = "Alphen" } },
                    new Student() { id = 0, idRk = 5, naam = "Arno", adress = new StudentAdress() { Id = 0, HuisNummer = 40, Postcode = "2402cz", Straat = "Keizershof", WoonPlats = "Alphen" } },
                    new Student() { id = 0, idRk = 4, naam = "Remko", adress = new StudentAdress() { Id = 0, HuisNummer = 40, Postcode = "2402cz", Straat = "Keizershof", WoonPlats = "Alphen" } },
                    new Student() { id = 0, idRk = 6, naam = "Joris", adress = new StudentAdress() { Id = 0, HuisNummer = 40, Postcode = "2402cz", Straat = "Keizershof", WoonPlats = "Alphen" } } };
            using (var db = new Models.TestdbContext())
            {
                db.Database.EnsureCreated();
                using (var Trans = db.Database.BeginTransaction())
                {
                    try
                    {
                        Console.WriteLine();
                        Console.WriteLine("Add");
                        Console.WriteLine();
                        db.Students.AddRange(students);
                        db.SaveChanges();

                        Console.WriteLine();
                        Console.WriteLine("Read");
                        Console.WriteLine();
                        foreach (Student item in db.Students)
                        {
                            Console.WriteLine(item.naam);
                        }


                        // انتباه  Eager
                        Console.WriteLine("Eager");
                        var Load = db.Students.Include(I => I.adress);

                        //+> انتباه  Explicit
                        Console.WriteLine("Explicit");
                        var Stu = db.Students.Find(1);
                        db.Entry(Stu).Reference(r => r.adress).Load();

                        // Lazy
                        Console.WriteLine("Lazy");
                        var a = db.Students;

                        Console.WriteLine();
                        Console.WriteLine("Delete");
                        Console.WriteLine();
                        foreach (Student item in db.Students)
                        {
                            db.Students.Remove(item);
                        }
                        db.SaveChanges();

                        Console.WriteLine();
                        Console.WriteLine("read again");
                        Console.WriteLine();
                        foreach (Student item in db.Students)
                        {
                            Console.WriteLine("aa" + item.naam);
                        }
                        Trans.Commit();
                    }
                    catch
                    {
                        Trans.Rollback();
                    }
                    finally
                    {
                        Trans.Dispose();
                    }
                }


            }
            Console.ReadLine();
        }
    }
}