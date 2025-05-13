using UnityEngine;

public class movimentodoinimigo : MonoBehaviour
{
    private GameObject _player;
    
    private Rigidbody _rigidbody;
    private float velocidade;

    public float raioDeVisao = 3;
    private bool naVisao = false;
    
    private SphereCollider _sphereCollider;
    void Start()
    {
        velocidade = gameObject.GetComponent<inimigo>().Velocidade();
        _rigidbody = gameObject.GetComponent<Rigidbody>();
        _sphereCollider = gameObject.GetComponent<SphereCollider>();
        
        _player = GameObject.FindWithTag("Player");
    }


    void Update()
    {
        if (Vector3.Distance(transform.position, _player.transform.position) < raioDeVisao)
        {
            transform.LookAt(_player.transform.position);
            transform.position = Vector3.MoveTowards(transform.position, _player.transform.position, velocidade * Time.deltaTime);
        }
    }

    void OnTriggerStay(Collider colisao)
    {
        if (colisao.gameObject.CompareTag("Player"))
        {
            naVisao = true;
        }
    }

   
}

