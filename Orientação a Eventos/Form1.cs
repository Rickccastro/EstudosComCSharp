namespace Orientação_a_Eventos;

public partial class Form1 : Form
{
    private GerenciadorLatidos _gerenciadorLatidos;
    public Form1()
    {
        InitializeComponent();
        _gerenciadorLatidos = new GerenciadorLatidos();

        _gerenciadorLatidos.ExcessoDecibeisEvent += (sender,args)=> 
        {
            ExcessoDecibeisEventArgs eventargs = (ExcessoDecibeisEventArgs)args;
            MessageBox.Show($"O cachorro passou dos limites,com {eventargs.IntensidadeLatido} decibeis", "Excesso de decibéis", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        };
        _gerenciadorLatidos.ExcessoDecibeisEvent += (sender, args) =>
        {
            MessageBox.Show("Você levou uma multa", "Excesso de decibéis", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        };
    }

    private void Form1_Load(object sender, EventArgs e)
    {
        pgbIntensidadeLatido.Value = 0;

    }

    private void btnLatir_Click(object sender, EventArgs e)
    {
        pgbIntensidadeLatido.Value = _gerenciadorLatidos.Latir();
    }
}
