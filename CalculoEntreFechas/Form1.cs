using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculoEntreFechas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        void calculo()
        {
            DateTime fecha1 = dateTimePicker1.Value.Date; //seleccion de la primer fecha desde el calendario

            DateTime fecha2 = dateTimePicker2.Value.Date; //seleccion de la segunda fecha desde el calendario

            TimeSpan resultadoresta = fecha1 - fecha2; // resta las fechas seleccionadas


            float dias = resultadoresta.Days; 
            float semanas = 0.0f;
            semanas = dias / 7;

            txtresultado.Text = dias.ToString(); //muestra el resultado en dias

            txtresultadosemanas.Text = semanas.ToString(); //muestra el resultado en semanas
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            calculo();
        }
    }
}
