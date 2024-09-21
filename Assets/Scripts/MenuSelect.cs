using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.UI;

public class MenuSelect : MonoBehaviour
{

    //Exit Menu
    public GameObject exitMenu;

    //Options menu
    public GameObject OptionsMenu;

    public GameObject mainMenu;

    bool menu = true;

    public Slider volume;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            mainMenu.SetActive(true);
        }
    }

    public void SelectLevel()
    {
        mainMenu.SetActive(false);
    }

    public void VolumeChange()
    {
        AudioListener.volume = volume.value;
    }


    //Opens the exit menu
    public void exitMenuOpen()
    {
        var animEx = exitMenu.GetComponent<Animation>();
        exitMenu.transform.SetAsLastSibling();
        animEx.Play("Fade In");
    }

    //Closes the exit menu
    public void exitMenuClose()
    {
        var animEx = exitMenu.GetComponent<Animation>();
        animEx.Play("Fade out");
    }

    //Exit Game
    public void exitGame()
    {
        Application.Quit();
    }

    //Open Options
    public void openOptions()
    {
        OptionsMenu.gameObject.GetComponent<Animation>().Play("Fade In");
        OptionsMenu.transform.SetAsLastSibling();
    }

    //Close Options
    public void closeOptions()
    {
        OptionsMenu.gameObject.GetComponent<Animation>().Play("Fade out");
    }
}
