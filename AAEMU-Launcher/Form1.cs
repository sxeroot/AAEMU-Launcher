using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AAEMU_Launcher
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void start_BTN_Click(object sender, EventArgs e)
        {
            bool flag = false;
            if (userList.SelectedItems.Count != 0)
            {
                flag = true;
            }
            if(acc_save.Checked == true)
            {
                Program.saveAccount(username.Text, password.Text);
            }

            Program.startGame(username.Text, password.Text, flag);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void password_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                start_BTN_Click(sender, e);

                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void settings_BTN_Click(object sender, EventArgs e)
        {
            Options opts = new Options();
            opts.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            if (!Program.archexeCheck())
            {
                Options opts = new Options();
                opts.ShowDialog();
            }

            Program.getAccounts(userList);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Program.getAccounts(userList);
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void userList_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (userList.SelectedItems.Count != 0 && e.Button == MouseButtons.Left)
            {

                username.Text = userList.SelectedItems[0].Text;
                password.Text = userList.SelectedItems[0].SubItems[1].Text;
                acc_save.Checked = false;
                acc_save.Enabled = false;

                start_BTN_Click(sender, e);
                
            }
        }

        private void userList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (userList.SelectedItems.Count != 0)
            {
                username.Text = userList.SelectedItems[0].Text;
                password.Text = userList.SelectedItems[0].SubItems[1].Text;
                acc_save.Checked = false;
                acc_save.Enabled = false;
                username.Enabled = false;
                password.Enabled = false;
                panel2.BackColor = Color.Transparent;
                panel3.BackColor = Color.Transparent;

            }
            else
            {
                username.Text = "";
                password.Text = "";
                acc_save.Checked = false;
                acc_save.Enabled = true;
                username.Enabled = true;
                password.Enabled = true;
                panel2.BackColor = Color.White;
                panel3.BackColor = Color.White;
            }
        }
        

        private void clearSelectionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            userList.SelectedItems.Clear();
        }

        private void removeAccountToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Program.removeSave(userList.SelectedItems[0].Text);
            userList.SelectedItems[0].Remove();
        }
    }
}
