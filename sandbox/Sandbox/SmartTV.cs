public class SmartTV : SmartDevice
{
    public SmartTV(string name, bool isOn) : base(name, isOn)
    {
        _timeOn = 0;
    }

    public override void AboutDevice()
    {
        return $"{name}: {isOn}";
    }
}