using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BlazorFilmes.Shared
{
    public class CadastroUsuario
    {
        [Required(ErrorMessage = "Título é obrigatório")]
        public string Titulo {get; set;}
        
        [Required(ErrorMessage = "Primeiro Nome é obrigatório")]
        public string PrimeiroNome {get; set;}

        [Required(ErrorMessage = "Segundo Nome é obrigatório")]
        public string SegundoNome {get; set;}

        [Required(ErrorMessage = "Data de nascimento é obrigatório")]
        public DateTime DataDeAniversario {get; set;}

        [Required(ErrorMessage = "E-mail é obrigatório")]
            [RegularExpression(".+\\@.+\\..+", ErrorMessage="E-mail inválido...")]
        public string Email {get; set;}

        [Required(ErrorMessage = "Senha é obrigatório")]
        [StringLength(255, ErrorMessage = "Mínimo de caracteres 6", MinimumLength = 6)]        
        public string Senha {get; set;}

        [Required(ErrorMessage = "Confirmação de Senha é obrigatório")]
        [Compare("Senha", ErrorMessage = "Senhas não são iguais, tente novamente!")]
        public string ConfirmarSenha {get; set;}

       [Required]
        [Range(typeof(bool), "true", "true", 
        ErrorMessage = "Aceite os Termos de Uso para continuar.")]
        public bool Termo { get; set; }
    }
}
