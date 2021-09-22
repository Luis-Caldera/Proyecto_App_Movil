using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.Collections.ObjectModel;

namespace Parcialpr
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MiTematica : TabbedPage
    {
        public class UserInformation
        {
            public ImageSource UserImage { get; set; }
        }

        private ObservableCollection<UserInformation> userCollection;

        public ObservableCollection<UserInformation> UserCollection
        {
            get 
            { 
                return userCollection;
            }
            set
            {
                userCollection = value;
                OnPropertyChanged();
            }
        }
      

        public MiTematica()
        {
            InitializeComponent();

            BindingContext = this;
            UserCollection = new ObservableCollection<UserInformation>
            {
                new UserInformation{UserImage = "seguridad.jpg"},
                 new UserInformation{UserImage = "img.jpg"},
                  new UserInformation{UserImage = "seginform.png"},
                   new UserInformation{UserImage = "imguno.jpg"},
                    new UserInformation{UserImage = "infor.jpg"},
            };
        }
    }
}