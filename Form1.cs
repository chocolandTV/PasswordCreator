using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows;

namespace PasswortErsteller
{
    public partial class Form1 : Form
    {
        private static Random randomizer = new Random();
        string passwort = "";
        private static string PasswortGen(int length)
        {
            const string chars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789!§$%&/()=?*@#,.";
            return new string(Enumerable.Repeat(chars, length)
                .Select(s => s[randomizer.Next(s.Length)]).ToArray());
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //ausgabe passwort (int Passwortlaenge)
            passwort = PasswortGen((this.Passwortlaenge.Value + 1) * 6);
            passwordField.Text = passwort;
            passwordField.Focus();
            passwordField.SelectAll();
        }

        private void Passwortlaenge_Scroll(object sender, EventArgs e)
        {
            switch (this.Passwortlaenge.Value)
            {
                case 0:this.trackBarText.Text = "6";break;
                case 1:this.trackBarText.Text = "12";break;
                case 2:this.trackBarText.Text = "18";break;
                case 3:this.trackBarText.Text = "24";break;
                case 4:this.trackBarText.Text = "30";break;
                default:Console.WriteLine("Default case");break;
            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(passwort);
        }
    }
}
