using System;

namespace Practica_ITLA
{
    internal class Program
    {
        static void Main(string[] args)


        {
            string[] user;
            user = new string[10];
            user[0] = "Pedro";

            while (true)
            {
                Console.WriteLine("Welcome To the user registry\nAre you a new user o would like to create a new user?\n1- New User\n2- Existent User");
                int option = Convert.ToInt32(Console.ReadLine());



                switch (option)
                {

                    case 1:
                        for (int x = 1; x < user.Length; x++)
                        {

                            Console.WriteLine($"Type your Username you would like to register ({x})");
                            user[x] = Console.ReadLine();
                            string verifUsuario = Console.ReadLine();
                            bool verif = Array.IndexOf(user, verifUsuario) >= 0;
                            if (user[x] == null)
                            {
                                if (verif == false)
                                {
                                    user[x] = verifUsuario;
                                    Console.WriteLine($" User{user[x]} not succesfull Registered");
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("User Already Exist");
                                    break;
                                }
                            }

                            else if (user[9] != null)
                            {
                                Console.WriteLine(" There's no more space for new users");
                                break;
                            }

                        }
                        break;

                    case 2:
                        Console.WriteLine("Enter your Username");
                        string userchk = Console.ReadLine();
                        bool chk = Array.IndexOf(user, userchk) >= 0;


                        if (chk)
                        {
                            Console.WriteLine($"Welcome {userchk}");
                        }
                        else
                        {
                            Console.WriteLine(" User not found");


                        }
                        break;


                    default:
                        Console.WriteLine("Option Entered not valid");
                        break;


                }
            }
        }
    }
}



