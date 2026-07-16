using UnityEngine;

public class AudioManager : MonoBehaviour
{
    //ƒVƒ“ƒOƒ‹ƒgƒ“
    public static AudioManager instance;

    private AudioSource seAudioSource;
    private AudioSource bgmAudioSource;
    public AudioClip[] seAudioClips;
    public AudioClip[] bgmAudioClips;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(this.gameObject);
        }
    }
    public void SEPlay(int i)
    {
        if (seAudioSource == null)
        {
            seAudioSource = this.gameObject.AddComponent<AudioSource>();
        }
        seAudioSource.clip = seAudioClips[i];
        seAudioSource.Play();
    }

    public void BGMPlay(int i)
    {
        if (bgmAudioSource == null)
        {
            bgmAudioSource = this.gameObject.AddComponent<AudioSource>();
        }
        bgmAudioSource.clip = bgmAudioClips[i];
        bgmAudioSource.Play();
        bgmAudioSource.loop = true;
    }

    public void Start()
    {
        BGMPlay(0);
    }
}
