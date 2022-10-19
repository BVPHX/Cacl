using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Linq.Expressions;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Cacl
{
    public partial class MainPage : ContentPage
    {
      
        public MainPage()
        {
            InitializeComponent();

        }

        private void Knopka(object sender, EventArgs e)
        {
            
            var aboba = sender as Button;
            switch (aboba.Text)
            {
                case "C":
                    resultField.Text = String.Empty;
                    break;
                case "%":
                    resultField.Text += "/";
                    break;
                case "*":
                    resultField.Text += "*";
                    break;
                case "@{":
                    if (resultField.Text.Length > 0)
                    {                       
                       resultField.Text = resultField.Text.Remove(resultField.Text.Length - 1);
                    }
                    break;
                case "7":
                    resultField.Text += "7";
                    break;
                case "8":
                    resultField.Text += "8";
                    break;
                case "9":
                    resultField.Text += "9";
                    break;
                case "-":
                    resultField.Text += "-";
                    break;
                case "4":
                    resultField.Text += "4";
                    break;
                case "5":
                    resultField.Text += "5";
                    break;
                case "6":
                    resultField.Text += "6";
                    break;
                case "+":
                    resultField.Text += "+";
                    break;
                case "1":
                    resultField.Text += "1";
                    break;
                case "2":
                    resultField.Text += "2";
                    break;
                case "3":
                    resultField.Text += "3";
                    break;
                case ".|.":
                    resultField.Text += "%";
                    break;
                case "0":
                    resultField.Text += "0";
                    break;
                case ",":
                    resultField.Text += ",";
                    break;
                case "=":
                    var operationB = new System.Data.DataTable().Compute(resultField.Text, "");
                    resultField.Text = operationB.ToString();
                    break;
            }
        }
    }
}
