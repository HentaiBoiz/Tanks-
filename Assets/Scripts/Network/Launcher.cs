using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;

public class Launcher : MonoBehaviour
{
    [SerializeField]
    private float delayTime = 1.2f;
    [SerializeField]
    private string scene_Name;

    private float timeElapsed;

    // Start is called before the first frame update
    void Start()
    {

    }

    private void Update()
    {
        timeElapsed += Time.deltaTime;
        if(timeElapsed > delayTime)
        {
            SceneManager.LoadScene(scene_Name);
        }
    }

}
