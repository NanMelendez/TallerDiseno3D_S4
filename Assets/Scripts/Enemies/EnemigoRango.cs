using System;
using UnityEngine;
public class EnemigoRango : MonoBehaviour
{
    private int vida;
    private int daño;
    private int balas = 5;
    private bool estaVivo;
    private bool yaImprimiMuerte;
    private int vecesQueRecibioDaño;

    public void Disparar()
    {
        if (balas > 0)
        {
            balas -= 1;
            Console.WriteLine("El enemigo rango dispara y le quedan " + balas + " balas");
        }
        else
        {
            Console.WriteLine("El enemigo rango no tiene balas para disparar");
        }
    }

    public void RecibirDaño(int cantidad)
    {
        vecesQueRecibioDaño = vecesQueRecibioDaño + 1;

        if (cantidad < 0)
        {
            Console.WriteLine("ERROR: no se puede recibir daño negativo");
            return;
        }

        int vidaAntes = vida;
        vida = vida - cantidad;

        Console.WriteLine("El enemigo rango recibe " + cantidad + " de daño");
        Console.WriteLine("Vida antes: " + vidaAntes);
        Console.WriteLine("Vida ahora: " + vida);

        if (vida <= 0)
        {
            vida = 0;
            estaVivo = false;

            if (yaImprimiMuerte == false)
            {
                Console.WriteLine("*** El enemigo rango ha muerto ***");
                yaImprimiMuerte = true;
            }
            else
            {
                Console.WriteLine("El enemigo ya estaba muerto, no hace falta pegarle mas");
            }
        }
        else
        {
            Console.WriteLine("Al enemigo rango le quedan " + vida + " puntos de vida");
        }

        Console.WriteLine("----------------------------------------");
    }

    public int GetDaño()
    {
        int dañoQueVoyARetornar = this.daño;
        return dañoQueVoyARetornar;
    }

    public bool EstaVivo()
    {
        if (vida > 0)
        {
            return true;
        }
        else if (vida == 0)
        {
            return false;
        }
        else
        {
            return false;
        }
    }
    public void MostrarEstado()
    {
        Console.WriteLine("===== ESTADO DEL ENEMIGO RANGO =====");
        Console.WriteLine("Vida: " + vida);
        Console.WriteLine("Daño: " + daño);
        Console.WriteLine("Balas: " + balas);

        if (estaVivo == true)
        {
            Console.WriteLine("Estado: VIVO");
        }
        else
        {
            Console.WriteLine("Estado: MUERTO");
        }

        Console.WriteLine("Veces que ha recibido daño: " + vecesQueRecibioDaño);
    }
}