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
    public partial class MisMateriales : ContentPage
    {

        public List<ProductInfo> ListMateriales { get; set; }

        public MisMateriales()
        {
            InitializeComponent();
            ListMateriales = new List<ProductInfo>();

        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            App.MasterD.Detail.Navigation.PopAsync();
        }

        private void guardarMateriales(object sender, EventArgs e)
        {
            ProductInfo c = new ProductInfo(tipoMaterial.Text, nombreMaterial.Text, unidades.Text);
            ListMateriales.Add(c);

            lista.ItemsSource = null;
            lista.ItemsSource = ListMateriales;
            tipoMaterial.Text = string.Empty;
            nombreMaterial.Text = string.Empty;
            unidades.Text = string.Empty;

        }

        private void busqueda_TextChanged(object sender, TextChangedEventArgs e)
        {
            var busquedaPorNombre = ListMateriales.Where(c => c.NombreMaterial.Contains(busqueda.Text));

            lista.ItemsSource = busquedaPorNombre;

        }
    }
}