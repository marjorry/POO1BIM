using UnityEngine;

public class teste : MonoBehaviour
{
    private carro fusca = new carro();
    void Start()
    {
        fusca.setNome("Fusca do Shalom");
        fusca.setCor("Verde");
        
        Debug.Log(" 0 "+ fusca.getNome() + " é " + fusca.getCor());
    }

    
    void Update()
    {
        
    }
}
