using System;
using System.Collections.Generic;
using System.Text;

namespace TicTacToe
{
    class GamePlaySession
    {
        public int Player1 { get; } = 1;
        public int Player2 { get; } = 2;
        public int CurrentPlayer { get; set; } = 1;

        public bool GameOver { get; set; } = false;

        private int[] slotsFilled = new int[9];


        public string[,] Database { get; set; } = new string[3, 3] 
        {
            { "1", "2", "3" },
            { "4", "5", "6" },
            { "7", "8", "9" }
        };


        public GamePlaySession()
        {
            Console.WriteLine("Game has started");
        }


        // Methods

        public void GameDisplay()
        {
            //Console.BackgroundColor = ConsoleColor.Black;
            //Console.Clear();
            string slot1 = Database[0, 0];
            string slot2 = Database[0, 1];
            string slot3 = Database[0, 2];

            string slot4 = Database[1, 0];
            string slot5 = Database[1, 1];
            string slot6 = Database[1, 2];

            string slot7 = Database[2, 0];
            string slot8 = Database[2, 1];
            string slot9 = Database[2, 2];

            Console.WriteLine($"| {slot1} | {slot2} | {slot3} |");
            Console.WriteLine($"| {slot4} | {slot5} | {slot6} |");
            Console.WriteLine($"| {slot7} | {slot8} | {slot9} |");
        }
        public int InputAsInt()
        {
            string input = Console.ReadLine();
            int userInput = Int32.Parse(input);
            return userInput;
        }
        public void PlayTurn(int id)
        {

            string mark = id == 1 ? "X" : "O";
            Console.WriteLine($"Player {id} enter slot number:");

            switch (InputAsInt())
            {
                case 1:
                    SlotFiller(mark,0, 0);
                    break;
                case 2:
                    SlotFiller(mark,0, 1);
                    break;
                case 3:
                    SlotFiller(mark,0, 2);
                    break;
                case 4:
                    SlotFiller(mark,1, 0);
                    break;
                case 5:
                    SlotFiller(mark,1, 1);
                    break;
                case 6:
                    SlotFiller(mark,1, 2);
                    break;
                case 7:
                    SlotFiller(mark,2, 0);
                    break;
                case 8:
                    SlotFiller(mark,2, 1);
                    break;
                case 9:
                    SlotFiller(mark,2, 2);
                    break;
                default:
                    Console.WriteLine("Game Over");
                    break;
            }
            WinnerCheck(id);
        }

        public void SlotFiller(string mark, int row, int col)
        {

            if (Database[row,col].Equals(mark))
            {
                Console.WriteLine($"Sorry you already marked slot with {Database[row, col]}");

            } else if (Database[row,col].Contains("O")|| Database[row, col].Contains("X"))
            {
                Console.WriteLine($"Sorry slot already marked with {Database[row, col]}");
            }
            else {
                Database[row, col] = mark;
                if(CurrentPlayer == 1)
                {
                    CurrentPlayer++;
                } else
                {
                    CurrentPlayer--;
                }
            }
            
        }
        public void WinnerCheck(int id)
        {
            string mark = id == 1 ? "X" : "O";

            string slot1 = Database[0, 0];
            string slot2 = Database[0, 1];
            string slot3 = Database[0, 2];

            string slot4 = Database[1, 0];
            string slot5 = Database[1, 1];
            string slot6 = Database[1, 2];

            string slot7 = Database[2, 0];
            string slot8 = Database[2, 1];
            string slot9 = Database[2, 2];

            if (slot1.Equals(mark) && slot2.Equals(mark) && slot3.Equals(mark))
            {
                Console.WriteLine($"Game Over player {id} wins");
            }
        }
    }
}
