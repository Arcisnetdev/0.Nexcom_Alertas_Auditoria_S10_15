

namespace Nexcom.Backend_Alerta_S10.Business.BusinessLogicMasivoC
{
   public class LgImplVerifNroUser
    {

        private string _usuario;

        public LgImplVerifNroUser()
        {
        }

        public LgImplVerifNroUser(string tcUsuario)
        {
            this.Usuario = tcUsuario;
        }

       public string Usuario
       {
           get { return _usuario; }
           set { _usuario = value; }
       }
    }
}
