using UnityEngine;

using UnityEngine;

public class inimigo : Personagem
{
    
    
    public enum ArmaDoInimigo
    {
        ESPADA, MACHADO, ADAGA 
    }
    
    public enum ArmaduraDoInimigo
    {
        MADEIRA, COURO, BRONZE, AÇO
    }
    
    
    [ SerializeField ]
    private ArmaduraDoInimigo armadura;
    [ SerializeField ]
    private ArmaDoInimigo arma;
    private int dano;

    public void AtribuirArmadura(ArmaduraDoInimigo armadura)
    {
        this.armadura = armadura;
    }
    
    public ArmaduraDoInimigo Armadura()
    {
        return armadura;
    }
    
    public void AtribuirArma(ArmaDoInimigo arma)
    {
        this.arma = arma;
    }
    
    public ArmaDoInimigo Arma()
    {
        return arma;
    }

    public void DanoDoInimigo()
    {
        int dano = 0;

        switch (arma)
        
        
        {
            case ArmaDoInimigo.ESPADA:
                dano = Forca_Ataque() + 10;
                break;
            case ArmaDoInimigo.MACHADO:
                dano = dano = Forca_Ataque() + 18;
                break;
            case ArmaDoInimigo.ADAGA:
                dano = Forca_Ataque() + 5;
                break;
        }


    }
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    
    // Update is called once per frame
   
}