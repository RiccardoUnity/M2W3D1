using UnityEngine;

public class Esercizio3Opzionale : MonoBehaviour
{
    private MeshRenderer _meshRenderer;

    public Material[] material;

    private void ChangeMaterial(Material[] material)
    {
        _meshRenderer.material = material[Random.Range(0, material.Length)];
    }

    private void ChangeMaterial(Material[] material, string coloreStringa)
    {
        _meshRenderer.material = material[Random.Range(0, material.Length)];
        Debug.Log(coloreStringa + _meshRenderer.material.name);
    }

    void Start()
    {
        _meshRenderer = GetComponent<MeshRenderer>();
        ChangeMaterial(material, "Il colore usato è: ");
    }
}
