using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        string regUser;
        byte[] regPass;
        public Form1()
        {
            InitializeComponent();
        }


        private static bool MatchSHA1(byte[] p1, byte[] p2)
        {
            bool result = false;
            if (p1 != null && p2 != null)
            {
                if (p1.Length == p2.Length)
                {
                    result = true;
                    for (int i = 0; i < p1.Length; i++)
                    {
                        if (p1[i] != p2[i])
                        {
                            result = false;
                            break;
                        }
                    }
                }
            }
            return result;
        }

        private static byte[] GetSHA1(string password)
        {
            SHA1CryptoServiceProvider sha = new SHA1CryptoServiceProvider();
            return sha.ComputeHash(System.Text.Encoding.ASCII.GetBytes(password));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            regUser = username.Text;
            regPass = GetSHA1(regPassword.Text);
            //Store username and password in database
            MessageBox.Show("Registered Successfully");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Hash login password
            byte[] hashedPassword = GetSHA1(password.Text);

            //retrieve password from database where username matches

            //Check login hashed password matches the database stored hashed password
            if (MatchSHA1(hashedPassword, regPass))
                MessageBox.Show("Login successful");
            else
                MessageBox.Show("Login Failed");
        }

    }
}
