using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public interface IEngine
{
    void StartEngine();
}

public class SolidFuelEngine : IEngine
{
    public void StartEngine()
    {
        SolidPropellant();
        Debug.Log("Engine Started");
    }
    private void SolidPropellant()
    {
        Debug.Log("Solid Fuel Engine Ready");
    }
}

public class LiquidFuelEngine : IEngine
{
    public void StartEngine()
    {
        LiquidPropellant();
        Debug.Log("Engine Started");
    }
    private void LiquidPropellant()
    {
        Debug.Log("Liquid Fuel Engine Ready");
    }
}
public class HybridEngine : IEngine
{
    public void StartEngine()
    {
        HybridPropellant();
        Debug.Log("Engine Started");
    }
    private void HybridPropellant()
    {
        Debug.Log("Hybrid Engine Ready");
    }
}
public class IonEngine : IEngine
{
    public void StartEngine()
    {
        SpaceBoosters();
        Debug.Log("Engine Started");
    }
    private void SpaceBoosters()
    {
        Debug.Log("Ion Engine Ready");
    }
}