using UnityEngine;


public class player : MonoBehaviour
{
    private Rigidbody _rigdibody;

    private float velocidade = 10;
    

    void Start()
    {
        velocidade = gameObject.GetComponent<personagem>().Velocidade();
        _rigdibody = GetComponent<Rigidbody>();
    }
    
    void Update()
    {
        Vector3 posicao = transform.position;



        // esquerda
        if (Input.GetKey(KeyCode.D))
        {
            posicao.x = posicao.x + velocidade * Time.deltaTime;
        }


        //direita

        if (Input.GetKey(KeyCode.A))
        {
            posicao.x = transform.position.x - velocidade * Time.deltaTime;
        }


        // cima Z+
        if (Input.GetKey(KeyCode.W))
        {
            posicao.z = transform.position.z + velocidade * Time.deltaTime;
        }

        //baixo Z-
        if (Input.GetKey(KeyCode.S))
        {
            posicao.z = transform.position.z - velocidade * Time.deltaTime;

        }
        
        transform.position = posicao;
    }
}
