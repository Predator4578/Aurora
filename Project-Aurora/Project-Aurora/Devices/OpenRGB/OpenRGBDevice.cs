using Aurora.Settings;
using OpenRGB.NET;
using OpenRGB.NET.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using DK = Aurora.Devices.DeviceKeys;
using OpenRGBColor = OpenRGB.NET.Models.Color;
using OpenRGBDevice = OpenRGB.NET.Models.Device;
using OpenRGBDeviceType = OpenRGB.NET.Enums.DeviceType;
using OpenRGBZoneType = OpenRGB.NET.Enums.ZoneType;

namespace Aurora.Devices.OpenRGB
{
    public class OpenRGBAuroraDevice : DefaultDevice
    {
        public override string DeviceName => "OpenRGB";
        protected override string DeviceInfo => string.Join(", ", _devices.Select(d => d.Name));

        private OpenRGBClient _openRgb;
        private OpenRGBDevice[] _devices;
        private OpenRGBColor[][] _deviceColors;
        private List<DK>[] _keyMappings;

        public override bool Initialize()
        {
            if (IsInitialized)
                return true;

            try
            {
                _openRgb = new OpenRGBClient(name: "Aurora");
                _openRgb.Connect();

                _devices = _openRgb.GetAllControllerData();

                _deviceColors = new OpenRGBColor[_devices.Length][];
                _keyMappings = new List<DK>[_devices.Length];

                int ramIndex = 0;                                           // INDEX for RAM DEVICE Count
                int ledLightIndex = 0;                                      // INDEX for LEDLIGHT DEVICE Count

                for (var i = 0; i < _devices.Length; i++)
                {
                    var dev = _devices[i];

                    _deviceColors[i] = new OpenRGBColor[dev.Leds.Length];
                    for (var ledIdx = 0; ledIdx < dev.Leds.Length; ledIdx++)
                        _deviceColors[i][ledIdx] = new OpenRGBColor();

                    _keyMappings[i] = new List<DK>();
                        //  Method for Single Logo Lights
                    for (int j = 0; j < dev.Leds.Length; j++)
                    {
                        //  Method for Motherboard Logo Lights (Type 0)
                        if (dev.Type == OpenRGBDeviceType.Motherboard)
                        {
                            if (OpenRGBKeyNames.MOBO_LOGO.TryGetValue(dev.Leds[j].Name, out var dk))
                            {
                                _keyMappings[i].Add(dk);
                            }
                            else
                            {
                                _keyMappings[i].Add(DK.MOBO_LOGO);
                            }
                        }
                        //  Method for DRAM Logo Lights (Type 1)
                        if (dev.Type == OpenRGBDeviceType.Dram)
                        {
                            if (OpenRGBKeyNames.DRAM_LOGO.TryGetValue(dev.Leds[j].Name, out var dk))
                            {
                                _keyMappings[i].Add(dk);
                            }
                            else
                            {
                                _keyMappings[i].Add(DK.DRAM_LOGO); // DK.DRAM_LOGO
                            }
                        }
                        //  Method for GPU Logo Lights (Type 2)
                        if (dev.Type == OpenRGBDeviceType.Gpu)
                        {
                            if (OpenRGBKeyNames.GPU_LOGO.TryGetValue(dev.Leds[j].Name, out var dk))
                            {
                                _keyMappings[i].Add(dk);
                            }
                            else
                            {
                                _keyMappings[i].Add(DK.GPULIGHT1);
                                _keyMappings[i].Add(DK.GPULIGHT2);
                                _keyMappings[i].Add(DK.GPULIGHT3);
                                _keyMappings[i].Add(DK.GPULIGHT4);
                                _keyMappings[i].Add(DK.GPULIGHT5);
                                _keyMappings[i].Add(DK.GPU_LOGO); // DK.GPU_LOGO - Done
                            }
                        }
                        //  Method for Cooler Logo Lights (Type 3)
                        else if (dev.Type == OpenRGBDeviceType.Cooler)
                        {
                            if (OpenRGBKeyNames.COOLER_LOGO.TryGetValue(dev.Leds[j].Name, out var dk))
                            {
                                _keyMappings[i].Add(dk);
                            }
                            else
                            {
                                _keyMappings[i].Add(DK.COOLER_LOGO);
                            }
                        }
                        //  Method for Ledstrip Logo Lights (Type 4)
                        else if (dev.Type == OpenRGBDeviceType.Ledstrip)
                        {
                            if (OpenRGBKeyNames.LEDSTRIP_LOGO.TryGetValue(dev.Leds[j].Name, out var dk))
                            {
                                _keyMappings[i].Add(dk);
                            }
                            else
                            {
                                _keyMappings[i].Add(DK.LED_LOGO);
                            }
                        }
                        //  Method for Keyboards (Type 5)
                        else if (dev.Type == OpenRGBDeviceType.Keyboard)
                        {
                            if (OpenRGBKeyNames.Keyboard.TryGetValue(dev.Leds[j].Name, out var dk))
                            {
                                _keyMappings[i].Add(dk);
                            }
                            else
                            {
                                _keyMappings[i].Add(DK.Peripheral_Logo);
                            }
                        }
                        //  Method for Mouse (Type 6)
                        else if (dev.Type == OpenRGBDeviceType.Mouse)
                        {
                            if (OpenRGBKeyNames.Mouse.TryGetValue(dev.Leds[j].Name, out var dk))
                            {
                                _keyMappings[i].Add(dk);
                            }
                            else
                            {
                                _keyMappings[i].Add(DK.MOUSELIGHT11);
                                _keyMappings[i].Add(DK.MOUSELIGHT12);
                                _keyMappings[i].Add(DK.MOUSELIGHT13);
                                _keyMappings[i].Add(DK.MOUSELIGHT14);
                                _keyMappings[i].Add(DK.MOUSELIGHT15);
                                _keyMappings[i].Add(DK.Peripheral_Logo);
                            }
                        }
                        //  Method for Mousemat Logo (Type 7)
                        else if (dev.Type == OpenRGBDeviceType.Mousemat)
                        {
                            if (OpenRGBKeyNames.MOUSEMAT_LOGO.TryGetValue(dev.Leds[j].Name, out var dk))
                            {
                                _keyMappings[i].Add(dk);
                            }
                            else
                            {
                                _keyMappings[i].Add(DK.MOUSEPAD_LOGO);
                            }
                        }
                        //  Method for Head Set Logo (Type 8)
                        else if (dev.Type == OpenRGBDeviceType.Headset)
                        {
                            if (OpenRGBKeyNames.HEADSET_LOGO.TryGetValue(dev.Leds[j].Name, out var dk))
                            {
                                _keyMappings[i].Add(dk);
                            }
                            else
                            {
                                _keyMappings[i].Add(DK.HEADSET_LOGO);
                            }
                        }
                        //  Method for Head Set Stand Logo (Type 9)
                        else if (dev.Type == OpenRGBDeviceType.HeadsetStand)
                        {
                            if (OpenRGBKeyNames.HEADSETSTAND_LOGO.TryGetValue(dev.Leds[j].Name, out var dk))
                            {
                                _keyMappings[i].Add(dk);
                            }
                            else
                            {
                                _keyMappings[i].Add(DK.HEADSETSTAND_LOGO);
                            }
                        }
                        //  Method for Gamepad Logo Lights (Type 10)
                        else if (dev.Type == OpenRGBDeviceType.Gamepad)
                        {
                            if (OpenRGBKeyNames.GAMEPAD_LOGO.TryGetValue(dev.Leds[j].Name, out var dk))
                            {
                                _keyMappings[i].Add(dk);
                            }
                            else
                            {
                                _keyMappings[i].Add(DK.GAMEPAD_LOGO);
                            }
                        }
                        //  Method for LIGHT Logo Lights (Type 11)
                        else if (dev.Type == OpenRGBDeviceType.Light)
                        {
                            if (OpenRGBKeyNames.LIGHT_LOGO.TryGetValue(dev.Leds[j].Name, out var dk))
                            {
                                _keyMappings[i].Add(dk);
                            }
                            else
                            {
                                _keyMappings[i].Add(DK.HUELIGHT1);
                                _keyMappings[i].Add(DK.HUELIGHT2);
                                _keyMappings[i].Add(DK.HUELIGHT3);
                                _keyMappings[i].Add(DK.HUELIGHT4);
                                _keyMappings[i].Add(DK.HUELIGHT5);
                                _keyMappings[i].Add(DK.HUE_LOGO);
                            }
                        }
                        //  Method for All other Single Logo Lights (Type 0?)
                        else
                        {
                            _keyMappings[i].Add(DK.Peripheral_Logo);
                        }
                    }

                    //  Method for LINEAR LIGHT STRIPS 

                    uint LedOffset = 0;
                    for (int j = 0; j < dev.Zones.Length; j++)
                    {
                        if (dev.Zones[j].Type == OpenRGBZoneType.Linear)
                        {
                            for (int k = 0; k < dev.Zones[j].LedCount; k++)
                            {
                                //  Method for Motherboards with up to 5 LEDs (Type 0)
                                if (dev.Type == OpenRGBDeviceType.Motherboard)
                                {
                                    if (k < 5)
                                    {
                                        _keyMappings[i][(int)(LedOffset + k)] = OpenRGBKeyNames.MOBO_LIGHTS[k];
                                    }
                                }
                                else
                                //  Method for RAM Modules with 5 LEDs (Type 1)
                                //  Supporting a Maximum of 8 Dimms with 25 Leds each when fully written down (WIP)
                                if (dev.Type == OpenRGBDeviceType.Dram)
                                {
                                    if (k < 25)
                                    {
                                        _keyMappings[i][(int)(LedOffset + k)] = OpenRGBKeyNames.All_RAM_LIGHTS[ramIndex][k];
                                    }
                                }
                                else
                                //  Method for GPUs with 20 LEDs (Type 2)
                                if (dev.Type == OpenRGBDeviceType.Gpu)
                                {
                                    if (k < 20)
                                    {
                                        _keyMappings[i][(int)(LedOffset + k)] = OpenRGBKeyNames.GPU_LIGHTS[k];
                                    }
                                }
                                else
                                //  Method for Coolers with up to 8 LEDs (Type 3)
                                if (dev.Type == OpenRGBDeviceType.Cooler)
                                {
                                    if (k < 8)
                                    {
                                        _keyMappings[i][(int)(LedOffset + k)] = OpenRGBKeyNames.COOLER_LIGHTS[k];
                                    }
                                }
                                else
                                //  Method for Ledstrips (Type 4)
                                //  up to 3 Devices, Channel Layout 2,2,4 channels per device, up to 200 LED Lights per channel
                                if (dev.Type == OpenRGBDeviceType.Ledstrip)
                                {
                                    if (k < 200)
                                    {
                                        _keyMappings[i][(int)(LedOffset + k)] = OpenRGBKeyNames.ALL_LED_LIGHTS[ledLightIndex][j][k];
                                    }
                                }
                                else
                                //  Method for Keyboard with up to 40 LEDs (Type 5)
                                if (dev.Type == OpenRGBDeviceType.Keyboard)
                                {
                                    if (k < 40)
                                    {
                                        _keyMappings[i][(int)(LedOffset + k)] = OpenRGBKeyNames.ADDITIONAL_LIGHTS[k];
                                    }
                                }
                                else
//                               //  Method for Mouses with up to 20 LEDs (Type 6)
//                               if (dev.Type == OpenRGBDeviceType.Mouse)
//                               {
//                                   if (k < 20)
//                                   {
//                                       _keyMappings[i][(int)(LedOffset + k)] = OpenRGBKeyNames.ALL_MOUSE_LIGHTS[mouseIndex][j][k];
//                                   }
//                                }
                                //  Method for Mouses with up to 20 LEDs (Type 6)
                                if (dev.Type == OpenRGBDeviceType.Mouse)
                                {
                                    if (k < 10)
                                    {
                                        _keyMappings[i][(int)(LedOffset + k)] = OpenRGBKeyNames.ALL_MOUSE_LIGHTS[j][k];
                                    }
                                }
                                else
                                //  Method for Mousepads with up to 20 LEDs (Type 7)
                                if (dev.Type == OpenRGBDeviceType.Mousemat)
                                {
                                    if (k < 20)
                                    {
                                        _keyMappings[i][(int)(LedOffset + k)] = OpenRGBKeyNames.MOUSEPAD_LIGHTS[k];
                                    }
                                }
                                else
                                //  Method for Headsets with up to 20 LEDs (Type 8)
                                if (dev.Type == OpenRGBDeviceType.Headset)
                                {
                                    if (k < 20)
                                    {
                                        _keyMappings[i][(int)(LedOffset + k)] = OpenRGBKeyNames.HEADSET_LIGHTS[k];
                                    }
                                }
                                else
                                //  Method for HeadsetStands with up to 20 LEDs (Type 9)
                                if (dev.Type == OpenRGBDeviceType.HeadsetStand)
                                {
                                    if (k < 20)
                                    {
                                        _keyMappings[i][(int)(LedOffset + k)] = OpenRGBKeyNames.HEADSETSTAND_LIGHTS[k];
                                    }
                                }
                                else
                                //  Method for Gamepads with up to 20 LEDs (Type 10)
                                if (dev.Type == OpenRGBDeviceType.Gamepad)
                                {
                                    if (k < 20)
                                    {
                                        _keyMappings[i][(int)(LedOffset + k)] = OpenRGBKeyNames.GAMEPAD_LIGHTS[k];
                                    }
                                }
                                else
                                //  Method for LIGHTs with up to 20 LEDs (Type 11)
                                if (dev.Type == OpenRGBDeviceType.Light)
                                {
                                    if (k < 20)
                                    {
                                        _keyMappings[i][(int)(LedOffset + k)] = OpenRGBKeyNames.HUE_LIGHTS[k];
                                    }
                                }
                                else
                                //  Method for Unknown Peripherals (Type 0)
                                if (dev.Type == OpenRGBDeviceType.Unknown)
                                {
                                    if (k < 20)
                                    {
                                        _keyMappings[i][(int)(LedOffset + k)] = OpenRGBKeyNames.PERIPHERAL_LIGHTS[k];
                                    }
                                }
                                else
                                //  Method for all other devices up to 40 Additional Lights
                                {
                                    if (k < 40)
                                    {
                                        _keyMappings[i][(int)(LedOffset + k)] = OpenRGBKeyNames.ADDITIONAL_LIGHTS[k];
                                    }
                                }
                            }
                        }
                        LedOffset += dev.Zones[j].LedCount;
                    }
                    //CREATING DEVICE COUNTERS
                    if (dev.Type == OpenRGBDeviceType.Dram) //(Type 1)
                    {
                        ramIndex++;
                    }
                    else
                    if (dev.Type == OpenRGBDeviceType.Ledstrip) //(Type 4)
                    {
                        ledLightIndex++;
                    }
                    
                }
            }
            catch (Exception e)
            {
                LogError("error in OpenRGB device: " + e);
                IsInitialized = false;
                return false;
            }

            IsInitialized = true;
            return IsInitialized;
        }

        public override void Shutdown()
        {
            if (!IsInitialized)
                return;

            for (var i = 0; i < _devices.Length; i++)
            {
                try
                {
                    _openRgb.UpdateLeds(i, _devices[i].Colors);
                }
                catch
                {
                    //we tried.
                }
            }

            _openRgb?.Dispose();
            _openRgb = null;
            IsInitialized = false;
        }

        public override bool UpdateDevice(Dictionary<DK, Color> keyColors, DoWorkEventArgs e, bool forced = false)
        {
            if (!IsInitialized)
                return false;

            for (var i = 0; i < _devices.Length; i++)
            {
                //should probably store these bools somewhere when initing
                //might also add this as a property in the library
                if (!_devices[i].Modes.Any(m => m.Name == "Direct"))
                    continue;

                for (int ledIdx = 0; ledIdx < _devices[i].Leds.Length; ledIdx++)
                {
                    if (keyColors.TryGetValue(_keyMappings[i][ledIdx], out var keyColor))
                    {
                        _deviceColors[i][ledIdx] = new OpenRGBColor(keyColor.R, keyColor.G, keyColor.B);
                    }
                }

                try
                {
                    _openRgb.UpdateLeds(i, _deviceColors[i]);
                }
                catch (Exception exc)
                {
                    LogError($"Failed to update OpenRGB device {_devices[i].Name}: " + exc);
                    Reset();
                }
            }

            var sleep = Global.Configuration.VarRegistry.GetVariable<int>($"{DeviceName}_sleep");
            if (sleep > 0)
                Thread.Sleep(sleep);

            return true;
        }

        protected override void RegisterVariables(VariableRegistry variableRegistry)
        {
            variableRegistry.Register($"{DeviceName}_sleep", 25, "Sleep for", 1000, 0);
        }
    }
}