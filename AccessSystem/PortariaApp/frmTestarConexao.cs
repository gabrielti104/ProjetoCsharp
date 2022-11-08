using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace PortariaApp
{
    public partial class frmTestarConexao : Form
    {
        public frmTestarConexao()
        {
            InitializeComponent();
        }

        private void btnconectar_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection();
            conn.ConnectionString = "Server=localhost;Port=3306;Database=dbportaria;Uid=root;Pwd=''";
            try
            {
                conn.Open();
                lblmensagem.Text = "Banco de dados conectado";
            }
            catch (MySqlException)
            {
                lblmensagem.Text = "Erro ao conectar";
            }
        }

        private void btndesconectar_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection();
            try
            {
                conn.Close();
                lblmensagem.Text = "Banco de dados desconectado";
            }
            catch (MySqlException)
            {
                lblmensagem.Text = "Erro ao conectar";
            }
        }
    }
}
