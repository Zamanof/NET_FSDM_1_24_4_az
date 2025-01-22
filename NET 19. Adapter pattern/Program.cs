// Adapter pattern
List<IAudioFile> musicPlayList = new List<IAudioFile> ();
musicPlayList.Add(new Mp3());
musicPlayList.Add(new Mp3());
musicPlayList.Add(new FLAC());
musicPlayList.Add(new Wav());
musicPlayList.Add(new OggAudioFileAdapter());

musicPlayList.ForEach(m => m.Play());


interface IAudioFile
{
    void Play();
}

class Mp3 : IAudioFile
{
    public void Play()
    {
        Console.WriteLine("MP3 is playing"); ;
    }
}

class Wav : IAudioFile
{
    public void Play()
    {
        Console.WriteLine("Wav is playing");
    }
}

class FLAC : IAudioFile
{
    public void Play()
    {
        Console.WriteLine("FLAC is playing");
    }
}

class Ogg
{
    public void PlaySomethingInteresting(bool repeat)
    {
        Console.WriteLine("Choxdan");
        Console.WriteLine("Yay chixibdi oxdan!!!");
    }
}

// Object Adapter

//class OggAudioFileAdapter : IAudioFile
//{
//    private Ogg m_ogg;
//    public void Play()
//    {
//        m_ogg.PlaySomethingInteresting(true);
//    }
//}

// Class adapter
class OggAudioFileAdapter : Ogg, IAudioFile
{
    public void Play()
    {
        this.PlaySomethingInteresting(true);
        // some magic convert programming code
    }
}