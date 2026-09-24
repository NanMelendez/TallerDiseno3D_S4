using System;
using UnityEngine;
public class EnemigoRango : MonoBehaviour
{
    int vida;
    int daño;
    private int balas = 5;
    private bool estaVivo;
    private bool yaImprimiMuerte;
    private int vecesQueRecibioDaño;
    public EnemigoRango(int vida, int daño)//: base(vida, daño)
    {
        this.vida = vida;
        this.daño = daño;
        this.balas = 5;
        this.estaVivo = true;
        this.yaImprimiMuerte = false;
        this.vecesQueRecibioDaño = 0;

        Console.WriteLine("Se crea un enemigo rango con " + vida + " de vida y " + daño + " de daño");
    }

    public void Disparar()
    {
        if (this.balas > 0)
        {
            this.balas = this.balas - 1;
            Console.WriteLine("El enemigo rango dispara y le quedan " + this.balas + " balas");
        }
        else
        {
            Console.WriteLine("El enemigo rango no tiene balas para disparar");
        }
    }

    public void RecibirDaño(int cantidad)
    {
        this.vecesQueRecibioDaño = this.vecesQueRecibioDaño + 1;

        if (cantidad < 0)
        {
            Console.WriteLine("ERROR: no se puede recibir daño negativo");
            return;
        }

        int vidaAntes = this.vida;
        this.vida = this.vida - cantidad;

        Console.WriteLine("El enemigo rango recibe " + cantidad + " de daño");
        Console.WriteLine("Vida antes: " + vidaAntes);
        Console.WriteLine("Vida ahora: " + this.vida);

        if (this.vida <= 0)
        {
            this.vida = 0;
            this.estaVivo = false;

            if (this.yaImprimiMuerte == false)
            {
                Console.WriteLine("*** El enemigo rango ha muerto ***");
                this.yaImprimiMuerte = true;
            }
            else
            {
                Console.WriteLine("El enemigo ya estaba muerto, no hace falta pegarle mas");
            }
        }
        else
        {
            Console.WriteLine("Al enemigo rango le quedan " + this.vida + " puntos de vida");
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
        if (this.vida > 0)
        {
            return true;
        }
        else if (this.vida == 0)
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
        Console.WriteLine("Vida: " + this.vida);
        Console.WriteLine("Daño: " + this.daño);
        Console.WriteLine("Balas: " + this.balas);

        if (this.estaVivo == true)
        {
            Console.WriteLine("Estado: VIVO");
        }
        else
        {
            Console.WriteLine("Estado: MUERTO");
        }

        Console.WriteLine("Veces que ha recibido daño: " + this.vecesQueRecibioDaño);
        Console.WriteLine("=====================================");
    }
}