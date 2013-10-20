using System;
using System.Collections;
using System.Threading;
using Microsoft.SPOT;
using Microsoft.SPOT.Presentation;
using Microsoft.SPOT.Presentation.Controls;
using Microsoft.SPOT.Presentation.Media;
using Microsoft.SPOT.Presentation.Shapes;
using Microsoft.SPOT.Touch;

using Gadgeteer.Networking;
using GT = Gadgeteer;
using GTM = Gadgeteer.Modules;
using Gadgeteer.Modules.GHIElectronics;

namespace HelloTuneModule
{
    public partial class Program
    {
        // This method is run when the mainboard is powered up or reset.   
        void ProgramStarted()
        {
            // Use Debug.Print to show messages in Visual Studio's "Output" window during debugging.
            Debug.Print("Program Started");
            tunes.AddNote(new Tunes.MusicNote(new Tunes.Tone(440), 500 ));
            tunes.AddNote(new Tunes.MusicNote(Tunes.Tone.C4, 500));
            tunes.AddNote(new Tunes.MusicNote(Tunes.Tone.D4, 500));
            tunes.AddNote(new Tunes.MusicNote(Tunes.Tone.E4, 500));
            tunes.AddNote(new Tunes.MusicNote(Tunes.Tone.F4, 500));
            tunes.AddNote(new Tunes.MusicNote(Tunes.Tone.G4, 500));
            tunes.AddNote(new Tunes.MusicNote(Tunes.Tone.A4, 500));
            tunes.AddNote(new Tunes.MusicNote(Tunes.Tone.B4, 500));
            tunes.AddNote(new Tunes.MusicNote(Tunes.Tone.C5, 500));
            tunes.Play();
        }
    }
}
