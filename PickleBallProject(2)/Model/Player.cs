using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace PickleBallProject_2_.Model
{
    [ObservableObject]
    public partial class Player
    {
        private string FullName;

        private double DuprScore = 2.0;
      
        private int Wins = 0;

        private int losses = 0;
        private List<Match> MatchHistory = new List<Match>();              

        public Player(string fullName) //constructor 
        {
            this.FullName = fullName;
        }

        public void loss()
        {
            losses++;
         
            if (DuprScore > 2.0)
            {
                DuprScore -= .2;
            }
        }

        public void Win()
        {
            Wins++;

            if (DuprScore < 8.0)
            {
                DuprScore += .2;
            }
        }
        public void UpdateMatchHistory(Match Match)
        {
            MatchHistory.Add(Match);
        }

        public void DisplayStats()
        {
            Console.WriteLine($"The current stats for {FullName}");
            Console.WriteLine($"The Dupr Score is {DuprScore}");
            Console.WriteLine($"With {Wins} and {losses}");
            
        }
        



    }
}
