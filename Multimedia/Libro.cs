using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multimedia
{
   public class Libro:Multimedia
    {
       public int Paginas { get; set; }
       public Idioma Idioma { get; set; }

       public Libro(String titulo, String autor, int codigo,
           int paginas, Idioma idioma):base(titulo,autor,codigo)
       {
           Paginas = paginas;
           Idioma = idioma;
       }


       public override void Detalle()
       {
           Console.WriteLine("Un libro llamado {0} de {1} con {2} " +
                             "páginas y en {3}",Titulo,Autor,Paginas,
                             Idioma
               );
       }
    }
}
