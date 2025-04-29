using UnityEngine;

public class Esercizio1 : MonoBehaviour
{
    [Header("IsEven")]
    public int pariDispari;

    [Header("IsMultipleOf")]
    [Tooltip("Non inserire zero")]
    public int baseNumero;
    public int multiplo;

    private bool IsEven(int number)
    {
        return number % 2 == 0;
    }

    private bool IsMultipleOf(int bas, int multiple)
    {
        return multiple % bas == 0;
    }

    void Start()
    {
        if (IsEven(pariDispari))
        {
            Debug.Log($"Il numero {pariDispari} è pari");
        }
        else
        {
            Debug.Log($"Il numero {pariDispari} è dispari");
        }

        if (baseNumero == 0) 
        {
            Debug.LogError("NON mettere zero come Base Numero, cambialo");
        }
        else
        {
            if (IsMultipleOf(baseNumero, multiplo))
            {
                Debug.Log($"Il numero {baseNumero} è multiplo del numero {multiplo}");
            }
            else
            {
                Debug.Log($"Il numero {baseNumero} NON è multiplo del numero {multiplo}");
            }
        }
    }
}
