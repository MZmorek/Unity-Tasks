using System.Collections;
using UnityEngine;

public class CoroutineScript : MonoBehaviour
{
    private Coroutine myCoroutine;
    private void Start()
    {
        myCoroutine = StartCoroutine(LogStuff());
    }
    private IEnumerator LogStuff()
    {
        while (true)
        {
            yield return new WaitForSeconds(2);
            Debug.Log("Wiadomoœæ co 2 sekundy");
        }
    }
    private void OnDisable()
    {
        StopCoroutine(myCoroutine);
    }
}
