class RemoteControlCar
{
    int speed = 0;
    int batteryDrain = 0;
    int distanceDriven = 0;
    int battery = 100;
    
    public RemoteControlCar(int speed, int batteryDrain)
    {
        this.speed = speed;
        this.batteryDrain = batteryDrain;
    }
    public bool BatteryDrained() => battery <= 0 || batteryDrain > battery;
    

    public int DistanceDriven() => distanceDriven;
    

    public void Drive()
    {
        if(BatteryDrained())
            return;
        distanceDriven += speed;
        battery -= batteryDrain;
    }

    public static RemoteControlCar Nitro()
    {
        RemoteControlCar nitroCar = new RemoteControlCar(50, 4);
        return nitroCar;
    }
}

class RaceTrack
{
    int distance = 0;
    // TODO: define the constructor for the 'RaceTrack' class
    public RaceTrack(int distance)
    {
        this.distance = distance;
    }
    public bool TryFinishTrack(RemoteControlCar car)
    {
        while(!car.BatteryDrained())
        {
            car.Drive();
        }
            
        if(car.DistanceDriven() >= distance)
        {
            return true;
        }
        else
            return false;
    }
}
