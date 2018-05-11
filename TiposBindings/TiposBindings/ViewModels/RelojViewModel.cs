using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using Xamarin.Forms;

namespace TiposBindings.ViewModels
{
   public class RelojViewModel:INotifyPropertyChanged
    {
        //en el constructor iniciamos la hora del sistema
        public RelojViewModel()
        {
            this.HoraSistema = DateTime.Now;
            //vamos a indicar que el reloj cambie
            //para ello llamamos al timer del dispositivo
            Device.StartTimer(TimeSpan.FromSeconds(1)
                , () => {
                    this.HoraSistema = DateTime.Now;
                    return true;
                });
        }
        private DateTime _HoraSistema;
        //al implementar crea un evento que se comunica con la vista y el modelo 
        //al cambiar la propiedad que le indiquemos....
        public event PropertyChangedEventHandler PropertyChanged;
        //normalmente lo que se tiene es un metodo estandar que recibe 
        //el nombre de la propiedad a cambiar e invoca el evento
        public virtual void OnPropertyChanged(string nombrepropiedad)
        {
            //invocamos al evento PropertyChanged indicando la propiedad que estamos cambiando para comunicarnos
            //entre view y model. 
            PropertyChanged?.Invoke(this,
                new PropertyChangedEventArgs(nombrepropiedad));
        }

        //en los viewmodels, las propiedades son extendidas
        public DateTime HoraSistema
        {
            get { return this._HoraSistema; }
            set { this._HoraSistema = value;
                //realizo la llamada a la activacion del evento de propiedades
                OnPropertyChanged("HoraSistema");
            }
        }
    }
}
