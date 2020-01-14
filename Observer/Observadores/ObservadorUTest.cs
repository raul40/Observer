﻿using Observer.Observer.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer.Observer.Observadores
{
    public class ObservadorUTest : IObservadorCommit
    {
        public void Actualizar(string _cCodigo, string _cDescripcion)
        {
            Console.WriteLine("Se han realizado Pruebas Unitarias exitosamente. Codigo: {0} Descripcion: {1}", _cCodigo, _cDescripcion);
        }
    }
}
