using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PracticaXamarin.Vistas
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainView : ContentPage
    {
        // Variable contador, se inicializa a 1.
        int count = 0;

        public MainView()
        {
            InitializeComponent();

            MyButton.Clicked += (sender, args) =>
            {
               // MyButton.Text = String.Format("{0} clicks!", count++);
                MessageCount.Text = String.Format("Botón pulsado {0} veces", ++count);
            };
        }
        
    }
}