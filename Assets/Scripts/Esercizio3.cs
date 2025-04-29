using UnityEngine;

public class Esercizio3 : MonoBehaviour
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

    private void TrovaMinimi2(int[] _array)
    {
        if (_array.Length > 1)
        {
            int ultimo = numeroMaggiore;
            int penultimo = numeroMaggiore;

            for (int i = 0; i < _array.Length; i++)
            {
                if (_array[i] < ultimo)
                {
                    penultimo = ultimo;
                    ultimo = _array[i];
                }
                else if (_array[i] < penultimo && _array[i] != ultimo)
                    penultimo = _array[i];
            }

            Debug.Log($"Numero più basso: {ultimo} - Secondo numero più basso: {penultimo}");
        }
        else
        {
            Debug.LogError("Il tuo array non è grande abbastanza");
        }
    }

    private void TrovaMassimi2(int[] _array)
    {
        if (_array.Length > 1)
        {
            int primo = numeroMinore;
            int secondo = numeroMinore;

            for (int i = 0; i < _array.Length; i++)
            {
                if (_array[i] > primo)
                {
                    secondo = primo;
                    primo = _array[i];
                }
                else if (_array[i] > secondo && _array[i] != primo)
                    secondo = _array[i];
            }

            Debug.Log($"Numero più alto: {primo} - Secondo numero più alto: {secondo}");
        }
        else
        {
            Debug.LogError("Il tuo array non è grande abbastanza");
        }
    }

    void Start()
    {
        _array = GeneraArray(grandezzaArray, numeroMinore, numeroMaggiore);
        //Debug.Log("Numero minore dell'array: " + TrovaMinimo(_array));
        //Debug.Log("Numero maggiore dell'array: " + TrovaMassimo(_array));
        TrovaMinimi2(_array);
        TrovaMassimi2(_array);
    }
}
