using System;

namespace Heranca
{
  class Program
  {
    static void Main(string[] args)
    {
      var conta = new ContaCorrente(20);

      var contaCorrente = new ContaCorrente(20);
      var contaInvestimento = new ContaInvestimento();

      var convert = ConverteConta(contaCorrente, contaInvestimento);
      Console.WriteLine($"Saldo: {convert.Saldo}");
      Console.WriteLine($"TipoConta: {convert.GetType().Name}");

    }
    public static C2 ConverteConta<C1, C2>(C1 conta1, C2 conta2) where C1 : Conta where C2 : Conta
    {
      //   var a = Activator.CreateInstance<A>();
      //   var b = Activator.CreateInstance<B>();

      conta2.setAttributes(conta1.Agencia, conta1.Numero, conta1.Saldo);
      return conta2;
    }
  }
}
