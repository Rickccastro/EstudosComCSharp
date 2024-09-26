namespace Orientação_a_Eventos;

public class GerenciadorLatidos
{
    private int _intensidadeLatido;

    public event EventHandler ExcessoDecibeisEvent;

    public GerenciadorLatidos()
    {
        _intensidadeLatido = 0;
    }
    public int Latir()
    {
        _intensidadeLatido += 10;
        if (_intensidadeLatido > 80)
        {
            ExcessoDecibeisEventArgs excessoDecibeisEventArgs = new ExcessoDecibeisEventArgs
            {
                IntensidadeLatido= _intensidadeLatido,  
            };

            OnExcessoDecibeisHandler(excessoDecibeisEventArgs);
        }

        return _intensidadeLatido;
    }

    protected virtual void OnExcessoDecibeisHandler(EventArgs e)
    {
        if(ExcessoDecibeisEvent != null)
        {
            ExcessoDecibeisEvent(this,e);
        }
    }
}
