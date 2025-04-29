using UnityEngine;

public class Esercizio2 : MonoBehaviour
{
    public bool debug;

    [Header("Genera Array")]
    [Tooltip("Non inserire zero")]
    public int grandezzaArray;
    public int numeroMinore;
    public int numeroMaggiore;

    private int[] _array;

    private int[] GeneraArray(int dimensione, int minimo, int massimo)
    {
        if (dimensione <= 0)
        {
            Debug.LogError("Il tuo array non ha elementi");
            return null;
        }
        else
        {
            int[] _array = new int[dimensione];
            for (int i = 0; i < dimensione; i++)
            {
                _array[i] = Random.Range(minimo, massimo);
                if (debug)
                    Debug.Log($"Array 1 - {i} - {_array[i]}");
            }
            return _array;
        }
    }

    private int TrovaMinimo(int[] _array)
    {
        int minimo = numeroMaggiore;

        if (_array.Length > 0)
        {
            for (int i = 0; i < _array.Length; i++)
            {
                if (_array[i] < minimo)
                    minimo = _array[i];
            }
        }
        else
        {
            Debug.LogError("Il tuo array non ha elementi");
        }
        return minimo;
    }

    private int TrovaMassimo(int[] _array)
    {
        int massimo = numeroMinore;

        if (_array.Length > 0)
        {
            for (int i = 0; i < _array.Length; i++)
            {
                if (_array[i] > massimo)
                    massimo = _array[i];
            }
        }
        else
        {
            Debug.LogError("Il tuo array non ha elementi");
        }
            return massimo;
    }


    void Start()
    {
        _array = GeneraArray(grandezzaArray, numeroMinore, numeroMaggiore);
        Debug.Log("Numero minore dell'array: " + TrovaMinimo(_array));
        Debug.Log("Numero maggiore dell'array: " + TrovaMassimo(_array));
    }
}
