using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Management;

namespace GetUnknowDevice_WMI
{
    public partial class Form1 : Form
    {
        private Boolean _FindDevice=false;
        public Form1()
        {
            InitializeComponent();
        }

        private void detect_button_Click(object sender, EventArgs e)
        {
            FindDeviceWmi(false);
            _FindDevice = false;
        }
        ///  <summary>
        ///  Use the System.Management class to find a device by Vendor ID and Product ID using WMI.
        ///  </summary>
        ///
        private void FindDeviceWmi(Boolean _deviceSpecified)
		{
			try
			{
                String deviceIdString = @"USB\VID_";
                String strQry = "SELECT * FROM Win32_PnPEntity";
                ManagementObjectSearcher searcher = new ManagementObjectSearcher("root\\CIMV2", strQry);
                foreach (ManagementObject QueryObj in searcher.Get())
                {
                    if (QueryObj["PNPDeviceID"].ToString().Contains(deviceIdString))
                    {
                        String[] strArray = QueryObj["PNPDeviceID"].ToString().Split('&');
                        if (strArray[0].ToString().Contains(@"USB\VID_"))
                        {
                          String[] strArrayVID = strArray[0].Split('_');
                          String[] strArrayPID = strArray[1].Split('_');
                          String[] strSubArrayPID = strArrayPID[1].Split('\\');
                         if (_deviceSpecified)
                          {
                              if (strArrayVID[1] == vid_textBox.Text && strSubArrayPID[0] == pid_textBox.Text)
                              {
                                  //Lst_listBox.Items.Add("VID:" + strArrayVID[1] + " , " + "PID:" + strSubArrayPID[0] + " , " + "PC PortID:" + strArray[2] + "_" + strArray[3] + "_" + strArray[4]);
                                  Lst_listBox.Items.Add(QueryObj["PNPDeviceID"].ToString());
                                  Lst_listBox.Items.Add(" ");
                                  _FindDevice = true;
                              }
                              else
                              {
                                 continue;
                              }
                          }
                          else
                          {
                              //Lst_listBox.Items.Add("VID:" + strArrayVID[1] + " , " + "PID:" + strSubArrayPID[0] + " , " + "PC PortID:" + strArray[2] + "_" + strArray[3] + "_" + strArray[4]);
                             Lst_listBox.Items.Add(QueryObj["PNPDeviceID"].ToString());
                             Lst_listBox.Items.Add(" ");
                              _FindDevice = true;
                          }
                        }
                    }

                }
                if (!_FindDevice)
                    Lst_listBox.Items.Add("The device Specified not found ");

                Lst_listBox.Items.Add("");
                Lst_listBox.Items.Add("*********************************************************");
                Lst_listBox.Items.Add("");
            }
            catch (Exception ex)
            {
                DisplayException(Name, ex);
                throw;
            }
        }

        ///  <summary>
        ///  Displays a message box that describes the exception.
        ///  </summary>
        ///  
        internal static void DisplayException(String moduleName, Exception e)
        {
            //  Create an error message.
            String message = "Exception: " + e.Message + Environment.NewLine + "Module: " + moduleName + Environment.NewLine + "Method: " + e.TargetSite.Name;
            const String caption = "Unexpected Exception";
            MessageBox.Show(message, caption, MessageBoxButtons.OK);
        }

        private void clean_button_Click(object sender, EventArgs e)
        {
            Lst_listBox.Items.Clear();
            _FindDevice = false;
        }

        private void specDetect_button_Click(object sender, EventArgs e)
        {
            FindDeviceWmi(true);
            _FindDevice = false;
        }
    }
}
