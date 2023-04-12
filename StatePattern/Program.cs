using StatePattern;
using System.Threading;
State button = new VolumePressduringMusic();


button.PressUpVolume();
button.PressDownVolume();

Thread.Sleep(1000);
Console.WriteLine("...");
Thread.Sleep(1000);
Console.WriteLine("...");
Thread.Sleep(1000);
Console.WriteLine("...");

button = new VolumeButtonduringCamera();

button.PressUpVolume();
button.PressDownVolume();
