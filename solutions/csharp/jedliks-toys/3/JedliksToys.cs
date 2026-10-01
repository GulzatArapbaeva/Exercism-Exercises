class RemoteControlCar
{
    public int meters = 0;
    public int percentage = 100;
    
    public static RemoteControlCar Buy() => new RemoteControlCar();
    

    public string DistanceDisplay() => $"Driven {meters} meters";
    

    public string BatteryDisplay() => percentage > 0 ? $"Battery at {percentage}%" : "Battery empty";
    

    public void Drive()
    {
        if(percentage <= 0)
            return;
        meters += 20;
        percentage -= 1;
    }
}
