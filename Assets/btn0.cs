using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonPress : MonoBehaviour
{
    public InputField pass_input;
    public Button btn0;

    void Start () {
		Button btn = btn0.GetComponent<Button>();
		btn.onClick.AddListener(TaskOnClick);
	}

	void TaskOnClick(){
		pass_input += "0";
	}
}