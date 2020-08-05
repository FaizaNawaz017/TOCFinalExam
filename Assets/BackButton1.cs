using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackButton1 : MonoBehaviour
{
    public void backtoMainMenu()
    {
        SceneManager.LoadScene("Palindrome_menu");
    }
}

