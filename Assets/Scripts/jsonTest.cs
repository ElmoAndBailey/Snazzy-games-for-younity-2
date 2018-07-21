using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jsonTest : MonoBehaviour {
    public TextAsset jsonFile;
    public SceneList ListOfScenes;

	void Start () {
        ListOfScenes = JsonUtility.FromJson<SceneList>(jsonFile.text);
        Debug.Log(ListOfScenes.Scenes.Count);
	}
	
	
}
