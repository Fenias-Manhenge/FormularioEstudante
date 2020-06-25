using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Collections;

namespace FormularioEstudante
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           /* OleDbConnection conection = null;

            try
            {
                String path = @"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = C:\BD-AULA\Estudante.accdb";

                conection = new OleDbConnection(path);
               
                MessageBox.Show("Conectou com sucesso", "Conexão", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Conexão", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conection.Close();
            }*/
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OleDbCommand command = null;

            OleDbConnection connection = connect();

            try
            {
                connection.Open();

                String sqlInsert = "insert into Estudante1(CODIGO,NOME,TURMA,CONTACTO) values(?,?,?,?)";

                command = new OleDbCommand(sqlInsert, connection);
                
                command.Parameters.Add(new OleDbParameter("CODIGO", int.Parse(txtCode.Text)));

                command.Parameters.Add(new OleDbParameter("NOME", txtName.Text));

                command.Parameters.Add(new OleDbParameter("TURMA", txtClass.Text));

                command.Parameters.Add(new OleDbParameter("CONTACTO", txtContact.Text));

                command.ExecuteNonQuery(); clean();

                MessageBox.Show("CADASTRO FEITO COM SUCESSO!", "CADASTRO", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro no Cadastro: " + ex.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Close();
            }
        }

        public static OleDbConnection connect()
        {
            OleDbConnection connection = null;

            try
            {
                String path = @"Provider = Microsoft.ACE.OLEDB.12.0;Data Source = C:\bdAulas\Estudante1.accdb";

                connection = new OleDbConnection(path);

                //MessageBox.Show("Conectou com sucesso", "Conexão", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro na conexão: " + ex.Message, "Conexão", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Close();
            }
            return connection;
        }

        public void clean()
        {
            txtCode.Clear();
            txtName.Clear();
            txtClass.Clear();
            txtContact.Clear();
        }

        public static ArrayList recoverStudent()
        {
            OleDbConnection connection = connect();
            OleDbDataReader read = null;
            OleDbCommand command = null;

            ArrayList student = new ArrayList();

            try
            {
                connection.Open();

                string selection = "select* From Estudante1";

                command = new OleDbCommand(selection, connection);

                read = command.ExecuteReader();

                while (read.Read())
                {
                    student.Add(new ModelEstudante(read.GetInt32(0), read.GetString(1),
                        read.GetString(2), read.GetString(3)));
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Erro na solicitação de dados: " + e.Message, "DADOS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Close();
            }
            return student;
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            ArrayList student = recoverStudent();

            lstList.Items.Clear();

            foreach (ModelEstudante studentModel in student)
            {
                ListViewItem lstVItem = new ListViewItem();

                lstVItem.Text = studentModel.GetCodigo() + "";
                lstVItem.SubItems.Add(studentModel.GetNome());
                lstVItem.SubItems.Add(studentModel.GetTurma());
                lstVItem.SubItems.Add(studentModel.GetContacto());

                lstList.Items.Add(lstVItem);
            }
        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }
    }
}
