public class Room : House
{
    private List<SmartDevice> _devices = new List<SmartDevice>();

    public void AddDevice(SmartDevice device)
    {
        _devices.Add(device);

    }

    public void ChangeLights(bool onOrOff)
    {
        foreach (SmartLight light in _devices)
        {
            light.TurnOnOrOff(onOrOff);
        }
    }

    public void ChangeDevice(SmartDevice device, bool onOrOff)
    {
        device.TurnOnOrOff(onOrOff);
    }

    public void ChangeAll(bool onOrOff)
    {
        foreach (SmartDevice device in _devices)
        {
            device.TurnOnOrOff(onOrOff);
        }
    }

    public void ShowAllDevices()
    {
        foreach(SmartDevice device in _devices)
        {
            Console.WriteLine(device.AboutDevice());
        }
    }

    public void ShowOnDevices()
    {
        foreach(SmartDevice device in _devices)
        {
            if(device.GetIsOn())
            {
                Console.WriteLine(device.GetName());
            }
        }
    }

    public void DeviceOnLongest()
    {
        SmartDevice d = _devices[0];
        foreach(SmartDevice device in _devices)
        {
            if(device.GetTimeOn > d.GetTimeOn)
            {
                d = device;
            }
        }
        Console.WriteLine(d.GetName());
    }
}