using System;

namespace cadastro_mvc.Models
{
    public class UsuarioModel : Cadastromvc
    {
        public string Email { get; set; }

        public string Senha { get; set; }
    }
}