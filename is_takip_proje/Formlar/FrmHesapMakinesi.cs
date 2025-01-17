using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace is_takip_proje.Formlar
{
    public partial class FrmHesapMakinesi : Form
    {
        private string _currentInput = "0";  // Kullanıcının girdiği sayı
        private string _operand1 = "";      // İlk sayı
        private char _operation;
        public FrmHesapMakinesi()
        {
            InitializeComponent();
        }
        private void AssignButtonTags()
        {
            // Sayılar için Tag değerleri
            btn1.Tag = "1"; btn2.Tag = "2"; btn3.Tag = "3";
            btn4.Tag = "4"; btn5.Tag = "5"; btn6.Tag = "6";
            btn7.Tag = "7"; btn8.Tag = "8"; btn9.Tag = "9";
            btn0.Tag = "0";

            // İşlemler ve diğer butonlar için Tag değerleri
            

            HideButtonTexts();  // Butonların metinlerini gizle
        }

        private void HideButtonTexts()
        {
            foreach (var control in this.Controls)
            {
                if (control is Button button)
                {
                    button.Text = ""; // Buton üzerindeki metin gizlenir
                }
            }
        }

        private void Button_Click(object sender, EventArgs e)
        {
            var button = sender as Button;
            if (button != null)
            {
                string tag = button.Tag.ToString();

                if (char.IsDigit(tag[0])) // Sayı butonları
                {
                    _currentInput = _currentInput == "0" ? tag : _currentInput + tag;
                }
                else if ("+-*/".Contains(tag)) // İşlem butonları
                {
                    _operand1 = _currentInput;
                    _operation = tag[0];
                    _currentInput = "0";
                }
                else if (tag == "=") // Eşittir butonu
                {
                    _currentInput = CalculateResult();
                }
                else if (tag == "C") // Temizleme butonu
                {
                    _currentInput = "0";
                    _operand1 = "";
                    _operation = '\0';
                }

                UpdateDisplay(); // Dijital ekran güncellemesi
            }
        }

        private string CalculateResult()
        {
            if (string.IsNullOrEmpty(_operand1) || _operation == '\0')
                return _currentInput;

            double num1 = double.Parse(_operand1);
            double num2 = double.Parse(_currentInput);
            double result = 0;

            switch (_operation)
            {
                case '+': result = num1 + num2; break;
                case '-': result = num1 - num2; break;
                case '*': result = num1 * num2; break;
                case '/': result = num2 != 0 ? num1 / num2 : 0; break;
            }

            return result.ToString();
        }

        private void UpdateDisplay()
        {
            label1.Text = _currentInput; // Dijital göstergeyi güncelle
        }
    }
}