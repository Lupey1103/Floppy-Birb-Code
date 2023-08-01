using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlappingScript : MonoBehaviour
{
    private Animator anim;
    // Start is called before the first frame update
    void Start()
    {
      anim = GetComponent<Animator>();  
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) == false)
        {
            anim.SetBool("isFlapping", false);
        }
        else
        {
            anim.SetBool("isFlapping", true);
        }
    }
}
