using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Scoring : MonoBehaviour
{
    Audio audioManager;
    public float score;
    public Text scoreUI;
    // Start is called before the first frame update

    private void Awake()
    {
        audioManager = GameObject.FindGameObjectWithTag("Audio").GetComponent<Audio>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("Virus"))
        {
            audioManager.PlaySFX(audioManager.ScoreFX);
            score += 100;
            scoreUI.text = "Score : " + score.ToString();
            Destroy(collision.collider.gameObject);
        }
    }
}
