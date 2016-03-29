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
    public partial class FormCadastroDesejos : Form
    {
        private ControllerAmigo controleAmigo;
        private ControllerDesejo controleDesejo;
        private List<Amigo> listaAmigo;
        private AutoCompleteStringCollection listaNomeAmigos;
        private Amigo amigoSolicitadoAtual;
        private Desejo desejoAtual;
        private Amigo amigoSolicitanteAtual;

        public FormCadastroDesejos()
        {
            InitializeComponent();
        }
        private void novo()
        {
            desejoAtual = new Desejo();
            textBoxAmigoSolicitado.Text = "";
            textBoxAmigoSolicitante.Text = "";
            textBoxValorDesejo.Text = "0";
            richTextBoxDescricao.Text = "";
        }
        
        private void autocomplete()
        {
            //Autocomplete da caixa de texto referente aos funcionários
            textBoxAmigoSolicitado.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            textBoxAmigoSolicitante.AutoCompleteSource = AutoCompleteSource.CustomSource;
            listaAmigo = controleAmigo.ListarAmigos();
            listaNomeAmigos = new AutoCompleteStringCollection();
            foreach (Amigo amigo in listaAmigo)
            {
                listaNomeAmigos.Add(amigo.Nome);
            }
            textBoxAmigoSolicitado.AutoCompleteCustomSource = listaNomeAmigos;
            textBoxAmigoSolicitante.AutoCompleteCustomSource = listaNomeAmigos;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            novo();
        }

        private void textBoxAmigoSolicitante_TextChanged(object sender, EventArgs e)
        {
            int index = listaNomeAmigos.IndexOf(textBoxAmigoSolicitante.Text);
            if (index == -1)
            {
                amigoSolicitanteAtual = null;
                return;
            }
            amigoSolicitanteAtual = listaAmigo[index];
            desejoAtual.Solicitante = amigoSolicitanteAtual;
        }

        private void textBoxAmigoSolicitado_TextChanged(object sender, EventArgs e)
        {
            int index = listaNomeAmigos.IndexOf(textBoxAmigoSolicitado.Text);
            if (index == -1)
            {
                amigoSolicitadoAtual = null;
                return;
            }
            amigoSolicitadoAtual = listaAmigo[index];
            desejoAtual.Solicitado = amigoSolicitadoAtual;
        }


        private void button2_Click(object sender, EventArgs e)
        {
            desejoAtual.Valor = Convert.ToInt32(textBoxValorDesejo.Text);
            desejoAtual.Descricao = richTextBoxDescricao.Text;
            desejoAtual.DataDesejo = dateTimePickerDataDesejo.Value;
            if (controleDesejo.GravarDesejo(desejoAtual))
            {
                MessageBox.Show("Desejo Salvo com sucesso");
                novo();
            }
            else MessageBox.Show("Erro ao salvar Desejo");
        }

    }
}
