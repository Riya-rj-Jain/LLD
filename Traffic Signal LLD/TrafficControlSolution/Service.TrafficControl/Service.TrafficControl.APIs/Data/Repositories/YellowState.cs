using Service.TrafficControl.APIs.Interfaces;
using Service.TrafficControl.APIs.Models.Entities;


namespace Service.TrafficControl.APIs.Data.Repositories
{
    internal class YellowState : ITrafficLight
    {
        bool ITrafficLight.canTransitionTo(ITrafficLight newState)
        {
            throw new NotImplementedException();
        }

        string ITrafficLight.GetStateName()
        {
            throw new NotImplementedException();
        }

        Task ITrafficLight.TurnGreen(TrafficLightEntity trafficLight)
        {
            throw new NotImplementedException();
        }

        Task ITrafficLight.TurnOff(TrafficLightEntity trafficLight)
        {
            throw new NotImplementedException();
        }

        Task ITrafficLight.TurnRed(TrafficLightEntity trafficLight)
        {
            throw new NotImplementedException();
        }

        Task ITrafficLight.TurnYellow(TrafficLightEntity trafficLight)
        {
            throw new NotImplementedException();
        }
    }
}
