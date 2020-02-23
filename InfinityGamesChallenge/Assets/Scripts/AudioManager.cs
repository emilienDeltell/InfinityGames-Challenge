using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class AudioManager : MonoBehaviour
{

    public AudioClip[] sound;
    public AudioSource audios;
    public AudioMixer audioMixer;
    int clipCounter = 0;
    float clipLenght = 0;

    // Use this for initialization
    void Start() {
        audios = GetComponent<AudioSource> ();
        PlayNextSound ();
        //audioMixer.SetFloat ("volume", +60);
    }

    // Update is called once per frame
    void Update() {

    }

    public void PlayNextSound() {
        audios.clip = sound[clipCounter];
        clipLenght = sound[clipCounter].length; //the lenght of the audioclip in seconds
        clipCounter++;
        audios.Play ();
        Debug.Log ("clipLenght: " + clipLenght + "seconds" + clipCounter);
        if (clipCounter == sound.Length) {
            clipCounter = 0;
        }

        StartCoroutine (NextSoundCourotine ());
    }

    IEnumerator NextSoundCourotine() {
        yield return new WaitForSeconds (clipLenght);

        PlayNextSound (); //write whatever you want in here

    }



}