namespace ipsen5_data_hound.Services;

public class CounterService
{
    public int CurrentCount { get; private set; } = 0;

    public void IncrementCount()
    {
        CurrentCount++;
    }
    public void IncrementCount5()
    {
        CurrentCount+= 5;
    }
    public void IncrementCount10()
    {
        CurrentCount+= 10;
    }
}