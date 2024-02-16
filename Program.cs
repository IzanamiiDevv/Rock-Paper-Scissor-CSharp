using System;
using System.Linq.Expressions;

namespace Game
{
    class Program
    {
        static int score = 0;
        static int escore = 0;

        static void Main(string[] args)
        {
            Start();
        }

        static void Start()
        {
            Console.WriteLine("Pick One: Rock, Paper, Scissor");
            string pick = Console.ReadLine() ?? "Rock";

            string enemyChoice = Enemy();
            Console.WriteLine($"Enemy Choose: {enemyChoice} And You Picked: {pick}");

            DetermineWinner(pick, enemyChoice);
        }

        static string Enemy()
        {
            Random random = new Random();
            int randomNum = random.Next(0,2);
            string picked = "Rock";

            if(randomNum == 0){
                picked = "Paper";
            }else if(randomNum == 1){
                picked = "Scissor";
            }else{
                picked = "Rock";
            }
            return picked;
        }

        static void DetermineWinner(string playerChoice, string enemyChoice)
        {
            if (playerChoice == enemyChoice)
            {
                Console.WriteLine("It's a tie!");
            }
            else if ((playerChoice == "Rock" && enemyChoice == "Scissor") ||
                     (playerChoice == "Paper" && enemyChoice == "Rock") ||
                     (playerChoice == "Scissor" && enemyChoice == "Paper"))
            {
                score++;
                Console.WriteLine($"You win! \n Your Score is:{score}\n Enemy Score is:{escore}");
                Start();
            }
            else
            {
                escore++;
                Console.WriteLine($"You lose! \n Your Score is:{score}\n Enemy Score is:{escore}");
                Start();
            }
        }
    }
}
