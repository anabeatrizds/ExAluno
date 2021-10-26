
namespace ExAula7Cliente
{
    partial class Inclusao
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtCPF = new System.Windows.Forms.MaskedTextBox();
            this.lblTel = new System.Windows.Forms.Label();
            this.lblCid = new System.Windows.Forms.Label();
            this.lblend = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblRegiao = new System.Windows.Forms.Label();
            this.lblCpf = new System.Windows.Forms.Label();
            this.btnIncluir = new System.Windows.Forms.Button();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.txtDDD = new System.Windows.Forms.TextBox();
            this.txtCid = new System.Windows.Forms.TextBox();
            this.txtEnd = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtCPF
            // 
            this.txtCPF.Location = new System.Drawing.Point(156, 32);
            this.txtCPF.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCPF.Mask = "000.000.000-00";
            this.txtCPF.Name = "txtCPF";
            this.txtCPF.Size = new System.Drawing.Size(133, 26);
            this.txtCPF.TabIndex = 26;
            this.txtCPF.Leave += new System.EventHandler(this.txtCpf_Leave);
            // 
            // lblTel
            // 
            this.lblTel.AutoSize = true;
            this.lblTel.Location = new System.Drawing.Point(58, 218);
            this.lblTel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTel.Name = "lblTel";
            this.lblTel.Size = new System.Drawing.Size(75, 20);
            this.lblTel.TabIndex = 25;
            this.lblTel.Text = "Telefone:";
            // 
            // lblCid
            // 
            this.lblCid.AutoSize = true;
            this.lblCid.Location = new System.Drawing.Point(58, 171);
            this.lblCid.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCid.Name = "lblCid";
            this.lblCid.Size = new System.Drawing.Size(63, 20);
            this.lblCid.TabIndex = 24;
            this.lblCid.Text = "Cidade:";
            // 
            // lblend
            // 
            this.lblend.AutoSize = true;
            this.lblend.Location = new System.Drawing.Point(46, 121);
            this.lblend.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblend.Name = "lblend";
            this.lblend.Size = new System.Drawing.Size(82, 20);
            this.lblend.TabIndex = 23;
            this.lblend.Text = "Endereço:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(73, 76);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 20);
            this.label3.TabIndex = 22;
            this.label3.Text = "Nome:";
            // 
            // lblRegiao
            // 
            this.lblRegiao.AutoSize = true;
            this.lblRegiao.Location = new System.Drawing.Point(328, 32);
            this.lblRegiao.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRegiao.Name = "lblRegiao";
            this.lblRegiao.Size = new System.Drawing.Size(64, 20);
            this.lblRegiao.TabIndex = 21;
            this.lblRegiao.Text = "Região:";
            this.lblRegiao.Click += new System.EventHandler(this.lblReg_Click);
            // 
            // lblCpf
            // 
            this.lblCpf.AutoSize = true;
            this.lblCpf.Location = new System.Drawing.Point(84, 32);
            this.lblCpf.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCpf.Name = "lblCpf";
            this.lblCpf.Size = new System.Drawing.Size(44, 20);
            this.lblCpf.TabIndex = 20;
            this.lblCpf.Text = "CPF:";
            // 
            // btnIncluir
            // 
            this.btnIncluir.Location = new System.Drawing.Point(616, 279);
            this.btnIncluir.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnIncluir.Name = "btnIncluir";
            this.btnIncluir.Size = new System.Drawing.Size(112, 35);
            this.btnIncluir.TabIndex = 19;
            this.btnIncluir.Text = "Incluir";
            this.btnIncluir.UseVisualStyleBackColor = true;
            this.btnIncluir.Click += new System.EventHandler(this.btnIncluir_Click);
            // 
            // txtTel
            // 
            this.txtTel.Location = new System.Drawing.Point(225, 212);
            this.txtTel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTel.MaxLength = 9;
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(148, 26);
            this.txtTel.TabIndex = 18;
            // 
            // txtDDD
            // 
            this.txtDDD.Location = new System.Drawing.Point(156, 212);
            this.txtDDD.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDDD.MaxLength = 2;
            this.txtDDD.Name = "txtDDD";
            this.txtDDD.Size = new System.Drawing.Size(61, 26);
            this.txtDDD.TabIndex = 17;
            // 
            // txtCid
            // 
            this.txtCid.Location = new System.Drawing.Point(156, 165);
            this.txtCid.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCid.MaxLength = 50;
            this.txtCid.Name = "txtCid";
            this.txtCid.Size = new System.Drawing.Size(284, 26);
            this.txtCid.TabIndex = 16;
            // 
            // txtEnd
            // 
            this.txtEnd.Location = new System.Drawing.Point(156, 118);
            this.txtEnd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtEnd.MaxLength = 100;
            this.txtEnd.Name = "txtEnd";
            this.txtEnd.Size = new System.Drawing.Size(679, 26);
            this.txtEnd.TabIndex = 15;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(156, 76);
            this.txtNome.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNome.MaxLength = 100;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(679, 26);
            this.txtNome.TabIndex = 14;
            // 
            // Inclusao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 341);
            this.Controls.Add(this.txtCPF);
            this.Controls.Add(this.lblTel);
            this.Controls.Add(this.lblCid);
            this.Controls.Add(this.lblend);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblRegiao);
            this.Controls.Add(this.lblCpf);
            this.Controls.Add(this.btnIncluir);
            this.Controls.Add(this.txtTel);
            this.Controls.Add(this.txtDDD);
            this.Controls.Add(this.txtCid);
            this.Controls.Add(this.txtEnd);
            this.Controls.Add(this.txtNome);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Inclusao";
            this.Text = "Inclusão";
            this.Load += new System.EventHandler(this.Inclusao_Clientes_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox txtCPF;
        private System.Windows.Forms.Label lblTel;
        private System.Windows.Forms.Label lblCid;
        private System.Windows.Forms.Label lblend;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblRegiao;
        private System.Windows.Forms.Label lblCpf;
        private System.Windows.Forms.Button btnIncluir;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.TextBox txtDDD;
        private System.Windows.Forms.TextBox txtCid;
        private System.Windows.Forms.TextBox txtEnd;
        private System.Windows.Forms.TextBox txtNome;
    }
}