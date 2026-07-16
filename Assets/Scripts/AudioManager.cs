using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioSource sabAudioSource;
    public AudioSource bgmAudioSource;
    public AudioClip[] seAudioClips;
    public AudioClip[] bgmAudioClips;

    public void SEPlay(int i)
    {
        audioSource.clip = seAudioClips[i];
        if (audioSource.isPlaying == true)
        {
            sabAudioSource.clip = seAudioClips[i];
            sabAudioSource.Play();
        }
        else
        {
            audioSource.Play();
        }
    }

    public void BGMPlay()
    {
        bgmAudioSource.clip = bgmAudioClips[0];
        bgmAudioSource.Play();
    }
    public void Update()
    {
        if(bgmAudioSource.isPlaying == false)
        {
            BGMPlay();
        }
    }
}
