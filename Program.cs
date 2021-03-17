using System;

namespace DIObank
{
    class Program
    {
        static void Main(string[] args)
        {
            Conta minhaConta = new Conta(TipoConta.PessoaFisica, 0, 0, "Jõao das Coves");


            Console.WriteLine(minhaConta.ToString());
        }
    }
}
