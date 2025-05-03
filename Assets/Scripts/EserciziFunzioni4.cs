using UnityEngine;

public class EserciziFunzioni4 : MonoBehaviour
{
    private int[] GeneraArray()
    {
        int[] array = new int[20];
        for(int i = 0; i < array.Length; i++)
        {
            array[i] = Random.Range(0, 100);
        }

        return array;
    }

    private void StampaArray(int[] array)
    {
        Debug.Log(string.Join(", ", array));
    }

    void Start()
    {
        StampaArray(GeneraArray());
    }
}
