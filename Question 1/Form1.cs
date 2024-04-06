using Data_Layer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Data_Layer;
using Logic_Layer;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;

namespace Question_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            Agetxt.Text =string.Empty;
            SurnameTextBox.Clear();
            NameTextBox.Clear();
            EmailTxt.Text = string.Empty;
            IDtextBox.Clear();
        }

        private void ReadBtn_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            string allMembers = AccesFile.ReadStaffMembers();

            string[] staffMembersArr = allMembers.Split(new string[] {Environment.NewLine}, StringSplitOptions.RemoveEmptyEntries);

            foreach (string staffMember in staffMembersArr)
            {
                listBox1.Items.Add(staffMember);
            }
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            string name = NameTextBox.Text;
            string surname = SurnameTextBox.Text;
            string IDnumber = IDtextBox.Text;
            string email = EmailGenerator.GenerateEmail(name, surname);
            int age = AgeGenerator.GenerateAge(IDnumber);
            if (true)
            {

                AccesFile.SaveStaffMember($"{name} {surname} {email} {age}");
                MessageBox.Show("Written to File");
            }
            else
            {
                MessageBox.Show("Error writting to file");
            }

        }

        private void CreateBtn_Click(object sender, EventArgs e)
        {
            string name = NameTextBox.Text;
            string IDnumber = IDtextBox.Text;
            string surname = SurnameTextBox.Text;

            EmailTxt.Text = EmailGenerator.GenerateEmail(name, surname);
            int age = AgeGenerator.GenerateAge(IDnumber);
            Agetxt.Text = age.ToString();
        }

        private void SurnameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void NameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void IDtextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
