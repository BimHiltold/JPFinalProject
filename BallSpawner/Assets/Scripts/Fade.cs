using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fade : Ball
{

    public string ballName;

    void Awake()
    {
        SetUpBall();
    }

    public override void SetUpBall()
    {
        m_ballType = ballName;
        Debug.Log("Fade Spawn" + m_ballType);
    }

}
