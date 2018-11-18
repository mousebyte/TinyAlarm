using System;
using System.Windows.Forms;
using NAudio.Wave;

namespace MouseNet.TinyAlarm.Forms.Controls
{
    public partial class SoundOptions : UserControl, ISoundConfig
    {
        private string _soundFileName;

        private readonly DirectSoundOut _soundOut =
            new DirectSoundOut();

        private AudioFileReader _audioReader;

        public SoundOptions()
            {
            InitializeComponent();
            _soundOut.PlaybackStopped += OnPlaybackStopped;
            }

        public bool PlaySound {
            get => _cPlaySound.Checked;
            set => _cPlaySound.Checked = value;
        }

        public string SoundFileName {
            get => _soundFileName;
            set {
                _soundFileName = value;
                _cFileName.Text = value;
            }
        }

        public float Volume {
            get => _cVolume.Value / 100f;
            set => _cVolume.Value = (int) (value * 100);
        }

        public bool Loop {
            get => _cLoop.Checked;
            set => _cLoop.Checked = value;
        }

        private void StopPlaying()
            {
            if (_soundOut.PlaybackState != PlaybackState.Stopped)
                _soundOut.Stop();
            _audioReader.Dispose();
            _cTestStopBtn.Text = @"Test";
            }

        private void StartPlaying()
            {
            if (_soundOut.PlaybackState == PlaybackState.Playing)
                StopPlaying();
            _audioReader = new AudioFileReader(SoundFileName);
            _soundOut.Init(_audioReader);
            _audioReader.Volume = Volume;
            _soundOut.Play();
            _cTestStopBtn.Text = @"Stop";
            }

        private void OnPlaybackStopped
            (object sender,
             EventArgs e)
            {
            if (Loop) StartPlaying();
            else StopPlaying();
            }

        private void OnPlaySoundCheckedChanged
            (object sender,
             EventArgs e)
            {
            _cFileName.Enabled = PlaySound;
            _cBrowseBtn.Enabled = PlaySound;
            _lblVolume.Enabled = PlaySound;
            _cVolume.Enabled = PlaySound;
            _cLoop.Enabled = PlaySound;
            _cTestStopBtn.Enabled = PlaySound;
            }

        private void OnBrowseClicked
            (object sender,
             EventArgs e)
            {
            _cOpenSoundDialog.FileName = SoundFileName;
            if (_cOpenSoundDialog.ShowDialog(this) == DialogResult.OK)
                SoundFileName = _cOpenSoundDialog.FileName;
            }

        private void OnVolumeChanged
            (object sender,
             EventArgs e)
            {
            if (_soundOut.PlaybackState == PlaybackState.Playing)
                _audioReader.Volume = Volume;
            }

        private void OnTestStopClicked
            (object sender,
             EventArgs e)
            {
            if (_soundOut.PlaybackState == PlaybackState.Playing)
                StopPlaying();
            else StartPlaying();
            }

        ~SoundOptions()
            {
            if (_soundOut.PlaybackState == PlaybackState.Playing)
                StopPlaying();
            _soundOut.Dispose();
            }
    }
}