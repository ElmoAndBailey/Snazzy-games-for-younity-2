using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoryManager : MonoBehaviour {
    public StoryButton MainButton;
    public TextAsset jsonFile;
    public SceneList ListOfScenes;
    private int sceneIndex, actionIndex;
    private SceneContents currentScene
    {
        get
        {
            return ListOfScenes.Scenes[sceneIndex].scene;
        }
    }
    private StorylineAction currentAction
    {
        get
        {
            return currentScene.storylineActions[actionIndex];
        }
    }

    void Start () {
        ListOfScenes = JsonUtility.FromJson<SceneList>(jsonFile.text);
        MainButton.Text.text = currentScene.buttonText;
        MainButton.ButtonObj.onClick.AddListener(HandleButtonClick);

    }
    private void HandleButtonClick()
    {
        MainButton.Text.text = currentAction.line;
        MainButton.Speaker.text = currentAction.speaker;
        actionIndex++;
        if (currentAction.type == "choice") {
            foreach (string Choice in currentAction.choices)
            {
                int SceneNumber  = ListOfScenes.FindNextSceneIndex(Choice);
                NovelScene Scene = ListOfScenes.FindNextScene(Choice);
                 string buttonText = Scene.scene.buttonText;
                var go = Instantiate(MainButton);
                var button = GetComponent<UnityEngine.UI.Button>();
                button.onClick.AddListener(() => HandleNextScene(SceneNumber));


            }


        }
            //HandleNextScene();
    }   
    


    private void HandleNextScene(int SceneNumber)
    {
       
        sceneIndex = SceneNumber;
        actionIndex = 0;
        MainButton.Text.text = currentAction.line;
        MainButton.Speaker.text = currentAction.speaker;

    }
}
