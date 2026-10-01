class RemoteControlCar
{
    public int meters = 0;
    public int percentage = 100;
    
    public static RemoteControlCar Buy()
    {
        return new RemoteControlCar();
    }

    public string DistanceDisplay()
    {
        return $"Driven {meters} meters";
    }

    public string BatteryDisplay()
    {
        if(percentage <= 0)
            return "Battery empty";
        else
            return $"Battery at {percentage}%";
    }

    public void Drive()
    {
        if(percentage <= 0)
            return;
        meters += 20;
        percentage -= 1;
    }
}
