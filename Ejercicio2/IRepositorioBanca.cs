using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio2
{
    public interface IRepositorioBanca
    {

        Banca Obtener(string pNumero);
        
        void Agregar(Banca pBanca);

    }
}
