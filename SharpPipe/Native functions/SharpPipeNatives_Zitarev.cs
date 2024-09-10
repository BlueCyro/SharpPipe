using System.Runtime.InteropServices;

namespace SharpPipe;

public static partial class SharpPipeNatives
{
    /// <summary>
    /// Allocates a <see cref="sp_zitarev"/> struct and assigns its memory address to a pointer passed in by reference
    /// </summary>
    /// <param name="zitaRevObject">Reference to a pointer that will point to the allocated struct</param>
    /// <returns>Success code</returns>
    [DllImport("libsoundpipe")]
    public static unsafe extern int sp_zitarev_create(ref IntPtr zitaRevObject);



    /// <summary>
    /// Inits a <see cref="sp_zitarev"/> struct from a pointer to it
    /// </summary>
    /// <param name="spObject">Pointer to a <see cref="sp_data"/> struct for gathering info</param>
    /// <param name="zitaRevObject">Pointer to a <see cref="sp_zitarev"/> struct</param>
    /// <returns>Success code</returns>
    [DllImport("libsoundpipe")]
    public static unsafe extern int sp_zitarev_init(IntPtr spObject, IntPtr zitaRevObject);



    /// <summary>
    /// Computes a single sample of audio from references to both a left and right channel and assigns the result to the left and right variables passed in by reference
    /// </summary>
    /// <param name="spObject">Pointer to a <see cref="sp_data"/> struct for gathering info</param>
    /// <param name="zitaRevObject">Pointer to a <see cref="sp_zitarev"/> struct</param>
    /// <param name="in1">Reference to the left audio sample</param>
    /// <param name="in2">Reference to the right audio sample</param>
    /// <param name="out1">Reference to the left output audio sample</param>
    /// <param name="out2">Reference to the right output audio sample</param>
    /// <returns>Success code</returns>
    [DllImport("libsoundpipe")]
    public static unsafe extern int sp_zitarev_compute(IntPtr spObject, IntPtr zitaRevObject, ref float in1, ref float in2, [In, Out] ref float out1, [In, Out] ref float out2);


    // P/Invoking the weird pointer-to-a-pointer type this wants is tricky and was taking a lot of time.
    // /// <summary>
    // /// Computes a span of audio samples from an input buffer of stereo samples and places the result into an output buffer of stereo samples
    // /// </summary>
    // /// <param name="spObject">Pointer to a <see cref="sp_data"/> struct for gathering info</param>
    // /// <param name="zitaRevObject">Pointer to a <see cref="sp_zitarev"/> struct</param>
    // /// <param name="size">Size of the input/output buffers</param>
    // /// <param name="stereoIn">Reference to the input buffer of stereo samples</param>
    // /// <param name="stereoOut">Reference to the output buffer of stereo samples</param>
    // /// <returns>Success code</returns>
    // [DllImport("libsoundpipe")]
    // public static unsafe extern int sp_zitarev_compute_many(IntPtr spObject, IntPtr zitaRevObject, int size, [In, Out] ref IntPtr stereoIn, [In, Out] ref IntPtr stereoOut);



    /// <summary>
    /// Frees a <see cref="sp_zitarev"/> struct from memory
    /// </summary>
    /// <param name="zitaRevObject">Reference to the pointer to the struct to be freed</param>
    /// <returns>Success code</returns>
    [DllImport("libsoundpipe")]
    public static unsafe extern int sp_zitarev_destroy(ref IntPtr zitaRevObject);
}
