using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenuUI : MonoBehaviour
{
    [SerializeField] private Button playSinglePlayerButton;
    [SerializeField] private Button playMultiplayerButton;
    [SerializeField] private Button quitButton;

    private void Awake() {
        playSinglePlayerButton.onClick.AddListener(() => {
            KitchenGameMultiplayer.playMultiplayer = false;
            Loader.Load(Loader.Scene.LobbyScene);
        });           
        
        playMultiplayerButton.onClick.AddListener(() => {
            KitchenGameMultiplayer.playMultiplayer = true;
            Loader.Load(Loader.Scene.LobbyScene);
        });        
        
        quitButton.onClick.AddListener(() => {
            Application.Quit();
        });

        Time.timeScale = 1.0f;
    }
}
