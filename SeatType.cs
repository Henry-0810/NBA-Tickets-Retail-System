﻿

using Oracle.ManagedDataAccess.Client;
using System.Collections.Generic;

namespace NBA_Tickets_Retail
{
    class SeatType
    {
        private string _TypeCode;
        private string _description;
        private double _price;
        //My seat types in database
        //LLS - Lower-Level Sideline, ideal angle for game action - 250 - 10
        //CS - Courtside, expensive but nearest to the players - 800 - 10
        //CL - Club-Level seats, exclusive lounges, bars - 950 - 10
        //UPS - Upper-Level Sideline, budget but elegant - 150 - 10
        //BTB - Behind the basket, best seats for families - 200 - 10

        public SeatType( string typeCode, string description, double price)
        {
            TypeCode = typeCode;
            Description = description;
            Price = price;
        }
        public string TypeCode { get => _TypeCode; set => _TypeCode = value; }
        public string Description { get => _description; set => _description = value; }
        public double Price { get => _price; set => _price = value; }

        public override string ToString()
        {
            return "Type Code: " + TypeCode + "\nDescription: " + Description + "\nPrice: " + Price;
        }

        public void AddSeatType()
        {
            OracleConnection conn = Program.getOracleConnection();

            string sqlQuery = $"INSERT INTO SeatTypes (Type_Code, Description, Price) Values ('{this.TypeCode}'," +
                $"'{this.Description}',{this.Price})";

            OracleCommand cmd = new OracleCommand(sqlQuery, conn);

            cmd.ExecuteNonQuery();
        }
        public void UpdateSeatType()
        {
            OracleConnection conn = Program.getOracleConnection();

            string sqlQuery = $"UPDATE SeatTypes SET Description = '{this.Description}',Price = {this.Price} " +
                $"WHERE Type_Code = '{this.TypeCode}'";

            OracleCommand cmd = new OracleCommand(sqlQuery, conn);

            cmd.ExecuteNonQuery();
        }

        public static void getAllSeatTypes(ref List<string> allSeatTypes)
        {
            allSeatTypes = new List<string>();
            OracleConnection conn = Program.getOracleConnection();

            string sqlQuery = "SELECT Type_Code FROM SeatTypes";

            OracleCommand cmd = new OracleCommand(sqlQuery, conn);

            OracleDataReader dr = cmd.ExecuteReader();

            while (dr.Read() && !dr.IsDBNull(0))
            {
                string seatType = dr.GetString(0);

                allSeatTypes.Add(seatType);
            }

            dr.Close();
        }
    }
}