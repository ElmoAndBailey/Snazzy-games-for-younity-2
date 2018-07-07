using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jsonTest : MonoBehaviour {
    public TextAsset jsonFile;
	
	void Start () {
        SceneList scenes = JsonUtility.FromJson<SceneList>(jsonFile.text);
        Debug.Log(scenes.Scenes.Count);
	}
	
	
}
