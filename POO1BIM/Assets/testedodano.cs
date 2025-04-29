using UnityEngine;

public class testedodano : MonoBehaviour
{

    
    Personagem
    private void OnCollisionEnter(Collision colisao)
    {
        if (colisao.gameObject.CompareTag()== "inimigo"))
        {
            int energia_atual = Personagem.Energia() 
                                - colisao.gameObject.GetComponent<inimigo>().DanoDoInimigo();
            
            Personagem.AtribuirEnergia(energia_atual);

            Debug.Log("O personagem " + Personagem.getNome() + "tem agora " + Personagem.Energia());




        }
    }
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
}
