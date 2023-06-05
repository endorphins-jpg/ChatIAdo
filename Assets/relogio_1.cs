using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class relogio_1 : MonoBehaviour
{
    public GameObject imageObject;
    // Start is called before the first frame update
    void Start()
    {
        imageObject.SetActive(false);
    }

    // Update is called once per frame
    void OnMouseDown()
    {
        imageObject.SetActive(true);
    }
}
