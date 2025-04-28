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

    public void DanoDoInimigo()
    {
        int dano = 0;

        switch (arma)
        {
            case "ESPADA":
                dano = Forca_Ataque() + 10;
                break;
            case "MACHADO":
                dano = dano = Forca_Ataque() + 18;
                break;
            case "ADAGA":
                dano = Forca_Ataque() + 5;
                break;
        }


    }
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    
    // Update is called once per frame
   
}
