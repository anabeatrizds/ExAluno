using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExAula7Cliente
{
    public partial class Inclusao : Form
    {
        SqlConnection conexao = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\AnaDosSantos\source\repos\ExAula7Cliente\ExAula7Cliente\data.mdf;Integrated Security=True");
        SqlCommand cmd;

        public Inclusao()
        {
            InitializeComponent();
        }

        private void Inclusao_Clientes_Load(object sender, EventArgs e)
        {
            try
            {
                conexao.Open();
                MessageBox.Show("Conexão Ok", "Conexão Banco");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message.ToString(), "Conexão Banco");
            }
        }

        private void txtCpf_Leave(object sender, EventArgs e)
        {
            string result = txtCPF.Text.Substring(10, 1);

            if (result == "0")
            {
                lblRegiao.Text = "Região: Rio Grande do Sul";
            }

            if (result == "1")
            {
                lblRegiao.Text = "Região: Distrito Federal, Goiáis, Mato Grosso do Sul e Tocantins";
            }

            if (result == "2")
            {
                lblRegiao.Text = "Região: Amazonas, Pará, Roraima, Amapá, Acre e Rondônia";
            }

            if (result == "3")
            {
                lblRegiao.Text = "Região: Ceará, Maranhão e Piauí ";
            }

            if (result == "4")
            {
                lblRegiao.Text = "Região: Paraiba, Pernambuco, Alagoas e Rio Grande do Sul";
            }

            if (result == "5")
            {
                lblRegiao.Text = "Região: Bahia e Sergipe";
            }

            if (result == "6")
            {
                lblRegiao.Text = "Região: Minas Gerais";
            }

            if (result == "7")
            {
                lblRegiao.Text = "Região: Rio de Janeiro e Espirito Santo";
            }

            if (result == "8")
            {
                lblRegiao.Text = "Região: São Paulo";
            }

            if (result == "9")
            {
                lblRegiao.Text = "Região: Paraná e Santa Catarina";
            }

            if (txtCPF.Text.Length < 14)
            {
                txtCPF.Text = "";
            }
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            int retorno;
            String cmd_sql;
            cmd_sql = "INSERT INTO CLIENTES (NOME,ENDERECO,CIDADE,DDD,TELEFONE,CPF) VALUES ('" + txtNome.Text + "','" + txtEnd.Text + "','" + txtCid.Text + "','" + txtDDD.Text + "','" + txtTel.Text + "','" + txtCPF.Text + "')";
            cmd = new SqlCommand(cmd_sql, conexao);
            retorno = cmd.ExecuteNonQuery(); //Somente para instruções Insert/Delete/update

            if (retorno > 0)
            {
                MessageBox.Show("Cadastrado com Sucesso!!!", "Cadastro - Cliente");
                Limpar();

            }
            else
            {
                MessageBox.Show("Cadastro Não Realizado!!!", "Cadastro - Cliente");
            }

            cmd.Dispose();
        }

        private void Limpar()
        {
            txtNome.Text = "";
            txtCPF.Text = "";
            txtEnd.Text = "";
            txtTel.Text = "";
            txtCid.Text = "";
            txtDDD.Text = "";
            lblRegiao.Text = "Região:";

        }

        private void lblReg_Click(object sender, EventArgs e)
        {

        }
    }
}
