using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{

    public GameObject thisBall;
    public string m_ballType;

    public virtual void SetUpBall()
    {
        Debug.Log("Ball Spawn");
    }

}
