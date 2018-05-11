using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TiposBindings.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TiposBindings.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ProductosView : ContentPage
	{
		public ProductosView ()
		{
			InitializeComponent ();
            Producto1 prod = new Producto1
            {
                Nombre="Rana",
                Imagen= "rana.png",
                Precio= 45
            };
            BindingContext = prod;
		}
	}
}
