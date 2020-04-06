using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IDriver
{
    void Control(Rocket rocket);
}



public class HumanDriver: IDriver
{
    private Rocket rocket;

    public void Control(Rocket selectedRocket)
    {
        rocket = selectedRocket;
        Debug.Log("Welcome aboard, the player/humans will be piloting this rocket");
    }
}




public class AIDriver : IDriver
{
    private Rocket rocket;

    public void Control(Rocket selectedRocket)
    {
        rocket = selectedRocket;
        Debug.Log("Welcome aboard, the AI/autopilot will be piloting this rocket");
    }
	
	
}
public class AlienDriver : IDriver
{
    private Rocket rocket;

    public void Control(Rocket selectedRocket)
    {
        rocket = selectedRocket;
        Debug.Log("Welcome aboard, our extraterrestrial overlords will be piloting this rocket");
    }
}



public class ElonMuskDriver : IDriver
{
    private Rocket rocket;

    public void Control(Rocket selectedRocket)
    {
        rocket = selectedRocket;
        Debug.Log("Welcome aboard, Elon Musk himself will be piloting this rocket");
    }
}
