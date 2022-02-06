using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Inheritance
public class Heavy : Ball
{


    public string ballName;

    void Awake()
    {
        SetUpBall();
    }

    //Polymorphism
    public override void SetUpBall()
    {
        m_ballType = ballName;
        Debug.Log("Heavy Spawn" + m_ballType);
    }

}
