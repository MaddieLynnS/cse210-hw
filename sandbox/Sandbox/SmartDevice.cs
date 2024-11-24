public abstract class SmartDevice
{
    protected string _name;
    protected bool _isOn;
    protected DateTime _timeOn;
    private DateTime _startTime;

    public name GetName()
    {
        return _name;
    }
    public bool GetIsOn()
    {
        return _isOn;
    }
    public void TurnOnOrOff(bool onOrOff)
    {
        if(onOrOff)
        {
            _isOn = true;
            _startTime = DateTime.Now;
        }
        else
        {
            _isOn = false;
            _timeOn += (DateTime.Now - _startTime);
        }
    }
    public DateTime GetTimeOn()
    {
        return _timeOn;
    }

    public abstract SmartDevice(string name, bool isOn)
    {
        _name = name;
        _isOn = isOn;
        _timeOn = 0;
    }

    public abstract string AboutDevice();
}