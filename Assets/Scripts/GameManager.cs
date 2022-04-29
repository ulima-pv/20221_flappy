
using System;
using UnityEngine;

// Observador
public class GameManager : MonoBehaviour
{
    public BirdMovement birdMovement;
    public BackgroundScrolling backgroundScrolling;
    public TubeScrolling tubeScrolling1;
    public TubeScrolling tubeScrolling2;
    public TubeScrolling tubeScrolling3;
    public TubeScrolling tubeScrolling4;

    private void Start()
    {
        birdMovement.AddGameOverDelegate(GameOverDelegate);
    }

    public void GameOverDelegate(object sender, EventArgs e)
    {
        birdMovement.IsRunning = false;
        backgroundScrolling.IsRunning = false;
        tubeScrolling1.IsRunning = false;
        tubeScrolling2.IsRunning = false;
        tubeScrolling3.IsRunning = false;
        tubeScrolling4.IsRunning = false;
    }
}
