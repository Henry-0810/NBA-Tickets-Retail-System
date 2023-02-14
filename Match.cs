﻿using Oracle.ManagedDataAccess.Client;
using System;


namespace NBA_Tickets_Retail
{
    class Match
    {
        private int _MatchID;
        private DateTime _matchTime;
        private String _homeTeam;
        private int _awayTeamID;
        private static int count = 0;

        public Match(DateTime matchTime, int awayTeamID)
        {
            MatchID = ++count;
            MatchTime = matchTime;
            HomeTeam = "";
            AwayTeamID = awayTeamID;
        }

        public int MatchID
        {
            get => _MatchID;
            set => _MatchID = value;
        }
        public DateTime MatchTime { get => _matchTime; set => _matchTime = value; }
        public string HomeTeam
        {
            get => _homeTeam;
            set { _homeTeam = "Golden State Warriros"; }
        }
        public int AwayTeamID { 
            get => _awayTeamID; 
            set => _awayTeamID = value; 
        }

        public override string ToString()
        {
            return "MatchID: " + MatchID + "\nMatch Time " + MatchTime + "\nHome Team: " + 
                HomeTeam + "\nAway Team: " + AwayTeamID ;
        }

        public void addMatches()
        {
            OracleConnection conn = Program.getOracleConnection();

            string sqlQuery = "INSERT INTO Matches Values (" + this.MatchID +
                ",'" + this.MatchTime + "', Team_Name FROM Teams WHERE Team_ID = "
                + this.AwayTeamID;

            OracleCommand cmd = new OracleCommand(sqlQuery, conn);

            cmd.ExecuteNonQuery();
        }
    }
}
