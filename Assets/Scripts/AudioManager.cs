using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioSource SabAudioSource;
    public AudioClip[] SEaudioClips;
    public AudioClip BGMaudioClips; 

    public void SEPlay(int i)
    {
        audioSource.clip = SEaudioClips[i];
        if (audioSource.isPlaying == false)
        {
            SabAudioSource.Play();
        }
        else
        {
            audioSource.clip = SEaudioClips[i];
            audioSource.Play();
        }
    }
}
