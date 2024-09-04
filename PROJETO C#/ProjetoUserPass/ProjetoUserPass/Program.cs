using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace ProjetoUserPass
{
    internal class Program
    {

        static string strConexao = "server=localhost;database=bduserpass;uid=root;pwd=123456";
        static MySqlConnection conexao;
        static void Main(string[] args)
        {

            bool sairMenu = false;
            int codigoMenu = 0;
            

            while (!sairMenu)
            {
                Console.WriteLine("MENU DE OPÇÕES");
                Console.WriteLine(gerarMenu());

                try
                {
                    codigoMenu = int.Parse(Console.ReadLine());
                }
                catch (Exception e)
                {
                    Console.WriteLine("Ocorreu um erro: \n" + e.Message);
                }

                switch (codigoMenu)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("°°°°°°°°°°°°°°°°°°");
                        Console.WriteLine("LISTAR CONTATO");
                        listarContato();
                        Console.WriteLine("°°°°°°°°°°°°°°°°°°");
                        break;

                    case 2:
                        Console.Clear();
                        Console.WriteLine("°°°°°°°°°°°°°°°°°°°°°°°");
                        Console.WriteLine("ADICIONAR NOVO CONTATO");
                        adicionarContato();
                        Console.WriteLine("°°°°°°°°°°°°°°°°°°°°°°°");
                        break;

                    case 3:
                        Console.Clear();
                        Console.WriteLine("°°°°°°°°°°°°°°°°°°°°°°°");
                        Console.WriteLine("REMOVER CONTATO");
                        removerContato();
                        Console.WriteLine("°°°°°°°°°°°°°°°°°°°°°°°");
                        break;

                    case 4:
                        Console.Clear();
                        Console.WriteLine("°°°°°°°°°°°°°°°°°°°°°°°");
                        Console.WriteLine("EDITAR CONTATO");
                        editarContato();
                        Console.WriteLine("°°°°°°°°°°°°°°°°°°°°°°°");
                        break;

                    case 9:
                        Console.Clear();
                        sairMenu = true;
                        break;

                    default:
                        Console.Clear();
                        break;

                }
            }

            
        }
        static string gerarMenu()
        {
            string menu = "(1) - LISTAR CONTATOS";
            menu += "\n(2) - ADICIONAR CONTATO";
            menu += "\n(3) - REMOVER CONTATO";
            menu += "\n(4) - EDITAR CONTATO";
            menu += "\n(9) - SAIR ";

            return menu;
        }

        static void listarContato()
        {
            try
            {
                conexao = new MySqlConnection(strConexao);
                conexao.Open();

                var strComando = new MySqlCommand("SELECT * FROM tbusuarios", conexao);

                var resultado = strComando.ExecuteReader();

                while (resultado.Read())
                {
                    Console.WriteLine($"{resultado["id"]} - {resultado["nome"]} - {resultado["email"]} - {resultado["senha"]}");
                }
            }

            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            finally
            {
                conexao.Close();
            }
        }

        static void adicionarContato()
        {
            try
            {
                conexao = new MySqlConnection(strConexao);
                conexao.Open();
                Console.WriteLine("Seja bem vindo, vamos ao cadastro");
                Console.WriteLine("Digite seu nome: ");
                string nome = Console.ReadLine();

                Console.WriteLine("Digite seu email: ");
                string email = Console.ReadLine();
                Console.WriteLine("Digite uma senha: ");
                string senha = Console.ReadLine();

                var strComando = new MySqlCommand("INSERT INTO tbusuarios (nome, email, senha) VALUES (@NOME, @EMAIL, @SENHA)", conexao);

                strComando.Parameters.Add(new MySqlParameter("@NOME", nome));
                strComando.Parameters.Add(new MySqlParameter("@EMAIL", email));
                strComando.Parameters.Add(new MySqlParameter("@SENHA", senha));

                var cmdExec = strComando.ExecuteNonQuery();

                if (cmdExec > 0)
                {
                    Console.WriteLine($"Comando executado! {cmdExec} registro(s) afetados(s)");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                conexao.Close();
            }
        }

        static void removerContato()
        {
            try
            {
                conexao = new MySqlConnection(strConexao);
                listarContato();
                conexao.Open();


                Console.WriteLine("Digite o ID para remover ");
                var id = int.Parse(Console.ReadLine());


                var strComando = new MySqlCommand("DELETE FROM tbusuarios where id = @ID", conexao);
                strComando.Parameters.Add(new MySqlParameter("@ID", id));

                var resultado = strComando.ExecuteNonQuery();


                if (resultado > 0)
                {
                    Console.WriteLine($"Comando executado! {resultado} registro removido com sucesso!");
                }
                else
                {
                    Console.WriteLine("Registro não excluido");
                }



            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                conexao.Close();
            }
        }

        static void editarContato()
        {
            try
            {
                conexao = new MySqlConnection(strConexao);
                listarContato();
                conexao.Open();



                Console.WriteLine("Digite o ID para editar ");
                var id = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite o novo nome para editar ");
                var nome = (Console.ReadLine());

                var strComando = new MySqlCommand("UPDATE tbusuarios SET nome = @NOME WHERE id = @ID", conexao);
                strComando.Parameters.Add(new MySqlParameter("@ID", id));
                strComando.Parameters.Add(new MySqlParameter("@NOME", nome));

                var resultado = strComando.ExecuteNonQuery();


                if (resultado > 0)
                {
                    Console.WriteLine($"Comando executado! {resultado} registro atualizado com sucesso!");
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                conexao.Close();
            }
        }


    }
}
