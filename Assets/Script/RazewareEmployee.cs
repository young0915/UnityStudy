using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RazewareEmployee
{
    public virtual string Speak()
    {
        return " Hi, I'm a Rezeware Employee.";
    }
}

public class Mic : RazewareEmployee
{
    public override string Speak()
    {
        return base.Speak() + "\n Hi I'm mic!";
    }
}