using Entidades;

namespace Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Escaner escaner1 = new Escaner("subaru", TipoDoc.libro);
            Escaner escaner2 = new Escaner("Mitsubishi", TipoDoc.mapa);
            Libro libro1 = new Libro("donquikote", "lucio", 1900, "120", "02020", 20);
            Libro libro2 = new Libro("mancha", "nicolas", 1910, "121", "03030", 20);
            Mapa mapa1 = new Mapa("America Latina", "Americo", 1520, "122", "04040", 10, 15);
            Mapa mapa2 = new Mapa("1", "Gardel", 1810, "123", "05050", 20, 25);

            Console.WriteLine(escaner1 + mapa1);
            Console.WriteLine(escaner1 + libro1);
            Console.WriteLine(escaner1 + libro2);
            Console.WriteLine(escaner1 + libro2);
            foreach (Documento dc in escaner1.ListaDocumentos)
            {
                Console.WriteLine(dc.ToString());
            }
            //Console.WriteLine(libro1.ToString());
            //Console.WriteLine(mapa1.ToString());
            //Console.WriteLine(escaner1 + libro1);
            //Console.WriteLine(escaner1 + libro2);
            //Console.WriteLine(escaner1 + libro1);
            //Console.WriteLine(escaner2 + mapa1);
            //Console.WriteLine($"{escaner2 + mapa2}\n");
            ////Console.WriteLine(libro1.ToString());
            ////Console.WriteLine(mapa1.ToString());
            //Console.WriteLine(escaner1.CambiarEstadoDocumento(libro1));
            //Console.WriteLine(escaner1.CambiarEstadoDocumento(libro2));
            //Informes.MostrarDistribuidos(escaner1, out int extension, out int cantidad, out string resumen);
            //Informes.MostrarEnEscaner(escaner1, out extension, out cantidad, out resumen);
            //Console.WriteLine(libro1.Estado);
            //Console.WriteLine(libro2.Estado);
            //Console.WriteLine($"\nextension: {extension}");
            //Console.WriteLine($"cantidad: {cantidad}");
            //Console.WriteLine($"{resumen}");
        }
    }
}