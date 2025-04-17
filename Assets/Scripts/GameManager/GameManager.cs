using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    public GameObject startMenu;
    public GameObject mainMenu;
    public GameObject settingsMenu;
    public GameObject creditsScreen;
    public GameObject gameplay;

    public void Awake()
    {
        if (Instance == null)
        {
            Instance = this;

            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        DeactivateAllStates();
        ActivateStartMenu();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void DeactivateAllStates()
    {
        startMenu.SetActive(false);
        settingsMenu.SetActive(false);
        creditsScreen.SetActive(false);
        gameplay.SetActive(false);
        mainMenu.SetActive(false);
    }

    public void ActivateStartMenu()
    {
        DeactivateAllStates();
        startMenu.SetActive(true);
    }

    public void ActivateSettingsMenu() 
    {
        DeactivateAllStates();
        mainMenu.SetActive(true);
    }

    public void ActivateCreditsScreen() 
    {
        DeactivateAllStates();
        creditsScreen.SetActive(true);
    }

    public void ActivateGameplay()
    {
        DeactivateAllStates();
        gameplay.SetActive(true);
    }

    public void QuitGame()
    {

    }
}
