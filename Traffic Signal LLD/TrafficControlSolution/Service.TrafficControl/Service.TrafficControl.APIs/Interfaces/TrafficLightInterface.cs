using Service.TrafficControl.APIs.Models.Entities;

namespace Service.TrafficControl.APIs.Interfaces
{
    public interface ITrafficLight
    {
        Task TurnGreen(TrafficLightEntity trafficLight);
        Task TurnYellow(TrafficLightEntity trafficLight);
        Task TurnRed(TrafficLightEntity trafficLight);
        Task TurnOff(TrafficLightEntity trafficLight);
        string GetStateName();
        bool canTransitionTo(ITrafficLight newState);

    }
}
