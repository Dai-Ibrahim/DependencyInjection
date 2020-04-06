using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Pattern.DependencyInjection
{
    public class Client : MonoBehaviour
    {
        public Rocket SaturnV_player;
        public Rocket Mercury_AI;
        public Rocket FalconHeavy_AI;
        public Rocket Antares_AI;
		
		
        void Awake()
        {
            IEngine solidFuel = new SolidFuelEngine();
            IDriver humanDriver = new HumanDriver();
            SaturnV_player.SetEngine(solidFuel);
            SaturnV_player.SetDriver(humanDriver);
            SaturnV_player.StartEngine();

            IEngine hybridFuel = new HybridEngine();
            IDriver ET = new AIDriver();
            Mercury_AI.SetEngine(hybridFuel);
            Mercury_AI.SetDriver(ET);
            Mercury_AI.StartEngine();

            IEngine liquidFuel = new LiquidFuelEngine();
            IDriver ElonMusk = new AIDriver();
            FalconHeavy_AI.SetEngine(liquidFuel);
            FalconHeavy_AI.SetDriver(ElonMusk);
            FalconHeavy_AI.StartEngine();

            IEngine ionEngine = new IonEngine();
            IDriver AI = new AIDriver();
            Antares_AI.SetEngine(ionEngine);
            Antares_AI.SetDriver(AI);
            Antares_AI.StartEngine();
        }

        void Update()
        {
            if (Input.GetKeyDown(KeyCode.A))
			{ 
				SaturnV_player.TurnLeft(); 
				Mercury_AI.TurnLeft(); 
				FalconHeavy_AI.TurnLeft(); 
				Antares_AI.TurnLeft(); 
			}
            if (Input.GetKeyDown(KeyCode.D))
			{
				SaturnV_player.TurnRight(); 
				Mercury_AI.TurnRight(); 
				FalconHeavy_AI.TurnRight(); 
				Antares_AI.TurnRight(); 
			}
        }
        void OnGUI() { 
            GUI.color = Color.white; 
            GUI.Label(new Rect(10, 10, 500, 20), "Press A to turn LEFT and D to turn RIGHT"); 
            GUI.Label(new Rect(10, 30, 500, 20), "Output displayed in the debug console"); 
        }
    }
}
