using System.Text;

namespace Entidades
{
    public abstract class Documento
    {
        int año;
        string autor;
        string barcode;
        Paso estado;
        string numNormalizado;
        string titulo;

        public Documento(string titulo, string autor, int año, string numNormalizado, string barcode)
        {
            this.año = año;
            this.autor = autor;
            this.barcode = barcode;
            this.estado = Paso.Inicio;
            this.numNormalizado = numNormalizado;
            this.titulo = titulo;
        }

        public int Año { get => año; }
        public string Autor { get => autor; }
        public string Barcode { get => barcode; }
        public Paso Estado { get => estado; }
        protected string NumNormalizado { get => numNormalizado; }
        public string Titulo { get => titulo; }

        public bool AvanzarEstado()
        {
            if (estado == Paso.Terminado)
            {
                return false;
            }
            else
            {
                estado++;
                return true;
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Titulo: {this.titulo}");
            sb.AppendLine($"Autor: {this.autor}");
            sb.AppendLine($"Año: {this.año}");
            sb.AppendLine($"Cód. de barras: {this.barcode}");
            sb.AppendLine($"Estado: {this.estado}");
            sb.AppendLine($"Numero Normalizado: {this.NumNormalizado}");
            return sb.ToString();
        }
    }
}