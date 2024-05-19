using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Escaner
    {
        List<Documento> listaDocumentos;
        Departamento locacion;
        string marca;
        TipoDoc tipo;

        public Escaner(string marca, TipoDoc tipo)
        {
            this.marca = marca;
            this.listaDocumentos = new List<Documento>();
            this.tipo = tipo;
            if (tipo == TipoDoc.libro)
            {
                this.locacion = Departamento.procesosTecnicos;
            }
            else
            {
                this.locacion = Departamento.mapoteca;
            }
        }

        public List<Documento> ListaDocumentos { get => listaDocumentos; }
        public Departamento Locacion { get => locacion; }
        public string Marca { get => marca; }
        public TipoDoc Tipo { get => tipo; }

        public bool CambiarEstadoDocumento(Documento d)
        {
            return d.AvanzarEstado();
        }

        public static bool operator ==(Escaner e, Documento d)
        {
            return e.listaDocumentos.Contains(d);
        }

        public static bool operator !=(Escaner e, Documento d)
        {
            return !(e.listaDocumentos.Contains(d));
        }

        public static bool operator +(Escaner e, Documento d)
        {
            bool retorno = false;
            if (e != d && d.Estado == Paso.Inicio)
            {
                if (e.tipo == TipoDoc.libro && d is Libro)
                {
                    e.CambiarEstadoDocumento(d);
                    e.listaDocumentos.Add(d);
                    retorno = true;
                }
                else if (e.tipo == TipoDoc.mapa && d is Mapa)
                {
                    e.CambiarEstadoDocumento(d);
                    e.listaDocumentos.Add(d);
                    retorno = true;
                }
            }
            return retorno;
        }
    }
}