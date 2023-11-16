using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

public class Validacao
{
    public string cpf { get; set; }

    public Validacao(string cpf)
    {
        this.cpf = cpf;
    }
    public static bool ValidarCpf(string cpf)
    {
        // Remove pontos e hífen
        cpf = cpf.Replace(".", "").Replace("-", "");

        // Verifica se tem 11 dígitos
        if (cpf.Length != 11)
        {
            return false;
        }

        // Verifica o primeiro dígito
        int soma = 0;

        for (int i = 0; i < 9; i++)
        {
            soma += Convert.ToInt32(cpf[i].ToString()) * (10 - i);
        }

        int resto = soma % 11;
        int primeiroDigito = (resto >= 2) ? 11 - resto : 0;

        if (Convert.ToInt32(cpf[9].ToString()) != primeiroDigito)
        {
            return false;
        }

        // Verifica o segundo dígito
        soma = 0;
        for (int i = 0; i < 10; i++)
        {
            soma += Convert.ToInt32(cpf[i].ToString()) * (11 - i);
        }

        resto = soma % 11;
        int segundoDigito = (resto >= 2) ? 11 - resto : 0;

        if (Convert.ToInt32(cpf[10].ToString()) != segundoDigito)
        {
            return false;
        }

        // Se todas as verificações passaram, o CPF é válido
        return true;
    }

    public static bool ValidarEmail(string email)
    {
        string pattern = @"^[a-zA-Z0-9._-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,4}$";

        Regex regex = new Regex(pattern);

        return regex.IsMatch(email);
    }
}