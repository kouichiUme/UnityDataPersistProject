using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class InputController : MonoBehaviour
{

    
    [SerializeField] TextMeshProUGUI m_Object;
    [SerializeField] MenuController controller;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SaveToMenuText(){

        MenuController.Instance.inputText = m_Object.text;
    }
}
