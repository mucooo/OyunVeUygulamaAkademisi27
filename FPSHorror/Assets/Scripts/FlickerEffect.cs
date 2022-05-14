#region

using System.Collections;
using UnityEngine;

#endregion

public class FlickerEffect : MonoBehaviour
{
    public bool isFlickering;
    public float timeDelay;

    // Update is called once per frame
    private void Update()
    {
        if (isFlickering == false) StartCoroutine(Flicker());
    }

    private IEnumerator Flicker()
    {
        isFlickering = true;
        gameObject.GetComponent<Light>().enabled = false;
        timeDelay = Random.Range(0.3f, 0.7f);
        yield return new WaitForSeconds(timeDelay);
        gameObject.GetComponent<Light>().enabled = true;
        timeDelay = Random.Range(0.1f, 0.5f);
        yield return new WaitForSeconds(timeDelay);
        isFlickering = false;
    }
}