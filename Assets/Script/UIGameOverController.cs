using System.Collections;
using System.Collections.Generic;
using UnityEngine;
<<<<<<< HEAD
=======

>>>>>>> 73c226d9a6def2603feb1d3843d5dbebc02aac86
using UnityEngine.SceneManagement;

public class UIGameOverController : MonoBehaviour
{
<<<<<<< HEAD
  
        // Update is called once per frame
        void Update()
        {
            if (Input.GetMouseButtonDown(0))
            {
                // reload
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            }
        }
    
=======
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            // reload
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
>>>>>>> 73c226d9a6def2603feb1d3843d5dbebc02aac86
}
