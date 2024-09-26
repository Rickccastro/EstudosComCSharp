namespace ExpressõesLambda;

partial class frmEstudoLambdas
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
        lblTexto1 = new Label();
        lblTexto2 = new Label();
        txbTexto1 = new TextBox();
        txbTexto2 = new TextBox();
        btnConcatenar = new Button();
        txbResultado = new TextBox();
        lblResultado = new Label();
        SuspendLayout();
        // 
        // lblTexto1
        // 
        lblTexto1.AutoSize = true;
        lblTexto1.Location = new Point(18, 28);
        lblTexto1.Name = "lblTexto1";
        lblTexto1.Size = new Size(47, 15);
        lblTexto1.TabIndex = 0;
        lblTexto1.Text = "Texto 1:";
        lblTexto1.Click += label1_Click;
        // 
        // lblTexto2
        // 
        lblTexto2.AutoSize = true;
        lblTexto2.Location = new Point(18, 80);
        lblTexto2.Name = "lblTexto2";
        lblTexto2.Size = new Size(47, 15);
        lblTexto2.TabIndex = 1;
        lblTexto2.Text = "Texto 2:";
        // 
        // txbTexto1
        // 
        txbTexto1.Location = new Point(71, 25);
        txbTexto1.Name = "txbTexto1";
        txbTexto1.Size = new Size(692, 23);
        txbTexto1.TabIndex = 2;
        // 
        // txbTexto2
        // 
        txbTexto2.Location = new Point(71, 72);
        txbTexto2.Name = "txbTexto2";
        txbTexto2.Size = new Size(692, 23);
        txbTexto2.TabIndex = 3;
        // 
        // btnConcatenar
        // 
        btnConcatenar.Location = new Point(71, 114);
        btnConcatenar.Name = "btnConcatenar";
        btnConcatenar.Size = new Size(82, 23);
        btnConcatenar.TabIndex = 4;
        btnConcatenar.Text = "Concatenar";
        btnConcatenar.UseVisualStyleBackColor = true;
        btnConcatenar.Click += btnConcatenar_Click;
        // 
        // txbResultado
        // 
        txbResultado.Location = new Point(71, 152);
        txbResultado.Name = "txbResultado";
        txbResultado.ReadOnly = true;
        txbResultado.Size = new Size(692, 23);
        txbResultado.TabIndex = 5;
        // 
        // lblResultado
        // 
        lblResultado.AutoSize = true;
        lblResultado.Location = new Point(6, 160);
        lblResultado.Name = "lblResultado";
        lblResultado.Size = new Size(59, 15);
        lblResultado.TabIndex = 6;
        lblResultado.Text = "Resultado";
        // 
        // frmEstudoLambdas
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(800, 450);
        Controls.Add(lblResultado);
        Controls.Add(txbResultado);
        Controls.Add(btnConcatenar);
        Controls.Add(txbTexto2);
        Controls.Add(txbTexto1);
        Controls.Add(lblTexto2);
        Controls.Add(lblTexto1);
        Name = "frmEstudoLambdas";
        Text = "Estudo sobre lambdas";
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label lblTexto1;
    private Label lblTexto2;
    private TextBox txbTexto1;
    private TextBox txbTexto2;
    private Button btnConcatenar;
    private TextBox txbResultado;
    private Label lblResultado;
}
