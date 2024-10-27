using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{ public float speed = 3;
    // Start is called before the first frame update
    private void OnMouseDrag()
    {
        Vector3 mousePos = new Vector3 (Input.mousePosition.x, Input.mousePosition.y, speed);
        Vector3  objectPos = Camera.main.ScreenToWorldPoint(mousePos);
        transform.position = objectPos;
    }
}
