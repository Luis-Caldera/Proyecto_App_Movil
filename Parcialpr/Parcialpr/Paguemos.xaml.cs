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
    public partial class Paguemos : ContentPage
    {
        public Paguemos()
        {
            InitializeComponent();
        }
        private void Calcular_Clicked(object sender, EventArgs e)
        {
            String totalcuenta = TotalCuenta.Text;
            String integrantes = NumeroIntegrantes.Text;
            String procentaje = PorcentajePropina.Text;

            float valorpropina;
            float valorpropinaintegrantes;
            float totalvalorpropina;
            float totalintegrantes;


            valorpropina = (float.Parse(TotalCuenta.Text) * float.Parse(PorcentajePropina.Text)) / 100;
            valorpropinaintegrantes = valorpropina / float.Parse(NumeroIntegrantes.Text);
            totalvalorpropina = float.Parse(TotalCuenta.Text) + valorpropina;
            totalintegrantes = totalvalorpropina / float.Parse(NumeroIntegrantes.Text);

            valorPropina.Text = valorpropina.ToString();
            valorPropinaIntegrantes.Text = valorpropinaintegrantes.ToString();
            TotalValorPropina.Text = totalvalorpropina.ToString();
            TotalIntegrantes.Text = totalintegrantes.ToString();


        }
    }
}