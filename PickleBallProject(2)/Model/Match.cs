using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace PickleBallProject_2_.Model
{
    public class Match
    {
        static int NextGameNum = 1;                             //Keeps track of which match objects

        private int GameNum;

        private int[] FinalScore = new int[2];

        private Player[] players = new Player[2]; 

        private Player Winner;
        private Player Loser;

        public Match (Player player1 , Player player2)     //this is where a match is created (Constructor)
        {
            players[0] = player1; 
            players[1] = player2;
            GameNum = NextGameNum;
            NextGameNum++;
        }
        public void Playmatch()                             //calls GENERATEFINALSCORE to assign winner and loser to players
        {
            int[] Score = new int[2];
            Score = GenerateFinalScore();

            if (Score[0] > Score[1])
            {
                Winner = players[0];
                Loser = players[1];
            }
            else
            {
                Winner = players[1];
                Loser = players[0];
            }
            UpdateStats();
        }

        private int[] GenerateFinalScore()  //generates a random number for both players scores to determine winner/loser
        {
            Random rand = new Random();
            int[] array = new int[2];

            // Decide which element gets the 11
            if (rand.Next(2) == 0)
            {
                array[0] = 11;
                array[1] = rand.Next(0, 11);
            }
            else
            {
                array[0] = rand.Next(0, 11);
                array[1] = 11;
            }
            return array;
        }

        private void UpdateStats()
        {
            Winner.Win();
            Loser.loss();

            Winner.UpdateMatchHistory(this);
            Loser.UpdateMatchHistory(this);
        }

    }
        
}
