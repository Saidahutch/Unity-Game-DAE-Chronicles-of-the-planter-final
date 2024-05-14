using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Resumer_Script : MonoBehaviour
{ 
        public void PlayGame()
    {
        SceneManager.LoadScene("Level 1");   
    }

        public void Go_to_mainmenu(){
            SceneManager.LoadScene("HomeScreen");
        }


}
