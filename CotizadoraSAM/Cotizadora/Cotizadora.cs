using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cotizadora
{
    public partial class Cotizadora : Form
    {

        int pesomaterial = 0;
        double total = 0;
        double subtotal = 0;
        double extra = 0;

        private void btBorrar_Click(object sender, EventArgs e)
        {
            txPeso.Text = "";
            txTiempo.Text = "";
        }

        private void btCalcular_Click(object sender, EventArgs e)
        {
            if (txPeso.Text == "")
            {
                lbMen.Text = "Ingrese un peso";
            }
            else {

                /* 
                 Peso
                 */
                if (txTiempo.Text == "")
                {
                    lbMen.Text = "Ingrese un tiempo";
                }
                else
                {
                    pesomaterial = Int32.Parse(txPeso.Text) * 80;
                if (Int32.Parse(txPeso.Text) >= 0 && Int32.Parse(txPeso.Text) <= 100)
                {
                    subtotal = subtotal + 2000;
                }
                else if (Int32.Parse(txPeso.Text) >= 101 && Int32.Parse(txPeso.Text) <= 200)
                {
                    subtotal = subtotal + 4000;
                }
                else if (Int32.Parse(txPeso.Text) >= 201 && Int32.Parse(txPeso.Text) <= 300)
                {
                    subtotal = subtotal + 6000;
                }
                else if (Int32.Parse(txPeso.Text) >= 301 && Int32.Parse(txPeso.Text) <= 400)
                {
                    subtotal = subtotal + 8000;
                }
                else if (Int32.Parse(txPeso.Text) >= 401 && Int32.Parse(txPeso.Text) <= 500)
                {
                    subtotal = subtotal + 10000;
                }

                /* 
                 Tiempo
                 */

                if(Int32.Parse(txTiempo.Text) > 0 && Int32.Parse(txTiempo.Text) < 7)
                    {
                        subtotal = subtotal + 1000;
                    }
                else if (Int32.Parse(txTiempo.Text) >= 7 && Int32.Parse(txTiempo.Text) < 14)
                    {
                        subtotal = subtotal + 2000;
                    }
                 else if (Int32.Parse(txTiempo.Text) >= 14 && Int32.Parse(txTiempo.Text) < 24)
                    {
                        subtotal = subtotal + 3000;
                    }
                    else if (Int32.Parse(txTiempo.Text) >= 24 && Int32.Parse(txTiempo.Text) < 31)
                    {
                        subtotal = subtotal + 4000;
                    }
                    else if (Int32.Parse(txTiempo.Text) >= 31 && Int32.Parse(txTiempo.Text) < 38)
                    {
                        subtotal = subtotal + 5000;
                    }
                    else if (Int32.Parse(txTiempo.Text) >= 38 && Int32.Parse(txTiempo.Text) < 48)
                    {
                        subtotal = subtotal + 6000;
                    }
                    else if (Int32.Parse(txTiempo.Text) >= 48 && Int32.Parse(txTiempo.Text) < 55)
                    {
                        subtotal = subtotal + 7000;
                    }
                    else if (Int32.Parse(txTiempo.Text) >= 55 && Int32.Parse(txTiempo.Text) < 62)
                    {
                        subtotal = subtotal + 8000;
                    }
                    else if (Int32.Parse(txTiempo.Text) >= 62 && Int32.Parse(txTiempo.Text) < 72)
                    {
                        subtotal = subtotal + 9000;
                    }
                    else if (Int32.Parse(txTiempo.Text) >= 72 && Int32.Parse(txTiempo.Text) < 79)
                    {
                        subtotal = subtotal + 10000;
                    }
                    else if (Int32.Parse(txTiempo.Text) >= 79 && Int32.Parse(txTiempo.Text) < 86)
                    {
                        subtotal = subtotal + 11000;
                    }
                    else if (Int32.Parse(txTiempo.Text) >= 86 && Int32.Parse(txTiempo.Text) < 96)
                    {
                        subtotal = subtotal + 12000;
                    }
                    else if (Int32.Parse(txTiempo.Text) >= 96 && Int32.Parse(txTiempo.Text) < 103)
                    {
                        subtotal = subtotal + 13000;
                    }
                    else if (Int32.Parse(txTiempo.Text) >= 103 && Int32.Parse(txTiempo.Text) < 110)
                    {
                        subtotal = subtotal + 14000;
                    }
                    else if (Int32.Parse(txTiempo.Text) >= 110 && Int32.Parse(txTiempo.Text) < 117)
                    {
                        subtotal = subtotal + 15000;
                    }
                    else if (Int32.Parse(txTiempo.Text) >= 117 && Int32.Parse(txTiempo.Text) < 124 )
                    {
                        subtotal = subtotal + 16000;
                    }
                    else
                    {
                        lbMen.Text = "Error, sobrepasó limite";
                    }

                    /* 
                     Fin Tiempo
                     */


                    /* 
                     Extra
                     */
                    if (txExtra.Text == "")
                    {
                        extra = 0;
                    }
                else if(Int32.Parse(txExtra.Text) >= 0 )
                    {
                        extra = Int32.Parse(txExtra.Text);
                        subtotal = subtotal + extra;
                    }
                    else
                    {
                        lbMen.Text = "Error!";
                    }

                    /* 
                     Fin Extra
                     */

                    subtotal = subtotal + pesomaterial;
                    total = subtotal + total;

                    var result = MessageBox.Show("Total de fabricación es: " + total+ "\n\n Total de venta: " +(total* 3)+ "\n\n\n¿Desea ingresar otra cotización?", "Información", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
                    if (result == DialogResult.No)
                    {
                        Application.Exit();
                    }
                    else if(result == DialogResult.Yes)
                    {
                        total = 0;
                        subtotal = 0;
                        extra = 0;
                        lbMen.Text = "";
                        txTiempo.Text = "";
                        txExtra.Text = "";
                        txPeso.Text = "";
                        pesomaterial = 0;
                    }
                }
            }


            
        }

        private void btSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public Cotizadora()
        {
            InitializeComponent();
        }

    }
}
