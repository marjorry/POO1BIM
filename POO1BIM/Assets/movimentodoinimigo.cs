using UnityEngine;

public class movimentodoinimigo : MonoBehaviour
{
    private GameObject _player;
    
    private Rigidbody _rigidbody;
    private float velocidade;

    public float raioDeVisao = 3;
    void Start()
    {
        velocidade = gameObject.GetComponent<inimigo>().Velocidade();
        _rigidbody = gameObject.GetComponent<Rigidbody>();
        
        _player = GameObject.FindWithTag("Player");
    }


    void Update()
    {
        if (Vector3.Distance(transform.position, _player.transform.position) < raioDeVisao)
        {
            transform.LookAt(_player.transform.position);
        }
    }


   
}

