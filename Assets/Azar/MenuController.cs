using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    [Header("Levels To Load")]
    public string newGameLevel;
    private string levelToLoad;

    [SerializeField] private GameObject noSavedGameDialog = null;
    [SerializeField] private GameObject LoadGameGameDialog = null;

    public void NewGameDialogYes() {
        SceneManager.LoadScene(newGameLevel);
    }
    public void LoadGameDialogYes() {
        if (PlayerPrefs.HasKey("SavedLevel")) {
            levelToLoad = PlayerPrefs.GetString("SavedLevel");
            SceneManager.LoadScene(levelToLoad);
        }
        else {
            LoadGameGameDialog.SetActive(false);
            noSavedGameDialog.SetActive(true);
        }
    }

    public void ExitButton() {
        Application.Quit();
    }
}
