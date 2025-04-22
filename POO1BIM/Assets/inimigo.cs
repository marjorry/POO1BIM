using UnityEngine;

public class inimigo : personagem
{


    private string armadura;
    private string arma;
    private int dano;


    public void AtribuirArmadura(string armadura)
    {
        this.armadura = armadura;
    }
    
    public string Armadura()
    {
        return armadura;
    }
    
    public void AtribuirArma(string arma)
    {
        this.arma = arma;
    }
    
    public string Arma()
    {
        return arma;
    }
    
    public int DanoDoInimigo()
    {
        int dano = 0;

        switch (arma)
        {
            case "ESPADA":
                dano = Forca_Ataque() + 10;
                break;
            case "MACHADO":
                dano = dano = Forca_Ataque() + 18;
        }
        
        
        
        
    }
    
    public string Armadura()
    {
        return armadura;
    }
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
