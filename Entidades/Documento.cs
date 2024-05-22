using System.Text;

namespace Entidades
{
    public abstract class Documento
    {
        int anio;
        string autor;
        string barcode;
        Paso estado;
        string numNormalizado;
        string titulo;

        public Documento(string titulo, string autor, int anio, string numNormalizado, string barcode)
        {
            this.anio = anio;
            this.autor = autor;
            this.barcode = barcode;
            this.estado = Paso.Inicio;
            this.numNormalizado = numNormalizado;
            this.titulo = titulo;
        }

        public enum Paso
        {
            Inicio,
            Distribuido,
            EnEscaner,
            EnRevision,
            Terminado
        }

        public int Anio { get => anio; }
        public string Autor { get => autor; }
        public string Barcode { get => barcode; }
        public Paso Estado { get => estado; }
        protected string NumNormalizado { get => numNormalizado; }
        public string Titulo { get => titulo; }

        public bool AvanzarEstado()
        {
            if (this.estado == Paso.Terminado)
            {
                return false;
            }
            else
            {
                this.estado++;
                return true;
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Titulo: {this.titulo}");
            sb.AppendLine($"Autor: {this.autor}");
            sb.AppendLine($"Año: {this.anio}");
            sb.AppendLine($"Cód. de barras: {this.barcode}");
            sb.AppendLine($"Estado: {this.estado}");
            sb.AppendLine($"Numero Normalizado: {this.NumNormalizado}");
            return sb.ToString();
        }
    }
}