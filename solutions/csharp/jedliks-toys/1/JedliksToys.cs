class RemoteControlCar
{
    private int _distance;
    private int _battery = 100;
    
    public static RemoteControlCar Buy() => new();

    public string DistanceDisplay()=> $"Driven {_distance} meters";

    public string BatteryDisplay() {
        if (_battery == 0) return "Battery empty";
        else return $"Battery at {_battery}%";
    }

    public void Drive()
    {
        if (_battery < 1) return;
        else{
        _battery -= 1;
        _distance += 20;
        }
    }
}
