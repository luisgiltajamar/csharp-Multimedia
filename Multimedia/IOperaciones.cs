using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multimedia
{
    public interface IOperaciones<Tipo>
    {
        void Add(Tipo data);

        void Listar();

        Tipo GetObjeto(int busqueda);

        int GetCodigo();

    }
}
