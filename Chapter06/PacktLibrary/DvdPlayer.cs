namespace Packt.Shared;

public class DvdPlayer : IPlayable
{
    public void Play()
    {
        WriteLine("DVD Player is pausing.");
    }

    public void Pause()
    {
        WriteLine("DVD player is playing.");
    }
}