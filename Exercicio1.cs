public class ContaBancaria
{ 
    public string Cliente { get; set; } = string.Empty; 
    public int NumConta { get; set; }
    public decimal Saldo { get; set; }

    public ContaBancaria(string cliente, int numConta, decimal saldo)
    {
        Cliente = cliente;
        NumConta = numConta;
        Saldo = saldo;
    }

    public virtual void Sacar(decimal valorsSaque)
    {
        if (valorsSaque - Saldo >= 0)
        {
            Saldo -= valorsSaque;
        }
        else
        {
            throw new Exception("Saque não permitido.");
        }

    }

    public void Depositar(decimal valorDeposito)
    {
        Saldo += valorDeposito;
    }

    public void MostrarDados()
    {
        Console.WriteLine($"Cliente: {Cliente}");
        Console.WriteLine($"Número da Conta: {NumConta}");
        Console.WriteLine($"Saldo: R${Saldo:F2}");
    }
}

public class ContaEspecial : ContaBancaria
{
    public decimal Limite {  get; set; }

    public ContaEspecial(string cliente, int num_conta, decimal saldo, decimal limite) : base(cliente, num_conta, saldo)
    {
        Limite = limite;
    }

    public override void Sacar(decimal valorSaque)
    {
        if(valorSaque > Saldo + Limite)
        {
            throw new Exception("Saque não disponível.");
        } else
        {
            Saldo -= valorSaque; 
        }
    }
}


public class ContaPoupanca : ContaBancaria
{
    public int DiaRendimento { get; set; } = 0; 


    public ContaPoupanca(string cliente, int num_conta, decimal saldo, int diaRendimento) : base(cliente, num_conta, saldo)
    {
        DiaRendimento = diaRendimento;
    }

    public void CalculaNovoSaldo(decimal taxaRendimento)
    {
        Saldo = Saldo + (Saldo * (taxaRendimento / 100));
    }

}





//Na main:

ContaPoupanca contaPoupanca = new ContaPoupanca("Ana", 1234, 1000.0M, 15);
ContaEspecial contaEspecial = new ContaEspecial("Julia", 6789, 500.0M, 200M);

Console.WriteLine("Dados da Conta Poupança:");
contaPoupanca.MostrarDados();

Console.WriteLine("\nDados da Conta Especial:");
contaEspecial.MostrarDados();



try
{
    Console.WriteLine("\nSaque na Conta Poupança:");
    contaPoupanca.Sacar(200);
} catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}

try
{
    Console.WriteLine("\nSaque na Conta Especial:");
    contaEspecial.Sacar(600);
} catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}

Console.WriteLine("Depósito na Conta Poupança:");
contaPoupanca.Depositar(300m);


Console.WriteLine("Depósito na Conta Especial:");
contaEspecial.Depositar(200);

Console.WriteLine("Calculando novo saldo da Conta Poupança após rendimento:");
contaPoupanca.CalculaNovoSaldo(2.5M);

Console.WriteLine("Dados atualizados da Conta Poupança:");
contaPoupanca.MostrarDados();

Console.WriteLine("Dados atualizados da Conta Especial:");
contaEspecial.MostrarDados();

