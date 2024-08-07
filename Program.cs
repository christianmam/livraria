// See https://aka.ms/new-console-template for more information
using Livraria2;


//Instanciar um objeto do tipo Editora
Editora novaEditora = new Editora();
novaEditora.Nome = "Novatec";
novaEditora.Telefone = "1129875485";
novaEditora.Site = "www.novatec.com.br";

//Instanciar um objeto do tipo Exemplar
Exemplar exemplarLivro = new Exemplar();

exemplarLivro.Tombo = "T1451-P2";

//Console.WriteLine("Editora: " + novaEditora.Nome);
//Instanciar um objeto -> Criar o objeto na memória
Livro meuLivro = new Livro();
//Console.WriteLine(meuLivro.Nome);
meuLivro.Nome = "Harry Potter 123";
meuLivro.Paginas = 150;
meuLivro.Valor = 100;
meuLivro.Resumo = "Harry Potter é um bruxo ...";

meuLivro.EditoraLivro = novaEditora;
meuLivro.ExemplarLivro = exemplarLivro;



/*meuLivro.SetIdioma("Ingles");*/
meuLivro.ExibirDados();
//Console.WriteLine(meuLivro.Nome + " foi publicado pela editora: " + meuLivro.Editora.Nome);
/*
Livro livroUML = new Livro("UML2");
//livroUML.Nome = "UML2";
livroUML.Autor = "Gilleanes Guedes";
livroUML.Paginas = 485;
livroUML.Valor = 100;
livroUML.Resumo = "UML 2.0 uma abordagem prática";
//livroUML.Idioma = "Portugues";
livroUML.ExibirDados();


Editora erika = new Editora();*/