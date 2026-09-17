using UnityEngine;

public class Salud : MonoBehaviour
{
    [SerializeField] [Range(1, 100)] private float maxSalud;

    private float saludActual;

    public float SaludActual
    {
        get => saludActual;
        set
        {
            saludActual = Mathf.Clamp(saludActual + value, 0, maxSalud);
        }
    }

    public bool EstáVivo
    {
        get => SaludActual > 0;
    }

    private void Awake()
    {
        saludActual = maxSalud;
    }

    public void RecibirSalud(float salud)
    {
        SaludActual += salud;
    }

    public void RecibirDaño(float daño)
    {
        SaludActual -= daño;
    }
}
