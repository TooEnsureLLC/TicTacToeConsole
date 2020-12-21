using System;

namespace TicTacToe
{
    class Program
    {
        static void Main(string[] args)
        {
            GamePlaySession gamePlaySession = new GamePlaySession();
            do
            {
                gamePlaySession.GameDisplay();
                if (gamePlaySession.CurrentPlayer == gamePlaySession.Player1)
                {
                    gamePlaySession.PlayTurn(gamePlaySession.Player1);
                } else
                {
                    gamePlaySession.PlayTurn(gamePlaySession.Player2);
                }
                

            } while (!gamePlaySession.GameOver);
        }
    }
}
