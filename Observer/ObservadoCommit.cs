using Observer.Observer.Interface;
using Observer.Observer.Observadores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer.Observer
{
    public class ObservadoCommit : IObservadoCommit
    {
        private readonly string cCodigo;
        private readonly string cDescripcion;

        public ObservadoCommit(string _cCodigo, string _cDescripcion)
        {
            cCodigo = _cCodigo;
            cDescripcion = _cDescripcion;
            lstObservadores = new List<IObservadorCommit>();
            IObservadorCommit observadorCorreo = new ObservadorCorreo();
            AgregarAcciones(observadorCorreo);
        }

        public List<IObservadorCommit> lstObservadores { get; set; }

        public void AgregarAcciones(IObservadorCommit _Observador)
        {
            lstObservadores.Add(_Observador);
        }

        public void NotificarObservadores()
        {
            foreach (IObservadorCommit item in lstObservadores)
            {
                item.Actualizar(cCodigo, cDescripcion);
            }
        }

        public void QuitarAcciones(IObservadorCommit _Observador)
        {
            lstObservadores.Remove(_Observador);
        }
    }
}
