using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bouncy : Ball
{

    public string ballName;

    void Awake()
    {
        SetUpBall();
    }

    public override void SetUpBall()
    {
        m_ballType = ballName;
        Debug.Log("Bouncy Spawn" + m_ballType);
    }

}
