using UnityEngine;

public class testedodano : MonoBehaviour
{


    personagem personagem = new personagem();
    private void OnCollisionEnter(Collision colisao)
    {
       
        
        if (colisao.gameObject.CompareTag("Inimigo"))
        {
            int energia_atual = personagem.Energia() - colisao.gameObject.GetComponent<inimigo>().DanoDoInimigo();
            
            personagem.AtribuirEnergia(energia_atual);

            Debug.Log("O personagem " + personagem.getNome() + "tem agora " + personagem.Energia());




        }
    }


    private void Start()
    {
        personagem = GetComponent <personagem>();
    }

   
}
