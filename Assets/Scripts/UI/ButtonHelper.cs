using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonHelper : MonoBehaviour
{
    public ParticleSystem buttonVFX; 

    public void OnClick()
    {
        if (buttonVFX != null) buttonVFX.Play();
    }
}
