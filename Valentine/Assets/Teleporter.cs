using UnityEngine;

public class Teleporter : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            // Define the specific coordinate (0, 1, 0)
            Vector3 destination = new Vector3(0, 1, 0);

            // Move the player
            other.transform.position = destination;

            Debug.Log("Teleported player to: " + destination);
        }
    }
}