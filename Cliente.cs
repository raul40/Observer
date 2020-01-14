using Observer.Observer;
using Observer.Observer.Interface;
using Observer.Observer.Observadores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    public class Cliente
    {
        private IObservadoCommit observadoCommit;
        private IObservadorCommit Observador;
        public void Main()
        {
            string cCodigo = ObtenerCodigo();
            string cDescripcion = ObtenerDescripcion();
            observadoCommit = new ObservadoCommit(cCodigo, cDescripcion);


            Observador = new ObservadorCompilar();
            observadoCommit.AgregarAcciones(Observador);

            Observador = new ObservadorVersionar();
            observadoCommit.AgregarAcciones(Observador);

            Observador = new ObservadorUTest();
            observadoCommit.AgregarAcciones(Observador);

            SubirCodigo();
            Console.ReadLine();
        }

        private string ObtenerDescripcion()
        {
            Console.WriteLine("Codigo a subir:");
            return Console.ReadLine();
        }

        private string ObtenerCodigo()
        {
            Console.WriteLine("Descripcion del codigo a subir:");
            return Console.ReadLine();
        }

        private void SubirCodigo()
        {
            observadoCommit.NotificarObservadores();
        }
    }
}
