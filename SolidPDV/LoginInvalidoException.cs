using System;
namespace SolidPDV
{
    public class LoginInvalidoException : Exception
    {
        public LoginInvalidoException(string mensagem)
            : base(mensagem) { }
    }
}
