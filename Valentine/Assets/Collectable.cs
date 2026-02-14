using UnityEngine;

public class Collectable : MonoBehaviour
{
    private AudioSource myAudio;

    void Start()
    {
        // This looks for the AudioSource attached to this specific GameObject
        myAudio = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (myAudio != null && myAudio.clip != null)
            {
                myAudio.Play();
            }
        }
    }
}