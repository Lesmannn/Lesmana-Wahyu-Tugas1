using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject[] life;
    int index = 0;
    public GameObject Over;


    public static GameManager instance;

    private void Awake()
    {
        instance = this;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene("Menu");
        }
    }
    public void takeDamage()
    {
        if(index < 2)
        {
            life[index].SetActive(false);
            index++;
        }
        else
        {
            gameOver();
        }
    }
    public void gameOver()
    {
        for (int i = 0; i<3; i++)
        {
            life[i].SetActive(false);
        }
        Over.SetActive(true);
        Time.timeScale = 0;
    }
    public void Restart()
    {
        SceneManager.LoadScene("Gameplay");
        Time.timeScale = 1;
    }
    public void Menu()
    {
        SceneManager.LoadScene("Menu");
        Time.timeScale = 1;
    }
}
