using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gotomymenu : MonoBehaviour
{
    public void menu()
    {
        SceneManager.LoadScene("Start Menu");
        Time.timeScale = 1f;
    }

}

