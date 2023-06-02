using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalcularMedia
{
    public partial class Form1 : Form
    {
        float nota1, nota2, nota3, nota4, media;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {

            nota1 = float.Parse(txtNota1.Text);
            nota2 = float.Parse(txtNota2.Text);
            nota3 = float.Parse(txtNota3.Text);
            nota4 = float.Parse(txtNota4.Text);
            media = (nota1 + nota2 + nota3 + nota4)/ 4;

            txtMedia.Text = Convert.ToString(media);

            if( media >= 7 && media <= 8)
            {
                lblResultado.Text = "APROVADO NA MARRA";
            }
            if (media > 8.5)
            {
                lblResultado.Text = "APROVADO";
            }
     
            else
            {
                lblResultado.Text = "REPROVADO";
            }
        } 
    }
}
