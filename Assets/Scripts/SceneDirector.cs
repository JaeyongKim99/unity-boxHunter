using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneDirector : MonoBehaviour
{
    Scene scene;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        scene = SceneManager.GetActiveScene();
        if(Input.GetMouseButtonDown(0)){
            if(scene.name == "ClearScene"){
                SceneManager.LoadScene("StartScene");
            } else{
                SceneManager.LoadScene("GameScene");
            }
        }
    }
}
