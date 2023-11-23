using System;
using System.Collections.Generic;
using System.Linq;

namespace B_E_Task13
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isExit = false;
            List<Student> students = new List<Student>();
            List<Employ> employs = new List<Employ>();
            do
            {
                Console.WriteLine("1 - Student elave et\n2 - Employe elave et\n3 - Axtaris et\n4 - Cixis");
                string chois = Console.ReadLine();
                switch (chois)
                {
                    case "1":

                        Console.Write("Sdutend Name: ");
                        string stName = Console.ReadLine();
                        Console.Write("Sdutend Surname: ");
                        string stSurname = Console.ReadLine();
                        Console.Write("Sdutend Age: ");
                        byte stAge;
                        while(!byte.TryParse(Console.ReadLine(),out stAge))
                        {
                            Console.Write("Sdutend Age is Nuber(0-255): ");
                        }
                        Console.Write("Sdutendin Grade: ");
                        double stGrade;
                        while (!double.TryParse(Console.ReadLine(), out stGrade))
                        {
                            Console.Write("Sdutend Grade is float number: ");
                        }
                        students.Add(new Student(stName, stGrade) { Age = stAge, Surname = stSurname });

                        break;
                    case "2":
                        Console.Write("Employ Name: ");
                        string employName = Console.ReadLine();
                        Console.Write("Employ Surname: ");
                        string employSurname = Console.ReadLine();
                        Console.Write("Sdutend Age: ");
                        byte employAge;
                        while (!byte.TryParse(Console.ReadLine(), out employAge))
                        {
                            Console.Write("Employ Age is Nuber(0-255): ");
                        }
                        bool isPositions = false;
                        do
                        {
                            Console.WriteLine("Employ Position:\n\t1.Junior\n\t2.Middle\n\t3.Senior");
                            switch (Console.ReadLine())
                            {
                                case "1":
                                    employs.Add(new Employ(employName, Position.Junior) { Age = employAge, Surname = employSurname }); isPositions = true;
                                    break;
                                case "2":
                                    employs.Add(new Employ(employName, Position.Middle) { Age = employAge, Surname = employSurname }); isPositions = true;
                                    break;
                                case "3":
                                    employs.Add(new Employ(employName, Position.Senior) { Age = employAge, Surname = employSurname }); isPositions = true;
                                    break;
                            }
                        } while (!isPositions);
                        
                        break;
                    case "3":
                        bool isSrc = false;
                        do
                        {
                            Console.WriteLine("\n\t--1-Employe üzrə axtarış\n\t--2 - Student ");
                            switch (Console.ReadLine())
                            {
                                case "1":
                                    byte employPosition;
                                    do
                                    {
                                        Console.WriteLine("Employun Positionunu secin:\n\t1.Junior\n\t2.Middle\n\t3.Senior");
                                    } while (!(byte.TryParse(Console.ReadLine(), out employPosition) && employPosition > 0 && employPosition <= 3));
                                    switch (employPosition)
                                    {
                                        case 1:
                                            foreach (var item in employs.Where(e => e.Position == Position.Junior).ToList())
                                            {
                                                Console.WriteLine(item);
                                            } 
                                            break;
                                        case 2:
                                            foreach (var item in employs.Where(e => e.Position == Position.Middle).ToList())
                                            {
                                                Console.WriteLine(item);
                                            }
                                            break;
                                        case 3:
                                            foreach (var item in employs.Where(e => e.Position == Position.Senior).ToList())
                                            {
                                                Console.WriteLine(item);
                                            }
                                            break;
                                    }
                                    break;
                                case "2":
                                    double minGrade;
                                    Console.Write("Student minGrade: ");
                                    while(!double.TryParse(Console.ReadLine(),out minGrade))
                                    {
                                        Console.Write("Student minGrade is float number: ");
                                    }
                                    double maxGrade;
                                    Console.Write("Student maxGrade: ");
                                    while (!double.TryParse(Console.ReadLine(), out maxGrade))
                                    {
                                        Console.Write("Student maxGrade is float number: ");
                                    }
                                    foreach (var item in students.Where(s => s.Grade >= minGrade && s.Grade <= maxGrade))
                                    {
                                        Console.WriteLine(item);
                                    }
                                    break;
                            }
                        } while (!isSrc);

                        break;
                    case "4":
                        isExit = true;
                        break;

                }

            } while (!isExit);
        }
    }
}
