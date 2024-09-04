using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;


namespace ProjetoContatos
{
    internal class Program
    {

        static string strConexao = "server=localhost;database=prjconexao;uid=root;pwd=123456";
        static MySqlConnection conexao;

        static void Main(string[] args)
        {
            bool sairMenu = false;
            int codigoMenu = 0;
            int id = 0;

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
                        Console.WriteLine("BUSCAR CONTATO POR ID");
                        Console.WriteLine("DIGITE O ID PROCURADO");
                        try
                        {
                            id = int.Parse(Console.ReadLine());
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e.Message);
                        }

                        Console.WriteLine("°°°°°°°°°°°°°°°°°°°°°°°");
                        buscarId(id);
                        break;


                    case 4:
                        Console.Clear();
                        Console.WriteLine("°°°°°°°°°°°°°°°°°°°°°°°");
                        Console.WriteLine("REMOVER CONTATO");
                        removerContato();
                        Console.WriteLine("°°°°°°°°°°°°°°°°°°°°°°°");
                        break;

                    case 5:
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
            menu += "\n(3) - BUSCAR CONTATO POR ID ";
            menu += "\n(4) - REMOVER CONTATO ";
            menu += "\n(5) - EDITAR CONTATO ";
            menu += "\n(9) - SAIR ";

            return menu;
        }

        static void adicionarContato()
        {
            try
            {
                conexao = new MySqlConnection(strConexao);
                conexao.Open();
                Console.WriteLine("Digite o nome para o novo Contato: ");
                string nome = Console.ReadLine();

                var strComando = new MySqlCommand("INSERT INTO contatos (nome) VALUES (@NOME)", conexao);

                strComando.Parameters.Add(new MySqlParameter("@NOME", nome));

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

        static void listarContato()
        {
            try
            {
                conexao = new MySqlConnection(strConexao);
                conexao.Open();

                var strComando = new MySqlCommand("SELECT * FROM contatos", conexao);

                var resultado = strComando.ExecuteReader();

                while (resultado.Read())
                {
                    Console.WriteLine($"{resultado["id"]} - {resultado["nome"]}");
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


                var strComando = new MySqlCommand("DELETE FROM contatos where id = @ID", conexao);
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


        static bool buscarId(int id)
        {
            try
            {
                conexao = new MySqlConnection(strConexao);
                conexao.Open();

                var strComando = new MySqlCommand("SELECT * FROM contatos where id = @ID", conexao);
                strComando.Parameters.Add(new MySqlParameter("@ID", id));

                var resultado = strComando.ExecuteReader();
                resultado.Read();

                Console.WriteLine($"{resultado["id"]} - {resultado["nome"]}");
                return true;

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
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

                var strComando = new MySqlCommand("UPDATE contatos SET nome = @NOME WHERE id = @ID", conexao);
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
