using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rocket : MonoBehaviour
{
    private IEngine engine;
    private IDriver driver;

    // Setter injection
    public void SetEngine(IEngine selectedEngine)
    {
        engine = selectedEngine;
    }
	
	
    public void SetDriver(IDriver selectedDriver)
    {
        driver = selectedDriver;
    }
	
	
    public void StartEngine()
    {
        engine.StartEngine();
        driver.Control(this);
    }
    
	
    public void TurnLeft()
    {
        Debug.Log("The " + driver + " is turning left in the " + engine + " rocketship.");
        transform.Rotate(0, -45, 0);
    }
	
	
    public void TurnRight()
    {
        Debug.Log("The " + driver + " is turning right in the " + engine + " rocketship.");
        transform.Rotate(0, 45, 0);
    }

}
