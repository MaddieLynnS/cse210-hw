public class SmartLight : SmartDevice
{
    public SmartLight(string name, bool isOn) : base(name, isOn)
    {
        _timeOn = 0;
    }

    public override void AboutDevice()
    {
        return $"{name}: {isOn}";
    }
}