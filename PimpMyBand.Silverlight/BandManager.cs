using System;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using Windows.Devices.Bluetooth.Rfcomm;
using Windows.Devices.Enumeration;
using Windows.Storage;
using Windows.System;

namespace PimpMyBand
{
    public static class BandManager
    {
        public static async Task<bool> IsBandConnectedAsync()
        {
            try
            {
                var devices = await DeviceInformation.FindAllAsync(RfcommDeviceService.GetDeviceSelector(RfcommServiceId.FromUuid(Guid.Parse("A502CA97-2BA5-413C-A4E0-13804E47B38F"))));
                if (devices.Count > 0)
                {
                    return true;
                }
            }
            catch { }

            return false;
        }

        public static async Task SetWallpaperAsync(WriteableBitmap image, Color accent)
        {
            if (image.PixelWidth != 310 || image.PixelHeight != 102)
            {
                throw new ArgumentOutOfRangeException("image", "Image size must be 310x102");
            }

            var folder = await ApplicationData.Current.LocalFolder.CreateFolderAsync("PimpMyBand", CreationCollisionOption.ReplaceExisting);
            var fileName = string.Format("{0:X2}{1:X2}{2:X2}.pmb", accent.R, accent.G, accent.B);
            var file = await folder.CreateFileAsync(fileName, CreationCollisionOption.ReplaceExisting);
            var stream = await file.OpenStreamForWriteAsync();

            image.SaveJpeg(stream, 310, 102, 0, 100);
            stream.Dispose();

            await Launcher.LaunchFileAsync(file);
        }
    }
}
