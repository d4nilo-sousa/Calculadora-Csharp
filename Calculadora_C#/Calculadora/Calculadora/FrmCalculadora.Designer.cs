
namespace Calculadora
{
    partial class FrmCalculadora
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.btn07 = new System.Windows.Forms.Button();
            this.btn08 = new System.Windows.Forms.Button();
            this.btn09 = new System.Windows.Forms.Button();
            this.btn05 = new System.Windows.Forms.Button();
            this.btn06 = new System.Windows.Forms.Button();
            this.btn04 = new System.Windows.Forms.Button();
            this.btn03 = new System.Windows.Forms.Button();
            this.btn02 = new System.Windows.Forms.Button();
            this.btn01 = new System.Windows.Forms.Button();
            this.btnZero = new System.Windows.Forms.Button();
            this.btnLimparTudo = new System.Windows.Forms.Button();
            this.btnMaisMenos = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnApagar = new System.Windows.Forms.Button();
            this.btnDivide = new System.Windows.Forms.Button();
            this.btnSubtrai = new System.Windows.Forms.Button();
            this.btnMultplica = new System.Windows.Forms.Button();
            this.button18 = new System.Windows.Forms.Button();
            this.btnIgual = new System.Windows.Forms.Button();
            this.btnSoma = new System.Windows.Forms.Button();
            this.button21 = new System.Windows.Forms.Button();
            this.btnRaiz = new System.Windows.Forms.Button();
            this.btnVirgula = new System.Windows.Forms.Button();
            this.lblMsg = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtResultado
            // 
            this.txtResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResultado.Location = new System.Drawing.Point(12, 12);
            this.txtResultado.MaxLength = 17;
            this.txtResultado.Multiline = true;
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(390, 64);
            this.txtResultado.TabIndex = 0;
            this.txtResultado.Text = "0";
            this.txtResultado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtResultado.TextChanged += new System.EventHandler(this.txtResultado_TextChanged);
            // 
            // btn07
            // 
            this.btn07.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn07.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn07.Location = new System.Drawing.Point(12, 187);
            this.btn07.Name = "btn07";
            this.btn07.Size = new System.Drawing.Size(63, 61);
            this.btn07.TabIndex = 1;
            this.btn07.Text = "7";
            this.btn07.UseVisualStyleBackColor = true;
            this.btn07.Click += new System.EventHandler(this.AgregarNumero);
            // 
            // btn08
            // 
            this.btn08.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn08.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn08.Location = new System.Drawing.Point(78, 187);
            this.btn08.Name = "btn08";
            this.btn08.Size = new System.Drawing.Size(63, 61);
            this.btn08.TabIndex = 2;
            this.btn08.Text = "8";
            this.btn08.UseVisualStyleBackColor = true;
            this.btn08.Click += new System.EventHandler(this.AgregarNumero);
            // 
            // btn09
            // 
            this.btn09.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn09.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn09.Location = new System.Drawing.Point(147, 187);
            this.btn09.Name = "btn09";
            this.btn09.Size = new System.Drawing.Size(63, 61);
            this.btn09.TabIndex = 3;
            this.btn09.Text = "9";
            this.btn09.UseVisualStyleBackColor = true;
            this.btn09.Click += new System.EventHandler(this.AgregarNumero);
            // 
            // btn05
            // 
            this.btn05.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn05.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn05.Location = new System.Drawing.Point(78, 254);
            this.btn05.Name = "btn05";
            this.btn05.Size = new System.Drawing.Size(63, 61);
            this.btn05.TabIndex = 4;
            this.btn05.Text = "5";
            this.btn05.UseVisualStyleBackColor = true;
            this.btn05.Click += new System.EventHandler(this.AgregarNumero);
            // 
            // btn06
            // 
            this.btn06.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn06.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn06.Location = new System.Drawing.Point(147, 254);
            this.btn06.Name = "btn06";
            this.btn06.Size = new System.Drawing.Size(63, 61);
            this.btn06.TabIndex = 5;
            this.btn06.Text = "6";
            this.btn06.UseVisualStyleBackColor = true;
            this.btn06.Click += new System.EventHandler(this.AgregarNumero);
            // 
            // btn04
            // 
            this.btn04.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn04.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn04.Location = new System.Drawing.Point(9, 254);
            this.btn04.Name = "btn04";
            this.btn04.Size = new System.Drawing.Size(63, 61);
            this.btn04.TabIndex = 6;
            this.btn04.Text = "4";
            this.btn04.UseVisualStyleBackColor = true;
            this.btn04.Click += new System.EventHandler(this.AgregarNumero);
            // 
            // btn03
            // 
            this.btn03.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn03.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn03.Location = new System.Drawing.Point(147, 321);
            this.btn03.Name = "btn03";
            this.btn03.Size = new System.Drawing.Size(63, 61);
            this.btn03.TabIndex = 7;
            this.btn03.Text = "3";
            this.btn03.UseVisualStyleBackColor = true;
            this.btn03.Click += new System.EventHandler(this.AgregarNumero);
            // 
            // btn02
            // 
            this.btn02.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn02.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn02.Location = new System.Drawing.Point(78, 321);
            this.btn02.Name = "btn02";
            this.btn02.Size = new System.Drawing.Size(63, 61);
            this.btn02.TabIndex = 8;
            this.btn02.Text = "2";
            this.btn02.UseVisualStyleBackColor = true;
            this.btn02.Click += new System.EventHandler(this.AgregarNumero);
            // 
            // btn01
            // 
            this.btn01.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn01.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn01.Location = new System.Drawing.Point(9, 321);
            this.btn01.Name = "btn01";
            this.btn01.Size = new System.Drawing.Size(63, 61);
            this.btn01.TabIndex = 9;
            this.btn01.Text = "1";
            this.btn01.UseVisualStyleBackColor = true;
            this.btn01.Click += new System.EventHandler(this.AgregarNumero);
            // 
            // btnZero
            // 
            this.btnZero.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnZero.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnZero.Location = new System.Drawing.Point(9, 393);
            this.btnZero.Name = "btnZero";
            this.btnZero.Size = new System.Drawing.Size(132, 48);
            this.btnZero.TabIndex = 10;
            this.btnZero.Text = "0";
            this.btnZero.UseVisualStyleBackColor = true;
            this.btnZero.Click += new System.EventHandler(this.AgregarNumero);
            // 
            // btnLimparTudo
            // 
            this.btnLimparTudo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimparTudo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimparTudo.Location = new System.Drawing.Point(78, 120);
            this.btnLimparTudo.Name = "btnLimparTudo";
            this.btnLimparTudo.Size = new System.Drawing.Size(63, 61);
            this.btnLimparTudo.TabIndex = 11;
            this.btnLimparTudo.Text = "CE";
            this.btnLimparTudo.UseVisualStyleBackColor = true;
            this.btnLimparTudo.Click += new System.EventHandler(this.btnLimparTudo_Click);
            // 
            // btnMaisMenos
            // 
            this.btnMaisMenos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaisMenos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMaisMenos.Location = new System.Drawing.Point(257, 120);
            this.btnMaisMenos.Name = "btnMaisMenos";
            this.btnMaisMenos.Size = new System.Drawing.Size(63, 61);
            this.btnMaisMenos.TabIndex = 12;
            this.btnMaisMenos.Text = "+/-";
            this.btnMaisMenos.UseVisualStyleBackColor = true;
            this.btnMaisMenos.Click += new System.EventHandler(this.btnMaisMenos_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Location = new System.Drawing.Point(147, 120);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(63, 61);
            this.btnLimpar.TabIndex = 13;
            this.btnLimpar.Text = "C";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnApagar
            // 
            this.btnApagar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnApagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApagar.Location = new System.Drawing.Point(9, 120);
            this.btnApagar.Name = "btnApagar";
            this.btnApagar.Size = new System.Drawing.Size(63, 61);
            this.btnApagar.TabIndex = 14;
            this.btnApagar.Text = "<-";
            this.btnApagar.UseVisualStyleBackColor = true;
            this.btnApagar.Click += new System.EventHandler(this.btnApagar_Click);
            // 
            // btnDivide
            // 
            this.btnDivide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDivide.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDivide.Location = new System.Drawing.Point(257, 187);
            this.btnDivide.Name = "btnDivide";
            this.btnDivide.Size = new System.Drawing.Size(63, 61);
            this.btnDivide.TabIndex = 15;
            this.btnDivide.Tag = "/";
            this.btnDivide.Text = "/";
            this.btnDivide.UseVisualStyleBackColor = true;
            this.btnDivide.Click += new System.EventHandler(this.ClickOperador);
            // 
            // btnSubtrai
            // 
            this.btnSubtrai.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubtrai.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubtrai.Location = new System.Drawing.Point(257, 321);
            this.btnSubtrai.Name = "btnSubtrai";
            this.btnSubtrai.Size = new System.Drawing.Size(63, 61);
            this.btnSubtrai.TabIndex = 16;
            this.btnSubtrai.Tag = "-";
            this.btnSubtrai.Text = "-";
            this.btnSubtrai.UseVisualStyleBackColor = true;
            this.btnSubtrai.Click += new System.EventHandler(this.ClickOperador);
            // 
            // btnMultplica
            // 
            this.btnMultplica.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMultplica.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMultplica.Location = new System.Drawing.Point(257, 254);
            this.btnMultplica.Name = "btnMultplica";
            this.btnMultplica.Size = new System.Drawing.Size(63, 61);
            this.btnMultplica.TabIndex = 17;
            this.btnMultplica.Tag = "*";
            this.btnMultplica.Text = "*";
            this.btnMultplica.UseVisualStyleBackColor = true;
            this.btnMultplica.Click += new System.EventHandler(this.ClickOperador);
            // 
            // button18
            // 
            this.button18.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button18.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button18.Location = new System.Drawing.Point(339, 254);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(63, 61);
            this.button18.TabIndex = 18;
            this.button18.Tag = "²";
            this.button18.Text = "X²";
            this.button18.UseVisualStyleBackColor = true;
            this.button18.Click += new System.EventHandler(this.ClickOperador);
            // 
            // btnIgual
            // 
            this.btnIgual.BackColor = System.Drawing.Color.White;
            this.btnIgual.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIgual.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIgual.ForeColor = System.Drawing.Color.Green;
            this.btnIgual.Location = new System.Drawing.Point(339, 321);
            this.btnIgual.Name = "btnIgual";
            this.btnIgual.Size = new System.Drawing.Size(63, 128);
            this.btnIgual.TabIndex = 19;
            this.btnIgual.Text = "=";
            this.btnIgual.UseVisualStyleBackColor = false;
            this.btnIgual.Click += new System.EventHandler(this.btnIgual_Click);
            // 
            // btnSoma
            // 
            this.btnSoma.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSoma.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSoma.Location = new System.Drawing.Point(257, 387);
            this.btnSoma.Name = "btnSoma";
            this.btnSoma.Size = new System.Drawing.Size(63, 61);
            this.btnSoma.TabIndex = 20;
            this.btnSoma.Tag = "+";
            this.btnSoma.Text = "+";
            this.btnSoma.UseVisualStyleBackColor = true;
            this.btnSoma.Click += new System.EventHandler(this.ClickOperador);
            // 
            // button21
            // 
            this.button21.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button21.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button21.Location = new System.Drawing.Point(339, 187);
            this.button21.Name = "button21";
            this.button21.Size = new System.Drawing.Size(63, 61);
            this.button21.TabIndex = 21;
            this.button21.Tag = "%";
            this.button21.Text = "%";
            this.button21.UseVisualStyleBackColor = true;
            this.button21.Click += new System.EventHandler(this.ClickOperador);
            // 
            // btnRaiz
            // 
            this.btnRaiz.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRaiz.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRaiz.Location = new System.Drawing.Point(339, 120);
            this.btnRaiz.Name = "btnRaiz";
            this.btnRaiz.Size = new System.Drawing.Size(63, 61);
            this.btnRaiz.TabIndex = 22;
            this.btnRaiz.Tag = "√";
            this.btnRaiz.Text = "√²";
            this.btnRaiz.UseVisualStyleBackColor = true;
            this.btnRaiz.Click += new System.EventHandler(this.ClickOperador);
            // 
            // btnVirgula
            // 
            this.btnVirgula.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVirgula.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVirgula.Location = new System.Drawing.Point(147, 393);
            this.btnVirgula.Name = "btnVirgula";
            this.btnVirgula.Size = new System.Drawing.Size(63, 48);
            this.btnVirgula.TabIndex = 23;
            this.btnVirgula.Text = ",";
            this.btnVirgula.UseVisualStyleBackColor = true;
            this.btnVirgula.Click += new System.EventHandler(this.btnVirgula_Click);
            // 
            // lblMsg
            // 
            this.lblMsg.AutoSize = true;
            this.lblMsg.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMsg.Location = new System.Drawing.Point(12, 79);
            this.lblMsg.Name = "lblMsg";
            this.lblMsg.Size = new System.Drawing.Size(37, 17);
            this.lblMsg.TabIndex = 24;
            this.lblMsg.Text = "msg";
            this.lblMsg.Visible = false;
            // 
            // FrmCalculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 460);
            this.Controls.Add(this.lblMsg);
            this.Controls.Add(this.btnVirgula);
            this.Controls.Add(this.btnRaiz);
            this.Controls.Add(this.button21);
            this.Controls.Add(this.btnSoma);
            this.Controls.Add(this.btnIgual);
            this.Controls.Add(this.button18);
            this.Controls.Add(this.btnMultplica);
            this.Controls.Add(this.btnSubtrai);
            this.Controls.Add(this.btnDivide);
            this.Controls.Add(this.btnApagar);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnMaisMenos);
            this.Controls.Add(this.btnLimparTudo);
            this.Controls.Add(this.btnZero);
            this.Controls.Add(this.btn01);
            this.Controls.Add(this.btn02);
            this.Controls.Add(this.btn03);
            this.Controls.Add(this.btn04);
            this.Controls.Add(this.btn06);
            this.Controls.Add(this.btn05);
            this.Controls.Add(this.btn09);
            this.Controls.Add(this.btn08);
            this.Controls.Add(this.btn07);
            this.Controls.Add(this.txtResultado);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmCalculadora";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculadora";
            this.Load += new System.EventHandler(this.FrmCalculadora_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.Button btn07;
        private System.Windows.Forms.Button btn08;
        private System.Windows.Forms.Button btn09;
        private System.Windows.Forms.Button btn05;
        private System.Windows.Forms.Button btn06;
        private System.Windows.Forms.Button btn04;
        private System.Windows.Forms.Button btn03;
        private System.Windows.Forms.Button btn02;
        private System.Windows.Forms.Button btn01;
        private System.Windows.Forms.Button btnZero;
        private System.Windows.Forms.Button btnLimparTudo;
        private System.Windows.Forms.Button btnMaisMenos;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnApagar;
        private System.Windows.Forms.Button btnDivide;
        private System.Windows.Forms.Button btnSubtrai;
        private System.Windows.Forms.Button btnMultplica;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.Button btnIgual;
        private System.Windows.Forms.Button btnSoma;
        private System.Windows.Forms.Button button21;
        private System.Windows.Forms.Button btnRaiz;
        private System.Windows.Forms.Button btnVirgula;
        private System.Windows.Forms.Label lblMsg;
    }
}

