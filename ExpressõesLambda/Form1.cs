using System.Security.Cryptography;

namespace ExpressõesLambda;

public partial class frmEstudoLambdas : Form
{
    public frmEstudoLambdas()
    {
        InitializeComponent();
    }

    private void label1_Click(object sender, EventArgs e)
    {

    }

    private void btnConcatenar_Click(object sender, EventArgs e)
    {
        Func<string, string, string> concatenador = (s1,s2) => { return s1 + " "+ s2; };
        Action<string> escritor = (resultadoDoConcatenador) =>
        {
            txbResultado.Text = resultadoDoConcatenador;
        };
        escritor(concatenador(txbTexto1.Text, txbTexto2.Text));
    
    }
}
