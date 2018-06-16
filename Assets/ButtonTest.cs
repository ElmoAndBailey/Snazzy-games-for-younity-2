using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonTest : MonoBehaviour {
    [SerializeField] private Text _text;
    [SerializeField] private Button _button1;
    [SerializeField] private Button _button2;

    private void Start () {
        _button1.onClick.AddListener(ChangeText);
	}
	
		
	private void ChangeText()
    {
        _text.text = "Can you hear me?";
    
    }
}
