using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VirusAppears : MonoBehaviour
{
    public GameObject virus;
    public float minTime, maxTime;
    public float positionMin, positionMax;
 
    void Start()
    {
        StartCoroutine(MunculVirus());
    }


    IEnumerator MunculVirus()
    {
        Instantiate(virus, transform.position + Vector3.right * Random.Range(positionMin, positionMax)
            , Quaternion.identity);
        yield return new WaitForSeconds(Random.Range(minTime, maxTime));
        StartCoroutine(MunculVirus());
    }
}
