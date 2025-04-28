using UnityEngine;

public class teste : MonoBehaviour
{
    carro fusca = new carro();
    carro gol = new carro();
    
    caminhao caminhao = new caminhao();
    
    //=====================================

    private personagem joao = new personagem();
    inimigo ork = new inimigo();
    
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
        
        //fusca.AtribuirTipoDeCarroceria("Larga");

        if (fusca.ComparePreco(caminhao))
        {
            Debug.Log("O carro " + fusca.NomeDoCarro() + "é mais caro do que o carro " + gol.NomeDoCarro());
        }
        
        //================================================
        
        joao.AtribuirNome("Joao Roberto II");
        joao.AtribuirEnergia(10);
        joao.AtribuirForca_Ataque(12);
        joao.AtribuirForca_Do_pulo(6);
        joao.AtribuirVelocidade(8);
        joao.AtribuirNumero_de_pes(2);
        joao.AtribuitNumero_de_maos(4);
        
        
        ork.AtribuirNome("Ork Gob");
        ork.AtribuirEnergia(23);
        ork.AtribuirForca_Ataque(15);
        ork.AtribuirForca_Do_pulo(8);
        ork.AtribuirVelocidade(6);
        ork.AtribuirNumero_de_pes(2);
        ork.AtribuitNumero_de_maos(4);


        if (joao.Energia() > ork.Forca_Ataque())
        {
            Debug.Log( "o personagem sobreviveu ao ataque do ork" + joao.getNome());
        }
        
        
        
        
        
        
        
        
        
    }

    
    void Update()
    {
        
    }
}