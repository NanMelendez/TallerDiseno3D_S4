using UnityEngine;

public class Daño : MonoBehaviour
{
    [SerializeField] [Range(1, 100)] private float daño;

    public float DañoInflingible
    {
        get => daño;
    }
}
