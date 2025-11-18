using System.Security.Permissions;

namespace _01_Proyecto_1.Controladores
{
    public class CalculadoraControlller
    {
        public float suma(int n1,int n2)
        {
            return n1 + n2;
        }
        public float resta(int n1, int n2) { 
            return n1 - n2;
        }
        public float multiplicacion(int n1, int n2) {
            return n1 * n2;
        }
        public float division(int n1, int n2)
        {
            try
            {
                return n1 / n2;
            }
            catch (Exception e)
            {
                MessageBox.Show("No se puede realizar la division. " + e.Message);
                return 0;
            }
        }
    }
}
