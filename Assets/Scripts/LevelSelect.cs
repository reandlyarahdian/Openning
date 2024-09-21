using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.Design;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelSelect : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI child;

    void Start()
    {
        child = this.GetComponentInChildren<TextMeshProUGUI>();
        child.gameObject.SetActive(false);
    }

    public void PointerEnter()
    {
        child.gameObject.SetActive(true);
    }

    public void PointerExit()
    {
        child.gameObject.SetActive(false);
    }

    public void PointerClick(string SceneName)
    {
        SceneManager.LoadScene(SceneName);
    }
}
