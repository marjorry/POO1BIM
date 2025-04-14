using UnityEngine;

public class carro
{
    private string nome;
    private int numero_de_rodas;
    private string cor;
    private float preco;

    public string getNome()
    {
        return this.nome;
    }

    public void AtribuirNome(string nome)
    {
        this.nome = nome;
    }

    public void AtribuirCor(string cor)
    {
        this.cor = cor;
    }

    public string CorDoCarro()
    {
        return this.cor;
    }

    public string NomeDoCarro()
    {
        return this.nome;
    }
    public void AtribuirNumero_de_rodas(int numero_de_rodas)
    {
        this.numero_de_rodas = numero_de_rodas;
    }

    public int Numero_de_rodas()
    {
        return this.numero_de_rodas;
    }

    public void AtribuirPreco(float preco)
    {
        this.preco = preco;

    }

    public float Preco()
    {
        return this.preco;
    }
    

}