using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            //Trazer para a variavel S o que estiver na textbox
            string S = textBox2.Text;

            //Contar os nomes identicos da lista
            int limiteSuperior = listBox1.Items.Count - 1;

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
           
        }
    }
}
