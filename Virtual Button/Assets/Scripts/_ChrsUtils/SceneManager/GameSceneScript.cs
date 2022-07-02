﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class GameSceneScript : Scene<TransitionData>
{
    public bool endGame;

    public static bool hasWon { get; private set; }

    public const int LEFT_CLICK = 0;
    public const int RIGHT_CLICK = 1;

    [SerializeField] MonoTweener fadeOutScreenCover;
    [SerializeField] MonoTweener fadeInScreenCover;
    TransitionData transitionData;

    TaskManager _tm = new TaskManager();

    private void Start()
    {
        
    }

    private void OnDestroy()
    {
    }

    internal override void OnEnter(TransitionData data)
    {
        transitionData = data;
        fadeOutScreenCover?.Play();
    }


    public void StartStory()
    {

    }

    public void FadeInScreenCover()
    {
        fadeInScreenCover?.Play();
    }

    public void BackToMainMenuScreen()
    {

        Services.Scenes.Swap<MainMenuSceneScript>();
    }

    public void SwapScene()
    {
        Services.AudioManager.SetVolume(1.0f);
        Services.Scenes.Swap<TitleSceneScript>();
    }

    public void SceneTransition()
    {
        _tm.Do
        (
            new ActionTask(SwapScene)
        );
    }

    private void EndGame()
    {
        Services.AudioManager.FadeAudio();

    }

    public void EndTransition()
    {

    }
    
	// Update is called once per frame
	void Update ()
    {
        _tm.Update();
	}
}
