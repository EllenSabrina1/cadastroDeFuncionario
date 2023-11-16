using System;
using System.Windows.Forms;

public class Cadastro
{
    public string Nome { get; set; }
    public string Email { get; set; }
    public DateTime DataNascimento { get; set; }
    public string CPF { get; set; }
    public int RG { get; set; }
    public string Estado { get; set; }
    public string Cidade { get; set;}
    public string Endereco { get; set; }
    public string EstadoCivil { get; set; }
    public string Telefone { get; set; }
    public string Funcao { get; set; }
    public double Salario {  get; set; }

    public Cadastro() { }
    public Cadastro(string Nome, string Email, DateTime ataNascimento, string CPF, int RG, string estado, string cidade,
    string endereco, string estadoCivil, string telefone, string funcao, double salario)
    {
        this.Nome = Nome;
        this.Email = Email;
        this.DataNascimento = DataNascimento;
        this.CPF = CPF;
        this.RG = RG;
        this.Estado = Estado;
        this.Cidade = Cidade;
        this.Endereco = Endereco;
        this.Telefone = Telefone;
        this.Funcao = Funcao;
        this.Salario = Salario;
    }
}

