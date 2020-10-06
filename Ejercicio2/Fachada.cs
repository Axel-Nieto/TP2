using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio2
{
    class Fachada
    {
        FachadaImp iFachadaImp=new FachadaImp();
        RepositorioBanca iContenedor = new RepositorioBanca();
        public Fachada()
        {
        }

        public void MostrarPantallaPrincipal()
        {
            iFachadaImp.MostrarPantallaPrincipal();
        }

        public void CrearCuenta()
        {
            iFachadaImp.CrearCuenta(iContenedor);
        } 

        public void MostrarPantallaOperarCuenta()
        {

        }

        public int PedirOpcion()
        {
            return iFachadaImp.PedirOpcion();
        }

        public Banca BuscarBanca()
        {
            return iFachadaImp.BuscarBanca(iContenedor);
        }

        public void MenuSeleccionCuenta(Banca pBanca)
        {
            iFachadaImp.MenuSeleccionCuenta(pBanca);
        }

        public void MenuOperacionesPesoArgentino()
        {
            iFachadaImp.MenuOperacionesPesoArgentino();
        }

        public void MenuOperacionesDolarEstadounidense()
        {
            iFachadaImp.MenuOperacionesDolarEstadounidense();
        }

        public void GuardarCambios(Banca pBanca)
        {
            iFachadaImp.GuardarCambios(pBanca,iContenedor);
        }

        public void AcreditarSaldo(Cuenta pCuenta)
        {
            iFachadaImp.AcreditarSaldo(pCuenta);
        }

        public void DebitarSaldo(Cuenta pCuenta)
        {
            iFachadaImp.DebitarSaldo(pCuenta);
        }

        public void MostrarSaldoPesos(Cuenta pCuenta)
        {
            iFachadaImp.MostrarSaldoPesos(pCuenta);
        }

        public void MostrarSaldoDolares(Cuenta pCuenta)
        {
            iFachadaImp.MostrarSaldoDolares(pCuenta);
        }

        public void TransferirPesosADolares(Banca pBanca)
        {
            iFachadaImp.TransferirPesosADolares(pBanca);
        }

        public void TransferirDolaresAPesos(Banca pBanca)
        {
            iFachadaImp.TransferirDolaresAPesos(pBanca);
        }
    }
}
