Introduction
============
PimpMyBand SDK is a library for _Windows Phone_ (Silverlight 8.1) that let you change Microsoft Band wallpaper through **_Pimp my Band_** application.

How to
======

* Make sure your image is `310x102` and has **no** transparency.
* Check if Band is connected to the phone using `PimpMyBand.BandManager.IsConnectedAsync()`.
* Call `PimpMyBand.BandManager.SetWallpaperAsync(WriteableBitmap, Color)` to launch **_Pimp my Band_**.
* That's all!

Sample
======

```csharp
var isConnected = await PimpMyBand.BandManager.IsConnectedAsync();
if (isConnected)
{
  if (MessageBox.Show("Hey, seems that you have a Band! Do you want to set our wallpaper?", "MyApp", MessageBoxButton.OKCancel) == MessageBoxResult.OK)
  {
    var bitmap = LoadYourBitmap();
    var accent = LoadYourColor();
    await PimpMyBand.BandManager.SetWallpaper(bitmap, accent);
  }
}
```

Install
=======
You can install the library via [NuGet]:

Install-Package [PimpMyBand]
------------------------------

[NuGet]:http://nuget.org/
[PimpMyBand]:http://nuget.org/packages/PimpMyBand
