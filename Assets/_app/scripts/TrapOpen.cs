﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrapOpen : MonoBehaviour
{
    public Animator anim;
    
    private void OnTriggerEnter(Collider other)
    {
        anim.SetBool("IsOpened", true);
    }
}
