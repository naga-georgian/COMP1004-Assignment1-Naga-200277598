using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP1004_Assignment1_Naga_200277598
{
    public partial class SalesBonusForm : Form
    {
        public SalesBonusForm()
        {
            InitializeComponent();
        }

        private void EnglishRadioButton_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void FrancaisRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            EmployeeNameLabel.Text = "Le nom de l'employé";
            EmployeeIDLabel.Text = "Employé ID";
            HoursWorkedLabel.Text = "Heures travaillées";
            TotalSalesLabel.Text = "Ventes totales";
            SalesBonusLabel.Text = "Bonus de vente";
        }

        private void CalculateSalesBonusButton_Click(object sender, EventArgs e)
        {
           
            double percentageOfHoursWorked;
            double totalBonusAmount;
            double salesBonus;

            percentageOfHoursWorked = Convert.ToDouble(HoursWorkedTextBox.Text) / 160;
            totalBonusAmount = Convert.ToDouble(TotalSalesTextBox.Text) * 0.02;
            salesBonus = percentageOfHoursWorked * totalBonusAmount;
            SalesBonusTextBox.Text = salesBonus.ToString();
            



        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            EmployeeNameTextBox.Focus();
            EmployeeNameTextBox.Text = " ";
            EmployeeIDTextBox.Text = " ";
            HoursWorkedTextBox.Text = " ";
            TotalSalesTextBox.Text = " ";
            SalesBonusTextBox.Text = " ";


        }

        private void PrintButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The form is being sent to the printer. Thank you!");
        }
    }
}
