using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acesso
{
    class Login
    {
        public String empresa;
        public String usuario;
        public String senha;

        public int validaAcesso()
        {
            if (this.empresa.Equals("") || this.usuario.Equals("") || this.senha.Equals(""))
            {
                return 0;
            } else if (this.empresa.Equals("empresa"))
            {
                if(this.usuario.Equals("usuario") && this.senha.Equals("senha123"))
                {
                    return 3;
                }
                else
                {
                    return 2;
                }
            } else 
            {
                return 1;
            }
           
        }

    }
}
