using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotateTransformToMousePosition : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        rotateToMousePosition();
    }

    void rotateToMousePosition()
    {
        Vector3 mouseWorldPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition + Vector3.forward *10f);
        float angle = angleBetweenPoints(transform.position, mouseWorldPosition);

        transform.rotation = Quaternion.Euler (new Vector3(0f, 0f, angle - 30)); //30 is offset
    }

    float angleBetweenPoints(Vector2 a, Vector2 b)
    {
        return Mathf.Atan2(a.y - b.y, a.x - b.x) * Mathf.Rad2Deg;
    }
}
