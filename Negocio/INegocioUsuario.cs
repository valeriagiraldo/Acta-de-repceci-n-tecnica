using System;

namespace Negocio
{
    public interface INegocioUsuario
    {
        bool ValidarUsuario(string usuario, string contrase�a);
    }
}
