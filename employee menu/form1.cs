using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ics
{
    public partial class Form1 : Form
    {
        class Employee
        {
            private int IDNumber;
            private string FN;
            private string LN;
            private double ASalary;
            private string StartDate;
            public int iDNumber
            {
                get { return IDNumber; }
                set { IDNumber = value; }
            }
            public string fN
            {
                get { return FN; }
                set { FN = value; }
            }
            public string lN
            {
                get { return LN; }
                set { LN = value; }
            }
            public double aSalary
            {
                get { return ASalary; }
                set { ASalary = value; }
            }
            public string startDate
            {
                get { return StartDate; }
                set { StartDate = value; }
            }
        }
        List<Employee> empL = new List<Employee>();
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void LnameText_TextChanged(object sender, EventArgs e)
        {

        }

        private void annualSalaryTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void startDateTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            Employee employee = new Employee();
            employee.iDNumber = int.Parse(textBox1.Text);
            employee.fN = textBox2.Text;
            employee.lN = LnameText.Text;
            employee.aSalary = double.Parse(annualSalaryTxt.Text);
            employee.startDate = startDateTxt.Text; 
            empL.Add(employee);
            textBox1.Clear();
            textBox2.Clear();
            LnameText.Clear();
            annualSalaryTxt.Clear();
            startDateTxt.Clear();

        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            if(empL.Count == 0)
            {
                MessageBox.Show("The List is Empty");
            }
            else
            {
                int IDinp = int.Parse(textBox1.Text);
                string FNinp = textBox2.Text;
                string LNinp = LnameText.Text;
                double salInp = double.Parse(annualSalaryTxt.Text);
                string startDateInp = startDateTxt.Text;
                for (int i = empL.Count - 1; i >= 0; i--)
                {
                    if (empL[i].iDNumber == IDinp && empL[i].fN == FNinp && empL[i].lN == LNinp && empL[i].aSalary == salInp && empL[i].startDate == startDateInp)
                    {
                        empL.RemoveAt(i);
                    }
                }
                MessageBox.Show("Removed successfully");
            }
            
            
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void ListBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void DisplayButton_Click(object sender, EventArgs e)
        {
            ListBox.Clear();
            foreach(Employee employee in empL)
            {
                ListBox.AppendText(employee.fN);
                ListBox.AppendText(Environment.NewLine);
            }
        }
    }
}
