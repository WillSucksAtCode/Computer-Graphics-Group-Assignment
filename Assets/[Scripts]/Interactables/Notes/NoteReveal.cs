using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NoteReveal : MonoBehaviour
{
    [SerializeField]
    private Image _noteImage;

    //when the player enters the trigger area, the note will appear
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            _noteImage.enabled = true;
        }
    }

    //when the player exits the trigger area, the note will disappear
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            _noteImage.enabled = false;
        }
    }
}