using System; 

namespace Heranca
{
    class Program
    {
        static void Main(string[] args)
        {
           
        
        var conta = new ContaCorrente(20);

         var contaCorrente = new ContaCorrente(20);
         var contaInvestimento = new ContaInvestimento(10);


         var convert = ConverteConta(contaCorrente, contaInvestimento);

         Console.WriteLine(convert);

        }


    
        public static B ConverteConta<A, B>( A valor1, B valor2)
            where A: Conta
            where B: Conta
        {
        var a = Activator.CreateInstance<A>();
        var b = Activator.CreateInstance<B>();


        b.setAttributes(a.Agencia, a.Numero, a.Saldo);

        return b;



        }
    




    }


}
