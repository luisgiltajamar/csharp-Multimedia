using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multimedia
{
    class Program
    {
        static void Main(string[] args)
        {
            IOperaciones<Multimedia> ope=
                new OperacionMultimediaLista();
            int codigo = 0;
            do
            {
              Console.WriteLine("1.Alta 2.Listar 3.Buscar 4.salir");
              Int32.TryParse(Console.ReadLine(), out codigo);

                switch (codigo)
                {
                    case 1:
                        Alta(ope);
                        break;
                    case 2:
                        ope.Listar();
                        break;
                    case 3:
                        Buscar(ope);
                        break;
                    case 4:
                        break;
                    default:
                        Console.WriteLine("Opcion incorrecta");
                        break;
                }

            } while (codigo != 4);


        }

        private static void Buscar(IOperaciones<Multimedia> ope)
        {
            int cod;
            Console.WriteLine("Codigo");
            int.TryParse(Console.ReadLine(), out cod);

            ope.GetObjeto(cod).Detalle();
        }

        private static void Alta(IOperaciones<Multimedia> ope)
        {
            int tipo;
            Console.WriteLine("Tipo 1.Libro 2.Cancion");
            int.TryParse(Console.ReadLine(), out tipo);

            Console.WriteLine("Titulo");
            var tit = Console.ReadLine();

            Console.WriteLine("Autor");
            var aut = Console.ReadLine();

            if (tipo == 1)
            {
                Console.WriteLine("Paginas");
                int pag;
                int.TryParse(Console.ReadLine(), out pag);

                Console.WriteLine("Idioma 0.Esp 1.Ing 2.Fr 3.Chino");
                int idi = 0;
                int.TryParse(Console.ReadLine(), out idi);

                ope.Add(new Libro(tit, aut, ope.GetCodigo(),
                    pag, (Idioma) idi));
            }
            else
            {
               
                    Console.WriteLine("Duracion");
                    int dur;
                    int.TryParse(Console.ReadLine(), out dur);

                    Console.WriteLine("Formato ");
                Formato forma;
                Enum.TryParse(Console.ReadLine(), true, out forma);

                    ope.Add(new Cancion(tit, aut, ope.GetCodigo(),
                        dur, forma));
              
            }

        }
    }
}
