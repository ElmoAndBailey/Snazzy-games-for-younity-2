using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]
public class SceneList {
    public List <NovelScene> Scenes;
    public NovelScene FindNextScene(string SceneName)
    {
        return Scenes.Find(scene => scene.name == SceneName);

    }
    public int FindNextSceneIndex(string SceneName)
    {
        return Scenes.FindIndex(scene => scene.name == SceneName);

    }
}
