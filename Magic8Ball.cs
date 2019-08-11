using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1Monday
{
    /// <summary>
    /// Start of Magic 8 Ball to Enter from
    /// </summary>
    class Magic8Ball
    {
        static void Main(string[] args)
        {
            #region Requirements
            /*
             * REQUIREMENTS:
             * 1) Ask the user for their Yes/No question
             * 2) Respong with a random answer from your sete (collection)
             * of answers
             * 3) Set the program to loop based on user choice
             * 
             * Magic 8 Ball Q&A -> Google 
             */
            #endregion
            Console.ReadLine();


            Console.Title = "Juans Magic 8 Ball!!";
            ProgramName();

            //CREATE A RANDOMIZER OBJECT
            //Originally had it inside the while loop
            //However I only want to generate the object once.
            Random randomObject = new Random();

            //Leaving it (true). So I can 
            //keep asking the user more questions
            while (true)
            {
                string invalidQuestionString = UserQuestions();



                if (invalidQuestionString.Length == 0)
                {
                    Console.WriteLine("That is not a questin! Please ask me a real question!");
                    continue; 
                }

                //if the user typed quit " break; " will get out of the while loop
                //" if " ... " quit is typed "
                if (invalidQuestionString.ToLower() == "quit")
                {
                    Console.WriteLine("K, Bye then!");
                    break;
                }

                //Getting a random number
                int randomNumber = randomObject.Next(19);

                //Use random number to determin response
                switch (randomNumber)
                {
                    case 0:
                        {
                            Console.WriteLine("It is certain!");
                            break;
                        }//end case 0
                    case 1:
                        {
                            Console.WriteLine("It is decidedly so!");
                            break;
                        }//end case 1
                    case 2:
                        {
                            Console.WriteLine("Without a doubt!");
                            break;
                        }//end case 2
                    case 3:
                        {
                            Console.WriteLine("Yes - definitely!");
                            break;
                        }//end case 3
                    case 4:
                        {
                            Console.WriteLine("You may rely on it!");
                            break;
                        }//end case 4
                    case 5:
                        {
                            Console.WriteLine("As I see it, yes!");
                            break;
                        }//end case 5
                    case 6:
                        {
                            Console.WriteLine("Most likely!");
                            break;
                        }//end case 6
                    case 7:
                        {
                            Console.WriteLine("Outlook good!");
                            break;
                        }//end case 7
                    case 8:
                        {
                            Console.WriteLine("Yes");
                            break;
                        }//end case 8
                    case 9:
                        {
                            Console.WriteLine("Signs point to yes!");
                            break;
                        }//end case 9
                    case 10:
                        {
                            Console.WriteLine("Reply hazy, try again!");
                            break;
                        }//end case 10
                    case 11:
                        {
                            Console.WriteLine("Ask again later!");
                            break;
                        }//end case 11
                    case 12:
                        {
                            Console.WriteLine("Better not tell you now!");
                            break;
                        }//end case 12
                    case 13:
                        {
                            Console.WriteLine("Cannot predict now!");
                            break;
                        }//end case 13
                    case 14:
                        {
                            Console.WriteLine("Concentrate and ask again!");
                            break;
                        }//end case 14
                    case 15:
                        {
                            Console.WriteLine("Don't count on it!");
                            break;
                        }//end case 15
                    case 16:
                        {
                            Console.WriteLine("My reply is no!");
                            break;
                        }//end case 16
                    case 17:
                        {
                            Console.WriteLine("My sources say no!");
                            break;
                        }//end case 17
                    case 18:
                        {
                            Console.WriteLine("Outlook not so good!");
                            break;
                        }//end case 18
                    case 19:
                        {
                            Console.WriteLine("Very doubtful!");
                            break;
                        }//end case 19
                    default:
                        break;
                }//end switch (randomNumber)

            }//end while


        }//end Main
        /// <summary>
        /// Program Name
        /// </summary>
        static void ProgramName()
        {
            Console.WriteLine("Magic 8 Ball! \n");
        }

        /// <summary>
        /// Users Questions
        /// </summary>
        /// <returns></returns>
        static string UserQuestions()
        {
            //Asks the user for a question + store the question
            //in questionString Variable.
            Console.Write("If you're out of Questions type 'quit'\n");

            Console.Write("\nAsk a question?: ");
            
            string questionString = Console.ReadLine();

            return questionString;
        }//end string

    }//end class
}//end namespace
