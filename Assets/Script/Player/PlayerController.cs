using Spine.Unity;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public int speed;

    Rigidbody2D rig;
    SkeletonAnimation skeletonAnimation;
    void Start()
    {
        rig = GetComponent<Rigidbody2D>();
        skeletonAnimation = GetComponent<SkeletonAnimation>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("d"))
        {
            rig.MovePosition(new Vector2(this.transform.position.x + 0.01f * this.speed, this.transform.position.y));
            transform.rotation = Quaternion.Euler(0, 180, 0);
            skeletonAnimation.AnimationName = "2.2.  Run_FIX2";
        }else if (Input.GetKey("a"))
        {
            rig.MovePosition(new Vector2(this.transform.position.x - 0.01f * this.speed, this.transform.position.y));
            transform.rotation = Quaternion.Euler(0, 0, 0);
            skeletonAnimation.AnimationName = "2.2.  Run_FIX2";
        }
        else
        {
            skeletonAnimation.AnimationName = "1. Idle";
        }
    }
}
