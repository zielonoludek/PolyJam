using UnityEngine;

public class RoomController : MonoBehaviour
{
    private CameraController cameraController;

    private void Start()
    {
        cameraController = FindObjectOfType<CameraController>();
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.layer == 7) cameraController.SetFollowTarget(transform);
    }
}
