using System;
using System.Windows.Forms;

namespace MiniRäknare
{
    public partial class Form1 : Form
    {
        public Calculator C = new Calculator();

        public Form1() { InitializeComponent(); }

        // Knapper som lägger till {CalcBox.Text}
        private void OneBtn_Click(object sender, EventArgs e)      {  CalcBox.Text += C.NextNumber("1");  }
        private void TwoBtn_Click(object sender, EventArgs e)      {  CalcBox.Text += C.NextNumber("2");  }
        private void ThreeBtn_Click(object sender, EventArgs e)    {  CalcBox.Text += C.NextNumber("3");  }
        private void FourBtn_Click(object sender, EventArgs e)     {  CalcBox.Text += C.NextNumber("4");  }
        private void FiveBtn_Click(object sender, EventArgs e)     {  CalcBox.Text += C.NextNumber("5");  }
        private void SixBtn_Click(object sender, EventArgs e)      {  CalcBox.Text += C.NextNumber("6");  }
        private void SevenBtn_Click(object sender, EventArgs e)    {  CalcBox.Text += C.NextNumber("7");  }
        private void EightBtn_Click(object sender, EventArgs e)    {  CalcBox.Text += C.NextNumber("8");  }
        private void NineBtn_Click(object sender, EventArgs e)     {  CalcBox.Text += C.NextNumber("9");  }
        private void CommaBtn_Click(object sender, EventArgs e)    {  CalcBox.Text += C.NextNumber(",");  }
        private void DivideBtn_Click(object sender, EventArgs e)   { CalcBox.Text += C.NextOperator("/"); }
        private void MultiplyBtn_Click(object sender, EventArgs e) { CalcBox.Text += C.NextOperator("*"); }
        private void MinusBtn_Click(object sender, EventArgs e)    { CalcBox.Text += C.NextOperator("-"); }
        private void PlusBtn_Click(object sender, EventArgs e)     { CalcBox.Text += C.NextOperator("+"); }

        private void CBtn_Click(object sender, EventArgs e) {
            C.C();
            CalcBox.Text = "";
        }

        // SPECIAL FUNCTIONS //
        // EqualsBtn
        private void EqualsBtn_Click(object sender, EventArgs e)
        {

        }

        private void BackspaceBtn_Click(object sender, EventArgs e)
        {
            var nt = CalcBox.Text.Remove(CalcBox.Text.Length - 1);
            CalcBox.Text = nt;
        }
    }
}
