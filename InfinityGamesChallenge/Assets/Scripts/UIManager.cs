using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    [Header ("Maps")]
    public GameObject maps;
    public Button map2Button;
    public Button map3Button;


    [Header ("FirstMap Levels")]
    public GameObject firstMapLevels;
    public Button firstMapLvl_2;

    [Header ("SecondMap Levels")]
    public GameObject secondMapLevels;
    public Button secondMapLvl_2;
    public Button secondMapLvl_3;
    public Button secondMapLvl_4;

    [Header ("ThirdMap Levels")]
    public GameObject thirdMapLevels;
    public Button thirdMapLvl_2;
    public Button thirdMapLvl_3;
    public Button thirdMapLvl_4;
    public Button thirdMapLvl_5;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void DisableBothMaps() {
        map2Button.interactable = false;
        map3Button.interactable = false;
    }

    public void DisableButton( Button button) {
        button.interactable = false;
    }

    public void EnableButton( Button button) {
        button.interactable = true;
    }
}
