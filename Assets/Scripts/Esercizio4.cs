using UnityEngine;

public class Esercizio4 : MonoBehaviour
{
    public bool debug;

    [Header("Genera Array")]
    [Tooltip("Non inserire zero")]
    public int grandezzaArray;
    public int numeroMinore;
    public int numeroMaggiore;

    [Header("Genera Nuovo Array")]
    public int grandezzaNuovoArray;

    private int[] _array1;
    private int[] _array2;

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

    private int[] CambiaDimensioneArray(int[] _array, int dim)
    {
        if (dim <= 0)
        {
            Debug.LogError("Il nuovo array non ha dimensioni");
            return _array;
        }
        else if (dim == _array.Length)
        {
            Debug.LogWarning("Il nuovo array ha la stessa dimensione del primo array");
            return _array;
        }
        else
        {
            int[] _nuovoArray = new int[dim];
            for (int i = 0; i < _array.Length; i++)
            {
                _nuovoArray[i] = _array[i];
                if (debug)
                    Debug.Log($"Array 2 - {i} - {_nuovoArray[i]}");
            }

            if (dim > _array.Length)
            {
                for (int i = _array.Length;  i < _nuovoArray.Length; i++)
                {
                    _nuovoArray[i] = 0;
                    if (debug)
                        Debug.Log($"Array 2 - {i} - {_nuovoArray[i]}");
                }
            }

            return _nuovoArray;
        }
    }

    void Start()
    {
        _array1 = GeneraArray(grandezzaArray, numeroMinore, numeroMaggiore);
        _array2 = CambiaDimensioneArray(_array1, grandezzaNuovoArray);
    }
}
