using PreAcademyAEquazione2Grado.Core;

namespace PreAcademyAEquazione2Grado.WinForms
{
    public partial class Equazione2GradoForm : Form
    {
        private double a;
        private double b;
        private double c;
        Equation eq = new Equation();
        public Equazione2GradoForm()
        {
            InitializeComponent();
        }

        private void btnRisolvi_Click(object sender, EventArgs e)
        {
            //a = double.Parse(txtA.Text); //TOBE: considerare il caso null Or Empty
            //b = double.Parse(txtB.Text);
            //c = double.Parse(txtC.Text);
            a = string.IsNullOrEmpty(txtA.Text)? 0: double.Parse(txtA.Text);
            b= string.IsNullOrEmpty(txtB.Text)? 0: double.Parse(txtB.Text);
            c= string.IsNullOrEmpty(txtC.Text)? 0: double.Parse(txtC.Text);
            

            var esito = eq.RisolviEquazioneDiSecondoGrado(a, b, c);


            if (esito == null)
            {
                lblSoluzione.Text = "Impossibile";
            }
            
            else if (esito.Length == 1)
            {
                lblSoluzione.Text = $"Soluzioni coincidenti:\nx1=x2= {esito[0]}";
            }
            else if (esito.Length == 2)
            {
                lblSoluzione.Text = $"Soluzioni distinte:\nx1={esito[0]}\nx2={esito[1]}";
            }

        }

        private void txtA_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && !(e.KeyChar == '.') && !(e.KeyChar == '-');
        }

        private void txtB_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && !(e.KeyChar == '.') && !(e.KeyChar == '-'); ;
        }

        private void txtC_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && !(e.KeyChar == '.') && !(e.KeyChar == '-'); ;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtA.Clear();
            txtB.Clear();
            txtC.Clear();
            lblSoluzione.Text = "";
        }

       
    }
}