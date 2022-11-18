using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LifeUI : MonoBehaviour
{
    [SerializeField] private GameObject[] objLifes;
    [SerializeField] private GameObject panelGameOver;
    private int hearts = 3;
    public void AddHeart()
    {
        hearts++;
        UpdateHeart();
    }
    public void RemoveHeart()
    {
        hearts--;
        UpdateHeart();
    }
    public void GameOver()
    {
        panelGameOver.SetActive(true);
    }
    public void NewGame()
    {
        SceneManager.LoadScene(1);
    }
    void UpdateHeart()
    {
        for (int i=0; i < 3; i++)
        {
            if(hearts>i)
            {
                objLifes[i].SetActive(true);
            }
            else
            {
                objLifes[i].SetActive(false);
            }
        }
    }
}
