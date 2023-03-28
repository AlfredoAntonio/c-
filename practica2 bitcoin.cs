using static System.Windows.Forms.Design.AxImporter;

namespace practica2
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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void procesar_Click(object sender, EventArgs e)
        {

               
            if (opciones.SelectedIndex ==-1)
            {
                MessageBox.Show("Debes seleccionar una opcion ");
               


            }
            else
            {

                string op = opciones.SelectedItem.ToString();
                double valor1=Convert.ToInt32(gastar.Text);
                
                

                

                double respuesta = this.operaciones(valor1,
                op);
                resultado.Text = respuesta.ToString();

            }

        }
        public double operaciones(double valor1, String op )
        {


            double resultado = 0;
            switch (op)

            {
                case "DOGE":
                    resultado = (valor1/ 0.001);
                    
                    break;
                case "XRP":
                    resultado   = (valor1 /1.6);
                   
                    break;
                case "BITCOIN":
                    resultado = (valor1 /   10000);
                     break;
                case "BAT":
                    resultado = (valor1 / 1 );
                    break;
                default:
                    MessageBox.Show("NO ES UNA OPCION VALIDA");
                    break;

            }
            return resultado;

        }

    }
}
