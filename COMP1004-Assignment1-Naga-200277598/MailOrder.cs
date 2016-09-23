using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// Sharp Mail Order	– SALES	BONUS
// Naga Rimmalapudi 200277598
// Sept 19, 2016
//Sales bonus should be calculated with provided details like Total Sales and hours worked. 
// Sales Bonus = (Hours Worked / 160) * (Total Sales * 0.02)

namespace COMP1004_Assignment1_Naga_200277598
{
    public partial class MailOrderForm : Form
    {
        public MailOrderForm()
        {
            InitializeComponent();
        }

        // Labels and buttons change to English language when clicked on English radio button
        private void EnglishRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            EmployeeNameLabel.Text = "Employee's Name";
            EmployeeIDLabel.Text = "Employee ID";
            HoursWorkedLabel.Text = "Hours Worked";
            TotalSalesLabel.Text = "Total Sales";
            SalesBonusLabel.Text = "Sales Bonus";
            CalculateSalesBonusButton.Text = "Calculate";
            NextButton.Text = "Next";
            PrintButton.Text = "Print";
        }

        // Labels and buttons change to French language when clicked on French radio button
        private void FrancaisRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            EmployeeNameLabel.Text = "Le nom de l'employé";
            EmployeeIDLabel.Text = "Employé ID";
            HoursWorkedLabel.Text = "Heures travaillées";
            TotalSalesLabel.Text = "Ventes totales";
            SalesBonusLabel.Text = "Bonus de vente";
            CalculateSalesBonusButton.Text = "Calculer";
            NextButton.Text = "Prochain";
            PrintButton.Text = "Impression";
        }

        // Calculating Sales Bonus and enclosed the entities in Try, catch
        private void CalculateSalesBonusButton_Click(object sender, EventArgs e)
        {

            double percentageOfHoursWorked;
            double totalBonusAmount;
            double salesBonus;
            try
            {
                // If else statement for hours worked <= 160
                if (Convert.ToDouble(HoursWorkedTextBox.Text) > 0 && Convert.ToDouble(HoursWorkedTextBox.Text) <= 160)
                {

                    percentageOfHoursWorked = Convert.ToDouble(HoursWorkedTextBox.Text) / 160;
                    totalBonusAmount = Convert.ToDouble(TotalSalesTextBox.Text) * 0.02;
                    salesBonus = percentageOfHoursWorked * totalBonusAmount;
                    SalesBonusTextBox.Text = salesBonus.ToString();
                    TotalSalesTextBox.Text = "$" + TotalSalesTextBox.Text;
                }
                else
                {
                    MessageBox.Show("Hours Worked: Enter a value from 0 to 160");
                }


            }
            catch(Exception exception)
            {
                MessageBox.Show("Invalid Data Entered", "Input Error");
                Debug.WriteLine(exception.Message);
                clearAll();
            }

        }

        // The functionality of Next button is that all the text boxes
        //  in the application are cleared
        private void NextButton_Click(object sender, EventArgs e)
        {

            clearAll();

        }

        // clearAll() method for clearing all text boxes in the form
        private void clearAll()
        {
            EmployeeNameTextBox.Focus();
            EmployeeNameTextBox.Text = " ";
            EmployeeIDTextBox.Text = " ";
            HoursWorkedTextBox.Text = " ";
            TotalSalesTextBox.Text = " ";
            SalesBonusTextBox.Text = " ";
        }

        // The Print functionality is to say the messsage "The Form is being sent to the printer" if all the data is entered
        // If the data is not entered it should say the message "Please fill the form".
        private void PrintButton_Click(object sender, EventArgs e)
        {
            if ((SalesBonusTextBox.Text) != "")
                MessageBox.Show("The form is being sent to the printer. Thank you!");

            else
                MessageBox.Show("Please fill the form");
        }

        // Labels and buttons change to German language when clicked on German radio button
        private void GermanRadioButton_CheckedChanged(object sender, EventArgs e)
        {

            EmployeeNameLabel.Text = "Mitarbeiter - Namen";
            EmployeeIDLabel.Text = "Angestellten ID";
            HoursWorkedLabel.Text = "Arbeitsstunden";
            TotalSalesLabel.Text = "Gesamtumsatz";
            SalesBonusLabel.Text = "Der Umsatz Bonus";
            CalculateSalesBonusButton.Text = "Berechnen";
            NextButton.Text = "Nächster";
            PrintButton.Text = "Drucken";
        }

        // Labels and buttons change to Spanish language when clicked on Spanish radio button
        private void SpanishRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            EmployeeNameLabel.Text = "Nombre del empleado";
            EmployeeIDLabel.Text = "ID de empleado";
            HoursWorkedLabel.Text = "horas trabajadas";
            TotalSalesLabel.Text = "Ventas totales";
            SalesBonusLabel.Text = "Bono de ventas";
            CalculateSalesBonusButton.Text = "Calcular";
            NextButton.Text = "Siguiente";
            PrintButton.Text = "Impresión";
        }

        // Labels and buttons change to Russian language when clicked on Russian radio button
        private void RussianRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            EmployeeNameLabel.Text = "Имя работника";
            EmployeeIDLabel.Text = "Сотрудник ID";
            HoursWorkedLabel.Text = "Отработанные часы";
            TotalSalesLabel.Text = "Тотальная распродажа";
            SalesBonusLabel.Text = "Бонус продаж";
            CalculateSalesBonusButton.Text = "подсчитывать";
            NextButton.Text = "следующий";
            PrintButton.Text = "Распечатать";
        }

        // Labels and buttons change to Portuguese language when clicked on Portuguese radio button
        private void PortugueseRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            EmployeeNameLabel.Text = "Nome do empregado";
            EmployeeIDLabel.Text = "ID do Empregado";
            HoursWorkedLabel.Text = "Horas trabalhadas";
            TotalSalesLabel.Text = "Vendas totais";
            SalesBonusLabel.Text = "Bonus de Vendas";
            CalculateSalesBonusButton.Text = "Calcular";
            NextButton.Text = "Próximo";
            PrintButton.Text = "Impressão";
        }

        // On closing the application, it should exit.
        private void SalesBonusForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}