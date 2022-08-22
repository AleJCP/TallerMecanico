using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TallerMecanico.Entidades;

namespace TallerMecanico
{
    interface ICServicios
    {
        #region Usuario
        bool TryLogIn(User tryUser);
        #endregion
    }
}
