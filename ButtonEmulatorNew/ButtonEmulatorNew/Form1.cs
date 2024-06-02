using System;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using Emgu;
using Emgu.CV;
using Emgu.CV.Structure;
//using Emgu.CV.Bitmap;
using Emgu.Util;
using DirectShowLib;
using System.Collections.Immutable;

namespace ButtonEmulator
{
    public partial class Form1 : Form
    {
        // для подключения по Serial
        bool is_connected = false;
        string[] portnames;

        // для работы камеры
        private VideoCapture capture = null;
        private DsDevice[] webcam = null;
        private int cameraId = 0;
        Mat m;

        // для управления направлением работы кнопок (прием/передача)
        List<CheckBox> checkBoxes;
        bool[] button_group_reverse_status;

        // для управления работой кнопок (кнопка/переключатель)
        bool is_switches = false;

        // состояние кнопки (нажата/отпущена)
        bool[] button_state;
        List<Button> buttons;
        Color default_backcolor = SystemColors.Control;
        Color active_backcolor = Color.Red;



        bool is_receive_1 = false;
        bool is_receive_2 = false;
        bool is_receive_3 = false;

        private delegate void SetTextDeleg(string text);
        public Form1()
        {
            InitializeComponent();

            sp = new System.IO.Ports.SerialPort();
            this.sp.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.sp_DataReceived);
            sp.BaudRate = 115200;
            sp.Parity = System.IO.Ports.Parity.None;
            sp.StopBits = System.IO.Ports.StopBits.One;
            sp.DataBits = 8;
            sp.ReadTimeout = 300;

            checkBoxes = new List<CheckBox>();
            checkBoxes.Add(checkBoxReverseData1);
            checkBoxes.Add(checkBoxReverseData2);
            checkBoxes.Add(checkBoxReverseData3);
            button_group_reverse_status = new bool[3];
            for (int i = 0; i < 3; i++)
            {
                button_group_reverse_status[i] = false;
            }

            button_state = new bool[24];
            for (int i = 0; i < 24; i++)
            {
                button_state[i] = false;
            }
            buttons = new List<Button>();
            buttons.Add(button1); buttons.Add(button2); buttons.Add(button3);
            buttons.Add(button4); buttons.Add(button5); buttons.Add(button6);
            buttons.Add(button7); buttons.Add(button8); buttons.Add(button9);
            buttons.Add(button10); buttons.Add(button11); buttons.Add(button12);
            buttons.Add(button13); buttons.Add(button14); buttons.Add(button15);
            buttons.Add(button16); buttons.Add(button17); buttons.Add(button18);
            buttons.Add(button19); buttons.Add(button20); buttons.Add(button21);
            buttons.Add(button22); buttons.Add(button23); buttons.Add(button24);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            portnames = SerialPort.GetPortNames();
            foreach (string s in portnames)
            {
                if (s != "COM1")
                {
                    comboBox_arduino.Items.Add(s);
                }
            }

            if (comboBox_arduino.Items.Count > 0)
            {
                comboBox_arduino.SelectedItem = comboBox_arduino.Items[0];
            }

            webcam = DsDevice.GetDevicesOfCat(FilterCategory.VideoInputDevice);
            for (int i = 0; i < webcam.Length; i++)
            {
                comboBox_cameras.Items.Add(webcam[i].Name);
            }

            if (comboBox_cameras.Items.Count > 0)
            {
                comboBox_cameras.SelectedItem = comboBox_cameras.Items[0];
                cameraId = comboBox_cameras.SelectedIndex;
            }

            GC.Collect();
        }

        #region Поключение и работа с Serial
        private void button_com_scan_Click(object sender, EventArgs e)
        {
            comboBox_arduino.Items.Clear();
            comboBox_arduino.SelectedItem = null;
            comboBox_arduino.Text = null;

            portnames = SerialPort.GetPortNames();
            foreach (string s in portnames)
            {
                if (s != "COM1")
                {
                    comboBox_arduino.Items.Add(s);
                }
            }

            if (comboBox_arduino.Items.Count == 0)
            {
                MessageBox.Show("Доступных COM портов не обнаружено");
            }

            if (comboBox_arduino.Items.Count > 0)
            {
                comboBox_arduino.SelectedItem = comboBox_arduino.Items[0];
            }
            GC.Collect();
        }

        private void buttonConnect_Click(object sender, EventArgs e)
        {
            if (is_connected)
            {
                try
                {
                    for (int i = 0; i < 24; i++)
                    {
                        string send_data = "bt" + ((i < 9) ? ("0" + (i + 1).ToString()) : (i + 1).ToString()) + "n";
                        sp.Write(send_data);
                        button_state[i] = false;
                        buttons[i].BackColor = default_backcolor;
                        buttons[i].UseVisualStyleBackColor = true;
                    }
                }
                catch
                { }

                sp.Close();
                buttonConnect.Text = "Подключиться";
                is_connected = false;

                for (int i = 0; i < 24; i++)
                {
                    buttons[i].Enabled = false;
                }

                checkBox_button_type.Enabled = false;
                for (int i = 0; i < checkBoxes.Count; i++)
                {
                    checkBoxes[i].Enabled = false;
                }
            }
            else
            {
                try
                {
                    sp.PortName = comboBox_arduino.Items[comboBox_arduino.SelectedIndex].ToString();
                    sp.Open();
                    sp.ReadTimeout = 1000;
                    sp.Write("Hello");
                    char[] buffer = new char[5];
                    sp.Read(buffer, 0, 1);
                    sp.Read(buffer, 1, 1);
                    sp.Read(buffer, 2, 1);
                    sp.Read(buffer, 3, 1);
                    sp.Read(buffer, 4, 1);

                    string spResponse = new string(buffer);
                    MessageBox.Show("Устройство подключено");

                    if (spResponse == "ardok")
                    {
                        is_connected = true;
                        buttonConnect.Text = "Отключиться";

                        for (int i = 0; i < 24; i++)
                        {
                            buttons[i].Enabled = true;
                        }

                        checkBox_button_type.Enabled = true;
                        for (int i = 0; i < checkBoxes.Count; i++)
                        {
                            checkBoxes[i].Enabled = true;
                        }
                        protButton.Enabled = true;
                        protComboBox.Enabled = true;
                        mesButton.Enabled = true;
                        mesText.Enabled = true;
                    }
                    else
                    {
                        throw new Exception("нет ответа от устройства");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Проблемы с подключением.\nВыбран неправильный порт или устройство не подключено.\n" + ex.Message);
                    sp.Close();
                }
            }
            GC.Collect();
        }


        #endregion

        #region Поключение и работа с камерой
        private void comboBox_cameras_SelectedIndexChanged(object sender, EventArgs e)
        {
            cameraId = comboBox_cameras.SelectedIndex;
            GC.Collect();
        }

        private void button_cam_scan_Click(object sender, EventArgs e)
        {
            comboBox_cameras.Items.Clear();
            comboBox_cameras.SelectedItem = null;
            comboBox_cameras.Text = null;

            webcam = DsDevice.GetDevicesOfCat(FilterCategory.VideoInputDevice);
            if (webcam.Length == 0)
            {
                MessageBox.Show("Доступных камер не обнаружено");
            }
            else
            {
                for (int i = 0; i < webcam.Length; i++)
                {
                    comboBox_cameras.Items.Add(webcam[i].Name);
                }

                if (comboBox_cameras.Items.Count > 0)
                {
                    comboBox_cameras.SelectedItem = comboBox_cameras.Items[0];
                    cameraId = comboBox_cameras.SelectedIndex;
                }
            }
            GC.Collect();
        }

        private void Capture_ImageGrabbed(object sender, EventArgs e)
        {
            try
            {
                capture.Retrieve(m);
                Image<Bgr, byte> img = m.ToImage<Bgr, byte>().Flip(Emgu.CV.CvEnum.FlipType.Horizontal);
                Bitmap btmp = img.ToBitmap<Bgr, byte>();
                pictureBox1.Image = btmp;
                GC.Collect();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Oops!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_cam_start_Click(object sender, EventArgs e)
        {
            try
            {
                if (webcam.Length == 0)
                {
                    throw new Exception("No cameras available");
                }
                else if (comboBox_cameras.SelectedItem == null)
                {
                    throw new Exception("Please, select camera");
                }
                else
                {
                    capture = new VideoCapture(cameraId);
                    capture.ImageGrabbed += Capture_ImageGrabbed;
                    m = new Mat();
                    capture.Start();
                }
                GC.Collect();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Oops!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_cam_stop_Click(object sender, EventArgs e)
        {
            try
            {
                if (capture != null)
                {
                    capture.Pause();
                    capture.Dispose();
                    capture = null;
                    pictureBox1.Image.Dispose();
                    pictureBox1.Image = null;
                    cameraId = 0;
                    m.Dispose();
                    GC.Collect();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Oops!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_create_screen_Click(object sender, EventArgs e)
        {
            saveFileDialog_create_screen.FileName = null;
            if (saveFileDialog_create_screen.ShowDialog() == DialogResult.OK)
            {
                Bitmap save_bmp = (Bitmap)pictureBox1.Image;
                if (save_bmp != null)
                {
                    save_bmp.Save(saveFileDialog_create_screen.FileName, System.Drawing.Imaging.ImageFormat.Jpeg);
                    MessageBox.Show("Изображение сохранено");
                    save_bmp.Dispose();
                }
                else
                {
                    MessageBox.Show("Камера не включена, нет изображения для сохранения");
                }

            }
            saveFileDialog_create_screen.Dispose();
            GC.Collect();
        }

        #endregion

        #region Определение типа и состояния элементов передачи данных
        private void checkBox_button_type_CheckedChanged(object sender, EventArgs e)
        {
            is_switches = checkBox_button_type.Checked;
            GC.Collect();
        }

        private void checkBox_group_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox senderbox = (CheckBox)sender;

            int checkBox_id = Convert.ToInt32(senderbox.Tag);

            button_group_reverse_status[checkBox_id] = checkBoxes[checkBox_id].Checked;
            if (button_group_reverse_status[checkBox_id])
            {
                for (int i = 0; i < 8; i++)
                {
                    buttons[(checkBox_id) * 8 + i].Text = "Светодиод " + ((checkBox_id) * 8 + i).ToString();
                }
                string sendtext = (checkBox_id + 1).ToString() + "in";
                sp.Write(sendtext);

                // MessageBox.Show(sendtext);
            }
            else
            {
                for (int i = 0; i < 8; i++)
                {
                    buttons[(checkBox_id) * 8 + i].Text = "Кнопка " + ((checkBox_id) * 8 + i).ToString();
                }
                string sendtext = (checkBox_id + 1).ToString() + "out";
                sp.Write(sendtext);
            }
            GC.Collect();
        }

        #endregion

        #region Обработка нажатий на кнопки для приема/передачи данных

        private void button_Click(object sender, EventArgs e)
        {
            Button senderbutton = (Button)sender;
            int button_id = Convert.ToInt32(senderbutton.Tag);
            int reverse_group_id = button_id / 8;
            if (!button_group_reverse_status[reverse_group_id])
            {
                if (is_switches)
                {
                    if (!button_state[button_id])
                    {
                        string send_text = "bt" + ((button_id < 9) ? ("0" + (button_id + 1).ToString()) : (button_id + 1).ToString()) + "y";
                        sp.Write(send_text);
                        buttons[button_id].BackColor = active_backcolor;
                        button_state[button_id] = true;
                    }
                    else
                    {
                        string send_text = "bt" + ((button_id < 9) ? ("0" + (button_id + 1).ToString()) : (button_id + 1).ToString()) + "n";
                        sp.Write(send_text);
                        buttons[button_id].BackColor = default_backcolor;
                        buttons[button_id].UseVisualStyleBackColor = true;
                        button_state[button_id] = false;
                    }
                }
            }
            GC.Collect();
        }

        private void button_MouseDown(object sender, MouseEventArgs e)
        {
            Button senderbutton = (Button)sender;
            int button_id = Convert.ToInt32(senderbutton.Tag);
            int reverse_group_id = button_id / 8;

            if (!button_group_reverse_status[reverse_group_id])
            {
                if (!is_switches)
                {

                    string send_text = "bt" + ((button_id < 9) ? ("0" + (button_id + 1).ToString()) : (button_id + 1).ToString()) + "y";
                    sp.Write(send_text);
                    button_state[button_id] = true;

                    /*   char[] buff = new char[2];
                       sp.ReadTimeout = 1000;
                       sp.Read(buff, 0, 1);
                       //sp.Read(buff, 1, 1);
                       string spResponse = new string(buff);
                       MessageBox.Show(spResponse.ToString() + " & " + send_text.ToString());
   */
                }
            }
            GC.Collect();
        }

        private void button_MouseUp(object sender, MouseEventArgs e)
        {
            Button senderbutton = (Button)sender;
            int button_id = Convert.ToInt32(senderbutton.Tag);
            int reverse_group_id = button_id / 8;

            if (!button_group_reverse_status[reverse_group_id])
            {
                if (!is_switches)
                {
                    string send_text = "bt" + ((button_id < 9) ? ("0" + (button_id + 1).ToString()) : (button_id + 1).ToString()) + "n";
                    sp.Write(send_text);
                    button_state[button_id] = false;
                }
            }
            GC.Collect();
        }

        #endregion

        void sp_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            //Thread.Sleep(500);
            char[] buffer = new char[32];
            /*sp.ReadTimeout = 1000;
            sp.Read(buffer, 0, 1);
            sp.Read(buffer, 1, 1);
            sp.Read(buffer, 2, 1);
            sp.Read(buffer, 3, 1);
            sp.Read(buffer, 4, 1);
            string data = new string(buffer);*/
            sp.ReadTimeout = 3000;
            string data = "";
            try
            {
                sp.Read(buffer, 0, 1);
                sp.Read(buffer, 1, 1);
                sp.Read(buffer, 2, 1);
                sp.Read(buffer, 3, 1);
                sp.Read(buffer, 4, 1);
                sp.Read(buffer, 5, 1);
                sp.Read(buffer, 6, 1);
                sp.Read(buffer, 7, 1);
                sp.Read(buffer, 8, 1);
                sp.Read(buffer, 9, 1);
                sp.Read(buffer, 10, 1);
                sp.Read(buffer, 11, 1);
                sp.Read(buffer, 12, 1);
                sp.Read(buffer, 13, 1);
                sp.Read(buffer, 14, 1);
                sp.Read(buffer, 15, 1);
                sp.Read(buffer, 16, 1);
                sp.Read(buffer, 17, 1);
                sp.Read(buffer, 18, 1);
                sp.Read(buffer, 19, 1);
                sp.Read(buffer, 20, 1);
                sp.Read(buffer, 21, 1);
                sp.Read(buffer, 22, 1);
                sp.Read(buffer, 23, 1);
                sp.Read(buffer, 24, 1);
                sp.Read(buffer, 25, 1);
                sp.Read(buffer, 26, 1);
                sp.Read(buffer, 27, 1);
                sp.Read(buffer, 28, 1);
                sp.Read(buffer, 29, 1);
                sp.Read(buffer, 30, 1);
                sp.Read(buffer, 31, 1);

                data = new string(buffer);
                //data = sp.ReadLine();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            // Привлечение делегата на потоке UI, и отправка данных, которые
            // были приняты привлеченным методом.
            // ---- Метод "si_DataReceived" будет выполнен в потоке UI,
            // который позволит заполнить текстовое поле TextBox.
            this.BeginInvoke(new SetTextDeleg(si_DataReceived),
                             new object[] { data });
        }

        private void si_DataReceived(string data)
        {
            data = data.Trim();
            textBox2.Text = data;
            if ((is_receive_1) && (data == "1LH")) button1.BackColor = active_backcolor;
            else if ((is_receive_1) && (data == "1LL")) button1.BackColor = default_backcolor;
            if ((is_receive_1) && (data == "2LH")) button2.BackColor = active_backcolor;
            else if ((is_receive_1) && (data == "2LL")) button2.BackColor = default_backcolor;
            if ((is_receive_1) && (data == "3LH")) button3.BackColor = active_backcolor;
            else if ((is_receive_1) && (data == "3LL")) button3.BackColor = default_backcolor;
            if ((is_receive_1) && (data == "4LH")) button4.BackColor = active_backcolor;
            else if ((is_receive_1) && (data == "4LL")) button4.BackColor = default_backcolor;
            if ((is_receive_1) && (data == "5LH")) button5.BackColor = active_backcolor;
            else if ((is_receive_1) && (data == "5LL")) button5.BackColor = default_backcolor;
            if ((is_receive_1) && (data == "6LH")) button6.BackColor = active_backcolor;
            else if ((is_receive_1) && (data == "6LL")) button6.BackColor = default_backcolor;
            if ((is_receive_1) && (data == "7LH")) button7.BackColor = active_backcolor;
            else if ((is_receive_1) && (data == "7LL")) button7.BackColor = default_backcolor;
            if ((is_receive_1) && (data == "8LH")) button8.BackColor = active_backcolor;
            else if ((is_receive_1) && (data == "8LL")) button8.BackColor = default_backcolor;

            if ((is_receive_2) && (data == "9LH")) button9.BackColor = active_backcolor;
            else if ((is_receive_2) && (data == "9LL")) button9.BackColor = default_backcolor;
            if ((is_receive_2) && (data == "10LH")) button10.BackColor = active_backcolor;
            else if ((is_receive_2) && (data == "10LL")) button10.BackColor = default_backcolor;
            if ((is_receive_2) && (data == "11LH")) button11.BackColor = active_backcolor;
            else if ((is_receive_2) && (data == "11LL")) button11.BackColor = default_backcolor;
            if ((is_receive_2) && (data == "12LH")) button12.BackColor = active_backcolor;
            else if ((is_receive_2) && (data == "12LL")) button12.BackColor = default_backcolor;
            if ((is_receive_2) && (data == "13LH")) button13.BackColor = active_backcolor;
            else if ((is_receive_2) && (data == "13LL")) button13.BackColor = default_backcolor;
            if ((is_receive_2) && (data == "14LH")) button14.BackColor = active_backcolor;
            else if ((is_receive_2) && (data == "14LL")) button14.BackColor = default_backcolor;
            if ((is_receive_2) && (data == "15LH")) button15.BackColor = active_backcolor;
            else if ((is_receive_2) && (data == "15LL")) button15.BackColor = default_backcolor;
            if ((is_receive_2) && (data == "16LH")) button16.BackColor = active_backcolor;
            else if ((is_receive_2) && (data == "16LL")) button16.BackColor = default_backcolor;

            if ((is_receive_3) && (data == "17LH")) button17.BackColor = active_backcolor;
            else if ((is_receive_3) && (data == "17LL")) button17.BackColor = default_backcolor;
            if ((is_receive_3) && (data == "18LH")) button18.BackColor = active_backcolor;
            else if ((is_receive_3) && (data == "18LL")) button18.BackColor = default_backcolor;
            if ((is_receive_3) && (data == "19LH")) button19.BackColor = active_backcolor;
            else if ((is_receive_3) && (data == "19LL")) button19.BackColor = default_backcolor;
            if ((is_receive_3) && (data == "20LH")) button20.BackColor = active_backcolor;
            else if ((is_receive_3) && (data == "20LL")) button20.BackColor = default_backcolor;
            if ((is_receive_3) && (data == "21LH")) button21.BackColor = active_backcolor;
            else if ((is_receive_3) && (data == "21LL")) button21.BackColor = default_backcolor;
            if ((is_receive_3) && (data == "22LH")) button22.BackColor = active_backcolor;
            else if ((is_receive_3) && (data == "22LL")) button22.BackColor = default_backcolor;
            if ((is_receive_3) && (data == "23LH")) button23.BackColor = active_backcolor;
            else if ((is_receive_3) && (data == "23LL")) button23.BackColor = default_backcolor;
            if ((is_receive_3) && (data == "24LH")) button24.BackColor = active_backcolor;
            else if ((is_receive_3) && (data == "24LL")) button24.BackColor = default_backcolor;
        }

        private void testbench_button_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(testbench_name.Text)) //@@@
            {

                string file_name = testbench_name.Text;

                try
                {
                    string filetext = File.ReadAllText(@file_name);
                    Regex reg_regex = new Regex(@"\s*^\s*reg\s*((.*\])\s*(\w*)\s*;\s*\/\/\s*(\w+)\s*\n)");
                    MatchCollection matches_reg = reg_regex.Matches(filetext);

                    Regex initial_regex = new Regex(@"initial\s*\n\s*begin\s*\n(.*\n)*\s*end\n");
                    MatchCollection matches_initial = initial_regex.Matches(filetext);
                    Regex data_regex = new Regex(@"\s*^\s*(\w*)\s*=\s*(\d*)'([bdh])(\d*)\n*");
                    Regex delay_regex = new Regex(@"\s*(#)(\w*)\n*");

                    if (matches_reg.Count > 0)
                    {
                        foreach (Match match in matches_reg)
                        {
                            //Console.WriteLine(match.Groups[1].Value);
                            string data = match.Groups[3].Value + " " + match.Groups[4].Value;
                            Console.WriteLine(data);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Не найдено reg портов");
                    }

                    if (matches_initial.Count > 0)
                    {
                        foreach (Match match in matches_initial)
                        {
                            Group gr = match.Groups[1];
                            for (int i = 0; i < gr.Captures.Count; i++)
                            {
                                //Console.WriteLine(gr.Captures[i].Value);
                                MatchCollection matches_data = data_regex.Matches(gr.Captures[i].Value);
                                MatchCollection matches_delay = delay_regex.Matches(gr.Captures[i].Value);
                                if (matches_data.Count > 0)
                                {
                                    foreach (Match match1 in matches_data)
                                    {
                                        //Console.WriteLine(match1.Groups[1].Value);
                                        string data = match1.Groups[1].Value + " " + match1.Groups[2].Value + " " + match1.Groups[4].Value;
                                        sp.Write(data);
                                        Console.WriteLine(data);
                                    }
                                }
                                else if (matches_delay.Count > 0)
                                {
                                    foreach (Match match1 in matches_delay)
                                    {
                                        string delay = match1.Groups[1].Value + match1.Groups[2].Value;
                                        sp.Write(delay);
                                        Console.WriteLine(delay);
                                    }
                                }
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Не найдено блока initial");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Oops!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Введите имя testbench");
            }
        }

        private void button_select_testbench_Click(object sender, EventArgs e)
        {
            openFileDialog_load_testbench.FileName = null;
            if (openFileDialog_load_testbench.ShowDialog() == DialogResult.OK)
            {
                testbench_name.Text = openFileDialog_load_testbench.FileName;
            }
        }

        private void protButton_Click(object sender, EventArgs e)
        {
            if (protComboBox.SelectedItem == "Serial")
            {
                try
                {
                    sp.Write("serHello");
                    sp.ReadTimeout = 500;
                    char[] buffer = new char[5];
                    sp.Read(buffer, 0, 1);
                    sp.Read(buffer, 1, 1);
                    sp.Read(buffer, 2, 1);
                    sp.Read(buffer, 3, 1);
                    sp.Read(buffer, 4, 1);
                    string spResponse = new string(buffer);
                    if (spResponse == "serok")
                    {
                        MessageBox.Show("Режим Serial");
                        for (int i = 0; i < 24; i++)
                        {
                            buttons[i].Enabled = true;
                        }

                        checkBox_button_type.Enabled = true;
                        for (int i = 0; i < checkBoxes.Count; i++)
                        {
                            checkBoxes[i].Enabled = true;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }

            }
            if (protComboBox.SelectedItem == "i2c")
            {
                try
                {
                    sp.Write("i2cHello");
                    sp.ReadTimeout = 500;
                    char[] buffer = new char[5];
                    sp.Read(buffer, 0, 1);
                    sp.Read(buffer, 1, 1);
                    sp.Read(buffer, 2, 1);
                    sp.Read(buffer, 3, 1);
                    sp.Read(buffer, 4, 1);
                    string spResponse = new string(buffer);
                    if (spResponse == "i2cok")
                    {
                        MessageBox.Show("Режим i2c");
                        for (int i = 0; i < 24; i++)
                        {
                            buttons[i].Enabled = false;
                        }

                        checkBox_button_type.Enabled = false;
                        for (int i = 0; i < checkBoxes.Count; i++)
                        {
                            checkBoxes[i].Enabled = false;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
            if (protComboBox.SelectedItem == "uart")
            {
                try
                {
                    sp.Write("uartHello");
                    sp.ReadTimeout = 800;
                    char[] buffer = new char[6];
                    sp.Read(buffer, 0, 1);
                    sp.Read(buffer, 1, 1);
                    sp.Read(buffer, 2, 1);
                    sp.Read(buffer, 3, 1);
                    sp.Read(buffer, 4, 1);
                    sp.Read(buffer, 5, 1);
                    string spResponse = new string(buffer);
                    if (spResponse == "uartok")
                    {
                        MessageBox.Show("Режим uart");
                        for (int i = 0; i < 24; i++)
                        {
                            buttons[i].Enabled = false;
                        }

                        checkBox_button_type.Enabled = false;
                        for (int i = 0; i < checkBoxes.Count; i++)
                        {
                            checkBoxes[i].Enabled = false;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void mesButton_Click(object sender, EventArgs e)
        {
            if (protComboBox.SelectedItem == "uart")
            {
                sp.Write("tuart");
            }

            if (protComboBox.SelectedItem == "i2c")
            {
                sp.Write("tri2c");
            }

            if (protComboBox.SelectedItem == "spi")
            {
                sp.Write("trspi");
            }

            Thread.Sleep(100);

            sp.Write(mesText.Text + '\r');
            Console.WriteLine(mesText.Text);
            /*
            char[] buffer = new char[mesButton.Text.Length + 1];
            sp.ReadTimeout = 1000;
            sp.Read(buffer, 0, mesButton.Text.Length + 1);

            Console.WriteLine(buffer);
            */
        }

        private void Button25_Click(object sender, EventArgs e)
        {
            sp.Write("pwmon");

            char num = Convert.ToChar(int.Parse(textBox1.Text));

            sp.Write(num.ToString());
        }

        private void Button26_Click(object sender, EventArgs e)
        {
            sp.Write("pwmof");
        }

        private void Button27_Click(object sender, EventArgs e)
        {
            sp.Write("anlon");

            char num1 = Convert.ToChar(int.Parse(textBox3.Text));

            

            char num2 = Convert.ToChar(int.Parse(textBox4.Text));

            sp.Write(num1.ToString() + num2.ToString());
        }

        private void Button28_Click(object sender, EventArgs e)
        {
            sp.Write("anlof");
        }
    }
}
