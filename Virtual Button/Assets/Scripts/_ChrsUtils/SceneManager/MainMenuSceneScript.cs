using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Sirenix.OdinInspector;

public class MainMenuSceneScript : Scene<TransitionData>
{
    public KeyCode startGame = KeyCode.Space;

    [SerializeField] private float SECONDS_TO_WAIT = 0.1f;

    private TaskManager _tm = new TaskManager();

    TransitionData mainMenuData = new TransitionData();

    bool finishedAllStories = true;

    internal override void OnEnter(TransitionData data)
    {
        Services.AudioManager.PlayBGM(BGM.SILENCE);

    }

    internal override void OnExit()
    {

    }

    public void DeleteData()
    {

    }

    public void PressedStartGame()
    {
    }

    public void PressedOptions()
    {

    }

    private void TitleTransition()
    {

    }

    private void ChangeScene()
    {
        Services.Scenes.Swap<GameSceneScript>();
    }

    private void Update()
    {
        _tm.Update();
        if (Input.GetKeyDown(startGame) || Input.GetMouseButtonDown(0) || Input.GetMouseButtonDown(1))
        {
            //Services.AudioManager.PlayClip(SFX.CLICK);
        }
    }
}
