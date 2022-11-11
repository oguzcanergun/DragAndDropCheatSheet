using UnityEngine;

public class DraggerWithOffsetAndDamp : DraggerWithOffset
{
    [SerializeField] private float speed = 10.0f;
    public override Vector3 UpdateObjectPosition()
    {
        return Vector3.MoveTowards(transform.position, GetMousePosition() + dragOffset, speed * Time.deltaTime);
    }
}
