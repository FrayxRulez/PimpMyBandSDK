Introduction
============
PimpMyBand SDK is a library for _Windows Phone_ (Silverlight 8.1) that let you change Microsoft Band wallpaper through **_Pimp my Band_** application.

How to
======

* Make sure your image is `310x102` and has **no** transparency.
* Check if Band is connected to the phone using `PimpMyBand.BandManager.IsConnectedAsync()`.
* Call `PimpMyBand.BandManager.SetWallpaperAsync(WriteableBitmap, Color)` to launch **_Pimp my Band_**.
* That's all!

Install
=======
You can install the library via [NuGet]:

Install-Package [PimpMyBand]
------------------------------

[NuGet]:http://nuget.org/
[PimpMyBand]:http://nuget.org/packages/PimpMyBand
