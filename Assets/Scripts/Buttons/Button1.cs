using UnityEngine;

public class Button1 : MonoBehaviour
{
    [SerializeField] private GameObject panelText;
    [SerializeField] private AudioSource audioSource;
    [SerializeField] AudioClip audioClip;
    private bool playerIsOnButton;


    private void Update()
    {
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.D))
            playSound();
        else
            StopPlaySound();

        if (Input.GetKey(KeyCode.LeftShift))
            audioSource.pitch = 2f;
        else
            audioSource.pitch = 1f;
    }


    private void playSound()
    {
        if (!audioSource.isPlaying)
            audioSource.PlayOneShot(audioClip);
    }

    private void StopPlaySound()
    {
        audioSource.Stop();
    }
    private void Start()
    {
        panelText.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
            playerIsOnButton = true;
        panelText.SetActive(true);
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
            playerIsOnButton = false;
        panelText.SetActive(false);
    }
}