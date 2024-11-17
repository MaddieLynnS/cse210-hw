public class SmartTemp : SmartDevice
{
    public SmartTemp(string name, bool isOn) : base(name, isOn)
    {
        _timeOn = 0;
    }

    public override void AboutDevice()
    {
        return $"{name}: {isOn}";
    }
}