using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Management;
using System.Windows.Forms;
using OpenHardwareMonitor.Hardware;

namespace ohm_arduino_gui
{
    public partial class MainForm : Form
    {
        private int _cpuCores = 0;
        private int _line1SwitchTimes = 1;
        private int _line2SwitchTimes = 1;
        private int _cpt = 1;
        private List<PortInfo> _ports = new List<PortInfo>();
        private readonly Computer _computer = new Computer();
        private readonly UpdaterVisitor _updater = new UpdaterVisitor();
        private readonly SensorVisitor _sensorVisitor;
        private readonly Dictionary<string, float> _sensorData = new Dictionary<string, float>();

        private class PortInfo
        {
            public string Name { get; set; }
            public string Caption { get; set; }
        }

        public MainForm()
        {
            _sensorVisitor = new SensorVisitor(ProcessSensor);

            InitializeComponent();
            if (Initialize())
            {
                mainTimer.Enabled = true;
                WindowState = FormWindowState.Minimized;
            }
        }

        private void Log(string message)
        {
            message = $"[{DateTime.Now:HH:mm:ss.fff}] {message}";
            logBox.AppendText(message);
            logBox.AppendText(Environment.NewLine);
            logBox.Select(logBox.Text.Length, 0);
            logBox.ScrollToCaret();
        }

        private void Log(Exception ex, string title)
        {
            Log($"Exception {title} ({ex.GetType().FullName}): {ex.Message}");
        }

        private bool Initialize()
        {
            try
            {
                _computer.Open();
                _computer.CPUEnabled = true;
                _computer.GPUEnabled = true;
                _computer.RAMEnabled = true;

                var portNames = SerialPort.GetPortNames();
                using (var searcher = new ManagementObjectSearcher
                    ("SELECT * FROM WIN32_SerialPort"))
                {
                    var ports = searcher.Get().Cast<ManagementBaseObject>().ToList();
                    _ports = (from portName in portNames
                        join port in ports on portName equals port["DeviceID"].ToString()
                        select new PortInfo
                        {
                            Name = portName,
                            Caption = port["Caption"].ToString()
                        }).ToList();
                }

                foreach (var port in _ports)
                {
                    comPortCombo.Items.Add($"{port.Caption}");
                }

                if (comPortCombo.Items.Count > 0)
                {
                    var index = _ports.FindIndex(p => p.Caption.ToLower().Contains("arduino"));
                    if (index < 0)
                    {
                        throw new Exception("No Arduino port is found");
                    }

                    comPortCombo.SelectedIndex = index;
                }
                else
                {
                   throw new Exception("No COM port available");
                }
                
                return true;
            }
            catch (Exception ex)
            {
                Log(ex, "initializing");
                return false;
            }
        }

        private void SendData(string data)
        {
            if (_ports.Count < 1 || comPortCombo.SelectedItem == null)
                return;

            try
            {
                var info = _ports[comPortCombo.SelectedIndex];
                var port = new SerialPort(info.Name);
                port.Open();
                port.Write(data);
                port.Close();

                Log("Sent data =>\n" + data);
            }
            catch (Exception ex)
            {
                Log(ex, "sending data");
            }
        }

        private string GetSensorData(string key)
        {
            string strSensorData =_sensorData.ContainsKey(key) ? _sensorData[key].ToString("###") : "NA";
            if(strSensorData == "")
            {
                strSensorData = "0";
            }
            return strSensorData;
        }
        private string setValueStrLenght(string value, int targetedLenght)
        {
            string strValue = value.ToString();
            int lenghtDiff = targetedLenght - strValue.Length;
            if (lenghtDiff > 0)
            {
                return strValue.PadLeft(targetedLenght, ' ');
            } else
            {
                return strValue;
            }
        }

        private void mainTimer_Tick(object sender, EventArgs e)
        {
            try
            {
                _sensorData.Clear();
                _computer.Traverse(_updater);
                _computer.Traverse(_sensorVisitor);

                float RAMTotal = _sensorData["ram_available"] + _sensorData["ram_used"];

                float totalClock = 0;

                for (int i = 1; i <= _cpuCores; i++)
                {
                    var cpuId = "cpu_" + i;
                    totalClock += float.Parse(GetSensorData(cpuId + "_clock"));
                }

                _sensorData["cpu_clock"] = totalClock / _cpuCores;

                bool line1CPUDisplay = false;
                bool line1CPUClockDisplay = false;
                bool line1GPUDisplay = false;
                bool line1GPUClockDisplay = false;
                bool line1RAMDisplay = false;

                List<string> line1ToDisplayList = new List<string>();

                if (line1CPU.Checked)
                {
                    line1ToDisplayList.Add("CPU");
                }
                if (line1CPUClock.Checked)
                {
                    line1ToDisplayList.Add("CPUClock");
                }
                if (line1GPU.Checked)
                {
                    line1ToDisplayList.Add("GPU");
                }
                if (line1GPUClock.Checked)
                {
                    line1ToDisplayList.Add("GPUClock");
                }
                if (line1RAM.Checked)
                {
                    line1ToDisplayList.Add("RAM");
                }

                string[] line1ToDisplay = line1ToDisplayList.ToArray();

                if (line1ToDisplay.Length > 0)
                {
                    if (_line1SwitchTimes > line1ToDisplay.Length)
                    {
                        _line1SwitchTimes = 1;
                    }

                    if (line1ToDisplay[_line1SwitchTimes - 1] == "CPU")
                    {
                        line1CPUDisplay = true;
                    }
                    else if (line1ToDisplay[_line1SwitchTimes - 1] == "CPUClock")
                    {
                        line1CPUClockDisplay = true;
                    }
                    else if (line1ToDisplay[_line1SwitchTimes - 1] == "GPU")
                    {
                        line1GPUDisplay = true;
                    }
                    else if (line1ToDisplay[_line1SwitchTimes - 1] == "GPUClock")
                    {
                        line1GPUClockDisplay = true;
                    }
                    else if (line1ToDisplay[_line1SwitchTimes - 1] == "RAM")
                    {
                        line1RAMDisplay = true;
                    }
                }


                bool line2CPUDisplay = false;
                bool line2CPUClockDisplay = false;
                bool line2GPUDisplay = false;
                bool line2GPUClockDisplay = false;
                bool line2RAMDisplay = false;

                List<string> line2ToDisplayList = new List<string>();

                if (line2CPU.Checked)
                {
                    line2ToDisplayList.Add("CPU");
                }
                if (line2CPUClock.Checked)
                {
                    line2ToDisplayList.Add("CPUClock");
                }
                if (line2GPU.Checked)
                {
                    line2ToDisplayList.Add("GPU");
                }
                if (line2GPUClock.Checked)
                {
                    line2ToDisplayList.Add("GPUClock");
                }
                if (line2RAM.Checked)
                {
                    line2ToDisplayList.Add("RAM");
                }

                string[] line2ToDisplay = line2ToDisplayList.ToArray();

                if (_line2SwitchTimes > line2ToDisplay.Length)
                {
                    _line2SwitchTimes = 1;
                }

                if (line2ToDisplay.Length > 0)
                {
                    if (line2ToDisplay[_line2SwitchTimes - 1] == "CPU")
                    {
                        line2CPUDisplay = true;
                    }
                    else if (line2ToDisplay[_line2SwitchTimes - 1] == "CPUClock")
                    {
                        line2CPUClockDisplay = true;
                    }
                    else if (line2ToDisplay[_line2SwitchTimes - 1] == "GPU")
                    {
                        line2GPUDisplay = true;
                    }
                    else if (line2ToDisplay[_line2SwitchTimes - 1] == "GPUClock")
                    {
                        line2GPUClockDisplay = true;
                    }
                    else if (line2ToDisplay[_line2SwitchTimes - 1] == "RAM")
                    {
                        line2RAMDisplay = true;
                    }
                }

                _cpt += 1;
                if (_cpt * mainTimer.Interval > int.Parse(comboBoxSwitchTimer.Text) * 1000)
                {
                    _line1SwitchTimes += 1;
                    _line2SwitchTimes += 1;
                    _cpt = 1;
                }

                var CPUDataString = "CPU " + setValueStrLenght(GetSensorData("cpu_temp"), 3) + "_C  " + setValueStrLenght(GetSensorData("cpu_load"), 3) + "% ";
                var CPUClockDataString = "CPU   " + setValueStrLenght(GetSensorData("cpu_clock"), 4) + " Mhz  ";
                var GPUDataString = "GPU " + setValueStrLenght(GetSensorData("gpu_temp"), 3) + "_C  " + setValueStrLenght(GetSensorData("gpu_load"), 3) + "% ";
                var GPUClockDataString = "GPU   " + setValueStrLenght(GetSensorData("gpu_clock"), 4) + " Mhz  ";
                var RAMDataString = "RAM  " + setValueStrLenght(GetSensorData("ram_load"), 3) + "% " + setValueStrLenght(GetSensorData("ram_used") + "/" + Math.Ceiling(RAMTotal), 5) + " ";


                //start data string
                var str = "";
                //Start monitoring lines
                if (line1CPUDisplay)
                {
                    str += CPUDataString;
                }
                else if (line1CPUClockDisplay)
                {
                    str += CPUClockDataString;
                }
                else if (line1GPUDisplay)
                {
                    str += GPUDataString;
                }
                else if (line1GPUClockDisplay)
                {
                    str += GPUClockDataString;
                }
                else if (line1RAMDisplay)
                {
                    str += RAMDataString;
                }
                else
                {
                    str += "  #   #  #   #  ";
                }
                str += "-";

                if (line2CPUDisplay)
                {
                    str += CPUDataString;
                }
                else if (line2CPUClockDisplay)
                {
                    str += CPUClockDataString;
                }
                else if (line2GPUDisplay)
                {
                    str += GPUDataString;
                }
                else if (line2GPUClockDisplay)
                {
                    str += GPUClockDataString;
                }
                else if (line2RAMDisplay)
                {
                    str += RAMDataString;
                }
                else
                {
                    str += "   #   ##   #   ";
                }

                str += (checkRainbow.Checked ? 1 : 0).ToString() + rNumeric.Value.ToString().PadLeft(3, '0') + gNumeric.Value.ToString().PadLeft(3, '0') + bNumeric.Value.ToString().PadLeft(3, '0') + brightnessNumeric.Value.ToString().PadLeft(3, '0');
                //End String

                SendData(str);

            }
            catch (Exception ex)
            {
                Log(ex, "updating sensor data");
            }
        }

        private void ProcessSensor(ISensor sensor)
        {
            if ((sensor.SensorType !=SensorType.Temperature && sensor.SensorType != SensorType.Clock && sensor.SensorType != SensorType.Load && sensor.SensorType != SensorType.Data) || !sensor.Value.HasValue)
                {
                return;
            }

            var value = sensor.Value.Value;

            if (sensor.Name.StartsWith("CPU Core #"))
            {
                if (Int32.TryParse(sensor.Name.Substring(10), out var id))
                {
                    switch (sensor.SensorType)
                    {
                        case SensorType.Temperature:
                            _sensorData["cpu_"+sensor.Name.Substring(10)+"_temp"] = value;
                            break;
                        case SensorType.Clock:
                            _sensorData["cpu_" + sensor.Name.Substring(10) + "_clock"] = value;
                            break;
                        case SensorType.Load:
                            _sensorData["cpu_" + sensor.Name.Substring(10) + "_Load"] = value;
                            break;
                    }
                    if (id > _cpuCores)
                    {
                        _cpuCores = id;
                    }
                }
                
                return;
            }

                switch (sensor.Name)
            {
                case "CPU Package":
                    switch (sensor.SensorType)
                    {
                        case SensorType.Temperature:
                        _sensorData["cpu_temp"] = value;
                        break;
                    }
                    break;
                case "CPU Total":
                    switch (sensor.SensorType)
                    {
                        case SensorType.Load:
                        _sensorData["cpu_load"] = value;
                        break;
                    }
                   break;
                case "GPU Core":
                    switch (sensor.SensorType)
                    {
                        case SensorType.Temperature:
                            _sensorData["gpu_temp"] = value;
                            break;
                        case SensorType.Clock:
                            _sensorData["gpu_clock"] = value;
                            break;
                        case SensorType.Load:
                            _sensorData["gpu_load"] = value;
                            break;
                    }
                    break;
                case "Memory":
                    if (sensor.SensorType == SensorType.Load)
                    {
                        _sensorData["ram_load"] = value;
                    }
                    break;
                case "Used Memory":
                    if (sensor.SensorType == SensorType.Data)
                    {
                        _sensorData["ram_used"] = value;
                    }
                    break;
                case "Available Memory":
                    if (sensor.SensorType == SensorType.Data)
                    {
                        _sensorData["ram_available"] = value;
                    }
                    break;
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            _computer.Close();
        }

        private void notifyIcon_DoubleClick(object sender, EventArgs e)
        {
            if (!Visible)
            {
                Show();
                WindowState = FormWindowState.Normal;
            }
        }

        private void MainForm_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            {
                Hide();
            }
        }

        private void MainForm_Shown(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            {
                Hide();
            }
        }

        private void githubLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/logchan/open-hardware-monitor-arduino");
        }

        private void githubLink_LinkClicked_MPR(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/theMartinpo/ohm-arduino-rgb");
        }

        private void showWindowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            {
                Show();
                WindowState = FormWindowState.Normal;
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void saveSettings(object sender, EventArgs e)
        {
            Properties.Settings.Default.Save();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

    }
}
