using UnityEngine;

public class Esercizio1Opzionale : MonoBehaviour
{
    private Material _material;

    private Color rosso = Color.red;

    void Start()
    {
        _material = GetComponent<MeshRenderer>().material;
        _material.color = rosso;
    }
}
