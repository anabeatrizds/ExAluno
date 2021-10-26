
namespace ExAula7Cliente
{
    partial class Consulta
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
            this.components = new System.ComponentModel.Container();
            this.txtCpfConsul = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPesq = new System.Windows.Forms.Button();
            this.clientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cadastrarDataSet = new ExAula7Cliente.CadastrarDataSet();
            this.clientesTableAdapter = new ExAula7Cliente.CadastrarDataSetTableAdapters.clientesTableAdapter();
            this.listClientes = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cadastrarDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCpfConsul
            // 
            this.txtCpfConsul.Location = new System.Drawing.Point(176, 73);
            this.txtCpfConsul.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCpfConsul.Mask = "000.000.000-00";
            this.txtCpfConsul.Name = "txtCpfConsul";
            this.txtCpfConsul.Size = new System.Drawing.Size(133, 26);
            this.txtCpfConsul.TabIndex = 0;
            this.txtCpfConsul.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.txtCpfConsul_MaskInputRejected);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(112, 76);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "CPF:";
            // 
            // btnPesq
            // 
            this.btnPesq.Location = new System.Drawing.Point(612, 62);
            this.btnPesq.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnPesq.Name = "btnPesq";
            this.btnPesq.Size = new System.Drawing.Size(228, 48);
            this.btnPesq.TabIndex = 2;
            this.btnPesq.Text = "Pesquisar";
            this.btnPesq.UseVisualStyleBackColor = true;
            this.btnPesq.Click += new System.EventHandler(this.btnPesq_Click);
            // 
            // clientesBindingSource
            // 
            this.clientesBindingSource.DataMember = "clientes";
            this.clientesBindingSource.DataSource = this.cadastrarDataSet;
            // 
            // cadastrarDataSet
            // 
            this.cadastrarDataSet.DataSetName = "CadastrarDataSet";
            this.cadastrarDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clientesTableAdapter
            // 
            this.clientesTableAdapter.ClearBeforeFill = true;
            // 
            // listClientes
            // 
            this.listClientes.FormattingEnabled = true;
            this.listClientes.ItemHeight = 20;
            this.listClientes.Location = new System.Drawing.Point(13, 131);
            this.listClientes.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listClientes.Name = "listClientes";
            this.listClientes.Size = new System.Drawing.Size(870, 264);
            this.listClientes.TabIndex = 3;
            this.listClientes.Visible = false;
            this.listClientes.SelectedIndexChanged += new System.EventHandler(this.lstClientes_SelectedIndexChanged);
            // 
            // Consulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 409);
            this.Controls.Add(this.listClientes);
            this.Controls.Add(this.btnPesq);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCpfConsul);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Consulta";
            this.Text = "Consulta_Cliente";
            this.Load += new System.EventHandler(this.Consulta_Cliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cadastrarDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox txtCpfConsul;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPesq;
        private CadastrarDataSet cadastrarDataSet;
        private System.Windows.Forms.BindingSource clientesBindingSource;
        private CadastrarDataSetTableAdapters.clientesTableAdapter clientesTableAdapter;
        private System.Windows.Forms.ListBox listClientes;
    }
}