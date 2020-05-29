using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;


namespace lab8._1
{
    class F
    {
        public string name;
        public string format;
        public string obl;
        public int kolvo_str;
        public int number;

        public F() { }
        public F(string Name, string Format,string Obl, int Kolvo, int Number)
        {
            name = Name;
            format = Format;
            obl = Obl;
            kolvo_str = Kolvo;
            number = Number;
        }

        public override string ToString()
        {
            return this.name + "|" + this.format + "|" +this.obl+"|"+ this.kolvo_str + "|" + this.number;
        }

    }
    class Program
    {
        static public void FileInformationRewrite(string path, List<F> users)
        {
            File.WriteAllText(path, String.Empty);
            using (StreamWriter sw = new StreamWriter(path))
            {
                foreach (F informationUnit in users)
                {
                    sw.WriteLine(informationUnit.ToString());
                }
            }
        }

        static void Main(string[] args)
        {
            List<F> C1 = new List<F>();
            using (StreamReader sr = new StreamReader("input.txt"))
            {
                string str;
                string[] arr1;
                while (sr.EndOfStream == false)
                {
                    str = sr.ReadLine();
                    if (str != "" && str != " ")
                    {
                        arr1 = str.Split("|");
                        C1.Add(new F(arr1[0], arr1[1],arr1[2], int.Parse(arr1[3]), int.Parse(arr1[4])));
                    }
                }
            }
            Console.WriteLine("╔════════════╤══════════════════════════════╗");
            Console.WriteLine("   Hot key   │            Function       ");
            Console.WriteLine("╠════════════╪══════════════════════════════╣");
            Console.WriteLine("      A      │       Add new file ");
            Console.WriteLine("╠════════════╪══════════════════════════════╣");
            Console.WriteLine("      D      │ Delete file by numberl ");
            Console.WriteLine("╠════════════╪══════════════════════════════╣");
            Console.WriteLine("      T      │      Show all files  ");
            Console.WriteLine("╠════════════╪══════════════════════════════╣");
            Console.WriteLine("      U      │      Update file  ");
            Console.WriteLine("╠════════════╪══════════════════════════════╣");
            Console.WriteLine("    Space    │         Clear console  ");
            Console.WriteLine("╠════════════╪══════════════════════════════╣");
            Console.WriteLine("      Q      │   Sort file by name ");
            Console.WriteLine("╠════════════╪══════════════════════════════╣");
            Console.WriteLine("      O      │   Sort file by obl ");
            Console.WriteLine("╠════════════╪══════════════════════════════╣");
            Console.WriteLine("      F      │   Sort file by format ");
            Console.WriteLine("╠════════════╪══════════════════════════════╣");
            Console.WriteLine("     Enter   │          Exit program  ");
            Console.WriteLine("╚════════════╧══════════════════════════════╝");

            if (Console.ReadKey().Key == ConsoleKey.T)
            {
                Console.Clear();
                Console.WriteLine("\nYour files:");
                foreach (F p in C1)
                {
                    Console.WriteLine(p.ToString());
                }
            }

            if (Console.ReadKey().Key == ConsoleKey.A)
            {
                Console.Clear();
                Console.WriteLine("\nDo you want to add new file?");
                string a = Console.ReadLine();
                if (a == "Y" || a == "y")
                {
                    Console.WriteLine("Enter name:");
                    string s = Console.ReadLine();
                    Console.WriteLine("Enter format:");
                    string g = Console.ReadLine();
                    Console.WriteLine("Enter obl:");
                    string ob = Console.ReadLine();
                    Console.WriteLine("Enter kolvo str:");
                    int o = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter the number:");
                    int t = int.Parse(Console.ReadLine());


                    if (s != null && g != null && o != null && t != null)
                    {
                        C1.Add(new F() { name = s, format = g, obl = ob,kolvo_str=o,number = t });
                        Console.WriteLine("User is added!");
                        FileInformationRewrite("output.txt", C1);
                    }
                    else
                        Console.WriteLine("You do not add a new user!");

                }
            }

            if (Console.ReadKey().Key == ConsoleKey.T)
            {
                Console.WriteLine("\nYour users:");
                foreach (F p in C1)
                {
                    Console.WriteLine(p.ToString());

                }
            }

            if (Console.ReadKey().Key == ConsoleKey.D)
            {
                Console.Clear();
                Console.WriteLine("\nDo you want to delete file");
                string d = Console.ReadLine();

                if (d == "Y" || d == "y")
                {
                    Console.WriteLine("Enter the number of file you want to delete");
                    int n = int.Parse(Console.ReadLine());
                    C1.RemoveAt(n - 1);
                    Console.WriteLine("User number " + n + " is deleted!");
                    FileInformationRewrite("output.txt", C1);

                }
            }

            if (Console.ReadKey().Key == ConsoleKey.T)
            {
                Console.WriteLine("\nYour users:");
                foreach (F p in C1)
                {
                    Console.WriteLine(p.ToString());

                }
            }

            if (Console.ReadKey().Key == ConsoleKey.U)
            {
                Console.Clear();
                Console.WriteLine("\nDo you want to edit file?");
                string e = Console.ReadLine();
                if (e == "Y" || e == "y")
                {
                    F C2 = new F();
                    Console.WriteLine("Which file you want to edit");
                    int k = int.Parse(Console.ReadLine());

                    Console.WriteLine("Enter name:");
                    string s_n = Console.ReadLine();
                    C2.name = s_n;
                    Console.WriteLine("Enter format:");
                    string gr = Console.ReadLine();
                    C2.format = gr;
                    Console.WriteLine("Enter obl");
                    string ob = Console.ReadLine();
                    C2.obl = ob;
                    Console.WriteLine("Enter kolvo str:");
                    int kolvo = int.Parse(Console.ReadLine());
                    C2.number = kolvo;
                    Console.WriteLine("Enter number:");
                    int num = int.Parse(Console.ReadLine());
                    C2.number = num;

                    C1.RemoveAt(k - 1);
                    C1.Insert(k - 1, C2);
                    Console.WriteLine("User number " + k + " is edited!");
                    FileInformationRewrite("output.txt", C1);
                }

            }

            if (Console.ReadKey().Key == ConsoleKey.T)
            {
                Console.WriteLine("\nYour users:");
                foreach (F p in C1)
                {
                    Console.WriteLine(p.ToString());

                }
            }

            if (Console.ReadKey().Key == ConsoleKey.Q)
                
            {
                Console.Clear();
                Console.WriteLine("Do you want to sort files by name?");
                string sort = Console.ReadLine();
                if (sort == "Y" || sort == "y")
                {
                    
                    Console.WriteLine("Your files:");
                    foreach (F p in C1)
                    {
                        Console.WriteLine(p.ToString());

                    }

                    Console.WriteLine("\nYour files after sort:");
                    var result = from user in C1
                                 orderby user.name
                                 select user;
                    foreach (F u in result)
                    {
                        Console.WriteLine(u.ToString());
                    }
                    
                }
            }

            if (Console.ReadKey().Key == ConsoleKey.O)
               
            {
                Console.Clear();
                Console.WriteLine("Do you want to sort files by obl?");
                string sort = Console.ReadLine();
                if (sort == "Y" || sort == "y")
                {
                    
                    Console.WriteLine("Your files:");
                    foreach (F p in C1)
                    {
                        Console.WriteLine(p.ToString());

                    }

                    Console.WriteLine("\nYour files after sort:");
                    var result = from user in C1
                                 orderby user.obl
                                 select user;
                    foreach (F u in result)
                    {
                        Console.WriteLine(u.ToString());
                    }

                }
            }

            if (Console.ReadKey().Key == ConsoleKey.F)

            {
                Console.Clear();
                Console.WriteLine("Do you want to sort files by format?");
                string sort = Console.ReadLine();
                if (sort == "Y" || sort == "y")
                {
                    
                    Console.WriteLine("Your files:");
                    foreach (F p in C1)
                    {
                        Console.WriteLine(p.ToString());

                    }

                    Console.WriteLine("\nYour files after sort:");
                    var result = from user in C1
                                 orderby user.format
                                 select user;
                    foreach (F u in result)
                    {
                        Console.WriteLine(u.ToString());
                    }

                }
            }

            if (Console.ReadKey().Key == ConsoleKey.K)

            {
                Console.Clear();
                Console.WriteLine("Do you want to sort files by kolvo str?");
                string sort = Console.ReadLine();
                if (sort == "Y" || sort == "y")
                {

                    Console.WriteLine("Your files:");
                    foreach (F p in C1)
                    {
                        Console.WriteLine(p.ToString());

                    }

                    Console.WriteLine("\nYour files after sort:");
                    var result = from user in C1
                                 orderby user.kolvo_str
                                 select user;
                    foreach (F u in result)
                    {
                        Console.WriteLine(u.ToString());
                    }

                }
            }

            if (Console.ReadKey().Key == ConsoleKey.N)

            {
                Console.Clear();
                Console.WriteLine("Do you want to sort files by number?");
                string sort = Console.ReadLine();
                if (sort == "Y" || sort == "y")
                {

                    Console.WriteLine("Your files:");
                    foreach (F p in C1)
                    {
                        Console.WriteLine(p.ToString());

                    }

                    Console.WriteLine("\nYour files after sort:");
                    var result = from user in C1
                                 orderby user.number
                                 select user;
                    foreach (F u in result)
                    {
                        Console.WriteLine(u.ToString());
                    }

                }
            }
            Console.WriteLine("Press ENTER to exit");
            Console.ReadKey();

        }
    }
}
