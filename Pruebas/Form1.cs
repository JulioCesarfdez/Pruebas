using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pruebas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            panel3.Visible = panel3.Visible? false:true;            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            remplazarForm(new FormulariaRemplazar1());
        }


        Form formRemplazar = null;
        private void remplazarForm(Form formulario)
        {
            //if (formRemplazar != null) formRemplazar.Close();
            formulario.TopLevel = false;
            formRemplazar = formulario;
            panel4.Controls.Add(formulario);
            formulario.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (formRemplazar != null) formRemplazar.Close();
        }
    }
}
