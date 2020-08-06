using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Levels : MonoBehaviour
{
    public GameObject lvl2;
    public GameObject lvl3;
  
    
    // Start is called before the first frame update
    void Start()
    {
        
        lvl2.SetActive(false);
        lvl3.SetActive(false);
        if (SharedValues_Script.score < 100 && SharedValues_Script.score > 50)
        {
            lvl2.SetActive(true);
        }
        if (SharedValues_Script.score < 150 && SharedValues_Script.score > 100)
        {
            lvl3.SetActive(true);
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
