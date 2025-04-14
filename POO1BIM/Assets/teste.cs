using UnityEngine;

public class teste : MonoBehaviour
{
    carro fusca = new carro();
    carro gol = new carro();
    void Start()
    {
        fusca. AtribuirNome("Fusca do Shalom");
        fusca.AtribuirCor("Verde");
        fusca.AtribuirNumero_de_rodas(4);
        fusca.AtribuirPreco(2050.90f);
        Debug.Log(" 0 " + fusca.NomeDoCarro() + " é " + fusca.CorDoCarro() + "tem" + fusca.Numero_de_rodas() +" e custa R$" + fusca.Preco());


        gol. AtribuirNome("Fusca de marie");
        gol.AtribuirCor("rosa");
        gol.AtribuirNumero_de_rodas(4);
        gol.AtribuirPreco(3000.90f);
        
        
    }

    
    void Update()
    {
        
    }
}