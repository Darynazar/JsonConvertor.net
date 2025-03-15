using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Json.Models.NodeJson
{
    public class Row
    {
        public Competitor Competitor { get; set; }
        public int GamePlayed { get; set; }
        public int GamesWon { get; set; }
        public int GamesLost { get; set; }
        public int GamesEven { get; set; }
        public int For { get; set; }
        public int Against { get; set; }
        public double Ratio { get; set; }
        public double Points { get; set; }
        public int Strike { get; set; }
        public int GamesOT { get; set; }
        public int GamesWonOnOT { get; set; }
        public int GamesWonOnPen { get; set; }
        public int GamesLossOnOT { get; set; }
        public int GamesLossOnPen { get; set; }
        public string Pct { get; set; }
        public int Position { get; set; }
        public int Trend { get; set; }
        public List<DetailedRecentForm> DetailedRecentForm { get; set; }
        public NextMatch NextMatch { get; set; }
        public List<int> RecentForm { get; set; }
        public int DestinationNum { get; set; }
        public double Ppg { get; set; }
        public double Oppg { get; set; }
    }
}
