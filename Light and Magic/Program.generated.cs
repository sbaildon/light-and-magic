//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.33440
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Light_and_Magic {
    using Gadgeteer;
    using GTM = Gadgeteer.Modules;
    
    
    public partial class Program : Gadgeteer.Program {
        
        /// <summary>The SDCard module using socket 5 of the mainboard.</summary>
        private Gadgeteer.Modules.GHIElectronics.SDCard sdCard;
        
        /// <summary>The Button module using socket 4 of the mainboard.</summary>
        private Gadgeteer.Modules.GHIElectronics.Button button;
        
        /// <summary>The LightSensor module using socket 9 of the mainboard.</summary>
        private Gadgeteer.Modules.GHIElectronics.LightSensor lightSensor;
        
        /// <summary>The ColorSense module using socket 10 of the mainboard.</summary>
        private Gadgeteer.Modules.GHIElectronics.ColorSense colorSense;
        
        /// <summary>The Camera (Premium) module using socket 3 of the mainboard.</summary>
        private Gadgeteer.Modules.GHIElectronics.Camera camera;
        
        /// <summary>The Display TE35 module using sockets 14, 13 and 12 of the mainboard.</summary>
        private Gadgeteer.Modules.GHIElectronics.Display_TE35 display;
        
        /// <summary>This property provides access to the Mainboard API. This is normally not necessary for an end user program.</summary>
        protected new static GHIElectronics.Gadgeteer.FEZSpider Mainboard {
            get {
                return ((GHIElectronics.Gadgeteer.FEZSpider)(Gadgeteer.Program.Mainboard));
            }
            set {
                Gadgeteer.Program.Mainboard = value;
            }
        }
        
        /// <summary>This method runs automatically when the device is powered, and calls ProgramStarted.</summary>
        public static void Main() {
            // Important to initialize the Mainboard first
            Program.Mainboard = new GHIElectronics.Gadgeteer.FEZSpider();
            Program p = new Program();
            p.InitializeModules();
            p.ProgramStarted();
            // Starts Dispatcher
            p.Run();
        }
        
        private void InitializeModules() {
            this.sdCard = new GTM.GHIElectronics.SDCard(5);
            this.button = new GTM.GHIElectronics.Button(4);
            this.lightSensor = new GTM.GHIElectronics.LightSensor(9);
            this.colorSense = new GTM.GHIElectronics.ColorSense(10);
            this.camera = new GTM.GHIElectronics.Camera(3);
            this.display = new GTM.GHIElectronics.Display_TE35(14, 13, 12, Socket.Unused);
        }
    }
}
