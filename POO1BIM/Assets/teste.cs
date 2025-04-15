using UnityEngine;

public class teste : MonoBehaviour
{
    carro fusca = new carro();
    carro gol = new carro();
    
    caminhao caminhao = new caminhao();
    
    void Start()
    {
        fusca. AtribuirNome("Fusca do Shalom");
        fusca.AtribuirCor("Verde");
        fusca.AtribuirNumero_de_rodas(4);
        fusca.AtribuirPreco(2050.90f);
        Debug.Log(" 0 " + fusca.NomeDoCarro() + " é " + fusca.CorDoCarro() + "tem" + fusca.Numero_de_rodas() +" e custa R$" + fusca.Preco());

        if (fusca.ComparePreco(gol))
        {
            Debug.Log("O carro " + fusca.NomeDoCarro() + "é mais caro do que o carro " + gol.NomeDoCarro());
        }
        else
        {
            Debug.Log("O carro " + fusca.NomeDoCarro() + "é mais barato do que o carro " + gol.NomeDoCarro());
        }
        
        caminhao.AtribuirTipoDeCarroceria("Larga");
        caminhao.AtribuirNumero_de_rodas(4);
        caminhao.AtribuirPreco(2050.90f);
        caminhao.AtribuirCor("Verde");
        caminhao.AtribuirNome("Fusca do Shalom");

        if (fusca.ComparePreco(caminhao))
        {
            Debug.Log("O carro " + fusca.NomeDoCarro() + "é mais caro do que o carro " + gol.NomeDoCarro());
        }
        //else
        
        
        
        
        
        
        
        
        
        
        
        
    }

    
    void Update()
    {
        
    }
}