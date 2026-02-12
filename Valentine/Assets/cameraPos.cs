using UnityEngine;

public class CameraPos : MonoBehaviour
{
    public Transform cameraPosition;

    private void Update()
    {
        transform.position = cameraPosition.position;
        print("current cam pos: " + transform.position);
    }
}
