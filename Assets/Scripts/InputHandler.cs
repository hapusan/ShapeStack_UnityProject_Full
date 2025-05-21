using UnityEngine;

public class InputHandler : MonoBehaviour
{
    public Shape currentShape;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow))
            currentShape.transform.position += Vector3.left;
        if (Input.GetKeyDown(KeyCode.RightArrow))
            currentShape.transform.position += Vector3.right;
        if (Input.GetKeyDown(KeyCode.DownArrow))
            currentShape.transform.position += Vector3.down;
        if (Input.GetKeyDown(KeyCode.UpArrow))
            currentShape.RotateShape();
    }
}