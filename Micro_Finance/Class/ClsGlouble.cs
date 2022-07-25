using Micro_Finance.Class;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using System.Management;
using System.IO;

namespace Micro_Finance
{
    public class ClsGlouble
    {
        //public static string BASE_URL = "http://easylabel.technergycambodia.com/api/";
        public static string BASE_URL = "http://lhmfi.com/api/";
        public static string HEADER_URL = "Basic eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJuYW1lIjoiYWRtaW4iLCJpYXQiOjE2NTgxMzM5MDh9.NfXNW-YS13mo1AQxL2zMLCnIWwX2c1Ps8eZpFk3FPeE";
        public static string DB_IP = "127.0.0.1";
        public static string DB_PORT = "3306";
        public static string DB_USER = "posadmin";
        public static string DB_PWD = "Pa$$w0rd";
        public static string DB_NAME = "loansystem";
        public static string DB_DRIVER = "mysql";

        public static DataSet GetDataset(string SP_NAME, string[] PARAMS, string vDb = "")
        {
            DataSet ds = null;
            try
            {
                ConnectionEnity data = new ConnectionEnity(DB_IP, DB_USER, DB_PWD, vDb == "" ? DB_NAME : vDb, DB_PORT, DB_DRIVER, SP_NAME, PARAMS);
                string json = JsonConvert.SerializeObject(data);
                using (HttpClient vHttpClient = new HttpClient())
                {

                    vHttpClient.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
                    vHttpClient.DefaultRequestHeaders.Add("Authorization", HEADER_URL);
                    StringContent content = new StringContent(json, Encoding.UTF8, "application/json");
                    HttpResponseMessage result = vHttpClient.PostAsync(BASE_URL + "api/sp", content).Result;
                    string resultContent = result.Content.ReadAsStringAsync().Result;
                    if (!resultContent.Equals(""))
                    {
                        ds = JsonConvert.DeserializeObject<DataSet>(resultContent);
                    }
                }
                return ds.Copy();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static bool f_boolean(object p_value)
        {
            bool v_fail = false;
            if (p_value == null)
            {
                v_fail = false;
            }
            else
            {
                if (f_string(p_value).Equals("1"))
                {
                    v_fail = true;
                }
                else
                {
                    if (Boolean.TryParse(f_string(p_value), out v_fail))
                    {
                        return v_fail;
                    }
                }
            }
            return v_fail;
        }

        public static string f_string(object p_value)
        {
            if (p_value != DBNull.Value) { return Convert.ToString(p_value); }
            return "";
        }

        public static double f_double(object p_value, int p_decimal = 2)
        {
            if (p_value != DBNull.Value)
            {
                if (Microsoft.VisualBasic.Information.IsNumeric(p_value) == true)
                {
                    return Math.Round(Convert.ToDouble(p_value), p_decimal);
                }
                return 0.0F;
            }
            return 0.0F;
        }

        public static string f_doublestring(object p_value, int p_decimal = 2)
        {
            double v_value = 0;
            if (p_value == null || p_value == DBNull.Value)
            {
                return v_value.ToString("N" + p_decimal);
            }

            if (!double.TryParse(p_value.ToString(), out v_value))
                return v_value.ToString("N" + p_decimal);
            else if (Double.IsNaN(v_value) || Double.IsInfinity(v_value))
                return v_value.ToString("N" + p_decimal);
            else
                return v_value.ToString("N" + p_decimal);
        }

        public static int f_integer(object p_value)
        {
            if (p_value != DBNull.Value)
            {
                if (Microsoft.VisualBasic.Information.IsNumeric(p_value) == true)
                {
                    return (int)Math.Round(Convert.ToDouble(p_value));
                }
                return 0;
            }
            return 0;
        }

        public static void DoubleInput(KeyPressEventArgs e, TextBox t)
        {
            if (char.IsDigit(e.KeyChar) | e.KeyChar == ControlChars.Back | e.KeyChar == '.')
            {
                e.Handled = false;
                if (e.KeyChar == '.' | e.KeyChar == '0')
                {
                    if (t.SelectionLength == t.TextLength)
                        t.Text = "";
                    if (t.TextLength == 0)
                    {
                        t.Text = "0.";
                        t.Select(t.TextLength, 0);
                        if (e.KeyChar == '0')
                            e.Handled = true;
                    }
                    else
                    {
                        if (t.SelectionStart == 0)
                        {
                            if (e.KeyChar == '0')
                                e.Handled = true;
                        }
                        if (t.Text == "0")
                        {
                            t.Text = "0.";
                            t.Select(t.TextLength, 0);
                            e.Handled = true;
                        }
                    }
                    if (e.KeyChar == '.')
                    {
                        if (t.Text.IndexOf(".") != -1)
                            e.Handled = true;
                    }
                }
                else if (e.KeyChar != ControlChars.Back)
                {
                    if (t.SelectionLength == t.TextLength)
                        t.Text = "";
                    else if (t.Text == "0")
                    {
                        t.Text = "0.";
                        t.Select(t.TextLength, 0);
                    }
                }
            }
            else
                e.Handled = true;
        }

        public static void IntegerInput(KeyPressEventArgs e, TextBox t)
        {
            if (char.IsNumber(e.KeyChar) | e.KeyChar == ControlChars.Back)
                e.Handled = false;
            else
                e.Handled = true;
        }

        public static void ClearCtrl(params Control[] ctrl)
        {
            ctrl.ToList().ForEach(c =>
            {
                if (c is TextBox | c is Label)
                    c.Text = "";
                else if (c is ComboBox)
                {
                    ComboBox Cmb = c as ComboBox;
                    if (Cmb.DataSource == null)
                        Cmb.SelectedIndex = -1;
                    else
                        Cmb.DataSource = null;
                }
                else if (c is CheckBox)
                {
                    CheckBox k = c as CheckBox;
                    k.Checked = false;
                }
                else if (c is DateTimePicker)
                {
                    DateTimePicker d = c as DateTimePicker;
                    d.Value = DateTime.Now;
                }
                else if (c is DataGridView)
                {
                    DataGridView dgv = c as DataGridView;
                    if (dgv.DataSource == null)
                        dgv.Rows.Clear();
                    else
                        dgv.DataSource = null;
                }
            });
            if (ctrl.Length > 0)
                ctrl[0].Focus();
        }

        public static string GetMACAddress()
        {
            ManagementClass mc = new ManagementClass("Win32_NetworkAdapterConfiguration");
            ManagementObjectCollection moc = mc.GetInstances();
            string MACAddress = string.Empty;
            foreach (ManagementObject mo in moc)
            {
                if ((MACAddress.Equals(string.Empty)))
                {
                    if (System.Convert.ToBoolean(mo["IPEnabled"]))
                        MACAddress = mo["MacAddress"].ToString();
                    mo.Dispose();
                }
                MACAddress = MACAddress.Replace(":", string.Empty);
            }
            return MACAddress;
        }

        public static string GetHardiskSerial()
        {
            string vSerial = "";
            ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT * FROM Win32_PhysicalMedia");
            foreach (ManagementObject wmi_HD in searcher.Get())
            {
                if (wmi_HD["SerialNumber"] != null) {
                    vSerial = wmi_HD["SerialNumber"].ToString().Trim();
                    break;
                }
            }
            return vSerial;
        }

        public static void LoadBranch(ComboBox c) {
            DataSet ds = GetDataset("PRO_DATA_MANAGER", new string[] { "LOAD_BRANCH", "" }, "loansystem");
            c.DisplayMember = "var_name";
            c.ValueMember = "var_db";
            c.DataSource = ds.Tables[0];
        }
    }
}
