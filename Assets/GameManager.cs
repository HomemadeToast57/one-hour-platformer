using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    public Canvas win;
    // Start is called before the first frame update
    void Start()
    {
        win.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(win.isActiveAndEnabled)
        {
            Time.timeScale = 0;
            if (Input.GetKeyDown(KeyCode.R))
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
                Time.timeScale = 1;
            }
        }
    }
}
