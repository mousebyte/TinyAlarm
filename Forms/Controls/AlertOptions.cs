using System;
using System.Drawing;
using System.Windows.Forms;

namespace MouseNet.TinyAlarm.Forms.Controls
{
    public partial class AlertOptions : UserControl, IAlertConfig
    {
        public AlertOptions()
            {
            InitializeComponent();
            }

        public ISoundConfig Sound {
            get => _cSoundConfig;
            set => value.CopyByInterface(_cSoundConfig);
        }

        public IMessageConfig Message { get; set; }
    }

    public interface IAlertConfig
    {
        ISoundConfig Sound { get; set; }
        IMessageConfig Message { get; set; }
    }

    public enum AlertMessageType
    {
        Dialog,
        Balloon,
        Notification
    }

    public enum AnimationStyle
    {
        SlideUp,
        SlideLeft
    }

    public enum AnimationSpeed
    {
        Slow,
        Fast,
        VeryFast
    }

    [InterfaceCopyable]
    public interface IMessageConfig
    {
        bool ShowMessage { get; set; }
        AlertMessageType MessageType { get; set; }
        IMessageWindowConfig Window { get; set; }
    }

    public interface IMessageOptionsView
    {
        event EventHandler ConfigureClicked;
    }

    [InterfaceCopyable]
    public interface IMessageWindowConfig
    {
        bool IsModal { get; set; }
        bool IsSticky { get; set; }
        Size WindowSize { get; set; }
        int Duration { get; set; }
        IMessageAppearanceConfig Appearance { get; set; }
        IAnimationConfig Animation { get; set; }
    }

    [InterfaceCopyable]
    public interface IMessageAppearanceConfig
    {
        string MessageTitle { get; set; }
        string MessageText { get; set; }
        Font TitleFont { get; set; }
        Font TextFont { get; set; }
        Color BackgroundColor { get; set; }
        double Opacity { get; set; }
    }

    [InterfaceCopyable]
    public interface IAnimationConfig
    {
        AnimationStyle Style { get; set; }
        AnimationSpeed Speed { get; set; }
        bool FadeIn { get; set; }
    }

    public interface IView<TConfig>
    {
        TConfig Config { get; set; }
    }

    public class Config<TValue>
        where TValue : class
    {
        public TValue Value { get; set; }

        public void CopyTo<TView>
            (TView view)
            where TView : IView<TValue>
            {
            view.Config = Value;
            }
    }

    public interface IViewPresenter<out TView, in TConfig>
    {
        TView View { get; }

        void Present
            (TConfig config);
    }

    public class ViewPresenter<TView, TConfig>
        where TConfig : class
        where TView : IView<TConfig>
    {
        public void Configure<T>
            (T config)
            where T : Config<TConfig> { }
    }
}