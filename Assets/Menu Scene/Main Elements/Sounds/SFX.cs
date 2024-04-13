using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SFX : MonoBehaviour
{
    // Start is called before the first frame update
    public AudioSource Beep;

    public void PlayBeep()
    {
        Beep.Play();
    }
}
