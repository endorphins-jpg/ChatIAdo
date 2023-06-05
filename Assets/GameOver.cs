using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver : MonoBehaviour
{
    public GameObject imageObject;
    
    void Start()
    {
        imageObject.SetActive(false);
    }

    public void Check(string pass)
    {
        if (pass == "314"){
            Debug.Log("Você passou!");
            imageObject.SetActive(true);
            Invoke("EndGame", 5f);
        }else{
            Debug.Log("Senha incorreta!!");
        }
    }

    private void EndGame()
    {
        Debug.Log("GAME OVER");
        UnityEditor.EditorApplication.isPlaying = false;
    }
}
