using System;

namespace API.Models 
{
    public class Usuario
    {
        public Usuario()
        {
            CriadoEm = DateTime.Now;
        }
        public string Nome { get; set; }
        public string Cpf { get; set;}
        public string DataDeNascimento{ get; set;}
        public DateTime CriadoEm { get; set; }        
    }
}