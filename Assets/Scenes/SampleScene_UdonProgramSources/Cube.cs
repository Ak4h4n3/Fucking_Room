
using UdonSharp;
using UnityEngine;
using VRC.SDKBase;
using VRC.Udon;

public class Cube : UdonSharpBehaviour
{
    public GameObject toggleObject;
    public AudioSource audioSource;

    public override void Interact(){
        audioSource.Play();
    }
}
