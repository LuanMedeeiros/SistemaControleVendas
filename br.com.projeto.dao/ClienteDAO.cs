using MySql.Data.MySqlClient;
using ProjetoControleVendas.br.com.projeto.conexao;
using ProjetoControleVendas.br.com.projeto.model;
using System;
using System.Windows.Forms;

namespace ProjetoControleVendas.br.com.projeto.dao
{
    public class ClienteDAO
    {
        private MySqlConnection conexao;

        public ClienteDAO() 
        {
            this.conexao = new ConnectionFactory().getconnection();
        }

        #region CadastrarCliente
        public void cadastrarCliente(Cliente obj)
        {
            try
            {
                // 1 passo - Definir o cmd sql - insert into
                string sql = @"insert into tb_clientes (nome,rg,cpf,email,telefone,celular,cep,endereco,numero,complemento,bairro,cidade,estado)
                                values (@nome, @rg, @cpf, @email, @telefone, @celular, @cep, @endereco, @numero, @complemento, @bairro, @cidade, @estado)";

                // 2 passo - Organizar o cmd sql
                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@nome",obj.nome);
                executacmd.Parameters.AddWithValue("@rg",obj.rg);
                executacmd.Parameters.AddWithValue("@cpf",obj.cpf);
                executacmd.Parameters.AddWithValue("@email",obj.email);
                executacmd.Parameters.AddWithValue("@telefone",obj.telefone);
                executacmd.Parameters.AddWithValue("@celular",obj.celular);
                executacmd.Parameters.AddWithValue("@cep",obj.cep);
                executacmd.Parameters.AddWithValue("@endereco",obj.endereco);
                executacmd.Parameters.AddWithValue("@numero", obj.numero);
                executacmd.Parameters.AddWithValue("@complemento", obj.complemento);
                executacmd.Parameters.AddWithValue("@bairro", obj.bairro);
                executacmd.Parameters.AddWithValue("@cidade", obj.cidade);
                executacmd.Parameters.AddWithValue("@estado", obj.estado);

                // 3 passo - Abrir a conexao e executar o cmd sql
                conexao.Open();
                executacmd.ExecuteNonQuery();

                MessageBox.Show("Cliente cadastrado com sucesso!");
            }
            catch (Exception erro)
            {

                MessageBox.Show("Aconteceu o seguinte erro: " + erro);
            }

        }
        #endregion

        #region AlterarCliente
        #endregion

        #region ExcluirCliente
        #endregion

        #region ListarCliente
        #endregion

        #region BuscarCliente
        #endregion
    }
}
