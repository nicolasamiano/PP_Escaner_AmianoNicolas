using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Mapa : Documento
    {
        int alto;
        int ancho;

        public Mapa(string titulo, string autor, int año, string numNormalizado, string barcode, int ancho, int alto) : base(titulo, autor, año, numNormalizado, barcode)
        {
            this.alto = alto;
            this.ancho = ancho;
        }

        public int Alto { get => alto; }
        public int Ancho { get => ancho; }
        public int Superficie { get => alto * ancho; }

        public static bool operator ==(Mapa l1, Mapa l2)
        {
            return l1.Barcode == l2.Barcode || (l1.Titulo == l2.Titulo && l1.Autor == l2.Autor && l1.Año == l2.Año && l1.Superficie == l2.Superficie);
        }

        public static bool operator !=(Mapa l1, Mapa l2)
        {
            return !(l1.Barcode == l2.Barcode || (l1.Titulo == l2.Titulo && l1.Autor == l2.Autor && l1.Año == l2.Año && l1.Superficie == l2.Superficie));
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Titulo: {base.Titulo}");
            sb.AppendLine($"Autor: {base.Autor}");
            sb.AppendLine($"Año: {base.Año}");
            sb.AppendLine($"Cod. de barras: {base.Barcode}");
            sb.AppendLine($"Superficie: {this.alto} * {this.ancho} = {this.Superficie} cm2.");
            return sb.ToString();
        }
    }
}