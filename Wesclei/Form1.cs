using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Wesclei
{
    public partial class Form1 : Form
    {
        SqlConnection sqlCon = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\NULL\Desktop\Test_ACME\DB\ACME.mdf;Integrated Security=True;Connect Timeout=30");

        int ID_VOO = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Incluir();
            FillDataGridView();
        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            try
            {
                if (sqlCon.State == ConnectionState.Closed)
                    sqlCon.Open();
                if (btn_salvar.Text == "Salvar")
                {
                    SqlCommand sqlCmd = new SqlCommand("AddOrEditar", sqlCon);
                    sqlCmd.CommandType = CommandType.StoredProcedure;
                    sqlCmd.Parameters.AddWithValue("@MODE", "ADD");

                    qlCmd.Parameters.AddWithValue("@ID_VOO", 0);
                    sqlCmd.Parameters.AddWithValue("@DATA_VOO", data.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@CUSTO", lb_custo.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@DISTANCIA", lb_distância.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@CAPTURA", lb_captura.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@NIVEL_DOR", lb_nivel.Text.Trim());
                    sqlCmd.ExecuteNonQuery();
                    MessageBox.Show("Salvo com sucesso !");
                }
                Incluir();
                FillDataGridView();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro");
            }
            finally
            {
                sqlCon.Close();
            }
        }

        private void dataGridView1_Scroll(object sender, ScrollEventArgs e)
        {
            try
            {
                FillDataGridView();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro");
            }
        }

        private void FillDataGridView()
        {
            if (sqlCon.State == ConnectionState.Closed)
                sqlCon.Open();
            SqlDataAdapter sqlDa = new SqlDataAdapter("AddOrEditar", sqlCon);
            sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
            sqlDa.SelectCommand.Parameters.AddWithValue("", dataGridView1.Rows);
            DataTable dtbl = new DataTable();
            sqlDa.Fill(dtbl);
            dataGridView1.DataSource = dtbl;
            dataGridView1.Columns[0].Visible = false;
            sqlCon.Close();
            
        }

        private void dataGridView1_ReadOnlyChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            if(dataGridView1.CurrentRow.Index != 1)
            {
                ID_VOO = Convert.ToInt32(dataGridView1.CurrentRow.Cells[1].Value.ToString());
                data.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                lb_captura.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                tx_nivel.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                btn_salvar.Text = "Salvar";
                btn_cancelar.Enabled = true;
                btn_incluir.Enabled = true;
                btn_excluir.Enabled = true;
            }
        }
        void Incluir()
        {
            data.Text = lb_custo.Text = lb_distância.Text = lb_captura.Text = tx_nivel.Text = "";
            btn_incluir.Enabled = true;
            ID_VOO = 0;
        }

        private void btn_incluir_Click(object sender, EventArgs e)
        {
            Incluir();
        }

        private void btn_excluir_Click(object sender, EventArgs e)
        {
            try
            {
                if (sqlCon.State == ConnectionState.Closed)
                    sqlCon.Open();
                    SqlCommand sqlCmd = new SqlCommand("Excluir", sqlCon);
                    sqlCmd.CommandType = CommandType.StoredProcedure;

                    sqlCmd.Parameters.AddWithValue("@ID_VOO", ID_VOO);
                    sqlCmd.ExecuteNonQuery();
                    MessageBox.Show("Excluído com sucesso !");
                Incluir();
                FillDataGridView();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro");
            }
        }
    }
}
