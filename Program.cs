using System;
public class Program
{
	static void Main(string[] args)
	{
		try
		{
			string nome = null;
			Console.WriteLine(nome.Substring(2));
			new Curso().CriarAluno(nome);
		}
		// Capturando uma exceção de referência nula.
		// Similar ao NullPointerExceptio do  Java
		catch (NullReferenceException)
		{
			Console.WriteLine("Nome do aluno incorreto");
		}
		catch (Exception)
		{
			Console.WriteLine("Problema na execução a operação");
			throw new Exception("Problema na execução a operação");
		}
	}
}
