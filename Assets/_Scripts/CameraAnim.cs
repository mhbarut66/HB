using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraAnim : MonoBehaviour
{
    private Animator anim;

    void Start()
    {
        anim = GetComponent<Animator>();
    }



    public void CameraAnimation()
    {
        anim.SetBool("Finished", true);
    }
    
        
}
