using System.Collections;
using TMPro;
using UnityEngine;

public class CoroutineTimerScript : MonoBehaviour
{

    public GameObject circle;
    public TMP_Text timerText;

    private int seconds = 1;
    private int minutes = 0;
    private Coroutine timerCoroutine;


    private void Start()
    {
        timerCoroutine = StartCoroutine(MovingTimer());
    }
    private IEnumerator MovingTimer()
    {
        while (true)
        {
            yield return new WaitForSeconds(1);
            circle.transform.position = new Vector2(Random.Range(1, 4), Random.Range(1, 4));

            if (seconds == 10)
            {
                circle.transform.localScale = new Vector3(2f, 2f, 2f);
            }
            if (seconds > 59)
            {
                seconds = 0;
                minutes++;
            }
            if (minutes > 59)
            {
                minutes = 0;
            }
            timerText.text = $"Time elapsed: {minutes} minutes, {seconds} seconds";
            seconds++;

        }
    }

    private void OnDisable()
    {
        StopCoroutine(timerCoroutine);
    }
}
