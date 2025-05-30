using UnityEngine;

public class AudioManager : MonoBehaviour {
    
    public static AudioManager instance { get; set; }

    [Header("Audio Source")]
    [SerializeField] AudioSource musicSource;
    [SerializeField] AudioSource SFXSource;

    [Header("Audio Clip")]
    public AudioClip BackGroundSound;
    public AudioClip DoorSFX;
    public AudioClip LanternSFX;
    public AudioClip PickupNoteSFX;
    public AudioClip PlayerFootStepSFX;
    public AudioClip PlayerFootStepSFX2;
    
    public AudioClip PlayerFootStepIndoorSFX;
    public AudioClip PlayerFootStepIndoorSFX2;


    private void Awake()
    {

        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    void Start()
    {
        musicSource.clip = BackGroundSound;
        musicSource.Play();
    }

    public void playSFX(AudioClip clip){
        SFXSource.PlayOneShot(clip);
    }
}