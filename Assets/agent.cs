using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using TMPro;

[System.Serializable]
public class UnityStringEvent : UnityEvent<string> { }

public class agent : MonoBehaviour
{
    public UnityStringEvent onAgentEvent;
    public TextMeshPro GPTAnswer;

    // Start is called before the first frame update
    void Start()
    {
        onAgentEvent.AddListener(handleStringEvent);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void handleStringEvent(string message)
    {
        // Debug.Log("GPT Response: " + message);
        GPTAnswer.text = message;
    }

    public void MakeGPTRequest(string question)
    {
        // Debug.Log(question); 
        onAgentEvent.Invoke(question);
    }
}
