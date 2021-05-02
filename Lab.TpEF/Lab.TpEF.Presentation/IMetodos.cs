using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.TpEF.Presentation
{

    public interface IMetodos
    {
        void Mostrar();
        void MenuAdd(int id, string name, string description);
        void MuneUpdate(string description, int id);
        void MenuDelete(int id);
    }
}
