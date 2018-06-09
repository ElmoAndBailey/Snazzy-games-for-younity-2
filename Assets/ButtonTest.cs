using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonTest : MonoBehaviour {
    [SerializeField] private Button _button1;
    [SerializeField] private Button _button2;
    void Start () {
        _button1.onClick.AddListener(Test);
	}
	
		
	private void Test()
    {
        Debug.Log("1");
    }
}
