namespace Orientação_a_Eventos;

partial class Form1
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        btnLatir = new Button();
        pgbIntensidadeLatido = new ProgressBar();
        SuspendLayout();
        // 
        // btnLatir
        // 
        btnLatir.Location = new Point(12, 26);
        btnLatir.Name = "btnLatir";
        btnLatir.Size = new Size(75, 23);
        btnLatir.TabIndex = 0;
        btnLatir.Text = "Latir!";
        btnLatir.UseVisualStyleBackColor = true;
        btnLatir.Click += btnLatir_Click;
        // 
        // pgbIntensidadeLatido
        // 
        pgbIntensidadeLatido.Location = new Point(12, 72);
        pgbIntensidadeLatido.Name = "pgbIntensidadeLatido";
        pgbIntensidadeLatido.Size = new Size(487, 23);
        pgbIntensidadeLatido.TabIndex = 1;
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(511, 124);
        Controls.Add(pgbIntensidadeLatido);
        Controls.Add(btnLatir);
        Name = "Form1";
        Text = "Gerenciador de Latidos de Cachorros";
        Load += Form1_Load;
        ResumeLayout(false);
    }

    #endregion

    private Button btnLatir;
    private ProgressBar pgbIntensidadeLatido;
}
