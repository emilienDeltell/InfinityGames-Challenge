using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public int score;
    [SerializeField] private int map1Level; //The Map with 2 Levels
    [SerializeField] private int map2Level; //The Map with 4 Levels
    [SerializeField] private int map3Level; //The Map with 5 Levels
    UIManager ui;

    void Start()
    {
        ui = GetComponent<UIManager> ();
        PlayerPrefs.SetInt ("map1Level", 2);
        PlayerPrefs.SetInt ("map2Level", 2);
        map1Level = PlayerPrefs.GetInt ("map1Level");
        map2Level = PlayerPrefs.GetInt ("map2Level");

        LoadFromPlayerPrefs ();
        CheckPlayerProgress ();
    }

    // Update is called once per frame
    void Update()
    {
        
    }



    #region Check for the Player Progress
    public void CheckPlayerProgress() {            
            if (map1Level < 2) {   //Everything is turned off
            ui.map2Button.interactable = false;
            ui.map3Button.interactable = false;
        }
            if (map1Level == 2) {  //Unlock the button for second Map
            ui.map2Button.interactable = true;
            ui.map3Button.interactable = false;
        }

            if (map2Level == 4) {  //Unlock the button for the third Map
            ui.map2Button.interactable = true;
            ui.map3Button.interactable = true;
        }      
    }


    #endregion

    #region Load from PlayerPrefs
    //After having the game saved in both playerprefs and scriptable objects here I can just check for its level completion
    public void LoadFromPlayerPrefs() {
        if (!PlayerPrefs.HasKey ("map1Level")) {
            PlayerPrefs.SetInt ("map1Level", 0);
        }
        map1Level = PlayerPrefs.GetInt ("map1Level");

        if (!PlayerPrefs.HasKey ("map2Level")) {
            PlayerPrefs.SetInt ("map2Level", 0);
        }
        map2Level = PlayerPrefs.GetInt ("map2Level");

        if (!PlayerPrefs.HasKey ("map3Level")) {
            PlayerPrefs.SetInt ("map3Level", 0);
        }
        map3Level = PlayerPrefs.GetInt ("map3Level");
    }
    #endregion

    #region Button Clicks
    public void OnMap1Click() {
        ui.maps.SetActive (false);
        if (map1Level == 0) {
            ui.DisableButton (ui.firstMapLvl_2);
            ui.firstMapLevels.SetActive (true);
        }

        if (map1Level >= 1) {
            ui.EnableButton (ui.firstMapLvl_2);
            ui.firstMapLevels.SetActive (true);
        }

    }

    public void OnMap2Click() {
        ui.maps.SetActive (false);
        if (map2Level == 0) {
            ui.DisableButton (ui.secondMapLvl_2);
            ui.DisableButton (ui.secondMapLvl_3);
            ui.DisableButton (ui.secondMapLvl_4);
            ui.secondMapLevels.SetActive (true);
        }

        if (map2Level == 1) {
            ui.EnableButton (ui.secondMapLvl_2);
            ui.DisableButton (ui.secondMapLvl_3);
            ui.DisableButton (ui.secondMapLvl_4);
            ui.secondMapLevels.SetActive (true);
        }

        if (map2Level == 2) {
            ui.EnableButton (ui.secondMapLvl_2);
            ui.EnableButton (ui.secondMapLvl_3);
            ui.DisableButton (ui.secondMapLvl_4);
            ui.secondMapLevels.SetActive (true);
        }

        if (map2Level >= 3) {
            ui.EnableButton (ui.secondMapLvl_2);
            ui.EnableButton (ui.secondMapLvl_3);
            ui.EnableButton (ui.secondMapLvl_4);
            ui.secondMapLevels.SetActive (true);
        }
    }

    public void OnMap3Click() {
        ui.maps.SetActive (false);
        if (map3Level == 0) {
            ui.DisableButton (ui.thirdMapLvl_2);
            ui.DisableButton (ui.thirdMapLvl_3);
            ui.DisableButton (ui.thirdMapLvl_4);
            ui.DisableButton (ui.thirdMapLvl_5);
            ui.thirdMapLevels.SetActive (true);
        }

        if (map3Level == 1) {
            ui.EnableButton (ui.thirdMapLvl_2);
            ui.DisableButton (ui.thirdMapLvl_3);
            ui.DisableButton (ui.thirdMapLvl_4);
            ui.DisableButton (ui.thirdMapLvl_5);
            ui.thirdMapLevels.SetActive (true);
        }

        if (map3Level == 2) {
            ui.EnableButton (ui.thirdMapLvl_2);
            ui.EnableButton (ui.thirdMapLvl_3);
            ui.DisableButton (ui.thirdMapLvl_4);
            ui.DisableButton (ui.thirdMapLvl_5);
            ui.thirdMapLevels.SetActive (true);
        }

        if (map3Level == 3) {
            ui.EnableButton (ui.thirdMapLvl_2);
            ui.EnableButton (ui.thirdMapLvl_3);
            ui.EnableButton (ui.thirdMapLvl_4);
            ui.DisableButton (ui.thirdMapLvl_5);
            ui.thirdMapLevels.SetActive (true);
        }

        if (map3Level >= 4) {
            ui.EnableButton (ui.thirdMapLvl_2);
            ui.EnableButton (ui.thirdMapLvl_3);
            ui.EnableButton (ui.thirdMapLvl_4);
            ui.EnableButton (ui.thirdMapLvl_5);
            ui.thirdMapLevels.SetActive (true);
        }
    }
    #endregion

}
