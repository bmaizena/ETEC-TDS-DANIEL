namespace PrimeiroProjetoDesktop
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnTestar = new System.Windows.Forms.Button();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.grpSoma = new System.Windows.Forms.GroupBox();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.lblResultado = new System.Windows.Forms.Label();
            this.btnSomar = new System.Windows.Forms.Button();
            this.lblN2 = new System.Windows.Forms.Label();
            this.lblN1 = new System.Windows.Forms.Label();
            this.txtn2 = new System.Windows.Forms.TextBox();
            this.txtn1 = new System.Windows.Forms.TextBox();
            this.txtResultadoMulti = new System.Windows.Forms.TextBox();
            this.lblMulti = new System.Windows.Forms.Label();
            this.btnstart = new System.Windows.Forms.Button();
            this.lblsegundos = new System.Windows.Forms.Label();
            this.tmrSegundos = new System.Windows.Forms.Timer(this.components);
            this.btnstop = new System.Windows.Forms.Button();
            this.btnzerar = new System.Windows.Forms.Button();
            this.grpSoma.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnTestar
            // 
            this.btnTestar.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnTestar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTestar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTestar.Location = new System.Drawing.Point(209, 33);
            this.btnTestar.Name = "btnTestar";
            this.btnTestar.Size = new System.Drawing.Size(78, 20);
            this.btnTestar.TabIndex = 0;
            this.btnTestar.Text = "TESTAR";
            this.btnTestar.UseVisualStyleBackColor = false;
            this.btnTestar.Click += new System.EventHandler(this.btnTestar_Click);
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(25, 9);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(144, 21);
            this.lblNome.TabIndex = 1;
            this.lblNome.Text = "Digite o seu Nome:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(28, 33);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(175, 20);
            this.txtNome.TabIndex = 2;
            // 
            // grpSoma
            // 
            this.grpSoma.Controls.Add(this.lblMulti);
            this.grpSoma.Controls.Add(this.txtResultadoMulti);
            this.grpSoma.Controls.Add(this.txtResultado);
            this.grpSoma.Controls.Add(this.lblResultado);
            this.grpSoma.Controls.Add(this.btnSomar);
            this.grpSoma.Controls.Add(this.lblN2);
            this.grpSoma.Controls.Add(this.lblN1);
            this.grpSoma.Controls.Add(this.txtn2);
            this.grpSoma.Controls.Add(this.txtn1);
            this.grpSoma.Location = new System.Drawing.Point(28, 95);
            this.grpSoma.Name = "grpSoma";
            this.grpSoma.Size = new System.Drawing.Size(399, 304);
            this.grpSoma.TabIndex = 3;
            this.grpSoma.TabStop = false;
            this.grpSoma.Text = "Somando Componentes";
            // 
            // txtResultado
            // 
            this.txtResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResultado.Location = new System.Drawing.Point(225, 169);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.ReadOnly = true;
            this.txtResultado.Size = new System.Drawing.Size(100, 31);
            this.txtResultado.TabIndex = 6;
            this.txtResultado.Text = "0";
            this.txtResultado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Font = new System.Drawing.Font("Perpetua Titling MT", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.Location = new System.Drawing.Point(15, 185);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(138, 15);
            this.lblResultado.TabIndex = 5;
            this.lblResultado.Text = "Resultado da soma:";
            // 
            // btnSomar
            // 
            this.btnSomar.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnSomar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSomar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSomar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSomar.Image = ((System.Drawing.Image)(resources.GetObject("btnSomar.Image")));
            this.btnSomar.Location = new System.Drawing.Point(69, 125);
            this.btnSomar.Name = "btnSomar";
            this.btnSomar.Size = new System.Drawing.Size(190, 26);
            this.btnSomar.TabIndex = 4;
            this.btnSomar.Text = "Somar Agora";
            this.btnSomar.UseVisualStyleBackColor = false;
            this.btnSomar.Click += new System.EventHandler(this.btnSomar_Click);
            // 
            // lblN2
            // 
            this.lblN2.AutoSize = true;
            this.lblN2.Font = new System.Drawing.Font("Perpetua Titling MT", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblN2.Location = new System.Drawing.Point(6, 81);
            this.lblN2.Name = "lblN2";
            this.lblN2.Size = new System.Drawing.Size(183, 15);
            this.lblN2.TabIndex = 3;
            this.lblN2.Text = "Digite o Segundo Numero:";
            // 
            // lblN1
            // 
            this.lblN1.AutoSize = true;
            this.lblN1.Font = new System.Drawing.Font("Perpetua Titling MT", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblN1.Location = new System.Drawing.Point(6, 39);
            this.lblN1.Name = "lblN1";
            this.lblN1.Size = new System.Drawing.Size(181, 15);
            this.lblN1.TabIndex = 2;
            this.lblN1.Text = "Digite o Primeiro Numero:";
            // 
            // txtn2
            // 
            this.txtn2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtn2.Location = new System.Drawing.Point(225, 65);
            this.txtn2.Name = "txtn2";
            this.txtn2.Size = new System.Drawing.Size(100, 31);
            this.txtn2.TabIndex = 1;
            this.txtn2.Text = "0";
            this.txtn2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtn1
            // 
            this.txtn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtn1.Location = new System.Drawing.Point(225, 23);
            this.txtn1.Name = "txtn1";
            this.txtn1.Size = new System.Drawing.Size(100, 31);
            this.txtn1.TabIndex = 0;
            this.txtn1.Text = "0";
            this.txtn1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtResultadoMulti
            // 
            this.txtResultadoMulti.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResultadoMulti.Location = new System.Drawing.Point(225, 221);
            this.txtResultadoMulti.Name = "txtResultadoMulti";
            this.txtResultadoMulti.ReadOnly = true;
            this.txtResultadoMulti.Size = new System.Drawing.Size(98, 31);
            this.txtResultadoMulti.TabIndex = 6;
            this.txtResultadoMulti.Text = "0";
            this.txtResultadoMulti.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblMulti
            // 
            this.lblMulti.AutoSize = true;
            this.lblMulti.Font = new System.Drawing.Font("Perpetua Titling MT", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMulti.Location = new System.Drawing.Point(15, 232);
            this.lblMulti.Name = "lblMulti";
            this.lblMulti.Size = new System.Drawing.Size(202, 15);
            this.lblMulti.TabIndex = 5;
            this.lblMulti.Text = "Resultado da multiplicação:";
            // 
            // btnstart
            // 
            this.btnstart.BackColor = System.Drawing.SystemColors.Control;
            this.btnstart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnstart.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnstart.Location = new System.Drawing.Point(552, 95);
            this.btnstart.Name = "btnstart";
            this.btnstart.Size = new System.Drawing.Size(89, 70);
            this.btnstart.TabIndex = 4;
            this.btnstart.Text = "INICIAR";
            this.btnstart.UseVisualStyleBackColor = false;
            this.btnstart.Click += new System.EventHandler(this.btnstart_Click);
            // 
            // lblsegundos
            // 
            this.lblsegundos.BackColor = System.Drawing.SystemColors.Window;
            this.lblsegundos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblsegundos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblsegundos.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsegundos.Image = ((System.Drawing.Image)(resources.GetObject("lblsegundos.Image")));
            this.lblsegundos.Location = new System.Drawing.Point(696, 187);
            this.lblsegundos.Name = "lblsegundos";
            this.lblsegundos.Size = new System.Drawing.Size(89, 70);
            this.lblsegundos.TabIndex = 5;
            this.lblsegundos.Text = "0";
            this.lblsegundos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tmrSegundos
            // 
            this.tmrSegundos.Interval = 1000;
            this.tmrSegundos.Tick += new System.EventHandler(this.tmrSegundos_Tick);
            // 
            // btnstop
            // 
            this.btnstop.BackColor = System.Drawing.SystemColors.Control;
            this.btnstop.Enabled = false;
            this.btnstop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnstop.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnstop.Location = new System.Drawing.Point(552, 187);
            this.btnstop.Name = "btnstop";
            this.btnstop.Size = new System.Drawing.Size(89, 70);
            this.btnstop.TabIndex = 6;
            this.btnstop.Text = "STOP";
            this.btnstop.UseVisualStyleBackColor = false;
            this.btnstop.Click += new System.EventHandler(this.btnstop_Click);
            // 
            // btnzerar
            // 
            this.btnzerar.BackColor = System.Drawing.SystemColors.Control;
            this.btnzerar.Enabled = false;
            this.btnzerar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnzerar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnzerar.Location = new System.Drawing.Point(552, 277);
            this.btnzerar.Name = "btnzerar";
            this.btnzerar.Size = new System.Drawing.Size(89, 70);
            this.btnzerar.TabIndex = 7;
            this.btnzerar.Text = "ZERAR";
            this.btnzerar.UseVisualStyleBackColor = false;
            this.btnzerar.Click += new System.EventHandler(this.btnzerar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(963, 485);
            this.Controls.Add(this.btnzerar);
            this.Controls.Add(this.btnstop);
            this.Controls.Add(this.lblsegundos);
            this.Controls.Add(this.btnstart);
            this.Controls.Add(this.grpSoma);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.btnTestar);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Name = "Form1";
            this.Text = "Form1";
            this.grpSoma.ResumeLayout(false);
            this.grpSoma.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTestar;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.GroupBox grpSoma;
        private System.Windows.Forms.Label lblN1;
        private System.Windows.Forms.TextBox txtn2;
        private System.Windows.Forms.TextBox txtn1;
        private System.Windows.Forms.Label lblN2;
        private System.Windows.Forms.Button btnSomar;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.TextBox txtResultadoMulti;
        private System.Windows.Forms.Label lblMulti;
        private System.Windows.Forms.Button btnstart;
        private System.Windows.Forms.Label lblsegundos;
        private System.Windows.Forms.Timer tmrSegundos;
        private System.Windows.Forms.Button btnstop;
        private System.Windows.Forms.Button btnzerar;
    }
}

