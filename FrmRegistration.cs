using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ReadingAFile_ChallengeExer
{
    public partial class FrmRegistration : Form
    {
        public static string SetFileName;
        public FrmRegistration()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            SetFileName = txtStudentNo.Text + ".txt";

            string getStudentNo = "Student No.: " + txtStudentNo.Text;
            string getFullName = "FullName No.: " + txtLastName.Text + " " + txtFirstName.Text + " " + txtMI.Text;
            string getProgram = "Program: " + cbProgram.Text;
            string getGender = "Gender: " + cbGender.Text;
            string getAge = "Age: " + txtAge.Text;
            string getBirthday = "Birthday: " + dtpBirthday.Text;
            string getContactNo = "Contact No.: " + txtContactNo.Text;


            string docPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            using (StreamWriter outputFile = new StreamWriter(Path.Combine(docPath,
            SetFileName)))
            {
                outputFile.WriteLine(getStudentNo);
                Console.WriteLine(getStudentNo);
                outputFile.WriteLine(getFullName);
                Console.WriteLine(getFullName);
                outputFile.WriteLine(getProgram);
                Console.WriteLine(getProgram);
                outputFile.WriteLine(getGender);
                Console.WriteLine(getGender);
                outputFile.WriteLine(getAge);
                Console.WriteLine(getAge);
                outputFile.WriteLine(getBirthday);
                Console.WriteLine(getBirthday);
                outputFile.WriteLine(getContactNo);
                Console.WriteLine(getContactNo);
            }
        }

        private void btnRecords_Click(object sender, EventArgs e)
        {
            FrmStudentRecord record = new FrmStudentRecord();
            record.Show();
            this.Close();
        }
    }
}
