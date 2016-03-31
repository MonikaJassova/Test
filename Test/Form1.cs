using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            comboBox1.Items.Add("zbernicova");
            comboBox1.Items.Add("mesh");
            comboBox1.Items.Add("hviezdicova");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int result=checkAnswers();
            lblResult.Text = "Pocet spravnych odpovedi: " + result;
        }

        //skontrolovanie odpovedi
        public int checkAnswers()
        {
            int pocet = 0;

            string odpoved=textBox1.Text;
            if (odpoved.ToLower().Equals("arpanet"))
            {
                pocet++;
                label1.ForeColor = Color.Green;
            }
            else
                label1.ForeColor = Color.Red;

            if (radioButton1.Checked == true)
            {
                pocet++;
                label2.ForeColor = Color.Green;
            }
            else
                label2.ForeColor = Color.Red;

            if (checkBox1.Checked==true && checkBox2.Checked==true && 
                checkBox3.Checked==false && checkBox4.Checked == false)
            {
                pocet++;
                label3.ForeColor = Color.Green;
            }
            else
                label3.ForeColor = Color.Red;

            if (radioButton4.Checked == true)
            {
                pocet++;
                label4.ForeColor = Color.Green;
            }
            else
                label4.ForeColor = Color.Red;

            string datum = dateTimePicker1.Value.ToShortDateString();
            if (datum== "1.1.1970")
            {
                pocet++;
                label6.ForeColor = Color.Green;
            }
            else
                label6.ForeColor = Color.Red;

            if (comboBox1.Text.ToString().Equals("hviezdicova"))
            //if (listBox1.Text == "hviezdicova")
            {
                pocet++;
                label5.ForeColor = Color.Green;
            }
            else
                label5.ForeColor = Color.Red;

            return pocet;
        }
    }
}
