using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Devkit.Interfaces;

namespace UniverseEmulator.Devkit.RemoteSensorSuite
{
    public class RemoteSensorSuite
        :IPlugin
    {
        private SensorDevice _device;

        public void Action(string name)
        {
        }

        public void Load(IWorkspace workspace)
        {
            _device = new SensorDevice();
            workspace.RuntimeManager.System.HardwareController.RegisterHardwareDevice(_device);
        }

        public void Unload(IWorkspace workspace)
        {
            workspace.RuntimeManager.System.HardwareController.UnregisterHardwareDevice(_device);
        }

        public Guid Guid
        {
            get{ return new Guid("8bfa5552-9f68-4112-940f-0a61d708bdc1"); }
        
        }
        public string Name
        {
            get { return "Remote Sensor Suite"; }
        }
        public string Description
        {
            get { return "Peripheral: Remote Sensor Suite"; }
        }
        public string Author
        {
            get { return "Martin Evans AKA Nyarlathothep"; }
        }
        public string Version
        {
            get { return "0.0.1"; }
        }

        public string Url { get; private set; }
        public IEnumerable<string> ActionNames { get; private set; }
    }
}
