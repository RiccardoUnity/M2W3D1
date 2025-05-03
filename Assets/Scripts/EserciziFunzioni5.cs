using UnityEngine;

public class EserciziFunzioni5 : MonoBehaviour
{
    public int dimensioneArray;

    private int[] GeneraArray()
    {
        int[] array = new int[20];
        for(int i = 0; i < array.Length; i++)
        {
            array[i] = Random.Range(0, 100);
        }

        return array;
    }

    private int[] GeneraArray(ref int dimensione)
    {
        if (dimensione <= 0)
        {
            Debug.LogError("Il tuo array non ha una dimensione maggiore di zero");
            return null;
        }
        else
        {
            int[] array = new int[dimensione];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = Random.Range(0, 100);
            }

            return array;
        }
    }

    private void StampaArray(int[] array)
    {
        if (array == null)
        {
            Debug.LogError("Il tuo array non ha elementi");
        }
        else
        {
            Debug.Log(string.Join(", ", array));
        }
    }

    void Start()
    {
        StampaArray(GeneraArray(ref dimensioneArray));
    }
}
