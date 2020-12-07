using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Businness
{
    public class Produto
    {

       // private List<Produto> _produtos;

        public int Id { get; set; }
        public String CodBarras { get; set; }
        public String Nome { get; set; }
        public String Descricao { get; set; }
        public float Preco { get; set; }
        public DateTime DataAlteracao { get; set; }
        public DateTime DataEntrada { get; set; }
        public String Categoria { get; set; }

/*
        //metodo para acessar produtos
        public List<Produto> Produtos
        {
            get
            {
                if (_produtos == null)
                {
                    _produtos = Produto.Lista(this.Id);
                }
               
                    return _produtos;
            }
                
        }


        // metodo para cadastrar produtos ainda a ser alterado
        public void Salvar()
        {
            if (String.IsNullOrEmpty(this.Nome))
            {
                throw new Exception("nome não pode ser vazio");
            }

            if (this.Id > 0)
            {
                 new Database.Produto().Atualizar(this.Id, this.Nome, this.Cpf, this.Telefone, this.Email);
                return;
            }
            
                this.Id = new Database.Pessoa().Salvar(this.Nome, this.Cpf, this.Telefone, this.Email);
            
        }
*/
        // metodo para listar cadastros
        public static List<Produto> Lista()
        {
            return Lista(string.Empty);
        }

        public static List<Produto> Lista(string nome)
        {
            var produtos = new List<Produto>();

            DataTable dados = new Database.Produto().Lista(nome);

            for(var i=0; i < dados.Rows.Count; i++)
            {
                produtos.Add(new Produto() {

                    Id = Convert.ToInt32(dados.Rows[i]["id"]),
                    Nome = dados.Rows[i]["nome"].ToString(),
                    CodBarras = dados.Rows[i]["codBarras"].ToString(),
                    Descricao = dados.Rows[i]["descricao"].ToString(),
                    Preco = (float)Convert.ToDecimal(dados.Rows[i]["preco"]),
                    DataAlteracao = Convert.ToDateTime(dados.Rows[i]["data_alteracao"]),
                    DataEntrada = Convert.ToDateTime(dados.Rows[i]["dataEntrada"],
                    Categoria = dados.Rows[i]["categoria"].ToString())




                }); 
            }

            return produtos;
        }
        /*
        //metodo para excluir
        public static void Excluir(int id)
        {
            new Database.Produto().Excluir(id);
        }
        */
    }

}
