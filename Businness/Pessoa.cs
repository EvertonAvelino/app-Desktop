using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Businness
{
    public class Pessoa
    {
        public int Id { get; set; }
        public String Nome { get; set; }
        public String Cpf { get; set; }
        public String Telefone { get; set; }
        public String Email { get; set; }


        // metodo para cadastrar pessoas
        public void Salvar()
        {
            if (String.IsNullOrEmpty(this.Nome))
            {
                throw new Exception("nome não pode ser vazio");
            }

            if (this.Id > 0)
            {
                 new Database.Pessoa().Atualizar(this.Id, this.Nome, this.Cpf, this.Telefone, this.Email);
                return;
            }
            
                this.Id = new Database.Pessoa().Salvar(this.Nome, this.Cpf, this.Telefone, this.Email);
            
        }

        // metodo para listar cadastros
        public static List<Pessoa> Lista()
        {
            return Lista(string.Empty);
        }

        public static List<Pessoa> Lista(string nome)
        {
            var pessoas = new List<Pessoa>();

            DataTable dados = new Database.Pessoa().Lista(nome);

            for(var i=0; i < dados.Rows.Count; i++)
            {
                pessoas.Add(new Pessoa() {

                    Id = Convert.ToInt32(dados.Rows[i]["id"]),
                    Nome = dados.Rows[i]["nome"].ToString(),
                    Cpf = dados.Rows[i]["cpf"].ToString(),
                    Telefone = dados.Rows[i]["telefone"].ToString(),
                    Email = dados.Rows[i]["email"].ToString()
                }); 
            }

            return pessoas;
        }

       
    }

}
