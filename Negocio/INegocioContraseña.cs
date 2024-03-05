using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio_Autentificación
{
    public interface INegocioContraseña
    {
        bool ValidarContraseña(string usuario, string contraseña);
    }
}
