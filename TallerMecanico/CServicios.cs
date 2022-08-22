using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TallerMecanico.Entidades;
using TallerMecanico.Logica;

namespace TallerMecanico
{
    class CServicios : ICServicios
    {
        #region Usuario
        bool ICServicios.TryLogIn(TallerMecanico.Entidades.User tryUser)
        {
            return new LogicaUsers().TryLogIn(tryUser);
        }
        #endregion
    }
}
