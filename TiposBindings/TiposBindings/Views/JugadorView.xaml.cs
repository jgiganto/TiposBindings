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
	public partial class JugadorView : ContentPage
	{
		public JugadorView ()
		{
			InitializeComponent ();
            //Jugador jugador = new Jugador()
            //{
            //    Nombre = "Cristiano",
            //    Equipo="Real Madrid",
            //    Imagen= "https://www.diariogol.com/uploads/s1/55/86/12/8/cristiano-ronaldo-eibar-2_15_970x597.jpeg",
            //    Descripcion="El mejor.."
            //};
            //BindingContext = jugador;
		}
	}
}