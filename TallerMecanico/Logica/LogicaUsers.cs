using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TallerMecanico.Entidades;

namespace TallerMecanico.Logica
{
    class LogicaUsers
    {
        public bool TryLogIn(User tryUser)
        {
            using (ModelContext bd = new ModelContext())
            {
                var lst = from u in bd.Users
                          where u.Usuario == tryUser.Usuario && u.Password == tryUser.Password
                          select u;
                User usuarioLogeado = lst.FirstOrDefault() as User;

                if (usuarioLogeado != null)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
    }
}
