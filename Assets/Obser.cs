using UnityEngine;

public class ObservableInt
{
    public System.Action<int> OnValueChanged;
    private int _value;


    public int Value
    {
        get => _value;
        set
        {
            _value = value;
            OnValueChanged?.Invoke(value);
        }
    }
    public ObservableInt(int value)
    {
        _value = value;
    }
}
