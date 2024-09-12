namespace SharpPipe;


/// <summary>
/// Parameter struct that implements the Zita filter interface
/// </summary>
public struct ZitaParameters : IZitaFilter
{
    /// <summary>
    /// The input delay (ms) before reverb is applied to the incoming signal (default: 60ms)
    /// </summary>
    public float InDelay { get; set; }

    /// <summary>
    /// The separation between 'high' and 'low' frequencies (default: 200hz)
    /// </summary>
    public float Crossover { get; set; }

    /// <summary>
    /// The time in seconds it takes for low frequencies to decrease by 60dB (default: 3 seconds)
    /// </summary>
    public float RT60Low { get; set; }

    /// <summary>
    /// The time in seconds it takes for mid frequencies to decrease by 60dB (default: 2 seconds)
    /// </summary>
    public float RT60Mid { get; set; }

    /// <summary>
    /// Frequencies (hz) above this one are heard half as long as as the mid-range frequencies - e.g. when their T60 is half of the middle-range's T60 (default: 6000hz)
    /// </summary>
    public float HighFrequencyDamping { get; set; }

    /// <summary>
    ///  The center frequency (hz) of the Regalia Mitra peaking equalizer for the first section (default: 315hz)
    /// </summary>
    public float EQ1Frequency { get; set; }

    /// <summary>
    /// The peak level (dB) of equalizer 1 (default: 0dB)
    /// </summary>
    public float EQ1Level { get; set; }

    /// <summary>
    ///  The center frequency (hz) of the Regalia Mitra peaking equalizer for the second section (default: 1500hz)
    /// </summary>
    public float EQ2Frequency { get; set; }

    /// <summary>
    /// The peak level (dB) of equalizer 2 (default: 0dB)
    /// </summary>
    public float EQ2Level { get; set; }

    /// <summary>
    /// Mixes the wet and dry signals - e.g. 0 is no reverb, 1 is only reverb (default: 1)
    /// </summary>
    public float Mix { get; set; }

    /// <summary>
    /// The factor (dB) to scale the output by (default: -20dB)
    /// </summary>
    public float Level { get; set; }
}