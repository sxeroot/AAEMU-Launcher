using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AAEMU_Launcher
{
    public partial class Options : Form
    {
        public Options()
        {
            InitializeComponent();
        }

        private void Options_Load(object sender, EventArgs e)
        {
            hostname.Text = Properties.Settings.Default.host;
            port.Text = Properties.Settings.Default.port.ToString();

            bool splash = Properties.Settings.Default.splash;

            if(splash == false)
            {
                splash_CHK.Checked = false;
            }
            else
            {
                splash_CHK.Checked = true;
            }

            gamepath.Text = Properties.Settings.Default.gamepath;
        }

        private void get_BTN_Click(object sender, EventArgs e)
        {
            using (var folderDialog = new FolderBrowserDialog())
            {
                if (folderDialog.ShowDialog() == DialogResult.OK)
                {
                    gamepath.Text = folderDialog.SelectedPath;
                }
            }
        }

        private void save_BTN_Click(object sender, EventArgs e)
        {
            int prt;
            try
            {
                prt = Int32.Parse(port.Text);
            }
            catch(Exception ex)
            {
                MessageBox.Show("The Port can only be numbers");
                return;
            }
            Properties.Settings.Default.host = hostname.Text;
            Properties.Settings.Default.port = prt;
            Properties.Settings.Default.gamepath = gamepath.Text;
            if (splash_CHK.Checked == false)
            {
                Properties.Settings.Default.splash = false;
            }
            else
            {
                Properties.Settings.Default.splash = true;
            }
            Properties.Settings.Default.Save();
            this.Close();
        }

        private void Options_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!Program.archexeCheck())
            {
                
                DialogResult delq = MessageBox.Show(" Cant find \"archeage.exe\" please check game path.\n Saving without proper game path may cause launcher failure.\n Save as is?", "Missing (archeage.exe)", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (delq == DialogResult.Yes)
                {

                }
                else
                {
                    e.Cancel = true;
                    return;
                }
                    
            }
        }
    }
}
