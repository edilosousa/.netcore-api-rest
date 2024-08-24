using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace api.Models
{
    [Table("tblcliente")]
    public class Cliente
    {
        [Key]
        public int cliente_id { get; private set; }
        public string cliente_nome { get; private set; }
        public string cliente_endereco { get; private set; }
        public string cliente_telefone { get; private set; }
        public string cliente_foto { get; private set; }
        public bool cliente_status { get; private set; }
        public string cliente_email { get; private set; }
        public string cliente_observacoes { get; private set; }
        public Cliente(string cliente_nome, string cliente_endereco, string cliente_telefone, string cliente_foto, bool cliente_status, string cliente_email, string cliente_observacoes)
        {
            this.cliente_nome = cliente_nome;
            this.cliente_endereco = cliente_endereco;
            this.cliente_telefone = cliente_telefone;
            this.cliente_foto = cliente_foto;
            this.cliente_status = cliente_status;
            this.cliente_email = cliente_email;
            this.cliente_observacoes = cliente_observacoes;
        }

    }
}
   