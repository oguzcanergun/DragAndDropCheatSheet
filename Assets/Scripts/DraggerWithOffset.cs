using System;

public class DraggerWithOffset : Dragger
{
    private void OnMouseDown()
    {
        dragOffset = transform.position - GetMousePosition();
    }
}