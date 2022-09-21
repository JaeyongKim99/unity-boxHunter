using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScoreManager : MonoBehaviour
{
    public int score;
    Scene scene = SceneManager.GetActiveScene();

    void Awake() {
        DontDestroyOnLoad(gameObject);
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (scene.name == "GameScene")
        {
            Destroy(gameObject);
        }
    }
}
