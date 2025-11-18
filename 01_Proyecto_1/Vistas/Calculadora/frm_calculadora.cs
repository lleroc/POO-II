using _01_Proyecto_1.Controladores;

namespace _01_Proyecto_1.Vistas.Calculadora
{
    public partial class frm_calculadora : Form
    {
        CalculadoraControlller controlador = new CalculadoraControlller();
        public frm_calculadora()
        {
            InitializeComponent();
        }

        private void btn_1_Click(object sender, EventArgs e)
        {
            txt_resultaados.Text += (1).ToString();
            if (lbl_Resultados.Text == "0.0")
            {
                lbl_Resultados.Text = (1).ToString();
            }
            else
            {
                lbl_Resultados.Text += (1).ToString();
            }
        }

        private void btn_2_Click(object sender, EventArgs e)
        {
            txt_resultaados.Text += (2).ToString();
            lbl_Resultados.Text += (2).ToString();

        }

        private void n_3_Click(object sender, EventArgs e)
        {
            txt_resultaados.Text += (3).ToString();

        }

        private void btn_4_Click(object sender, EventArgs e)
        {
            txt_resultaados.Text += (4).ToString();

        }

        private void btn_5_Click(object sender, EventArgs e)
        {
            txt_resultaados.Text += (5).ToString();

        }

        private void btn_6_Click(object sender, EventArgs e)
        {
            txt_resultaados.Text += (6).ToString();

        }

        private void btn_7_Click(object sender, EventArgs e)
        {
            txt_resultaados.Text += (7).ToString();

        }

        private void tn_8_Click(object sender, EventArgs e)
        {
            txt_resultaados.Text += (8).ToString();

        }

        private void btn_9_Click(object sender, EventArgs e)
        {
            txt_resultaados.Text += (9).ToString();

        }

        private void tn_0_Click(object sender, EventArgs e)
        {
            txt_resultaados.Text += (0).ToString();

        }
        private void btn_suma_Click(object sender, EventArgs e)
        {
            txt_resultaados.Text += "+";
        }

        private void btn_resta_Click(object sender, EventArgs e)
        {
            txt_resultaados.Text += "-";

        }

        private void n_multiplicacion_Click(object sender, EventArgs e)
        {
            txt_resultaados.Text += "*";

        }

        private void btn_division_Click(object sender, EventArgs e)
        {
            txt_resultaados.Text += "/";
        }

        private void btn_igual_Click(object sender, EventArgs e)
        {
            var valores = txt_resultaados.Text.Split('+');
            if (valores.Count() >= 2 )
            {
               txt_resultaados.Text = controlador
                    .suma(Convert.ToInt32(valores[0]), 
                    Convert.ToInt32(valores[1])).ToString();
            }
            valores = txt_resultaados.Text.Split('-');
            if (valores.Count() >= 2)
            {
                txt_resultaados.Text = controlador
                     .resta(Convert.ToInt32(valores[0]),
                     Convert.ToInt32(valores[1])).ToString();
            }
            valores = txt_resultaados.Text.Split('*');
            if (valores.Count() >= 2)
            {
                txt_resultaados.Text = controlador
                     .multiplicacion(Convert.ToInt32(valores[0]),
                     Convert.ToInt32(valores[1])).ToString();
            }
            valores = txt_resultaados.Text.Split('/');
            if (valores.Count() >= 2)
            {
                txt_resultaados.Text = controlador
                     .division(Convert.ToInt32(valores[0]),
                     Convert.ToInt32(valores[1])).ToString();
            }
        }
    }
}
