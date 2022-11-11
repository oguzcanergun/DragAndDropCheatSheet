using UnityEngine;

public class Dragger : MonoBehaviour
{
    [SerializeField] private Camera mainCamera;

    [HideInInspector] public Vector3 dragOffset;

    private void Awake()
    {
        dragOffset = Vector3.zero;
    }

    private void OnMouseDrag()
    {
        transform.position = UpdateObjectPosition();
    }

    public virtual Vector3 UpdateObjectPosition()
    {
        return GetMousePosition() + dragOffset;
    }

    public virtual Vector3 GetMousePosition()
    {
        var mousePosition = mainCamera.ScreenToWorldPoint(Input.mousePosition);
        mousePosition.z = 0.0f;
        return mousePosition;
    }
}
