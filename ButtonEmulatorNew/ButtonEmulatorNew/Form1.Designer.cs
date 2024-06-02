namespace ButtonEmulator
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.Text.ASCIIEncoding asciiEncoding1 = new System.Text.ASCIIEncoding();
            System.Text.DecoderReplacementFallback decoderReplacementFallback1 = new System.Text.DecoderReplacementFallback();
            System.Text.EncoderReplacementFallback encoderReplacementFallback1 = new System.Text.EncoderReplacementFallback();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            buttonConnect = new Button();
            button5 = new Button();
            button6 = new Button();
            sp = new System.IO.Ports.SerialPort(components);
            label1 = new Label();
            button7 = new Button();
            button8 = new Button();
            checkBox_button_type = new CheckBox();
            saveFileDialog_create_screen = new SaveFileDialog();
            button9 = new Button();
            button10 = new Button();
            button11 = new Button();
            button12 = new Button();
            button13 = new Button();
            button14 = new Button();
            button15 = new Button();
            button16 = new Button();
            button17 = new Button();
            button18 = new Button();
            button19 = new Button();
            button20 = new Button();
            button21 = new Button();
            button22 = new Button();
            button23 = new Button();
            button24 = new Button();
            textBox2 = new TextBox();
            label2 = new Label();
            checkBoxReverseData1 = new CheckBox();
            checkBoxReverseData2 = new CheckBox();
            checkBoxReverseData3 = new CheckBox();
            testbench_button = new Button();
            testbench_name = new TextBox();
            pictureBox1 = new PictureBox();
            button_cam_start = new Button();
            comboBox_cameras = new ComboBox();
            button_cam_scan = new Button();
            button_cam_stop = new Button();
            comboBox_arduino = new ComboBox();
            button_com_scan = new Button();
            label3 = new Label();
            button_create_screen = new Button();
            openFileDialog_load_testbench = new OpenFileDialog();
            button_select_testbench = new Button();
            button1 = new Button();
            label4 = new Label();
            protComboBox = new ComboBox();
            protButton = new Button();
            mesText = new TextBox();
            label5 = new Label();
            mesButton = new Button();
            label6 = new Label();
            label7 = new Label();
            textBox1 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            button25 = new Button();
            button26 = new Button();
            button27 = new Button();
            button28 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button2
            // 
            button2.Enabled = false;
            button2.Location = new Point(18, 235);
            button2.Margin = new Padding(4, 3, 4, 3);
            button2.Name = "button2";
            button2.Size = new Size(103, 27);
            button2.TabIndex = 1;
            button2.Tag = "1";
            button2.Text = "Кнопка 2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button_Click;
            button2.MouseDown += button_MouseDown;
            button2.MouseUp += button_MouseUp;
            // 
            // button3
            // 
            button3.Enabled = false;
            button3.Location = new Point(18, 269);
            button3.Margin = new Padding(4, 3, 4, 3);
            button3.Name = "button3";
            button3.Size = new Size(103, 27);
            button3.TabIndex = 2;
            button3.Tag = "2";
            button3.Text = "Кнопка 3";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button_Click;
            button3.MouseDown += button_MouseDown;
            button3.MouseUp += button_MouseUp;
            // 
            // button4
            // 
            button4.Enabled = false;
            button4.Location = new Point(18, 302);
            button4.Margin = new Padding(4, 3, 4, 3);
            button4.Name = "button4";
            button4.Size = new Size(103, 27);
            button4.TabIndex = 3;
            button4.Tag = "3";
            button4.Text = "Кнопка 4";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button_Click;
            button4.MouseDown += button_MouseDown;
            button4.MouseUp += button_MouseUp;
            // 
            // buttonConnect
            // 
            buttonConnect.Location = new Point(183, 8);
            buttonConnect.Margin = new Padding(4, 3, 4, 3);
            buttonConnect.Name = "buttonConnect";
            buttonConnect.Size = new Size(156, 27);
            buttonConnect.TabIndex = 4;
            buttonConnect.Text = "Подключиться";
            buttonConnect.UseVisualStyleBackColor = true;
            buttonConnect.Click += buttonConnect_Click;
            // 
            // button5
            // 
            button5.Enabled = false;
            button5.Location = new Point(18, 336);
            button5.Margin = new Padding(4, 3, 4, 3);
            button5.Name = "button5";
            button5.Size = new Size(103, 27);
            button5.TabIndex = 5;
            button5.Tag = "4";
            button5.Text = "Кнопка 5";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button_Click;
            button5.MouseDown += button_MouseDown;
            button5.MouseUp += button_MouseUp;
            // 
            // button6
            // 
            button6.Enabled = false;
            button6.Location = new Point(18, 369);
            button6.Margin = new Padding(4, 3, 4, 3);
            button6.Name = "button6";
            button6.Size = new Size(103, 27);
            button6.TabIndex = 6;
            button6.Tag = "5";
            button6.Text = "Кнопка 6";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button_Click;
            button6.MouseDown += button_MouseDown;
            button6.MouseUp += button_MouseUp;
            // 
            // sp
            // 
            sp.BaudRate = 9600;
            sp.DataBits = 8;
            sp.DiscardNull = false;
            sp.DtrEnable = false;
            sp.Encoding = asciiEncoding1;
            sp.Handshake = System.IO.Ports.Handshake.None;
            sp.NewLine = "\n";
            sp.Parity = System.IO.Ports.Parity.None;
            sp.ParityReplace = 63;
            sp.PortName = "COM1";
            sp.ReadBufferSize = 4096;
            sp.ReadTimeout = -1;
            sp.ReceivedBytesThreshold = 1;
            sp.RtsEnable = false;
            sp.StopBits = System.IO.Ports.StopBits.One;
            sp.WriteBufferSize = 2048;
            sp.WriteTimeout = -1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(48, 14);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(35, 15);
            label1.TabIndex = 8;
            label1.Text = "Порт";
            // 
            // button7
            // 
            button7.Enabled = false;
            button7.Location = new Point(18, 403);
            button7.Margin = new Padding(4, 3, 4, 3);
            button7.Name = "button7";
            button7.Size = new Size(103, 27);
            button7.TabIndex = 10;
            button7.Tag = "6";
            button7.Text = "Кнопка 7";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button_Click;
            button7.MouseDown += button_MouseDown;
            button7.MouseUp += button_MouseUp;
            // 
            // button8
            // 
            button8.Enabled = false;
            button8.Location = new Point(18, 436);
            button8.Margin = new Padding(4, 3, 4, 3);
            button8.Name = "button8";
            button8.Size = new Size(103, 27);
            button8.TabIndex = 11;
            button8.Tag = "7";
            button8.Text = "Кнопка 8";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button_Click;
            button8.MouseDown += button_MouseDown;
            button8.MouseUp += button_MouseUp;
            // 
            // checkBox_button_type
            // 
            checkBox_button_type.Enabled = false;
            checkBox_button_type.Location = new Point(14, 107);
            checkBox_button_type.Margin = new Padding(4, 3, 4, 3);
            checkBox_button_type.Name = "checkBox_button_type";
            checkBox_button_type.Size = new Size(326, 25);
            checkBox_button_type.TabIndex = 12;
            checkBox_button_type.Text = "Использовать кнопки как переключатели";
            checkBox_button_type.UseVisualStyleBackColor = true;
            checkBox_button_type.CheckedChanged += checkBox_button_type_CheckedChanged;
            // 
            // saveFileDialog_create_screen
            // 
            saveFileDialog_create_screen.Filter = "\"image files (*.png)|*.png|All files (*.*)|*.*\"";
            // 
            // button9
            // 
            button9.Enabled = false;
            button9.Location = new Point(127, 201);
            button9.Margin = new Padding(4, 3, 4, 3);
            button9.Name = "button9";
            button9.Size = new Size(103, 27);
            button9.TabIndex = 13;
            button9.Tag = "8";
            button9.Text = "Кнопка 9\r\n";
            button9.UseVisualStyleBackColor = true;
            button9.Click += button_Click;
            button9.MouseDown += button_MouseDown;
            button9.MouseUp += button_MouseUp;
            // 
            // button10
            // 
            button10.Enabled = false;
            button10.Location = new Point(127, 235);
            button10.Margin = new Padding(4, 3, 4, 3);
            button10.Name = "button10";
            button10.Size = new Size(103, 27);
            button10.TabIndex = 14;
            button10.Tag = "9";
            button10.Text = "Кнопка 10";
            button10.UseVisualStyleBackColor = true;
            button10.Click += button_Click;
            button10.MouseDown += button_MouseDown;
            button10.MouseUp += button_MouseUp;
            // 
            // button11
            // 
            button11.Enabled = false;
            button11.Location = new Point(127, 269);
            button11.Margin = new Padding(4, 3, 4, 3);
            button11.Name = "button11";
            button11.Size = new Size(103, 27);
            button11.TabIndex = 15;
            button11.Tag = "10";
            button11.Text = "Кнопка 11";
            button11.UseVisualStyleBackColor = true;
            button11.Click += button_Click;
            button11.MouseDown += button_MouseDown;
            button11.MouseUp += button_MouseUp;
            // 
            // button12
            // 
            button12.Enabled = false;
            button12.Location = new Point(127, 302);
            button12.Margin = new Padding(4, 3, 4, 3);
            button12.Name = "button12";
            button12.Size = new Size(103, 27);
            button12.TabIndex = 16;
            button12.Tag = "11";
            button12.Text = "Кнопка 12";
            button12.UseVisualStyleBackColor = true;
            button12.Click += button_Click;
            button12.MouseDown += button_MouseDown;
            button12.MouseUp += button_MouseUp;
            // 
            // button13
            // 
            button13.Enabled = false;
            button13.Location = new Point(127, 336);
            button13.Margin = new Padding(4, 3, 4, 3);
            button13.Name = "button13";
            button13.Size = new Size(103, 27);
            button13.TabIndex = 17;
            button13.Tag = "12";
            button13.Text = "Кнопка 13";
            button13.UseVisualStyleBackColor = true;
            button13.Click += button_Click;
            button13.MouseDown += button_MouseDown;
            button13.MouseUp += button_MouseUp;
            // 
            // button14
            // 
            button14.Enabled = false;
            button14.Location = new Point(127, 370);
            button14.Margin = new Padding(4, 3, 4, 3);
            button14.Name = "button14";
            button14.Size = new Size(103, 27);
            button14.TabIndex = 18;
            button14.Tag = "13";
            button14.Text = "Кнопка 14";
            button14.UseVisualStyleBackColor = true;
            button14.Click += button_Click;
            button14.MouseDown += button_MouseDown;
            button14.MouseUp += button_MouseUp;
            // 
            // button15
            // 
            button15.Enabled = false;
            button15.Location = new Point(127, 404);
            button15.Margin = new Padding(4, 3, 4, 3);
            button15.Name = "button15";
            button15.Size = new Size(103, 27);
            button15.TabIndex = 19;
            button15.Tag = "14";
            button15.Text = "Кнопка 15";
            button15.UseVisualStyleBackColor = true;
            button15.Click += button_Click;
            button15.MouseDown += button_MouseDown;
            button15.MouseUp += button_MouseUp;
            // 
            // button16
            // 
            button16.Enabled = false;
            button16.Location = new Point(127, 437);
            button16.Margin = new Padding(4, 3, 4, 3);
            button16.Name = "button16";
            button16.Size = new Size(103, 27);
            button16.TabIndex = 20;
            button16.Tag = "15";
            button16.Text = "Кнопка 16";
            button16.UseVisualStyleBackColor = true;
            button16.Click += button_Click;
            button16.MouseDown += button_MouseDown;
            button16.MouseUp += button_MouseUp;
            // 
            // button17
            // 
            button17.Enabled = false;
            button17.Location = new Point(237, 201);
            button17.Margin = new Padding(4, 3, 4, 3);
            button17.Name = "button17";
            button17.Size = new Size(103, 27);
            button17.TabIndex = 21;
            button17.Tag = "16";
            button17.Text = "Кнопка 17";
            button17.UseVisualStyleBackColor = true;
            button17.Click += button_Click;
            button17.MouseDown += button_MouseDown;
            button17.MouseUp += button_MouseUp;
            // 
            // button18
            // 
            button18.Enabled = false;
            button18.Location = new Point(237, 235);
            button18.Margin = new Padding(4, 3, 4, 3);
            button18.Name = "button18";
            button18.Size = new Size(103, 27);
            button18.TabIndex = 22;
            button18.Tag = "17";
            button18.Text = "Кнопка 18";
            button18.UseVisualStyleBackColor = true;
            button18.Click += button_Click;
            button18.MouseDown += button_MouseDown;
            button18.MouseUp += button_MouseUp;
            // 
            // button19
            // 
            button19.Enabled = false;
            button19.Location = new Point(237, 269);
            button19.Margin = new Padding(4, 3, 4, 3);
            button19.Name = "button19";
            button19.Size = new Size(103, 27);
            button19.TabIndex = 23;
            button19.Tag = "18";
            button19.Text = "Кнопка 19";
            button19.UseVisualStyleBackColor = true;
            button19.Click += button_Click;
            button19.MouseDown += button_MouseDown;
            button19.MouseUp += button_MouseUp;
            // 
            // button20
            // 
            button20.Enabled = false;
            button20.Location = new Point(237, 302);
            button20.Margin = new Padding(4, 3, 4, 3);
            button20.Name = "button20";
            button20.Size = new Size(103, 27);
            button20.TabIndex = 24;
            button20.Tag = "19";
            button20.Text = "Кнопка 20";
            button20.UseVisualStyleBackColor = true;
            button20.Click += button_Click;
            button20.MouseDown += button_MouseDown;
            button20.MouseUp += button_MouseUp;
            // 
            // button21
            // 
            button21.Enabled = false;
            button21.Location = new Point(237, 336);
            button21.Margin = new Padding(4, 3, 4, 3);
            button21.Name = "button21";
            button21.Size = new Size(103, 27);
            button21.TabIndex = 25;
            button21.Tag = "20";
            button21.Text = "Кнопка 21";
            button21.UseVisualStyleBackColor = true;
            button21.Click += button_Click;
            button21.MouseDown += button_MouseDown;
            button21.MouseUp += button_MouseUp;
            // 
            // button22
            // 
            button22.Enabled = false;
            button22.Location = new Point(237, 370);
            button22.Margin = new Padding(4, 3, 4, 3);
            button22.Name = "button22";
            button22.Size = new Size(103, 27);
            button22.TabIndex = 26;
            button22.Tag = "21";
            button22.Text = "Кнопка 22";
            button22.UseVisualStyleBackColor = true;
            button22.Click += button_Click;
            button22.MouseDown += button_MouseDown;
            button22.MouseUp += button_MouseUp;
            // 
            // button23
            // 
            button23.Enabled = false;
            button23.Location = new Point(237, 404);
            button23.Margin = new Padding(4, 3, 4, 3);
            button23.Name = "button23";
            button23.Size = new Size(103, 27);
            button23.TabIndex = 27;
            button23.Tag = "22";
            button23.Text = "Кнопка 23";
            button23.UseVisualStyleBackColor = true;
            button23.Click += button_Click;
            button23.MouseDown += button_MouseDown;
            button23.MouseUp += button_MouseUp;
            // 
            // button24
            // 
            button24.Enabled = false;
            button24.Location = new Point(237, 437);
            button24.Margin = new Padding(4, 3, 4, 3);
            button24.Name = "button24";
            button24.Size = new Size(103, 27);
            button24.TabIndex = 28;
            button24.Tag = "23";
            button24.Text = "Кнопка 24";
            button24.UseVisualStyleBackColor = true;
            button24.Click += button_Click;
            button24.MouseDown += button_MouseDown;
            button24.MouseUp += button_MouseUp;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(121, 42);
            textBox2.Margin = new Padding(4, 3, 4, 3);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(218, 23);
            textBox2.TabIndex = 30;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(10, 45);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(94, 15);
            label2.TabIndex = 29;
            label2.Text = "Данные с порта";
            // 
            // checkBoxReverseData1
            // 
            checkBoxReverseData1.CheckAlign = ContentAlignment.MiddleCenter;
            checkBoxReverseData1.Enabled = false;
            checkBoxReverseData1.ForeColor = SystemColors.ActiveCaptionText;
            checkBoxReverseData1.Location = new Point(18, 171);
            checkBoxReverseData1.Margin = new Padding(4, 3, 4, 3);
            checkBoxReverseData1.Name = "checkBoxReverseData1";
            checkBoxReverseData1.Size = new Size(103, 24);
            checkBoxReverseData1.TabIndex = 31;
            checkBoxReverseData1.Tag = "0";
            checkBoxReverseData1.UseVisualStyleBackColor = true;
            checkBoxReverseData1.CheckedChanged += checkBox_group_CheckedChanged;
            // 
            // checkBoxReverseData2
            // 
            checkBoxReverseData2.CheckAlign = ContentAlignment.MiddleCenter;
            checkBoxReverseData2.Enabled = false;
            checkBoxReverseData2.Location = new Point(127, 171);
            checkBoxReverseData2.Margin = new Padding(4, 3, 4, 3);
            checkBoxReverseData2.Name = "checkBoxReverseData2";
            checkBoxReverseData2.Size = new Size(103, 23);
            checkBoxReverseData2.TabIndex = 32;
            checkBoxReverseData2.Tag = "1";
            checkBoxReverseData2.UseVisualStyleBackColor = true;
            checkBoxReverseData2.CheckedChanged += checkBox_group_CheckedChanged;
            // 
            // checkBoxReverseData3
            // 
            checkBoxReverseData3.CheckAlign = ContentAlignment.MiddleCenter;
            checkBoxReverseData3.Enabled = false;
            checkBoxReverseData3.Location = new Point(237, 171);
            checkBoxReverseData3.Margin = new Padding(4, 3, 4, 3);
            checkBoxReverseData3.Name = "checkBoxReverseData3";
            checkBoxReverseData3.Size = new Size(103, 23);
            checkBoxReverseData3.TabIndex = 33;
            checkBoxReverseData3.Tag = "2";
            checkBoxReverseData3.UseVisualStyleBackColor = true;
            checkBoxReverseData3.CheckedChanged += checkBox_group_CheckedChanged;
            // 
            // testbench_button
            // 
            testbench_button.Location = new Point(14, 69);
            testbench_button.Margin = new Padding(4, 3, 4, 3);
            testbench_button.Name = "testbench_button";
            testbench_button.Size = new Size(140, 27);
            testbench_button.TabIndex = 34;
            testbench_button.Text = "Запустить testbench";
            testbench_button.UseVisualStyleBackColor = true;
            testbench_button.Click += testbench_button_Click;
            // 
            // testbench_name
            // 
            testbench_name.Location = new Point(161, 72);
            testbench_name.Margin = new Padding(4, 3, 4, 3);
            testbench_name.Name = "testbench_name";
            testbench_name.Size = new Size(142, 23);
            testbench_name.TabIndex = 35;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.AppWorkspace;
            pictureBox1.BackgroundImage = ButtonEmulatorNew.Properties.Resources.camera;
            pictureBox1.BackgroundImageLayout = ImageLayout.Center;
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Location = new Point(346, 42);
            pictureBox1.Margin = new Padding(4, 3, 4, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(583, 421);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 36;
            pictureBox1.TabStop = false;
            // 
            // button_cam_start
            // 
            button_cam_start.Location = new Point(609, 8);
            button_cam_start.Margin = new Padding(4, 3, 4, 3);
            button_cam_start.Name = "button_cam_start";
            button_cam_start.Size = new Size(140, 27);
            button_cam_start.TabIndex = 37;
            button_cam_start.Text = "Запуск камеры";
            button_cam_start.UseVisualStyleBackColor = true;
            button_cam_start.Click += button_cam_start_Click;
            // 
            // comboBox_cameras
            // 
            comboBox_cameras.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox_cameras.FormattingEnabled = true;
            comboBox_cameras.Location = new Point(380, 10);
            comboBox_cameras.Margin = new Padding(4, 3, 4, 3);
            comboBox_cameras.Name = "comboBox_cameras";
            comboBox_cameras.Size = new Size(221, 23);
            comboBox_cameras.TabIndex = 39;
            comboBox_cameras.SelectedIndexChanged += comboBox_cameras_SelectedIndexChanged;
            // 
            // button_cam_scan
            // 
            button_cam_scan.BackgroundImage = ButtonEmulatorNew.Properties.Resources.search;
            button_cam_scan.BackgroundImageLayout = ImageLayout.Zoom;
            button_cam_scan.Location = new Point(346, 8);
            button_cam_scan.Margin = new Padding(4, 3, 4, 3);
            button_cam_scan.Name = "button_cam_scan";
            button_cam_scan.Size = new Size(27, 27);
            button_cam_scan.TabIndex = 40;
            button_cam_scan.UseVisualStyleBackColor = true;
            button_cam_scan.Click += button_cam_scan_Click;
            // 
            // button_cam_stop
            // 
            button_cam_stop.Location = new Point(756, 8);
            button_cam_stop.Margin = new Padding(4, 3, 4, 3);
            button_cam_stop.Name = "button_cam_stop";
            button_cam_stop.Size = new Size(140, 27);
            button_cam_stop.TabIndex = 38;
            button_cam_stop.Text = "Остановка камеры";
            button_cam_stop.UseVisualStyleBackColor = true;
            button_cam_stop.Click += button_cam_stop_Click;
            // 
            // comboBox_arduino
            // 
            comboBox_arduino.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox_arduino.FormattingEnabled = true;
            comboBox_arduino.Location = new Point(92, 10);
            comboBox_arduino.Margin = new Padding(4, 3, 4, 3);
            comboBox_arduino.Name = "comboBox_arduino";
            comboBox_arduino.Size = new Size(83, 23);
            comboBox_arduino.TabIndex = 41;
            // 
            // button_com_scan
            // 
            button_com_scan.BackgroundImage = ButtonEmulatorNew.Properties.Resources.search;
            button_com_scan.BackgroundImageLayout = ImageLayout.Zoom;
            button_com_scan.Location = new Point(14, 8);
            button_com_scan.Margin = new Padding(4, 3, 4, 3);
            button_com_scan.Name = "button_com_scan";
            button_com_scan.Size = new Size(27, 27);
            button_com_scan.TabIndex = 42;
            button_com_scan.UseVisualStyleBackColor = true;
            button_com_scan.Click += button_com_scan_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(14, 152);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(159, 15);
            label3.TabIndex = 46;
            label3.Text = "Принимать данные с плиса";
            // 
            // button_create_screen
            // 
            button_create_screen.BackgroundImage = ButtonEmulatorNew.Properties.Resources.download;
            button_create_screen.BackgroundImageLayout = ImageLayout.Zoom;
            button_create_screen.Location = new Point(903, 8);
            button_create_screen.Margin = new Padding(4, 3, 4, 3);
            button_create_screen.Name = "button_create_screen";
            button_create_screen.Size = new Size(27, 27);
            button_create_screen.TabIndex = 47;
            button_create_screen.UseVisualStyleBackColor = true;
            button_create_screen.Click += button_create_screen_Click;
            // 
            // openFileDialog_load_testbench
            // 
            openFileDialog_load_testbench.FileName = "openFileDialog1";
            openFileDialog_load_testbench.Filter = "\"verilog files (*.v)|*.v|text files (*.txt)|*.txt|All files (*.*)|*.*\"";
            // 
            // button_select_testbench
            // 
            button_select_testbench.Location = new Point(310, 69);
            button_select_testbench.Margin = new Padding(4, 3, 4, 3);
            button_select_testbench.Name = "button_select_testbench";
            button_select_testbench.Size = new Size(29, 27);
            button_select_testbench.TabIndex = 48;
            button_select_testbench.Text = "...";
            button_select_testbench.UseVisualStyleBackColor = true;
            button_select_testbench.Click += button_select_testbench_Click;
            // 
            // button1
            // 
            button1.Enabled = false;
            button1.Location = new Point(18, 202);
            button1.Margin = new Padding(4, 3, 4, 3);
            button1.Name = "button1";
            button1.Size = new Size(103, 27);
            button1.TabIndex = 49;
            button1.Text = "Кнопка 1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button_Click;
            button1.MouseDown += button_MouseDown;
            button1.MouseUp += button_MouseUp;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(936, 50);
            label4.Name = "label4";
            label4.Size = new Size(62, 15);
            label4.TabIndex = 50;
            label4.Text = "Протокол";
            // 
            // protComboBox
            // 
            protComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            protComboBox.Enabled = false;
            protComboBox.FormattingEnabled = true;
            protComboBox.Items.AddRange(new object[] { "uart", "i2c", "spi" });
            protComboBox.Location = new Point(1015, 47);
            protComboBox.Name = "protComboBox";
            protComboBox.Size = new Size(121, 23);
            protComboBox.TabIndex = 51;
            // 
            // protButton
            // 
            protButton.Enabled = false;
            protButton.Location = new Point(1142, 47);
            protButton.Name = "protButton";
            protButton.Size = new Size(132, 23);
            protButton.TabIndex = 52;
            protButton.Text = "Переключить";
            protButton.UseVisualStyleBackColor = true;
            protButton.Click += protButton_Click;
            // 
            // mesText
            // 
            mesText.Enabled = false;
            mesText.Location = new Point(1015, 76);
            mesText.Name = "mesText";
            mesText.Size = new Size(121, 23);
            mesText.TabIndex = 53;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(936, 79);
            label5.Name = "label5";
            label5.Size = new Size(73, 15);
            label5.TabIndex = 54;
            label5.Text = "Сообщение";
            // 
            // mesButton
            // 
            mesButton.Enabled = false;
            mesButton.Location = new Point(1142, 76);
            mesButton.Name = "mesButton";
            mesButton.Size = new Size(132, 23);
            mesButton.TabIndex = 55;
            mesButton.Text = "Отправить";
            mesButton.UseVisualStyleBackColor = true;
            mesButton.Click += mesButton_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(936, 139);
            label6.Name = "label6";
            label6.Size = new Size(98, 15);
            label6.TabIndex = 56;
            label6.Text = "Генератор ШИМ";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(936, 207);
            label7.Name = "label7";
            label7.Size = new Size(105, 15);
            label7.TabIndex = 57;
            label7.Text = "Генератор синуса";
            // 
            // textBox1
            // 
            textBox1.Enabled = true;
            textBox1.Location = new Point(1038, 136);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(98, 23);
            textBox1.TabIndex = 58;
            // 
            // textBox3
            // 
            textBox3.Enabled = true;
            textBox3.Location = new Point(1038, 204);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(98, 23);
            textBox3.TabIndex = 59;
            // 
            // textBox4
            // 
            textBox4.Enabled = true;
            textBox4.Location = new Point(1038, 254);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(98, 23);
            textBox4.TabIndex = 60;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(1052, 162);
            label8.Name = "label8";
            label8.Size = new Size(73, 15);
            label8.TabIndex = 61;
            label8.Text = "Скважность";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(1038, 230);
            label9.Name = "label9";
            label9.Size = new Size(89, 15);
            label9.TabIndex = 62;
            label9.Text = "Амплитуда (%)";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(1038, 280);
            label10.Name = "label10";
            label10.Size = new Size(96, 15);
            label10.TabIndex = 63;
            label10.Text = "Частота (x10 Hz)";
            // 
            // button25
            // 
            button25.Enabled = true;
            button25.Location = new Point(1142, 136);
            button25.Name = "button25";
            button25.Size = new Size(132, 23);
            button25.TabIndex = 64;
            button25.Text = "Старт";
            button25.UseVisualStyleBackColor = true;
            button25.Click += Button25_Click;
            // 
            // button26
            // 
            button26.Enabled = true;
            button26.Location = new Point(1142, 172);
            button26.Name = "button26";
            button26.Size = new Size(132, 23);
            button26.TabIndex = 65;
            button26.Text = "Стоп";
            button26.UseVisualStyleBackColor = true;
            button26.Click += Button26_Click;
            // 
            // button27
            // 
            button27.Enabled = true;
            button27.Location = new Point(1142, 206);
            button27.Name = "button27";
            button27.Size = new Size(132, 23);
            button27.TabIndex = 66;
            button27.Text = "Старт";
            button27.UseVisualStyleBackColor = true;
            button27.Click += Button27_Click;
            // 
            // button28
            // 
            button28.Enabled = true;
            button28.Location = new Point(1142, 239);
            button28.Name = "button28";
            button28.Size = new Size(132, 23);
            button28.TabIndex = 67;
            button28.Text = "Стоп";
            button28.UseVisualStyleBackColor = true;
            button28.Click += Button28_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(1294, 480);
            Controls.Add(button28);
            Controls.Add(button27);
            Controls.Add(button26);
            Controls.Add(button25);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox1);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(mesButton);
            Controls.Add(label5);
            Controls.Add(mesText);
            Controls.Add(protButton);
            Controls.Add(protComboBox);
            Controls.Add(label4);
            Controls.Add(button1);
            Controls.Add(button_select_testbench);
            Controls.Add(button_create_screen);
            Controls.Add(label3);
            Controls.Add(button_com_scan);
            Controls.Add(comboBox_arduino);
            Controls.Add(button_cam_scan);
            Controls.Add(comboBox_cameras);
            Controls.Add(button_cam_stop);
            Controls.Add(button_cam_start);
            Controls.Add(pictureBox1);
            Controls.Add(testbench_name);
            Controls.Add(testbench_button);
            Controls.Add(checkBoxReverseData3);
            Controls.Add(checkBoxReverseData2);
            Controls.Add(checkBoxReverseData1);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(button24);
            Controls.Add(button23);
            Controls.Add(button22);
            Controls.Add(button21);
            Controls.Add(button20);
            Controls.Add(button19);
            Controls.Add(button18);
            Controls.Add(button17);
            Controls.Add(button16);
            Controls.Add(button15);
            Controls.Add(button14);
            Controls.Add(button13);
            Controls.Add(button12);
            Controls.Add(button11);
            Controls.Add(button10);
            Controls.Add(button9);
            Controls.Add(checkBox_button_type);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(label1);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(buttonConnect);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            MinimizeBox = false;
            MinimumSize = new Size(16, 518);
            Name = "Form1";
            Text = "Butt Emulator";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void Button25_Click1(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Button buttonConnect;
        private System.IO.Ports.SerialPort sp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBox_button_type;
        private System.Windows.Forms.SaveFileDialog saveFileDialog_create_screen;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.Button button19;
        private System.Windows.Forms.Button button20;
        private System.Windows.Forms.Button button21;
        private System.Windows.Forms.Button button22;
        private System.Windows.Forms.Button button23;
        private System.Windows.Forms.Button button24;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkBoxReverseData1;
        private System.Windows.Forms.CheckBox checkBoxReverseData2;
        private System.Windows.Forms.CheckBox checkBoxReverseData3;
        private System.Windows.Forms.Button testbench_button;
        private System.Windows.Forms.TextBox testbench_name;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button_cam_start;
        private System.Windows.Forms.ComboBox comboBox_cameras;
        private System.Windows.Forms.Button button_cam_scan;
        private System.Windows.Forms.Button button_cam_stop;
        private System.Windows.Forms.ComboBox comboBox_arduino;
        private System.Windows.Forms.Button button_com_scan;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button_create_screen;
        private System.Windows.Forms.OpenFileDialog openFileDialog_load_testbench;
        private System.Windows.Forms.Button button_select_testbench;
        private System.Windows.Forms.Button button1;
        private Label label4;
        private ComboBox protComboBox;
        private Button protButton;
        private TextBox mesText;
        private Label label5;
        private Button mesButton;
        private Label label6;
        private Label label7;
        private TextBox textBox1;
        private TextBox textBox3;
        private TextBox textBox4;
        private Label label8;
        private Label label9;
        private Label label10;
        private Button button25;
        private Button button26;
        private Button button27;
        private Button button28;
    }
}

