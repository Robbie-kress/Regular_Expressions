using System;
using System.Text.RegularExpressions;

namespace Regular_Expressions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(GetNames());
            Console.WriteLine(GetEmail());
            Console.WriteLine(GetPhoneNumber());
            Console.WriteLine(GetBirthDate());
           // Console.WriteLine(ContinuePrompt());
           // any tips for getting this to work would be greatly appreciated
           
        }



        public static string GetNames()
        {
            Console.WriteLine("Please enter a name");
            string input = Console.ReadLine();
            if (Regex.IsMatch(input, @"\b[A-Z][a-z]{1,30}\b"))
            {
                string name = "Name input accepted";
                return name;
            }
            else
            {
                string notname = "Name input not accepted";
                return notname;
            }


        }
        public static string GetEmail()
        {
            Console.WriteLine("Please input your email! ");
            string input2 = Console.ReadLine();
            if (Regex.IsMatch(input2, @"\b([A - z]{ 5,30})@[A-z]{ 5,10}.[A-z]{ 2,3}\b"))
            {
                string email = "Thank you for putting in your email";
                return email;
            }
            else //(Regex.IsMatch(input2, @"\b([a-z]{5,30})@[a-z]{5,10}.[A-z]{2,3}\b"))
            {
                string email2 = "That is an invalid input ";
                return email2;
            }
        }

        public static string GetPhoneNumber()
        {
            Console.WriteLine("Now input your phone number ");
            string input3 = Console.ReadLine();
            if (Regex.IsMatch(input3, @"\b[0-9]{3}[-][0-9]{3}[-][0-9]{4}\b"))
            {
                string phoneNumber = "Thank you for inputing phone number";
                return phoneNumber;
            }
            else
            {
                string phoneNumber2 = "Invalid phone number entered";
                return phoneNumber2;
            }
        }



        public static string GetBirthDate()
        {
            Console.WriteLine("Now enter birthdate for final authorization ");
            string input4 = Console.ReadLine();
            if (Regex.IsMatch(input4, @"^(0[1-9]|1[012])[-/.](0[1-9]|[12][0-9]|3[01])[-/.](19|20)\\d\\d$"))
            {
                string birthDate = "Thank you for inputing your birthdate";
                return birthDate;
            }
            else
            {
                string birthDate2 = "Incorrect input for birthdate";
                return birthDate2;
            }

        }

        //public static string ContinuePrompt()
        //{
        //    Console.WriteLine("would you like to contintue (y/n):");
        //    Console.ReadLine();
        //    string cont = "y";
        //    string cont2 = "n";
        //    //while (cont == "y")
        //    while (cont == "(y/n)")
        //    {

        //        if (cont == "y")

        //        {
        //            return cont;
        //        }
        //        else if (cont2 == "n")
        //        {
        //           break;

        //        }
               
        //    }
        //    return cont;


            
        }
    }

}
