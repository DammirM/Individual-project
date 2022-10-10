using System;
using System.Numerics;


namespace Individual_project
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.Title = "Bankaccount";
            //Console.WriteLine("Welcome to SpaceBank!");




            //// 2D Array with UsersLogin
            //string[,] Users = UserArray();


            // Array with User account info

            //            Personkonto -        Lön       -      Spar       
            decimal[] Damir   = { 100.50M,     50, }; 
            decimal[] Banan   = { 323.99M,     549.90M,         678.99M,};
            decimal[] Åpple   = { 8199,        2999,};
            decimal[] Päron   = { 345.78M,     66};
            decimal[] Apelsin = { 99.34M};


            Console.WriteLine(Damir[0]); 
            Console.WriteLine("Lönekonto " + Damir[1]);
            decimal peng = Damir[0] + Damir[1];
            Console.WriteLine(peng);
            Console.WriteLine("lönkonto överföring till personkonto");
            decimal hihi = decimal.Parse(Console.ReadLine());








            //            // User Login
            //            CheckUser(Users);








            Console.WriteLine("1. Se dina konton och saldo");
            Console.WriteLine("2. Överföring mellan konton");
            Console.WriteLine("3. Ta ut Pengar");
            Console.WriteLine("4. Logga ut");

            int uChoice = int.Parse(Console.ReadLine());


            switch(uChoice) {

                case 1:
                    {
                        Console.WriteLine("Saldo o konto");
                    }
                    break;
                case 2:
                    Console.WriteLine("vilket konto vill du föra över mellan");
                    break;
                case 3:
                    Console.WriteLine("hur mycket vill du ta ut:");
                    break;
                case 4:
                    Console.WriteLine("vi ses åter =)");
                    break;

            }

            Console.WriteLine( "P""L""S")

            Console.ReadKey();
                }

        //        public static void CheckUser(string[,] Users)
        //        {
        //            int guess = 0;
        //            bool account = false;

        //            while (account == false && guess < 3)
        //            {


        //                // Take Userlogin
        //                Console.WriteLine("Enter your username: ");
        //                string login = Console.ReadLine();
        //                Console.WriteLine("Enter your PIN 4 digits: ");
        //                string Pin = Console.ReadLine();

        //                guess++;


        //                // Check userLogin
        //                if (login == Users[0, 0] && Pin == Users[0, 1])
        //                {
        //                    Console.WriteLine("Welcome Damir");
        //                    account = true;
        //                }


        //                else if (login == Users[1, 0] && Pin == Users[1, 1])
        //                {
        //                    Console.WriteLine("Welcome Banan");
        //                    account = true;



        //                }


        //                else if (login == Users[2, 0] && Pin == Users[2, 1])
        //                {
        //                    Console.WriteLine("Welcome Äpple");
        //                    account = true;
        //                }


        //                else if (login == Users[3, 0] && Pin == Users[3, 1])
        //                {
        //                    Console.WriteLine("Welcome Päron");
        //                    account = true;
        //                }


        //                else if (login == Users[4, 0] && Pin == Users[4, 1])
        //                {
        //                    Console.WriteLine("Welcome Apelsin");
        //                    account = true;
        //                }
        //                else if (guess == 3)
        //                {
        //                    Console.WriteLine("3 failed attempts program shuts down");

        //                }
        //                else
        //                    Console.WriteLine("try again");

        //            }
        //        }

        //        public static string[,] UserArray()
        //        {
        //            string[,] Users = new string[5, 2];
        //            {

        //                Users[0, 0] = "Damir"; Users[0, 1] = "1234";
        //                Users[1, 0] = "Banan"; Users[1, 1] = "2345";
        //                Users[2, 0] = "Äpple"; Users[2, 1] = "3456";
        //                Users[3, 0] = "Päron"; Users[3, 1] = "4567";
        //                Users[4, 0] = "Apelsin"; Users[4, 1] = "5678";

        //            };
        //            return Users;
    }


}

