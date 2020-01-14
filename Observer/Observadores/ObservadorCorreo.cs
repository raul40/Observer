using Observer.Observer.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer.Observer.Observadores
{
    public class ObservadorCorreo : IObservadorCommit
    {
        public void Actualizar(string _cCodigo, string _cDescripcion)
        {
            Console.WriteLine("Se envio correo de notificación exitosamente.");
        }
    }
}
