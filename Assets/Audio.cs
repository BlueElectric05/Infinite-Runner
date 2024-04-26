using UnityEngine;

public class Audio : MonoBehaviour
{
    [Header("-------------- Audio Source --------------")]
    [SerializeField] AudioSource musicSource;
    [SerializeField] AudioSource SFXSource;

    [Header("-------------- Audio Clip --------------")]
    public AudioClip BGM;
    public AudioClip Death;
    public AudioClip MenuConfirm;
    public AudioClip ScoreFX;

    private void Start()
    {
        musicSource.clip = BGM;
        musicSource.Play();
    }

    public void PlaySFX(AudioClip clip)
    {
        SFXSource.PlayOneShot(clip);
    }
}
