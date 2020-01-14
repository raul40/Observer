using Observer.Observer.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer.Observer.Observadores
{
    public class ObservadorCompilar : IObservadorCommit
    {
        public void Actualizar(string _cCodigo, string _cDescripcion)
        {
            Console.WriteLine(string.Format("El codigo {0} : {1} se ha compilado exitosamente", _cCodigo, _cDescripcion));
        }
    }
}
