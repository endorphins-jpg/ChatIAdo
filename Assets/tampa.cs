using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tampa : MonoBehaviour
{
    private bool moved;

    private void Start()
    {
        this.moved = false;
    }

    private void OnMouseDown()
    {
        if (!this.moved)
        {
            transform.position = Vector3.Lerp(
                transform.position, 
                transform.position + Vector3.up * 550f, 
                Time.deltaTime / 3f
            );
 
            this.moved = true;
        }
    }
}
