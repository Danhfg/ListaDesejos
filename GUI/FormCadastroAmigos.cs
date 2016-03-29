using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Controller;
using Model;

namespace GUI
{
    public partial class FormCadastroAmigos : Form
    {
        private ControllerAmigo controle;
        public FormCadastroAmigos()
        {
            InitializeComponent();
            controle = new ControllerAmigo();
            novo();
        }

        private void atualizarDataGrid()
        {
            dataGridViewAmigo.DataSource = controle.ListarAmigos();
            dataGridViewAmigo.Columns[0].Visible = false;            
        }

        private void novo()
        {
            textBoxName.Text = "";
            textBoxEmail.Text = "";
            textBoxIDAmigo.Text = "0";
        }

        private void buttonGravar_Click(object sender, EventArgs e)
        {
            Amigo amigo = new Amigo();
            amigo.IDAmigo = Convert.ToInt32(textBoxIDAmigo.Text);
            amigo.Nome = textBoxName.Text;
            amigo.Email = textBoxEmail.Text;
            amigo.DataNascimento = dateTimePickerDataDesejo.Value;

            if (controle.GravarAmigo(amigo))
            {
                MessageBox.Show("Amigo Salvo com Sucesso");
                novo();
                atualizarDataGrid();
            }
            else
            {
                MessageBox.Show("Erro ao Salvar Amigo");
            }

        }

        private void buttonExcluir_Click(object sender, EventArgs e)
        {
            int idAmigo = Convert.ToInt32(textBoxIDAmigo.Text);

            if (controle.ExcluirAmigo(idAmigo))
            {
                MessageBox.Show("Funcionário Excluido com Sucesso");
                novo();
                atualizarDataGrid();
            }
            else
            {
                MessageBox.Show("Erro Excluindo Funcionário");
            }
        }

        private void dataGridViewAmigo_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewAmigo.CurrentRow != null)
            {
                List<Amigo> lista = (List<Amigo>)dataGridViewAmigo.DataSource;
                Amigo amigo = lista[dataGridViewAmigo.CurrentRow.Index];
                textBoxName.Text = amigo.Nome;
                textBoxEmail.Text = amigo.Email;
                textBoxIDAmigo.Text = amigo.IDAmigo.ToString();
            }
        }

    }
}
