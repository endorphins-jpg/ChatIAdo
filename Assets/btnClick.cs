using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class btnClick : MonoBehaviour
{
    [SerializeField]
    private string value;

    public Button btnNumber;
    public TMP_InputField pass_input;

    public void Start()
    {
        btnNumber.onClick.AddListener(OnButtonClick);    
    }

    public void OnButtonClick()
    {
        Debug.Log("Botão clicado: " + value);
        pass_input.text = pass_input.text + value;
    }
}