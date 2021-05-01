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

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        StreamWriter writer = new StreamWriter("file.txt");
        DataTable table;
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            table = new DataTable();
            table.Columns.Add("title", typeof(String));
            table.Columns.Add("Message", typeof(String));

            dataGridView1.DataSource = table;

            dataGridView1.Columns["Message"].Visible = false;
            dataGridView1.Width = 100;

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonNew_Click(object sender, EventArgs e)
        {
            textName.Clear();
            textNote.Clear();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            table.Rows.Add(textName.Text, textNote.Text);

            textName.Clear();
            textNote.Clear();
        }

        private void buttonRead_Click(object sender, EventArgs e)
        {
            int index = dataGridView1.CurrentCell.RowIndex;

            if(index > - 1)
            {
                textName.Text = table.Rows[index].ItemArray[0].ToString();
                textNote.Text = table.Rows[index].ItemArray[1].ToString();
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            int index = dataGridView1.CurrentCell.RowIndex;

            table.Rows[index].Delete();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        
        private void saveFileButton_Click(object sender, EventArgs e)
        {
            int i = 0;
            while (i < table.Rows.Count)
            {
                writer.Write(table.Rows[i].ItemArray[0].ToString());
                writer.Write(" : ");
                writer.Write(table.Rows[i].ItemArray[1].ToString());
                writer.WriteLine();
                ++i;
            }
            writer.Close();
        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

       
    }
}
