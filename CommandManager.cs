using System;
using System.Collections.Generic;
using System.Text;

namespace cowsay
{
    class CommandManager
    {
        public void Sprejem(String ukaz)
        {
            if (ukaz.Equals("help"))
            {
                Console.WriteLine("This is a recreation of cowsay command from linux.\n" +
                    "Format goes as follows:\n" +
                    "Message [switch] or in the case of -e Message [switch] [eye simbol]\n"+
                    "-b | borg eyes\n" +
                    "-d | dead\n" +
                    "-g | gready\n" +
                    "-p | paranoid\n" +
                    "-s | stoned\n" +
                    "-t | sleapy\n" +
                    "-w | wired\n" +
                    "-y | youth\n" +
                    "-e | folow it with a simbol you want for eyes");
            }
            else
            {
                String[] ukazi = ukaz.Split('-');
                String msg;
                String eye;
                switch (ukazi.Length)
                {
                    case 1:
                        msg = ukazi[0];
                        Output(msg);
                        break;
                    case 2:
                        msg = ukazi[0];
                        eye = ukazi[1];
                        switch (eye)
                        {
                            case "b":
                                eye = "=";
                                break;
                            case "d":
                                eye = "x";
                                break;
                            case "g":
                                eye = "$";
                                break;
                            case "p":
                                eye = "@";
                                break;
                            case "s":
                                eye = "*";
                                break;
                            case "t":
                                eye = "-";
                                break;
                            case "w":
                                eye = "O";
                                break;
                            case "y":
                                eye = ".";
                                break;
                            default:
                                break;
                        }
                        if (eye.StartsWith("e"))
                        {
                            String[] ceye = eye.Split(' ');
                            eye = ceye[1];
                        }
                        Output(msg, eye);
                        break;
                }

            }


        }
        void Output(String msg, String eye = "o")
        {
            Console.Write(" ");
            for (int i = 0; i < (msg.Length + 2); i++)
            {
                Console.Write($"_");
            }
            Console.WriteLine($"\n< {msg} >");
            Console.Write(" ");
            for (int i = 0; i < (msg.Length + 2); i++)
            {
                Console.Write($"-");
            }
            Console.WriteLine($"\n        \\   ^__ ^" +
                $"\n         \\  ({eye}{eye})\\_______\n            (__)\\       )\\/\\" +
                $"\n                || ----w |\n                ||     || ");
        }
    }
}