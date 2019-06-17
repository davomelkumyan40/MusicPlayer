using System;
using Un4seen.Bass;

namespace Player_Core
{
    public static class BassCore
    {
        //description hertz
        private static readonly int hz = 44100;

        public static bool InitDefaultDevice { get; set; }
        public static int Stream { get; set; }
        public static int Volume { get; set; } = 50;

        public static bool InitBass(int hz)
        {
            if (!BassCore.InitDefaultDevice)
            {
                BassCore.InitDefaultDevice = Bass.BASS_Init(-1, hz, BASSInit.BASS_DEVICE_DEFAULT, IntPtr.Zero);
            }
            return BassCore.InitDefaultDevice;
        }

        public static void Play(string fileName, int volume)
        {
            BassCore.Stop();
            if (InitBass(hz))
            {
                BassCore.Stream = Bass.BASS_StreamCreateFile(fileName, 0, 0, BASSFlag.BASS_DEFAULT);
                if (BassCore.Stream != 0)
                {
                    BassCore.Volume = volume;
                    Bass.BASS_ChannelSetAttribute(Stream, BASSAttribute.BASS_ATTRIB_VOL, volume / 100f);
                    Bass.BASS_ChannelPlay(BassCore.Stream, false);
                }
            }
        }

        public static void Continue(int stream)
        {
            Bass.BASS_ChannelPlay(BassCore.Stream, false);
        }

        public static void Stop()
        {
            try
            {
                Bass.BASS_ChannelStop(Stream);
                Bass.BASS_StreamFree(Stream);
            }
            catch {}
        }

        public static void Pause()
        {
            Bass.BASS_ChannelPause(Stream);
        }

        public static void SetVolumeToStream(int stream, int volume)
        {
            BassCore.Volume = volume;
            Bass.BASS_ChannelSetAttribute(stream, BASSAttribute.BASS_ATTRIB_VOL, volume / 100f);
        }

        //get length as seconds
        public static int GetLengthOfStream(int stream)
        {
            long length = Bass.BASS_ChannelGetLength(stream);
            double secondsLength = Bass.BASS_ChannelBytes2Seconds(stream, length);
            return (int)secondsLength;
        }

        public static int GetStreamPosition(int stream)
        {
            long position = Bass.BASS_ChannelGetPosition(stream);
            double secondsPosition = Bass.BASS_ChannelBytes2Seconds(stream, position);
            return (int)secondsPosition;
        }

        public static void SetChannelPosition(int stream, int positionS)
        {
            Bass.BASS_ChannelSetPosition(stream, (double)positionS);
        }
    }
}
