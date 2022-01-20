using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuController : MonoBehaviour
{

    public static MenuController Instance;

    public string inputText ;
    // Start is called before the first frame update
    void Start()
    {

        if (Instance != null)
        {
            Destroy(gameObject);

        }
        else
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);

        }

    }
    // Update is called once per frame
    void Update()
    {

    }

}
