namespace Hito1_Encapsulamiento;
public class CuentaBancaria
{
    public string NumeroCuenta { get; }
    public string Titular { get; }
    public decimal Saldo { get; private set; }

    // Constructor principal
    public CuentaBancaria(string numeroCuenta, string titular, decimal saldoInicial)
    {
        if (string.IsNullOrWhiteSpace(numeroCuenta))
            throw new ArgumentException("Número de cuenta requerido.");
        if (string.IsNullOrWhiteSpace(titular))
            throw new ArgumentException("Titular requerido.");
        if (saldoInicial < 0m)
            throw new ArgumentException("Saldo inicial no puede ser negativo.");

        NumeroCuenta = numeroCuenta.Trim();
        Titular = titular.Trim();
        Saldo = saldoInicial;
    }

    // Constructor secundario
    public CuentaBancaria(string numeroCuenta, string titular)
        : this(numeroCuenta, titular, 0.0m) { }
}

public void Retirar(decimal monto)
{
    if (monto <= 0m)
        throw new ArgumentException("El monto debe ser mayor a cero.");
    if (monto > Saldo)
        throw new InvalidOperationException("Fondos insuficientes.");
    Saldo -= monto;
}

