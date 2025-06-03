using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerManager : MonoBehaviour
{
    public Animator animator;
    private  MovimentoPlayer movimentoPlayer;
    public float velocidadeDaAnimacao = 1;
    private personagem personagem;
        
    
    void Start()
    {
        movimentoPlayer = GetComponent<MovimentoPlayer>();
    }
    void Update()
    {
        animator.SetBool("Andando", movimentoPlayer.andando);
        animator.speed = velocidadeDaAnimacao;

        if (Input.GetKeyDown(KeyCode.Space))
        {
            animator.SetTrigger("Ataque");  
        }

        if (personagem.Energia() <= 0)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}

