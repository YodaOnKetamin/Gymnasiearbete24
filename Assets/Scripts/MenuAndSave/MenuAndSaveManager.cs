using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuAndSaveManager : MonoBehaviour
{


    public bool useSaved;
    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void QuitButton() 
    {
        Application.Quit();
        print("Quit");
    }

   public void NewGameButton() 
    {
        useSaved = false;
        SceneManager.LoadScene(1);
    }

    public void LoadGameButton() 
    {
        useSaved = true;
        SceneManager.LoadScene(1);
    }
}
