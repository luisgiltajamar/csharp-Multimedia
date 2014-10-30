using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multimedia
{
    public class Cancion:Multimedia
    {
         public int Duracion { get; set; }
       public Formato Formato { get; set; }

       public Cancion(String titulo, String autor, int codigo,
           int duracion , Formato formato):base(titulo,autor,codigo)
       {
           Duracion = duracion;
           Formato = formato;
       }


       public override void Detalle()
       {
           Console.WriteLine("Una cancion llamada {0} de {1} con {2} " +
                             "duracion y en formato {3}",Titulo,Autor,
                             Duracion,Formato
               );
       }

    }
}
