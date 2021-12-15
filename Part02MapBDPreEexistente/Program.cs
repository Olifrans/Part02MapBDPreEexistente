using System;
using MapeandoBDPreEexistente.Dados;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Data.SqlClient;
using Part02MapBDPreEexistente.Dados;
using Part02MapBDPreEexistente.Extensions;
using Part02MapBDPreEexistente.Negocio;
using System.Data;

namespace Part02MapBDPreEexistente
{
    class Program
    {
        static void Main(string[] args)
        {
            //select *from table
            using (var contexto = new AluraFilmesContext())
            {




                //Enviando comandos INSERT, UPDATE e DELETE
                contexto.LogSQLToConsole();
                var sql = "INSERT INTO language (name) VALUES ('Teste 1'), ('Teste 2'), ('Teste 3')";
                var registros = contexto.Database.ExecuteSqlRaw(sql);
                Console.WriteLine($"O total de registros afetados é {registros}.");

                var deleteSql = "DELETE FROM language WHERE name LIKE 'Teste%'";
                registros = contexto.Database.ExecuteSqlRaw(deleteSql);
                Console.WriteLine($"O total de registros afetados é {registros}.");





                ////Usando Stored Procedures
                //contexto.LogSQLToConsole();
                //var categ = "Action"; //36

                //var paramCateg = new SqlParameter("category_name", categ);
                //var paramTotal = new SqlParameter
                //{
                //    ParameterName = "@total_actors",
                //    Size = 4,
                //    Direction = ParameterDirection.Output
                //};
                //contexto.Database
                //    .ExecuteSqlCommand(
                //    //.ExecuteSqlRaw(
                //    "total_actors_from_given_category @category_name, @total_actors OUT",
                //    paramCateg,
                //    paramTotal);
                //Console.WriteLine($"O total de atores na categoria {categ} é de {paramTotal.Value}.");




                //////Elaboração de relatórios
                //contexto.LogSQLToConsole();
                ////Desativando a geração de relatório do entity para usar a própria com views
                //var sql = @"select a.* from actor a
                //     inner join top5_most_starred_actors filmes on filmes.actor_id = a.actor_id";
                //var atoresMaisAtuantes = contexto.Atores
                //    .FromSqlRaw(sql)
                //    .Include(a => a.Filmografia);
                //foreach (var ator in atoresMaisAtuantes)
                //{
                //    System.Console.WriteLine($"O ator --> {ator.PrimeiroNome} {ator.UltimoNome} --> atuou em {ator.Filmografia.Count} --> filmes");
                //}




                ///////Problema sql chapado no codigo
                //////Elaboração de relatórios
                //contexto.LogSQLToConsole();

                ////Desativando a geração de relatório do entity para usar a própria consulta
                //var sql = @"select a.*
                //    from actor a
                //     inner join
                //    (select top 5 a.actor_id, count(*) as total
                //    from actor a
                //     inner join film_actor fa on fa.actor_id = a.actor_id
                //    group by a.actor_id
                //    order by total desc) filmes on filmes.actor_id = a.actor_id";
                //var atoresMaisAtuantes = contexto.Atores
                //    .FromSqlRaw(sql)
                //    .Include(a => a.Filmografia);

                //foreach (var ator in atoresMaisAtuantes)
                //{
                //    System.Console.WriteLine($"O ator --> {ator.PrimeiroNome} {ator.UltimoNome} --> atuou em {ator.Filmografia.Count} --> filmes");
                //}









                //////Elaboração de relatórios
                //contexto.LogSQLToConsole();                
                //var atoresMaisAtuantes = contexto.Atores
                //    .Include(a => a.Filmografia) //Ordenação da lista de re relatórios
                //    .OrderByDescending(a => a.Filmografia.Count)
                //    .Take(5); //Top 05
                //foreach (var ator in atoresMaisAtuantes)
                //{
                //    System.Console.WriteLine($"O ator --> {ator.PrimeiroNome} {ator.UltimoNome} --> atuou em {ator.Filmografia.Count} --> filmes");
                //}



                //contexto.LogSQLToConsole();
                //Console.WriteLine("Idiomas:");
                //foreach (var idioma in contexto.Idiomas)
                //{
                //    Console.WriteLine(idioma);
                //}


                //contexto.LogSQLToConsole();
                //Console.WriteLine("Clientes:");
                //foreach (var cliente in contexto.Clientes)
                //{
                //    Console.WriteLine(cliente);
                //}


                //contexto.LogSQLToConsole();
                //Console.WriteLine("\nFuncionarios:");
                //foreach (var funcionario in contexto.Funcionarios)
                //{
                //    Console.WriteLine(funcionario);
                //}



                //contexto.LogSQLToConsole();
                //var filme = new Filme();
                //filme.TituloFilme = "A copia do livro";
                //filme.DuracaaoFilme = 120;
                //filme.AnoLancamentoFilme = "2000";
                //filme.Clasificacao = ClassificacaoIndicativa.Livre;
                //filme.Clasificacao = ClassificacaoIndicativa.Livre;
                //filme.IdiomaFalado = contexto.Idiomas.First();
                //contexto.Entry(filme).Property("last_update").CurrentValue = DateTime.Now;
                //contexto.Filmes.Add(filme);
                //contexto.SaveChanges();
                //var filmeInserido = contexto.Filmes.First(f => f.TituloFilme == "A copia do livro");
                //Console.WriteLine(filmeInserido.Clasificacao);




                //contexto.LogSQLToConsole();
                //var livre = ClassificacaoIndicativa.MaioresQue18;
                //Console.WriteLine(livre.ParaString());
                //Console.WriteLine("G".ParaValor());




                //contexto.LogSQLToConsole();

                //var filme = new Filme();
                //filme.TituloFilme = "Senhor dos Anéis";
                //filme.DuracaaoFilme = 120;
                //filme.AnoLancamentoFilme = "2010";
                //filme.Clasificacao = ClassificacaoIndicativa.Livre;
                //filme.IdiomaFalado = contexto.Idiomas.First();
                //contexto.Entry(filme).Property("last_update").CurrentValue = DateTime.Now;

                //contexto.Filmes.Add(filme);
                //contexto.SaveChanges();








                //contexto.LogSQLToConsole();

                //var idioma = new Idioma { Nome = "Hebraico"};

                //var filme = new Filme();
                //filme.TituloFilme = "A Coisa é preta";
                //filme.DuracaaoFilme = 120;
                //filme.AnoLancamentoFilme = "2010";
                //filme.Clasificacao = "G";
                //filme.IdiomaFalado = idioma;
                //contexto.Entry(filme).Property("last_update").CurrentValue = DateTime.Now;

                //contexto.Filmes.Add(filme);
                //contexto.SaveChanges();





                //var ator1 = new Ator { PrimeiroNome = "Pedro", UltimoNome = "Santos" };
                //var ator2 = new Ator { PrimeiroNome = "Emma", UltimoNome = "Watson" };

                //contexto.Atores.AddRange(ator1, ator2);
                //contexto.SaveChanges();

                //var emmaWatson = contexto.Atores
                //    .Where(a => a.PrimeiroNome == "Emma" && a.UltimoNome == "Watson");
                //Console.WriteLine($"Total de atores encontrados: {emmaWatson.Count()}.");





                //contexto.LogSQLToConsole();

                //var ator1 = new Ator { PrimeiroNome = "Emma", UltimoNome = "Watson" };
                //var ator2 = new Ator { PrimeiroNome = "Emma", UltimoNome = "Watson" };

                //contexto.Atores.AddRange(ator1, ator2);
                //contexto.SaveChanges();

                //var emmaWatson = contexto.Atores
                //    .Where(a => a.PrimeiroNome == "Emma" && a.UltimoNome == "Watson");
                //Console.WriteLine($"Total de atores encontrados: {emmaWatson.Count()}.");
















                ////Log sql enviado para o BD
                //contexto.LogSQLToConsole();

                //var idiomas = contexto.Idiomas
                //    .Include(i => i.FilmesFalados); //select com Join

                //foreach (var idioma in idiomas)
                //{
                //    Console.WriteLine(idioma);

                //    foreach (var filme in idioma.FilmesFalados)
                //    {
                //        Console.WriteLine(filme);
                //    }
                //    Console.WriteLine("\n");
                //}



                ////Log sql enviado para o BD
                //contexto.LogSQLToConsole();

                //var filme = contexto.Filmes
                //    .Include(f => f.Atores) //inclusão de Join
                //    .ThenInclude(fa => fa.Ator) //inclusão de Join
                //    .First();
                //Console.WriteLine(filme);
                //Console.WriteLine("Elenco:");

                ////Shadow Property ToTable("film_actor")
                //foreach (var ator in filme.Atores) 
                //{
                //    Console.WriteLine(ator.Ator);                   
                //}





                ////select *from category
                //using (var contexto = new AluraFilmesContext())
                //{
                //    //vendo o log sql enviado para o BD
                //    contexto.LogSQLToConsole();

                //    foreach (var categoria in contexto.Categorias)
                //    {
                //        System.Console.WriteLine(categoria);
                //    }
                //}



                ////select *from actor
                //using (var contexto = new AluraFilmesContext())
                //{
                //    //vendo o log sql enviado para o BD
                //    contexto.LogSQLToConsole();

                //    ////Lendo e ordenando valores de Shadow Property
                //    var atores = contexto.Atores
                //        .OrderByDescending(a => EF.Property<DateTime>(a, "last_update"))
                //        .Take(10);
                //    foreach (var ator in atores)
                //    {
                //        Console.WriteLine(ator + " - " + contexto.Entry(ator).Property("last_update").CurrentValue);
                //    }
                //}


                ////select *from filme
                //using (var contexto = new AluraFilmesContext())
                //{
                //    //vendo o log sql enviado para o BD
                //    contexto.LogSQLToConsole();

                //    foreach (var filme in contexto.Filmes)
                //    {
                //        Console.WriteLine(filme);
                //    }
                //}

            }
        }
    }
}








//select a.*
//from actor a
//inner join film_actor fa on fa.actor_id = a.actor_id
//where film_id = 1



//select a.*
//from actor a
//inner join film_actor fa on fa.actor_id = a.actor_id
//inner join film f on f.film_id = fa.film_id
//where fa.film_id = 1






////Elaboração de relatórios com Top5

//select top 5 a.first_name, a.last_name, count(*) as total
//from actor a
//	inner join film_actor fa on fa.actor_id = a.actor_id
//group by a.first_name, a.last_name
//order by total desc


////Elaboração de relatórios com Completo

//select a.first_name, a.last_name, count(*) as total
//from actor a
//	inner join film_actor fa on fa.actor_id = a.actor_id
//group by a.first_name, a.last_name
//order by total desc



//clausula para atender a regra do entity quanto ao FromSql

//select a.*
//from actor a
//    inner join
//(select top 5 a.actor_id, count(*) as total
//from actor a

//    inner join film_actor fa on fa.actor_id = a.actor_id
//group by a.actor_id
//order by total desc) filmes on filmes.actor_id = a.actor_id