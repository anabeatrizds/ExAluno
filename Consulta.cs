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
    
    public partial class Consulta : Form
    {
        SqlConnection conexao = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\AnaDosSantos\source\repos\ExAula7Cliente\ExAula7Cliente\data.mdf;Integrated Security=True");
        SqlCommand cmd;
        SqlDataReader dr;

        public Consulta()
        {
            InitializeComponent();
        }

        private void Consulta_Cliente_Load(object sender, EventArgs e)
        {
            try
            {
                conexao.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro:" + ex.Message.ToString(), "Conexão Banco");
            }
        }

        private void btnPesq_Click(object sender, EventArgs e)
        {
            String cmd_sql;
            cmd_sql = "SELECT NOME, CPF, ENDERECO, CIDADE FROM CLIENTES WHERE CPF LIKE '%" + txtCpfConsul.Text + "%'";
            cmd = new SqlCommand(cmd_sql, conexao);
            dr = cmd.ExecuteReader();

            if (dr.HasRows)
            {
                listClientes.Items.Clear();
                while (dr.Read())
                {
                    listClientes.Items.Add("Nome: " + dr["nome"].ToString() + " - " + "CPF: " + dr["cpf"].ToString() + " - " + "Endereço: " + dr["endereco"].ToString() + " - " + "Cidade:" + dr["cidade"].ToString());
                }
            }
            else
            {
                MessageBox.Show("Registro Não Localizado", "Consulta - Aluno");
            }

            dr.Close();
            cmd.Dispose();
        }

        private void txtCpfConsul_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void lstClientes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
