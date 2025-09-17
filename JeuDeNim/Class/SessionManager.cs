using JeuDeNim.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JeuDeNim.Class
{
    public static class SessionManager
    {
        public static Utilisateur CurrentUser { get; set; }

        public static void Login(Utilisateur user)
        {
            CurrentUser = user;
        }

        public static void Logout()
        {
            CurrentUser = null;
        }
    }

}
