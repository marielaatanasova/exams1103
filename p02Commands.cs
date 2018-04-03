using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problem2
{
    class p02Commands
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            string command = Console.ReadLine();
            List<string> allCommands = new List<string>();
            while (command != "print")
            {
                allCommands.Add(command);
                command = Console.ReadLine();
            }
            List<string> space = new List<string>();
            int el = 0;
            for (int i = 0; i < allCommands.Count; i++)
            {
                space = allCommands[i].Split(' ').ToList();
                string komanda = space[0];
                if (komanda == "push")
                {
                    el = int.Parse(space[1]);
                    numbers.Add(el);

                }
                else
                {
                    if (komanda == "pop")
                    {
                        el = numbers[numbers.Count - 1];
                        Console.WriteLine(el);
                        numbers.Remove(el);
                    }
                    else
                    {
                        if (komanda == "shift")
                        {
                            el = numbers[numbers.Count - 1];
                            numbers[numbers.Count - 1] = numbers[0];
                            numbers[0] = el;

                        }
                        else
                        {
                            if (komanda == "addMany")
                            {
                                el = int.Parse(space[1]);
                                List<int> addmany = new List<int>();
                                for (int j = 2; j < space.Count; j++)
                                {
                                    addmany.Add(int.Parse(space[j]));
                                }
                                if (el > 0 && el < numbers.Count)
                                {
                                    numbers.InsertRange(el, addmany);
                                }
                            }
                            else
                            {
                                if (komanda == "remove")
                                {
                                    el = int.Parse(space[1]);
                                    if (el > 0 && el < numbers.Count)
                                    {
                                        numbers.RemoveAt(el);
                                    }
                                }
                            }
                        }
                    }
                }
            }
            numbers.Reverse();
            Console.WriteLine(string.Join(", ", numbers));
        }

    }
}


