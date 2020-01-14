using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer.Observer.Interface
{
    public interface IObservadoCommit
    {
        List<IObservadorCommit> lstObservadores { get; set; }

        void AgregarAcciones(IObservadorCommit _Observador);
        void QuitarAcciones(IObservadorCommit _Observador);
        void NotificarObservadores();
    }
}
