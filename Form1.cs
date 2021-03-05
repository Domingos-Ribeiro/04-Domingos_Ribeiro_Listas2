using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace _04_Domingos_Ribeiro_Listas2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox1.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                //MessageBox.Show("Como não tem nada digitado... \nNão é possível remover nada!");
                return;
            }

            //Trazer para a variavel S o que estiver na textbox
            string S = textBox2.Text;

            //Contar os nomes identicos da lista
            int limiteSuperior = listBox1.Items.Count;

            for (int i = 0; i < limiteSuperior; i++)
            {
                if (listBox1.Items[i].ToString() == S)
                {
                    listBox1.Items[i] = "--------------> REMOVIDO";
                }

               

            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Ana");
            listBox1.Items.Add("Abel");
            listBox1.Items.Add("Rui");
            listBox1.Items.Add("Carla");
            listBox1.Items.Add("Becas");
            listBox1.Items.Add("Tó");
            listBox1.Items.Add("Bela");
            listBox1.Items.Add("Pedro");
            listBox1.Items.Add("Paulo");
   
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox3.Text == "" || textBox4.Text == "")
            {
                MessageBox.Show("Por favor preencha o Nome da Lista e o Nome a Entrar!");
                return;
            }

            

            DialogResult opcao = new DialogResult();
            Thread.Sleep(500);
            opcao = MessageBox.Show("Caso o nome exista na Lista, a troca será Permanente. \nDeseja continuar? ", "Atenção!", MessageBoxButtons.YesNo , MessageBoxIcon.Warning);
            if (opcao == DialogResult.Yes)
            {
                if (listBox1.Items.Contains(textBox3.Text) == true) // verificar se o nome na textbox existe na listbox com opção contains
                {
                    int posicaoNome; // declarar a variável para que possamos manipular a lista
                    posicaoNome = listBox1.Items.IndexOf(textBox3.Text); // com o indexOf, vamos guardar a posição e onde vai ficar guardado em nome

                    listBox1.Items[posicaoNome] = textBox4.Text;// aqui substituimos a variavel nome pelo que está na textbox inserir

                    

                    Thread.Sleep(2000);

                    MessageBox.Show("O nome " + textBox3.Text + " foi subtituído por: " + textBox4.Text, "Operação efetuada com sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
               }
                else
                {
                    Thread.Sleep(1500);
                    MessageBox.Show("O nome " + textBox3.Text + " não foi encontrado na Lista 1" + "\n \n" + "Nota: Verifique as letras Maiúsculas e Minúsculas.", "Erro!", MessageBoxButtons.OK , MessageBoxIcon.Error);
                }


            }

            
        }

        private void button8_Click(object sender, EventArgs e)
        {
            //Copiar todos os nomes da lista 1 para a lista 2
            listBox2.Items.AddRange(listBox1.Items);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                 listBox1.Items.Remove(listBox1.Items[listBox1.SelectedIndex]);
            }
            catch (Exception)
            {
                MessageBox.Show("Por favor Selecione um Nome na Lista.");
                return;
            }

          
        }
    }
}
