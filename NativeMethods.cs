using System;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;

// ReSharper disable FieldCanBeMadeReadOnly.Global
// ReSharper disable MemberCanBePrivate.Global
namespace MouseNet.TinyAlarm
{
    public struct Rect
    {
        public int Left;
        public int Top;
        public int Right;
        public int Bottom;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct Scrollbarinfo
    {
        public int cbSize;
        public Rect rcScrollBar;
        public int dxyLineButton;
        public int xyThumbTop;
        public int xyThumbBottom;
        public int reserved;

        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 6)]
        public uint[] rgstate;
    }

    internal static class NativeMethods
    {
        public const uint HScroll = 0xFFFFFFFA;
        public const uint VScroll = 0xFFFFFFFB;
        public const uint Client = 0xFFFFFFFC;

        [DllImport("user32.dll",
            SetLastError = true,
            EntryPoint = "GetScrollBarInfo")]
        public static extern int GetScrollBarInfo
            (IntPtr hWnd,
             uint idObject,
             ref Scrollbarinfo psbi);
    }

    internal static class Extensions
    {
        /// <exclude/>
        /// Internal implementation of IsScrollVisible.
        private static bool IsScrollVisible
            (IWin32Window c,
             uint id)
            {
            var sinfo = new Scrollbarinfo();
            sinfo.cbSize = Marshal.SizeOf(sinfo);
            if (NativeMethods.GetScrollBarInfo(
                    c.Handle,
                    id,
                    ref sinfo)
             == 0) return false;
            return (sinfo.rgstate[0] & 0x00008000) != 0x00008000;
            }

        /// <summary>
        /// Gets a value indicating whether the vertical scroll
        /// bar is shown in the given window.
        /// </summary>
        /// <param name="w">The window.</param>
        /// <returns>True if the vertical scroll bar is visible,
        /// otherwise, false.</returns>
        public static bool IsVerticalScrollVisible
            (this IWin32Window w)
            {
            return IsScrollVisible(w, NativeMethods.VScroll);
            }

        /// <summary>
        /// Gets a value indicating whether the horizontal scroll
        /// bar is shown in the given window.
        /// </summary>
        /// <param name="w">The window.</param>
        /// <returns>True if the horizontal scroll bar is visible,
        /// otherwise, false.</returns>
        public static bool IsHorizontalScrollVisible
            (this IWin32Window w)
            {
            return IsScrollVisible(w, NativeMethods.HScroll);
            }

        /// <summary>
        /// Copies properties exposed by the given interface from
        /// one object to another.
        /// </summary>
        /// <typeparam name="TInterface">The interface that defines
        /// the values to copy.</typeparam>
        /// <param name="source">The source object.</param>
        /// <param name="destination">The destination object.</param>
        public static void CopyByInterface<TInterface>
            (this TInterface source,
             TInterface destination)
            where TInterface : class
            {
            CopyByInterface(source, destination, typeof(TInterface));
            }

        /// <summary>
        /// Copies properties exposed by the given interface from one
        /// object to another.
        /// </summary>
        /// <param name="source">The source object.</param>
        /// <param name="destination">The destination object.</param>
        /// <param name="interfaceType">The interface that defines
        /// the values to copy.</param>
        public static void CopyByInterface
            (this object source,
             object destination,
             Type interfaceType)
            {
            if (!interfaceType.IsInterface
              | interfaceType.CustomAttributes.All(
                    a => a.AttributeType
                      != typeof(
                             InterfaceCopyableAttribute
                         )))
                throw new ArgumentException(
                    "Invalid type specified.");
            if (source.GetType().IsValueType
              | destination.GetType().IsValueType)
                throw new ArgumentException(
                    "Object cannot be a value type.");
            foreach (var prop in interfaceType.GetProperties())
                    prop.SetValue(destination, prop.GetValue(source));
            }
    }
}