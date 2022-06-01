﻿using System.ComponentModel.DataAnnotations;

namespace _2RPNET_API.ViewModels
{
    public class SendEmailViewModel
    {
        //[Required(ErrorMessage = "É necessário informar o id do assistant")]
        //public int idAssistant { get; set; }
        public string emailTitle { get; set; }
        [Required(ErrorMessage = "Email inválido")]
        public string email { get; set; }
        [Required(ErrorMessage = "Caminho da imagem errado")]
        public string emailBody { get; set; }
    }
}
