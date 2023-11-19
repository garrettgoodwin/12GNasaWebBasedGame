using UnityEngine;

public class CameraZoom : MonoBehaviour
{
    public Transform targetCharacter;
    public float zoomSpeed = 1f;
    public float targetOrthographicSize = 5f;

    void Update()
    {
        if (targetCharacter)
        {
            // Adjust the camera position smoothly towards the character
            Vector3 targetPosition = new Vector3(targetCharacter.position.x, targetCharacter.position.y, transform.position.z);
            transform.position = Vector3.Lerp(transform.position, targetPosition, Time.deltaTime * zoomSpeed);

            // Adjust the orthographic size for zoom effect
            Camera.main.orthographicSize = Mathf.Lerp(Camera.main.orthographicSize, targetOrthographicSize, Time.deltaTime * zoomSpeed);
        }
    }
}
