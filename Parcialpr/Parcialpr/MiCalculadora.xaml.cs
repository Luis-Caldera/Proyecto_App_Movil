using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Parcialpr
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MiCalculadora : ContentPage
    {
        public MiCalculadora()
        {
            InitializeComponent();
            btnSuma.Clicked += BtnSuma_Clicked;
            btnResta.Clicked += BtnResta_Clicked;
            btnMultiplicacion.Clicked += BtnMultiplicacion_Clicked;
            btnDivision.Clicked += BtnDivision_Clicked;
            btnPorcentaje.Clicked += BtnPorcentaje_Clicked;
            btnPotencia.Clicked += BtnPotencia_Clicked;
            btnRaiz.Clicked += BtnRaiz_Clicked;
           
            btnLimpiar.Clicked += BtnLimpiar_Clicked;
        }

        private void BtnLimpiar_Clicked(object sender, EventArgs e)
        {
            entNumero1.Text = "";
            entNumero2.Text = "";
            lblResultado.Text = "0.0";
        }

       
        private void BtnRaiz_Clicked(object sender, EventArgs e)
        {
            try
            {
                lblResultado.Text = Math.Sqrt(Double.Parse(entNumero1.Text)).ToString("N2");
            }
            catch (Exception)
            {
                DisplayAlert("Error", "No se encontraron datos y solo se permiten numeros", "OK");
            }
        }

        private void BtnPotencia_Clicked(object sender, EventArgs e)
        {
            try
            {
                lblResultado.Text = Math.Pow(double.Parse(entNumero1.Text), double.Parse(entNumero2.Text)).ToString("N2");
            }
            catch (Exception)
            {
                DisplayAlert("Error", "No se encontraron datos y solo se permiten numeros", "OK");
            }
        }

        private void BtnPorcentaje_Clicked(object sender, EventArgs e)
        {
            try
            {
                lblResultado.Text = ((Decimal.Parse(entNumero2.Text) / 100) * decimal.Parse(entNumero1.Text)).ToString("N2");
            }
            catch (Exception)
            {
                DisplayAlert("Error", "Recuerde llenar los dos campos y solo se permiten números", "OK");
            }
        }

        private void BtnDivision_Clicked(object sender, EventArgs e)
        {
            try
            {
                lblResultado.Text = (Decimal.Parse(entNumero1.Text) / Decimal.Parse(entNumero2.Text)).ToString("N2");
            }
            catch (Exception)
            {
                DisplayAlert("Error", "No se puede dividir entre cero", "OK");
            }
        }

        private void BtnMultiplicacion_Clicked(object sender, EventArgs e)
        {
            try
            {
                lblResultado.Text = (Decimal.Parse(entNumero1.Text)  * Decimal.Parse(entNumero2.Text)).ToString("N2");
            }
            catch (Exception)
            {
                DisplayAlert("Error", "Recuerde llenar los dos campos y solo se permiten números", "OK");
            }
        }

        private void BtnResta_Clicked(object sender, EventArgs e)
        {
            try
            {
                lblResultado.Text = (Decimal.Parse(entNumero1.Text) - Decimal.Parse(entNumero2.Text)).ToString("N2");
            }
            catch (Exception)
            {
                DisplayAlert("Error", "Recuerde llenar los dos campos y solo se permiten números", "OK");
            }
        }

        private void BtnSuma_Clicked(object sender, EventArgs e)
        {
            try
            {
                lblResultado.Text = (Decimal.Parse(entNumero1.Text) + Decimal.Parse(entNumero2.Text)).ToString("N2");
            }
            catch (Exception)
            {
                DisplayAlert("Error", "Recuerde llenar los dos campos y solo se permiten números", "OK");
            }
        }
    }
}