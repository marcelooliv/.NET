using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SQLite;

namespace Loja
{
    class Banco
    {
        private static SQLiteConnection conn; // ATRIBUTO DA CLASSE BANCO

        public static SQLiteConnection Conectar() // CONEXÃO COM O BANCO
        {
           
            conn = new SQLiteConnection("Data Source="+System.Environment.CurrentDirectory+@"\database\db_loja.db");
            conn.Open();
            return conn;
        }
        
        public static DataTable Consultar(string sql) // CONSULTA GENÉRICA PARA OS RELATÓRIOS
        {
            SQLiteDataAdapter ad = null;
            DataTable dt = new DataTable();
            try
            {
                using (var cmd = Conectar().CreateCommand())
                {
                    cmd.CommandText = sql;
                    ad = new SQLiteDataAdapter(cmd.CommandText, Conectar());
                    ad.Fill(dt);
                    return dt;

                }
            }
            catch(Exception)
            {
                throw;
            }
        }

        // FUNÇÕES SIMPLES RELACIONADOS AOS PRODUTOS SIMPLES
        public static void Adicionar(string nome, double precoCusto, double precoVenda)
        {

            using (var cmd = Conectar().CreateCommand())
            {
                cmd.CommandText = "INSERT INTO tb_estoque (prod_nome, prod_preco_custo, prod_preco_venda) VALUES (@prod_nome, @preco_custo, @preco_venda)";
                cmd.Parameters.AddWithValue("@prod_nome", nome);
                cmd.Parameters.AddWithValue("@preco_custo", precoCusto);
                cmd.Parameters.AddWithValue("@preco_venda", precoVenda);
                cmd.ExecuteNonQuery();
                Conectar().Close();
            }

        }
        public static bool VerificarProduto(string nomeProduto)
        {
            bool existe;
            SQLiteDataAdapter adp = null;
            DataTable dtab = new DataTable();
            using (var cmd = Conectar().CreateCommand())
            {
                cmd.CommandText = "SELECT prod_nome FROM tb_estoque WHERE prod_nome = '" + nomeProduto + "'";
                adp = new SQLiteDataAdapter(cmd.CommandText, Conectar());
                adp.Fill(dtab);
                if (dtab.Rows.Count > 0)
                {
                    existe = true;
                }
                else
                {
                    existe = false;
                }
                Conectar().Close();
            }


            return existe;
        }
        public static void RemoverProduto(string nome)
        {
            using (var cmd = Conectar().CreateCommand())
            {
                cmd.CommandText = "DELETE FROM tb_estoque WHERE prod_nome ='" + nome + "' ";
                cmd.ExecuteNonQuery();
                Conectar().Close();
            }
        }
        public static void AtualizarProduto(double precoCusto, double precoVenda, string nome)
        {
            using (var cmd = Conectar().CreateCommand())
            {
                cmd.CommandText = "UPDATE tb_estoque SET prod_preco_custo = '"+precoCusto+"', prod_preco_venda = '"+precoVenda+"' WHERE prod_nome ='" + nome + "' ";
                cmd.ExecuteNonQuery();
                Conectar().Close();
            }
        }

        // FUNÇÕES SIMPLES RELACIONADAS AOS PRODUTOS COMPOSTOS
        public static void AdicionarComposto(string nome, double preco)
        {
            try
            {
                using (var comando = Conectar().CreateCommand())
                {
                    comando.CommandText = "INSERT INTO tb_produtos_compostos (nome_prod_composto, preco_venda) VALUES (@nome, @preco)";
                    comando.Parameters.AddWithValue("@nome", nome);
                    comando.Parameters.AddWithValue("@preco", preco);
                    comando.ExecuteNonQuery();
                    Conectar().Close();
                }
            }
            catch (Exception)
            {
                throw; 
            }
        }
        public static void RemoverComposto(string nome)
        {
            using (var cmd = Conectar().CreateCommand())
            {
                cmd.CommandText = "DELETE FROM tb_produtos_compostos WHERE nome_prod_composto ='" + nome + "' ";
                cmd.ExecuteNonQuery();
                Conectar().Close();
            }
        }
        public static void AtualizarComposto(string nome, double precoDeVenda)
        {
            using (var cmd = Conectar().CreateCommand())
            {
                cmd.CommandText = "UPDATE tb_produtos_compostos SET preco_venda = '" + precoDeVenda + "' WHERE nome_prod_composto ='" + nome + "' ";
                cmd.ExecuteNonQuery();
                Conectar().Close();
            }
        }
        public static void InsereComponenteComposto(string nome, string nomeComposto, int qntdSimples)
        {
            using (var cmd = Conectar().CreateCommand())
            {

                SQLiteDataAdapter adpter = null;
                DataTable dtable = new DataTable();

                cmd.CommandText = "SELECT prod_id FROM tb_estoque WHERE prod_nome = '" + nome + "'";
                adpter = new SQLiteDataAdapter(cmd.CommandText, Conectar());
                adpter.Fill(dtable);
                int drID = Convert.ToInt32(dtable.Rows[0][0]);



                cmd.CommandText = "INSERT INTO tb_componentes_compostos (nome_prod_composto, id_componentes, quantidade) VALUES (@prod_nome, @id_componente, @qnt)";
                cmd.Parameters.AddWithValue("@prod_nome", nomeComposto);
                cmd.Parameters.AddWithValue("@id_componente", drID);
                cmd.Parameters.AddWithValue("@qnt", qntdSimples);
                cmd.ExecuteNonQuery();
                Banco.Conectar().Close();

            }
        }
        public static double CalculaTotalComposto(string nomeProduto, double custo, int quantidade)
        {
            SQLiteDataAdapter adp = null;
            DataTable dtab = new DataTable();
            using (var cmd = Conectar().CreateCommand())
            {
                cmd.CommandText = "SELECT prod_preco_custo FROM tb_estoque WHERE prod_nome = '" + nomeProduto + "'";
                adp = new SQLiteDataAdapter(cmd.CommandText, Conectar());
                adp.Fill(dtab);
                double parcial = Convert.ToDouble(dtab.Rows[0][0]);
                return custo + (parcial * quantidade);
            }
        }
        public static double DecresceTotalComposto(string nome, double custo, int quantidade)
        {
            SQLiteDataAdapter adp = null;
            DataTable dtab = new DataTable();
            using (var cmd = Conectar().CreateCommand())
            {
                cmd.CommandText = "SELECT prod_preco_custo FROM tb_estoque WHERE prod_nome = '" + nome + "'";
                adp = new SQLiteDataAdapter(cmd.CommandText, Conectar());
                adp.Fill(dtab);
                double parcial = Convert.ToDouble(dtab.Rows[0][0]);
                return custo - (parcial * quantidade);
            }
        }

        // FUNÇÕES DE ESTOQUE RELACIONADAS AOS PRODUTOS SIMPLES

        public static void InserirRequisicaoSimples(string nomeProduto, string funcionario, int quant, double subtotal)
        {
            SQLiteDataAdapter adp = null;
            DataTable dtab = new DataTable();
            using (var cmd = Conectar().CreateCommand())
            {
                cmd.CommandText = "SELECT prod_preco_venda FROM tb_estoque WHERE prod_nome = '" + nomeProduto + "'";
                adp = new SQLiteDataAdapter(cmd.CommandText, Conectar());
                adp.Fill(dtab);
                cmd.Reset();
                cmd.CommandText = "INSERT INTO tb_requisicoes VALUES(DATE('now','localtime'),'" + nomeProduto + "','" + funcionario + "','" + quant + "','" + subtotal + "', '"+Convert.ToDouble(dtab.Rows[0][0])*quant+"')";
                cmd.ExecuteNonQuery();
            }
        }
        public static void InserirRetiradaSimplesEstoque(int quant, string nomeSimples)
        {
            SQLiteDataAdapter adp = null;
            DataTable dtab = new DataTable();
            using (var cmd = Conectar().CreateCommand())
            {
                cmd.CommandText = "SELECT DATE('now','localtime'), prod_id,'" + quant + "', prod_preco_custo*'" + quant + "' FROM tb_estoque WHERE prod_nome='" + nomeSimples + "'";
                adp = new SQLiteDataAdapter(cmd.CommandText, Conectar());
                adp.Fill(dtab);
                cmd.Reset();
                cmd.CommandText = "INSERT INTO tb_retiradasDoEstoque VALUES('" + dtab.Rows[0][0] + "','" + dtab.Rows[0][1] + "','" + dtab.Rows[0][2] + "','" + dtab.Rows[0][3] + "')";
                cmd.ExecuteNonQuery();
            }
        }
        public static void RemoveRetiradaSimplesEstoque(string nome)
        {
            SQLiteDataAdapter adp = null;
            DataTable dtab = new DataTable();
            using (var cmd = Conectar().CreateCommand())
            {
                cmd.CommandText = "DELETE FROM tb_requisicoes WHERE nome_produto = '" + nome + "'";
                cmd.ExecuteNonQuery();
                cmd.Reset();
                cmd.CommandText = "SELECT prod_id FROM tb_estoque WHERE prod_nome= '" + nome + "' ";
                adp = new SQLiteDataAdapter(cmd.CommandText, Conectar());
                adp.Fill(dtab);
                cmd.Reset();
                cmd.CommandText = "DELETE FROM tb_retiradasDoEstoque WHERE id_produto = '" + dtab.Rows[0][0] + "'";
                cmd.ExecuteNonQuery();
                Banco.Conectar().Close();
            }
        }

        // FUNÇÕES DE ESTOQUE RELACIONADAS AOS PRODUTOS COMPOSTOS
        public static void InserirRequisicaoComposta(string nomeProduto, string funcionario, int quant, double subtotal)
        {
            SQLiteDataAdapter adp = null;
            DataTable dtab = new DataTable();
            using (var cmd = Conectar().CreateCommand())
            {
                cmd.CommandText = "SELECT preco_venda FROM tb_produtos_compostos WHERE nome_prod_composto = '" + nomeProduto + "'";
                adp = new SQLiteDataAdapter(cmd.CommandText, Conectar());
                adp.Fill(dtab);
                cmd.Reset();
                cmd.CommandText = "INSERT INTO tb_requisicoes VALUES(DATE('now','localtime'),'"+nomeProduto+"','" + funcionario + "','" + quant + "','" + subtotal + "','"+Convert.ToDouble(dtab.Rows[0][0])*quant+"')";
                cmd.ExecuteNonQuery();
            }
        }
        
        public static void InserirRetiradaCompostaEstoque(int quant, string nomeComposto)
        {
            SQLiteDataAdapter adp = null;
            DataTable dtab = new DataTable();
            using (var cmd = Conectar().CreateCommand())
            {
                cmd.CommandText = "SELECT DATE('now','localtime') as data, te.prod_id, tcc.quantidade*'"+quant+"' as qntd_total, te.prod_preco_custo*tcc.quantidade*'"+quant+"' as total_custo FROM tb_componentes_compostos as tcc INNER JOIN tb_estoque as te ON tcc.id_componentes = te.prod_id WHERE tcc.nome_prod_composto = '"+nomeComposto+"'";
                adp = new SQLiteDataAdapter(cmd.CommandText, Conectar());
                adp.Fill(dtab);
                cmd.Reset();
                for (int i = 0; i < dtab.Rows.Count; i++)
                {
                    cmd.CommandText = "INSERT INTO tb_retiradasDoEstoque VALUES('" + dtab.Rows[i][0] + "','" + dtab.Rows[i][1] + "','" + dtab.Rows[i][2] + "','" + dtab.Rows[i][3] + "')";
                    cmd.ExecuteNonQuery();
                }
            }
        }
        
        public static void RemoveRetiradaCompostaEstoque(string nome, int quant)
        {
            SQLiteDataAdapter adp = null;
            DataTable dtab = new DataTable();

            SQLiteDataAdapter adpter = null;
            DataTable dtable = new DataTable();

            using (var cmd = Conectar().CreateCommand())
            {
                cmd.CommandText = "DELETE FROM tb_requisicoes WHERE nome_produto = '" + nome + "'";
                cmd.ExecuteNonQuery();
                cmd.Reset();
                cmd.CommandText = "SELECT id_componentes FROM tb_componentes_compostos WHERE nome_prod_composto = '" + nome + "' ";
                adp = new SQLiteDataAdapter(cmd.CommandText, Conectar());
                adp.Fill(dtab);
                cmd.Reset();
                cmd.CommandText = "SELECT quantidade FROM tb_componentes_compostos WHERE nome_prod_composto = '" + nome + "'";
                adpter = new SQLiteDataAdapter(cmd.CommandText, Conectar());
                adpter.Fill(dtable);
                cmd.Reset();
                for(int i = 0; i < dtab.Rows.Count; i++)
                {
                    cmd.CommandText = "DELETE FROM tb_retiradasDoEstoque WHERE id_produto = '" + dtab.Rows[i][0] + "' AND quantidade = '"+Convert.ToInt32(dtable.Rows[i][0])*quant+"' AND data = DATE('now','localtime')";
                    cmd.ExecuteNonQuery();
                }
                Banco.Conectar().Close();
            }
        }
        
    }
}
