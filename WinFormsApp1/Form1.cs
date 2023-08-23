using WinFormsApp1.Algoritmos;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Paso1: Inicialización de parámetros
            int recursos = Convert.ToInt32(textBox1.Text);
            int tareas = Convert.ToInt32(textBox2.Text);

            //Paso2: Declarar clase algoritmo genético
            AlgoritmoGenetico algoritmo = new AlgoritmoGenetico();

            //Paso3: Llamar método principal
            algoritmo.AlgoritmoPrincipal(recursos, tareas);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}