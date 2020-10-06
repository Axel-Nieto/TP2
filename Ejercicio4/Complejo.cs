using System;

namespace Ejercicio4
{
    public class Complejo
    {
        private readonly double iReal;
        private readonly double iImaginario;

        /// <summary>
        /// Crea un numero complejo
        /// </summary>
        /// <param name="pReal">Componente real</param>
        /// <param name="pImaginario">Componente imaginario</param>
        public Complejo(double pReal,double pImaginario)
        {
            iReal = pReal;
            iImaginario = pImaginario;
        }

        /// <summary>
        /// Devuelve el componente real
        /// </summary>
        public double Real{get {return this.iReal; }}

        /// <summary>
        /// Devuelve el componente imaginario
        /// </summary>
        public double Imaginario{get { return this.iImaginario; }}

        /// <summary>
        /// Devuelve el argumento de un binomio complejo en Radianes
        /// </summary>
        /// <returns>
        /// devuelve un valor en decimal entre -PI y PI
        /// </returns>
        public double ArgumentoEnRadianes()
        {
            double argumento = 0;
            if (this.Real == 0)
            {
                if (this.Imaginario > 0)
                {
                    argumento = Math.PI / 2;
                }
                if (this.Imaginario < 0)
                {
                    argumento = (3 * Math.PI) / 2;
                }
            }
            else
            {
                argumento = Math.Atan(this.Imaginario / this.Real);
                if (this.Real < 0 && this.Imaginario > 0)
                {
                    argumento = argumento + Math.PI;
                }
                if (this.Real < 0 && this.Imaginario < 0)
                {
                    argumento = argumento - Math.PI;
                }                
            }
            return argumento;
        }

        /// <summary>
        /// Devuelve el argumento de un binomio complejo en Grados
        /// </summary>
        /// <returns>
        /// devuelve un valor en decimal entre -180º y 180º
        /// </returns>
        public double ArgumentoEnGrados()
        {
            double argumento = 0;
            if (this.Real == 0)
            {
                if (this.Imaginario > 0)
                {
                    argumento = Math.PI / 2;
                }
                if (this.Imaginario < 0)
                {
                    argumento = (3 * Math.PI) / 2;
                }
            }
            else
            {
                argumento = Math.Atan(this.Imaginario / this.Real);
                if (this.Real < 0 && this.Imaginario > 0)
                {
                    argumento = argumento + Math.PI;
                }
                if (this.Real < 0 && this.Imaginario < 0)
                {
                    argumento = argumento - Math.PI;
                }
            }            
            argumento = argumento * (180/Math.PI);
            return argumento;
        }

        /// <summary>
        /// Obtiene el conjugado de un binomio complejo
        /// </summary>
        /// <returns>Devuelve un objeto de tipo Complejo</returns>
        public Complejo Conjugado()
        {
            Complejo resultado = new Complejo(this.Real, -(this.Imaginario));
            return resultado;
        }

        /// <summary>
        /// Calcula la magnitud de un binomio complejo
        /// </summary>
        /// <returns>Regresa un 'double'</returns>
        public double Magnitud()
        {
            double resultado = Math.Sqrt(Math.Pow(this.Real, 2) + Math.Pow(this.Imaginario, 2));
            return resultado;
        }

        /// <summary>
        /// Consulta si un numero de tipo Complejo representa a un numero real
        /// </summary>
        /// <returns>Si representa un numero real devuelve true, caso contrario regresa false</returns>
        public bool EsReal()
        {
            if (this.Imaginario == 0) return true; else return false;
        }

        /// <summary>
        /// Consulta si un numero de tipo Complejo representa a un numero imaginario
        /// </summary>
        /// <returns>Si representa un numero imaginario devuelve true, caso contrario regresa false</returns>
        public bool EsImaginario()
        {
            if (this.Imaginario != 0) return true; else return false;
        }

        /// <summary>
        /// Compara dos numeros para verificar si son equivalentes
        /// </summary>
        /// <param name="pOtroComplejo">
        /// Complejo con el que se realizara la comparacion
        /// </param>
        /// <returns>Devuelve true si son iguales, false si no lo son</returns>
        public bool EsIgual(Complejo pOtroComplejo)
        {
            if (this.Real == pOtroComplejo.Real && this.Imaginario == pOtroComplejo.Imaginario) return true; else return false;
        }

        /// <summary>
        /// Compara dos numeros para verificar si son equivalentes
        /// </summary>
        /// <param name="pReal">componente Real del numero a comparar</param>
        /// <param name="pImaginario">componente Imaginaria del numero a comparar</param>
        /// <returns>Devuelve true si son iguales, false si no lo son</returns>
        public bool EsIgual(double pReal, double pImaginario)
        {
            Complejo complejo = new Complejo(pReal, pImaginario);
            return EsIgual(complejo);
        }

        /// <summary>
        /// Suma de dos numeros complejos
        /// </summary>
        /// <param name="pOtroComplejo">Sumando de tipo Complejo</param>
        /// <returns>Devuelve un objeto de tipo Complejo</returns>
        public Complejo Sumar(Complejo pOtroComplejo)
        {
            double real = this.Real + pOtroComplejo.Real;
            double imaginario = this.Imaginario + pOtroComplejo.Imaginario;
            Complejo resultado = new Complejo(real,imaginario);
            return resultado;
        }

        /// <summary>
        /// Resta de dos numeros complejos
        /// </summary>
        /// <param name="pOtroComplejo">Sustraendo de tipo Complejo</param>
        /// <returns>Devuelve un objeto de tipo Complejo</returns>
        public Complejo Restar(Complejo pOtroComplejo)
        {
            double real = this.Real - pOtroComplejo.Real;
            double imaginario = this.Imaginario - pOtroComplejo.Imaginario;
            Complejo resultado = new Complejo(real, imaginario);
            return resultado;
        }

        /// <summary>
        /// Productos de dos numeros complejos
        /// </summary>
        /// <param name="pOtroComplejo">
        /// Multiplicador de tipo Complejo
        /// </param>
        /// <returns>Devuelve un objeto de tipo Complejo</returns>
        public Complejo MultiplicarPor(Complejo pOtroComplejo)
        {
            double real = this.Real * pOtroComplejo.Real - this.Imaginario * pOtroComplejo.Imaginario;
            double imaginario = this.Real * pOtroComplejo.Imaginario + this.Imaginario * pOtroComplejo.Real;
            Complejo resultado = new Complejo(real,imaginario);
            return resultado;
        }

        /// <summary>
        /// Division de dos numeros complejos
        /// </summary>
        /// <param name="pOtroComplejo">
        /// Divisor de tipo Complejo
        /// </param>
        /// <returns>Devuelve un objeto de tipo Complejo</returns>
        public Complejo DividirPor(Complejo pOtroComplejo)
        {
            double real = (this.Real * pOtroComplejo.Real + this.Imaginario * pOtroComplejo.Imaginario) / (Math.Pow(pOtroComplejo.Real,2) + Math.Pow(pOtroComplejo.Imaginario, 2));
            double imaginario = (this.Imaginario * pOtroComplejo.Real - this.Real * pOtroComplejo.Imaginario) / (Math.Pow(pOtroComplejo.Real, 2) + Math.Pow(pOtroComplejo.Imaginario, 2));
            Complejo resultado = new Complejo(real, imaginario);
            return resultado;
        }
    }
}
