using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multimedia
{
   public class OperacionMultimediaLista: IOperaciones<Multimedia>
   {
       private List<Multimedia> lista;

       public OperacionMultimediaLista()
       {
           lista=new List<Multimedia>();
       }

       public void Add(Multimedia data)
       {
           lista.Add(data);
       }

       public void Listar()
       {
           foreach (var multimedia in lista)
           {
               multimedia.Detalle();
           }
       }

       public Multimedia GetObjeto(int busqueda)
       {
           //foreach (var multimedia in lista)
           //{
           //    if (multimedia.Codigo == busqueda)
           //        return multimedia;
           //}
           //return null;

           var ele = lista.FirstOrDefault(o => o.Codigo == busqueda);
           return ele;
       }


       public int GetCodigo()
       {
           //return lista.Max(o => o.Codigo);
           
           return lista.Count + 1;
       }
   }
}
