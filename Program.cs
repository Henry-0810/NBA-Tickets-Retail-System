﻿using System;

using System.Windows.Forms;
using System.Data;
using Oracle.ManagedDataAccess.Client;

namespace NBA_Tickets_Retail
{
    internal static class Program
    {
        private static OracleConnection conn;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //When system shuts down
            Application.ApplicationExit += new EventHandler(OnSysExit);

            const String oradb = "Data Source = oracle/orcl; User Id = T00229172; Password = fe4_Tdeegee6;";
            conn = new OracleConnection(oradb);
            conn.Open();
            MessageBox.Show("Database Connection status is " + conn.State.ToString(), "Connection State", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmMainMenu());
          
        }

        private static void OnSysExit(object sender, EventArgs e)
        {
            if (conn.State == ConnectionState.Open) conn.Close();
        }

        public static OracleConnection getOracleConnection()
        {
            return conn;
        }
    }
}
