using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Parcialpr
{
    public partial class MainPage : MasterDetailPage
    {
        public MainPage()
        {
            InitializeComponent();

            this.Master = new Maestro();
            this.Detail = new NavigationPage(new Detalle());

            App.MasterD = this;
        }
    }
}
