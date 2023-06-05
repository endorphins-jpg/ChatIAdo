using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class relogio : MonoBehaviour
{
    public GameObject imageObject;
    void OnMouseDown()
    {
        imageObject.SetActive(false);
    }
}
