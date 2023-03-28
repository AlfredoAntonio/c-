using System.Diagnostics.Eventing.Reader;

namespace practica1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           MessageBox.Show("hola que tal ");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void cmdOpciones_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void resolver_Click(object sender, EventArgs e)
        {

            if (cmdOpciones.SelectedIndex == -1)
            {

                MessageBox.Show("debes seleccionar una opcion ");

            }


            else
            {
                String opcion = cmdOpciones.SelectedItem.ToString();
                int valor01 = Convert.ToInt32(txt1.Text);
                int valor02 = Convert.ToInt32(txt2.Text);
                int RESPUESTA = this.resolverOperacion(
                    valor01,
                    valor02,
                    opcion);
                txtResultado.Text = RESPUESTA.ToString();

            }


        }
        public int resolverOperacion(int valor01, int valor02, String opcion)
        {

            int RESPUESTA = 0;
            switch (opcion)

            {
               
                case "SUMA" :
                    RESPUESTA = valor01 + valor02;
                    break;
                case "RESTAR" :
                    RESPUESTA = valor01 - valor02;
                    break;

                case "MULTIPLICAR":
                    RESPUESTA = valor01 * valor02 ;
                    break;
                case "DIVIDIR":
                    RESPUESTA = valor01 / valor02;
                    break;
                default:
                    MessageBox.Show("NO ES UNA OPCION VALIDA");
                    break;

            }
            return RESPUESTA;

        }



    }
}