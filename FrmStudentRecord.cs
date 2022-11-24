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

namespace ReadingAFile_ChallengeExer
{
    public partial class FrmStudentRecord : Form
    {
        public FrmStudentRecord()
        {
            InitializeComponent();
        }

        void DisplayToList()
        {
            openFileDialog1.InitialDirectory = @"MyDocuments";
            openFileDialog1.Title = "Browse Text File";
            openFileDialog1.DefaultExt = ".txt";
            openFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialog1.ShowDialog();

            string path = openFileDialog1.FileName;
            using (StreamReader streamReader = File.OpenText(path))
            {
                string _getText = "";
                while ((_getText = streamReader.ReadLine()) != null)
                {
                    Console.WriteLine(_getText);
                    lvViewRecord.Items.Add(_getText);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmRegistration reg = new FrmRegistration();
            reg.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DisplayToList();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            lvViewRecord.Clear();
            MessageBox.Show("Successfully Uploaded!");
        }
    }
}
