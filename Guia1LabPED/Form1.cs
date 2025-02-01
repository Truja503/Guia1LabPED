using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Guia1LabPED
{
    public partial class Form1 : Form
    {

        //PROGRAMACION CON ESTRUCTURA DE DATOS
        //O9L
        //ESTUDIANTES: 
        //Julian Benjamin Moreno Castillo MC230813
        //Óscar Alejandro Paredes Alfaro PA240326
        //Rodrigo Guillermo Trujillo Diaz TD240434
        //INGENIERO: 
        //René Mauricio Tejada Tobar

        public double Num1, Num2, Resultado;
        public bool Is1, Is2, Es_op;
        int Operacion;
        public Form1()
        {

            InitializeComponent();
            Is1 = Is2 = false;
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            limpiar_pantalla();
        }

        private void btnsuma_Click(object sender, EventArgs e)
        {
            if (!Is1)
            {
                Num1 = obtener_valor();
                Is1 = true;
                Operacion = 0;
            }
        }

        //funciones necesarias
        public void limpiar_pantalla()
        {
            txtpantalla.Text = "";
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            actualizar_pantalla("1");
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            actualizar_pantalla("2");
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            actualizar_pantalla("0");

        }

        private void btn3_Click(object sender, EventArgs e)
        {
            actualizar_pantalla("3");

        }

        private void btn4_Click(object sender, EventArgs e)
        {
            actualizar_pantalla("4");

        }

        private void btn5_Click(object sender, EventArgs e)
        {
            actualizar_pantalla("5");

        }

        private void btn6_Click(object sender, EventArgs e)
        {
            actualizar_pantalla("6");

        }

        private void btn7_Click(object sender, EventArgs e)
        {
            actualizar_pantalla("7");

        }

        private void btn8_Click(object sender, EventArgs e)
        {
            actualizar_pantalla("8");

        }

        private void btn9_Click(object sender, EventArgs e)
        {
            actualizar_pantalla("9");

        }

        private void btnresta_Click(object sender, EventArgs e)
        {
            if (!Is1)
            {
                Num1 = obtener_valor();
                Is1 = true;
                Operacion = 1;
            }
        }

        private void btnmultiplicar_Click(object sender, EventArgs e)
        {
            if (!Is1)
            {
                Num1 = obtener_valor();
                Is1 = true;
                Operacion = 2;
            }
        }

        private void btndividir_Click(object sender, EventArgs e)
        {
            if (!Is1)
            {
                Num1 = obtener_valor();
                Is1 = true;
                Operacion = 3;
            }
        }

        private void btnln_Click(object sender, EventArgs e)
        {
            try
            {
                // Obtener el número del TextBox
                double number = double.Parse(txtpantalla.Text);

                // Verificar que el número sea mayor que 0
                if (number > 0)
                {
                    // Calcular el logaritmo
                    //utilizamos la funcion Math.log
                    double result = Math.Log(number);

                    // Mostrar el resultado en el TextBox
                    txtpantalla.Text = result.ToString();
                }
                else
                {
                    MessageBox.Show("Por favor, ingrese un numero mayor que 0.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, ingrese un numero válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnlog_Click(object sender, EventArgs e)
        {
            try
            {
                // Obtenemos  el número del TextBox
                double number = double.Parse(txtpantalla.Text);

                // Verificamos que el número sea mayor que 0
                if (number > 0)
                {
                    // Calcular el logaritmo base 10
                    //Utilizando la funcion Math.log10
                    double result = Math.Log10(number);

                    // Mostramos el resultado en el TextBox
                    txtpantalla.Text = result.ToString();
                }
                else
                {
                    MessageBox.Show("Por favor, ingrese un numero mayor que 0.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, ingrese un numero válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnsen_Click(object sender, EventArgs e)
        {
            //obtenemos el numero directamente
            double num1 = Convert.ToDouble(txtpantalla.Text);
            //calculamos los radianes dado que MATH solo trabaja con ellos
            double radianes = num1 * (Math.PI / 180);
            //calculamos usando la libreria MATH
            double result = Math.Sin(radianes);
            //imprimimos en la pantalla
            txtpantalla.Text = result.ToString();
        }

        private void btncos_Click(object sender, EventArgs e)
        {
            //obtenemos el numero directamente
            double num1 = Convert.ToDouble(txtpantalla.Text);
            //calculamos los radianes dado que MATH solo trabaja con ellos
            double radianes = num1 * (Math.PI / 180);
            //calculamos usando la libreria MATH
            double result = Math.Cos(radianes);
            //imprimimos en la pantalla
            txtpantalla.Text = result.ToString();
        }

        private void btntan_Click(object sender, EventArgs e)
        {
            //obtenemos el numero directamente
            double num1 = Convert.ToDouble(txtpantalla.Text);
            //calculamos los radianes dado que MATH solo trabaja con ellos
            double radianes = num1 * (Math.PI / 180);
            //calculamos usando la libreria MATH
            double result = Math.Tan(radianes);
            //imprimimos en la pantalla
            txtpantalla.Text = result.ToString();
        }

        private void btnpotencia_Click(object sender, EventArgs e)
        {
            //dado que necesitamos mas de 1 valor vamos a utilizar lo mismo que se uso para las operaciones basicas
            if (!Is1)
            {
                Num1 = obtener_valor();
                Is1 = true;
                Operacion = 4;
            }

        }

        private void button11_Click(object sender, EventArgs e)
        {
            actualizar_pantalla(".");
        }

        private void btnCE_Click(object sender, EventArgs e)
        {
            //eliminar un solo caracter
            if (txtpantalla.Text.Length > 0) // Verificar que haya caracteres
            {
                txtpantalla.Text = txtpantalla.Text.Substring(0, txtpantalla.Text.Length - 1);
            }
        }

        public double obtener_valor()
        {
            //para transformar lo que se digite a formato numerico
            double valor = Convert.ToDouble(txtpantalla.Text);
            limpiar_pantalla();
            return valor;
        }
        public void actualizar_pantalla(String texto)
        {
            txtpantalla.Text = txtpantalla.Text + texto;
        }


        private void btnigual_Click(object sender, EventArgs e)
        {
            try
            {
                if (Operacion == 0)
                {
                    if (Is1)
                    {
                        Num2 = obtener_valor();
                        actualizar_pantalla(operar(Num1, Num2, "+").ToString());
                        Is1 = false;
                    }
                    else
                    {
                        MessageBox.Show("Seleccione una operacion requerida");

                          
                    }
                }
                if (Operacion == 1)
                {
                    if (Is1)
                    {
                        Num2 = obtener_valor();
                        actualizar_pantalla(operar(Num1, Num2, "-").ToString());
                        Is1 = false;
                    }
                    else
                    {
                        MessageBox.Show("Seleccione una operacion requerida");
                    }
                }
                if (Operacion == 2)
                {
                    if (Is1)
                    {
                        Num2 = obtener_valor();
                        actualizar_pantalla(operar(Num1, Num2, "*").ToString());
                        Is1 = false;
                    }
                    else
                    {
                        MessageBox.Show("Seleccione una operacion requerida");
                    }
                }
                if (Operacion == 3)
                {
                    if (Is1)
                    {
                        Num2 = obtener_valor();
                        actualizar_pantalla(operar(Num1, Num2, "/").ToString());
                        Is1 = false;
                        if(Num2 == 0)
                        {
                            MessageBox.Show("No se puede dividir entre 0!");
                            limpiar_pantalla();
                        }

                    }
                    else
                    {
                        MessageBox.Show("Seleccione una operacion requerida");
                    }
                }
                if (Operacion == 4)
                {
                    if (Is1)
                    {
                        Num2 = obtener_valor();
                        actualizar_pantalla(operar(Num1, Num2, "^").ToString());
                        Is1 = false;
                    }
                    else
                    {
                        MessageBox.Show("Seleccione una operacion requerida");
                    }
                }
            }
            catch
            {
                MessageBox.Show("Esta operacion requiere de dos operandos");
            }

        }

        public double operar(double operador1, double operador2, String signo)
        {
            double Resultado = 0.0;
            switch (signo)
            {
                case "+":
                    Resultado = operador1 + operador2;
                    break;
                case "-":
                    Resultado = operador1 - operador2;
                    break;
                case "*":
                    Resultado = operador1 * operador2;
                    break;
                case "/":
                    try
                    {
                        Resultado = operador1 / operador2;
                    }
                    catch
                    {
                        MessageBox.Show("No puede dividir entre 0");
                    }
                    break;
                case "^":
                    Resultado = Math.Pow(operador1, operador2);
                    break;
                default: break;
            }
            return Resultado;
        }
    }
}
