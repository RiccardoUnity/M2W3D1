using UnityEngine;

public class Esercizio2Opzionale : MonoBehaviour
{
    private Material _material;

    private Color rosso = Color.red;

    private void ChangeMaterial(ref Color color)
    {
        _material.color = color;
    }

    void Start()
    {
        _material = GetComponent<MeshRenderer>().material;
        ChangeMaterial(ref rosso);
    }
}
