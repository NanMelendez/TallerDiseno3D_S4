using System;
using UnityEngine;

public class EnemigoMelee : MonoBehaviour
{
    private int vida;
    private int daño;
    private bool estaVivo;
    private bool yaImprimiMuerte;
    private int vecesQueRecibioDaño;

  
    public void Inicializar(int vidaInicial, int dañoInicial)
    {
        vida = vidaInicial;
        daño = dañoInicial;
        estaVivo = true;
        yaImprimiMuerte = false;
        vecesQueRecibioDaño = 0;

        Debug.Log($"Enemigo Melee creado con {vida} de vida y {daño} de daño.");
    }

    
    public int Atacar()
    {
        if (!estaVivo)
        {
            Debug.Log("El enemigo melee está muerto, no puede atacar.");
            return 0;
        }

        Debug.Log($"El enemigo melee ataca cuerpo a cuerpo causando {daño} de daño.");
        return daño;
    }

    
    public void RecibirDaño(int cantidad)
    {
        vecesQueRecibioDaño = vecesQueRecibioDaño + 1;

        if (cantidad < 0)
        {
            Debug.Log("ERROR: no se puede recibir daño negativo");
            return;
        }

        int vidaAntes = vida;
        vida = vida - cantidad;

        Debug.Log($"El enemigo melee recibe {cantidad} de daño.");
        Debug.Log($"Vida antes: {vidaAntes}");
        Debug.Log($"Vida ahora: {vida}");

        if (vida <= 0)
        {
            vida = 0;
            estaVivo = false;

            if (yaImprimiMuerte == false)
            {
                Debug.Log("*** El enemigo melee ha muerto ***");
                yaImprimiMuerte = true;
            }
            else
            {
                Debug.Log("El enemigo melee ya estaba muerto, no hace falta pegarle más.");
            }
        }
        else
        {
            Debug.Log($"Al enemigo melee le quedan {vida} puntos de vida");
        }

        Debug.Log("---------------------------------------------");
    }

    
    public bool EstaVivo()
    {
        return estaVivo;
    }

   
    public int GetVida()
    {
        return vida;
    }

    public int GetDaño()
    {
        return daño;
    }
}
