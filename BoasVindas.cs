using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WikiRemedy
{
    public partial class BoasVindas : Form
    {
        public BoasVindas()
        {
            string m = "Remédios podem causar efeitos colaterais indesejados, evite automedicação. Consulte um médico ou farmacêutico antes de usa-los. (para mais informações clique no botão 'AUTOMEDICAÇÃO' dentro do programa).";
            string c = "ATENÇÃO!";
            MessageBoxButtons b = MessageBoxButtons.OK;
            DialogResult result;
            result = MessageBox.Show(m, c, b);
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 bv = new Form1();
            bv.Closed += (s, args) => this.Close();
            bv.Show();
        }

        private void BoasVindas_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string m = "WikiRemedy é um programa feito com o intuito de auxiliar e informar as pessoas e principalmente os idosos sobre os riscos da automedicação e sobre as contra-indicações dos remédios mais utilizados pela terceira idade.";
            string c = "SOBRE";
            MessageBoxButtons b = MessageBoxButtons.OK;
            DialogResult result;
            result = MessageBox.Show(m, c, b);
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
