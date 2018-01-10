using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store_and_Scramble_Message
{
    class Program
    {
        public static object random { get; private set; }

        static void Main(string[] args)
        {
            /* This program allows users to enter either a message or request a message via ID. Users should be given 
             * a prompt to chose to enter or retrieve a message. If users enter a message, the ID of that message 
             * should be returned. If an ID is entered under retrieve, the message should be displayed.
             * 
             * Please encrypt all messages when they are stored. When the user requests a message, you must decrypt it
             * when showing it to them.
           
             * What would you like to do? a) enter message, b) retrieve message, or c) quit?
             * a
             * Enter your message.
             * "This is my message."
             * Your ID is 0
             * What would you like to do? a) enter message, b) retrieve message, c) quit?
             * b
             * Enter your ID
             * 0
             * Your message is: This is my message.
             */

            string[] responses = new string[10];
            responses[0] = "Your message ID number is 0.";
            responses[1] = "Your message ID number is 1.";
            responses[2] = "Your message ID number is 2.";
            responses[3] = "Your message ID number is 3.";
            responses[4] = "Your message ID number is 4.";
            responses[5] = "Your message ID number is 5.";
            responses[6] = "Your message ID number is 6.";
            responses[7] = "Your message ID number is 7.";
            responses[8] = "Your message ID number is 8.";
            responses[9] = "Your message ID number is 9.";

            string[] messages = new string[10];

            int IDnum = 0;
            string choice = "";
            
            //could do while (true) instead of the line below - would then need to make bool keepLooping = true; and while (keepLooping) 
            while (IDnum <= 10 || choice == "a" || choice == "b" || choice == "d")
            {
                Console.WriteLine("Would you like to a) store a message, b) retrieve a message, c) exit, or d) show all messages?");
                choice = Console.ReadLine();

                if (choice == "a")
                {
                    Console.WriteLine("Enter the message you would like to store.");
                    messages[IDnum] = Console.ReadLine();

                    //encrypt/alter message
                    string encryptedMessage = ""; 
                    for (int k = 0; k < messages.Length; k++)
                    {
                        encryptedMessage = encryptedMessage + Convert.ToChar(messages[k]+5); 
                    }

                    Console.WriteLine(encryptedMessage);
                    IDnum++;
                }

                if (choice == "b")
                {
                    Console.WriteLine("What message ID would you like to see?");
                    int IDentered = Convert.ToInt32(Console.ReadLine());

                    //to do the decryption
                    string decryptedMessage = "";
                    for (int k = 0; k < messages[IDentered].Length; k++)
                    {
                        decryptedMessage = decryptedMessage + (char)(messages[IDentered][k] - 5); 
                    }

                    Console.WriteLine(messages[IDentered]);
                }

                if (choice == "c")
                {
                    //this is where you would put keepLooping = false; instead of the line below to go with the above comment
                    IDnum = 11;
                    Console.WriteLine("The program is over.");
                }

                if (choice == "d") 
                {
                    for (int i = 0; i < messages.Length; i++)
                    {
                        Console.WriteLine(i + ": " + messages[i]); 
                    }
                    
                }
            }
            Console.ReadLine();      
        }
    }
}
