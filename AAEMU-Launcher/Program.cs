using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AAEMU_Launcher
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }

        public static void startGame(string username, string password, bool flag)
        {
            if(username == "")
            {
                MessageBox.Show("Username can not be empty!");
                return;
            }
            if (password == "")
            {
                MessageBox.Show("Password can not be empty!");
                return;
            }

            string host = Properties.Settings.Default.host;
            int port = Properties.Settings.Default.port;
            bool splash = Properties.Settings.Default.splash;
            string gamepath = Properties.Settings.Default.gamepath;
            if (gamepath != "") { gamepath += @"\"; }

            string token = password;
            if (flag == false)
            {
                token = CreatePass(password);
            }
            else
            {
                updateTimestamp(username);
            }

            var args = "";
            if (splash == true)
            {
                args += "-nosplash";
            }

            using (var game = new Process())
            {
                var info = new ProcessStartInfo(@""+ gamepath + "archeage.exe");
                info.Arguments = string.Format(args + " -r +auth_ip "+ host + ":"+ port +" -uid "+ username +" -token "+ token +" +acpxmk");
                info.Verb = "runas"; //admin
                game.StartInfo = info;
                game.Start();
            }
            


        }

        public static string CreatePass(string input)
        {
            byte[] data = Encoding.Default.GetBytes(input);
            var result = new SHA256Managed().ComputeHash(data);
            return BitConverter.ToString(result).Replace("-", "").ToLower();
        }

        public static string LocateEXE(String filename)
        {
            String path = Environment.GetEnvironmentVariable("path");
            String[] folders = path.Split(';');
            foreach (String folder in folders)
            {
                if (File.Exists(folder + filename))
                {
                    return folder + filename;
                }
                else if (File.Exists(folder + "\\" + filename))
                {
                    return folder + "\\" + filename;
                }
            }

            return String.Empty;
        }

        public static string CreateMD5(string input)
        {
            // Use input string to calculate MD5 hash
            using (System.Security.Cryptography.MD5 md5 = System.Security.Cryptography.MD5.Create())
            {
                byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(input);
                byte[] hashBytes = md5.ComputeHash(inputBytes);

                // Convert the byte array to hexadecimal string
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < hashBytes.Length; i++)
                {
                    sb.Append(hashBytes[i].ToString("X2"));
                }
                return sb.ToString();
            }
        }

        public static bool archexeCheck()
        {
            string gamepath = Properties.Settings.Default.gamepath;
            if (gamepath != "") { gamepath += @"\"; }
            string archexe = @"" + gamepath + "archeage.exe";

            if (!File.Exists(archexe))
            {
                return false;
            }

            return true;
        }

        public static void getAccounts(ListView lv)
        {
            //istView lv = new ListView();

            SQLiteConnection m_dbConnection;

            m_dbConnection = new SQLiteConnection("Data Source=data.db;Version=3;");
            m_dbConnection.Open();

            string sql = "select * from accounts order by timestamp DESC";
            SQLiteCommand command = new SQLiteCommand(sql, m_dbConnection);

            
            

            SQLiteDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                var item = new ListViewItem(reader["username"].ToString());
                item.ImageKey = "user.png";
                item.SubItems.Add(reader["token"].ToString());
                lv.Items.Add(item);
            }

            m_dbConnection.Close();
        }

        public static void saveAccount(string username, string password)
        {
            SQLiteConnection m_dbConnection;

            m_dbConnection = new SQLiteConnection("Data Source=data.db;Version=3;");
            m_dbConnection.Open();

            string token = CreatePass(password);

            string sql = "insert into accounts (username, token) values ('"+ username +"', '"+ token +"')";
            SQLiteCommand command = new SQLiteCommand(sql, m_dbConnection);
            command.ExecuteNonQuery();

            m_dbConnection.Close();
        }


        private static void updateTimestamp(string username)
        {
            SQLiteConnection m_dbConnection;

            m_dbConnection = new SQLiteConnection("Data Source=data.db;Version=3;");
            m_dbConnection.Open();

            Int32 unixTimestamp = (Int32)(DateTime.UtcNow.Subtract(new DateTime(1970, 1, 1))).TotalSeconds;

            string sql = "UPDATE accounts SET timestamp = '"+ unixTimestamp + "' WHERE username = '"+ username +"'";
            SQLiteCommand command = new SQLiteCommand(sql, m_dbConnection);
            command.ExecuteNonQuery();

            m_dbConnection.Close();
        }

        public static void removeSave(string username)
        {
            
            SQLiteConnection m_dbConnection;

            m_dbConnection = new SQLiteConnection("Data Source=data.db;Version=3;");
            m_dbConnection.Open();
            

            string sql = "DELETE FROM accounts WHERE username = '" + username + "'";
            SQLiteCommand command = new SQLiteCommand(sql, m_dbConnection);
            command.ExecuteNonQuery();

            m_dbConnection.Close();
        }
    }
}
