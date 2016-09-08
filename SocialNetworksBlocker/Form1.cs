using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace SocialNetworksBlocker
{
    public partial class Form1 : Form
    {
        private string _hosts = Environment.SystemDirectory.ToString() + @"\drivers\etc\hosts";
        public Form1()
        {
            InitializeComponent();
            txtLocalhost.Text = "127.0.0.1";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CopyHostsFile();
            txtDomains.Lines = new string[] { "vk.com", "twitter.com", "leprosorium.ru", "facebook.com" };
        }

        private void CopyHostsFile()
        {
            if (!File.Exists("hosts"))
            {
                File.Copy(_hosts, "hosts");
            }
            else
            {
                File.Delete("hosts");
                File.Copy(_hosts, "hosts");
            }
        }

        private void txtBlock_Click(object sender, EventArgs e)
        {
            List<string> domainslist = new List<string> { };
            foreach (var item in txtDomains.Lines)
            {
                if (item != "")
                {
                    domainslist.Add(string.Format("{0} {1}", txtLocalhost.Text, item));
                }
            }
            File.AppendAllLines(_hosts, domainslist);
            MessageBox.Show("Заблокировано! Можете спокойно работать!");
        }

        private void Unblock()
        {

            if (!File.Exists(_hosts))
            {
                File.Copy("hosts", _hosts);
            }
            else
            {
                File.Delete(_hosts);
                File.Copy("hosts", _hosts);
            }
        }

        private void txtUnblock_Click(object sender, EventArgs e)
        {
            Unblock();
            MessageBox.Show("Разблокировано!");
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (chkRestoreOnClose.Checked)
            {
                Unblock();
            }
        }

        private void chkRestoreOnClose_CheckedChanged(object sender, EventArgs e)
        {
            if (!chkRestoreOnClose.Checked)
            {
                MessageBox.Show("Снимая галочку лучше сделать бекап своего файла hosts!");

            }
        }
    }
}
