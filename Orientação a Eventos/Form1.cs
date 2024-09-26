namespace Orientação_a_Eventos;

public partial class Form1 : Form
{
    private GerenciadorLatidos _gerenciadorLatidos;
    public Form1()
    {
        InitializeComponent();
        _gerenciadorLatidos = new GerenciadorLatidos();
        _gerenciadorLatidos.ExcessoDecibeisEvent += QuandoExcederDecibeis;
        _gerenciadorLatidos.ExcessoDecibeisEvent += QuandoExcederDecibeisDenovo;
           
    }

    private void Form1_Load(object sender, EventArgs e)
    {
        pgbIntensidadeLatido.Value = 0;

    }

    private void btnLatir_Click(object sender, EventArgs e)
    {
        pgbIntensidadeLatido.Value = _gerenciadorLatidos.Latir();
    }

    private void QuandoExcederDecibeis(object sender, EventArgs e)
    {
        ExcessoDecibeisEventArgs eventargs = (ExcessoDecibeisEventArgs)e;
        MessageBox.Show($"O cachorro passou dos limites,com {eventargs.IntensidadeLatido} decibeis", "Excesso de decibéis",MessageBoxButtons.OK,MessageBoxIcon.Warning);
    }
    private void QuandoExcederDecibeisDenovo(object sender, EventArgs e)
    {
        MessageBox.Show("Você levou uma multa", "Excesso de decibéis",MessageBoxButtons.OK,MessageBoxIcon.Warning);
    }
}
