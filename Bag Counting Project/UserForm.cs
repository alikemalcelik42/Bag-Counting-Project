using Emgu.CV;
using Emgu.CV.Structure;
using Emgu.CV.Util;
using Microsoft.VisualBasic;
using System.Net.NetworkInformation;

namespace Bag_Counting_Project
{
    public partial class UserForm : Form
    {
        VideoCapture VideoCapture;
        Image<Bgr, byte> Frame;
        Image<Bgr, byte> Section;
        Image<Bgr, byte> TopCountBox;
        Image<Bgr, byte> BottomCountBox;
        Rectangle SectionRect;
        Rectangle TopCountBoxRect;
        Rectangle BottomCountBoxRect;
        Point StartLocation;
        Point EndLocation;
        int ThresholdValue;
        int ThresholdValueCountBox;
        int MinArea;
        int MaxHeight;
        int DistanceOfBoxes;
        int Count = 0;
        int TotalCount = 0;
        int AimCount = 0;
        VideoWriter VideoW;
        bool IsVideoRecording = false;
        bool Licenced = false;
        bool Temp;
        bool TempIsBig = false;

        public UserForm()
        {
            InitializeComponent();
            GetSource();
            LoadSettings();
            GetVersion();
            GetTotalCount();

            if (VideoCapture != null)
                Application.Idle += StreamVideo;
        }

        private void StreamVideo(object? sender, EventArgs e)
        {
            if (VideoCapture.QueryFrame() == null)
            {
                pictureBox.Image = null;
                return;
            }

            int rectangleCount = 0;
            bool isBig = false;
            List<int> countoursY = new List<int>();
            Rectangle TopRect = new Rectangle();

            Frame = VideoCapture.QueryFrame().ToImage<Bgr, byte>();
            Frame = Frame.Resize(pictureBox.Width, pictureBox.Height, Emgu.CV.CvEnum.Inter.Linear);


            if (SectionRect.Width * SectionRect.Height > 0 && SectionRect != null)
            {
                Frame.ROI = SectionRect;
                Section = Frame.CopyBlank();
                Frame.CopyTo(Section);
                Frame.ROI = Rectangle.Empty;

                Mat Gray = new Mat();
                CvInvoke.CvtColor(Section, Gray, Emgu.CV.CvEnum.ColorConversion.Bgr2Gray);

                Mat Mask = new Mat();
                CvInvoke.Threshold(Gray, Mask, ThresholdValue, 255, Emgu.CV.CvEnum.ThresholdType.Binary);

                Mat kernel1 = CvInvoke.GetStructuringElement(Emgu.CV.CvEnum.ElementShape.Cross, new Size(3, 3), new Point(1, 1));
                CvInvoke.MorphologyEx(Mask, Mask, Emgu.CV.CvEnum.MorphOp.Open, kernel1, new Point(-1, -1), 3, Emgu.CV.CvEnum.BorderType.Default, new MCvScalar());

                VectorOfVectorOfPoint contours = new VectorOfVectorOfPoint();
                Mat h = new Mat();
                CvInvoke.FindContours(Mask, contours, h, Emgu.CV.CvEnum.RetrType.Tree, Emgu.CV.CvEnum.ChainApproxMethod.ChainApproxSimple);

                for (int i = 0; i < contours.Size; i++)
                {
                    if (CvInvoke.ContourArea(contours[i]) < MinArea)
                        continue;

                    var rect = CvInvoke.BoundingRectangle(contours[i]);
                    rect.X += SectionRect.X;

                    var RectangleFrame = Frame.Clone();
                    if (rect.Height > MaxHeight)
                    {
                        CvInvoke.Rectangle(RectangleFrame, rect, new MCvScalar(0, 0, 255), -1);
                        isBig = true;
                    }
                    else
                    {
                        CvInvoke.Rectangle(RectangleFrame, rect, new MCvScalar(0, 255, 0), -1);
                        isBig = false;
                    }
                    CvInvoke.AddWeighted(Frame, 0.8, RectangleFrame, 0.2, 0.0, Frame);

                    countoursY.Add(rect.Y);

                    if (rect.Y == 0)
                    {
                        TopRect = rect;
                    }

                    rectangleCount++;
                }

                Frame.ROI = TopCountBoxRect;
                TopCountBox = Frame.CopyBlank();
                Frame.CopyTo(TopCountBox);
                Frame.ROI = Rectangle.Empty;

                Mat GrayTopCountBox = new Mat();
                CvInvoke.CvtColor(TopCountBox, GrayTopCountBox, Emgu.CV.CvEnum.ColorConversion.Bgr2Gray);

                Mat MaskTopCountBox = new Mat();
                CvInvoke.Threshold(GrayTopCountBox, MaskTopCountBox, ThresholdValueCountBox, 255, Emgu.CV.CvEnum.ThresholdType.Binary);

                Mat kernel2 = CvInvoke.GetStructuringElement(Emgu.CV.CvEnum.ElementShape.Cross, new Size(3, 3), new Point(1, 1));
                CvInvoke.MorphologyEx(MaskTopCountBox, MaskTopCountBox, Emgu.CV.CvEnum.MorphOp.Dilate, kernel2, new Point(-1, -1), 3, Emgu.CV.CvEnum.BorderType.Default, new MCvScalar());

                bool detectTop;
                var color = MaskTopCountBox.ToImage<Gray, byte>().GetAverage();
                if (color.Intensity == 255)
                    detectTop = true;
                else
                    detectTop = false;

                Frame.ROI = BottomCountBoxRect;
                BottomCountBox = Frame.CopyBlank();
                Frame.CopyTo(BottomCountBox);
                Frame.ROI = Rectangle.Empty;

                Mat GrayBottomCountBox = new Mat();
                CvInvoke.CvtColor(BottomCountBox, GrayBottomCountBox, Emgu.CV.CvEnum.ColorConversion.Bgr2Gray);

                Mat MaskBottomCountBox = new Mat();
                CvInvoke.Threshold(GrayBottomCountBox, MaskBottomCountBox, ThresholdValueCountBox, 255, Emgu.CV.CvEnum.ThresholdType.Binary);

                Mat kernel3 = CvInvoke.GetStructuringElement(Emgu.CV.CvEnum.ElementShape.Cross, new Size(3, 3), new Point(1, 1));
                CvInvoke.MorphologyEx(MaskBottomCountBox, MaskBottomCountBox, Emgu.CV.CvEnum.MorphOp.Dilate, kernel3, new Point(-1, -1), 3, Emgu.CV.CvEnum.BorderType.Default, new MCvScalar());

                bool detectBottom;
                var bottomColor = MaskBottomCountBox.ToImage<Gray, byte>().GetAverage();
                if (bottomColor.Intensity == 255)
                    detectBottom = true;
                else
                    detectBottom = false;

                if (detectTop)
                {
                    if (rectangleCount > 0)
                    {
                        if (!TempIsBig && !Temp && countoursY.Min() == 0)
                        {
                            int raise = 1;
                            if (isBig)
                                raise = 2;
                            Count += raise;
                            TotalCount += raise;
                            if (AimCount != 0)
                            {
                                if (AimCount - raise <= 0)
                                {
                                    AimCount = 0;
                                    aimCountNum.Value = AimCount;
                                    aimCountBtn.Enabled = true;
                                }
                                else
                                {
                                    AimCount -= raise;
                                }
                            }
                        }
                    }
                }
                if (rectangleCount > 0)
                    Temp = detectTop && countoursY.Min() == 0;
                else
                    Temp = detectTop;

                if (isBig && detectTop && countoursY.Min() == 0)
                    TempIsBig = true;
                if (!isBig && !detectTop && !detectBottom)
                    TempIsBig = false;

                if (!Licenced)
                {
                    if (Count > 100)
                        Count = 0;
                    if (TotalCount > 100)
                        TotalCount = 0;
                }

                if (!TopRect.IsEmpty)
                    CvInvoke.PutText(Frame, Count.ToString(), new Point(TopRect.X + TopRect.Width / 2 - 20, TopRect.Y + TopRect.Height / 2), Emgu.CV.CvEnum.FontFace.HersheySimplex, 1.5, new MCvScalar(0, 0, 0), 3);

                countLbl.Text = Count.ToString();
                totalCountLbl.Text = TotalCount.ToString();
                if(!aimCountBtn.Enabled)
                    aimCountNum.Value = AimCount;

                if (IsVideoRecording)
                {
                    VideoW.Write(Frame);
                }
            }

            pictureBox.Image = Frame.ToBitmap();

            Thread.Sleep(50);
        }

        private void GetRectangles()
        {
            SectionRect = new Rectangle();
            SectionRect.X = Math.Min(StartLocation.X, EndLocation.X);
            SectionRect.Y = Math.Min(StartLocation.Y, EndLocation.Y);
            SectionRect.Width = Math.Abs(StartLocation.X - EndLocation.X);
            SectionRect.Height = Math.Abs(StartLocation.Y - EndLocation.Y);

            TopCountBoxRect = new Rectangle();
            TopCountBoxRect.X = SectionRect.X + SectionRect.Width / 2 - 8;
            TopCountBoxRect.Y = SectionRect.Y;
            TopCountBoxRect.Width = 16;
            TopCountBoxRect.Height = 16;

            BottomCountBoxRect = new Rectangle();
            BottomCountBoxRect.X = TopCountBoxRect.X;
            BottomCountBoxRect.Y = TopCountBoxRect.Y + TopCountBoxRect.Height + DistanceOfBoxes;
            BottomCountBoxRect.Width = TopCountBoxRect.Width;
            BottomCountBoxRect.Height = TopCountBoxRect.Height;
        }

        private void LoadSettings()
        {
            if (!File.Exists("memory.txt"))
                return;

            var data = File.ReadAllLines("memory.txt");
            if (data.Length <= 0)
                return;

            StartLocation.X = Convert.ToInt32(data[0]);
            StartLocation.Y = Convert.ToInt32(data[1]);
            EndLocation.X = StartLocation.X + Convert.ToInt32(data[2]);
            EndLocation.Y = StartLocation.Y + Convert.ToInt32(data[3]);
            ThresholdValue = Convert.ToInt32(data[4]);
            ThresholdValueCountBox = Convert.ToInt32(data[5]);
            MinArea = Convert.ToInt32(data[6]);
            MaxHeight = Convert.ToInt32(data[7]);
            DistanceOfBoxes = Convert.ToInt32(data[8]);
            GetRectangles();
        }

        private void GetSource()
        {
            if (!File.Exists("source.txt"))
                return;

            string source = File.ReadAllText("source.txt");
            if (source.Length <= 0)
                return;

            VideoCapture = new VideoCapture(source);
        }

        private void GetVersion()
        {
            if (!File.Exists("key.txt"))
                return;

            string key = File.ReadAllText("key.txt");
            string macAdress = (
                from nic in NetworkInterface.GetAllNetworkInterfaces()
                where nic.OperationalStatus == OperationalStatus.Up
                select nic.GetPhysicalAddress().ToString()
            ).FirstOrDefault();

            if (GenerateKey(macAdress, "MEKONT") == key)
            {
                Licenced = true;
                fullVersionLbl.Text = "Full Sürüm";
            }

        }

        private string GenerateKey(string id, string param)
        {
            string CharacterSet = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            param = Repeat(param, id.Length);
            string key = "";

            for (int i = 0; i < id.Length; i++)
            {
                int idIndex = CharacterSet.IndexOf(id[i]);
                int paramIndex = CharacterSet.IndexOf(param[i]);
                int keyIndex = idIndex + paramIndex;

                if (keyIndex > CharacterSet.Length - 1)
                    keyIndex = keyIndex - CharacterSet.Length + 1;

                key += CharacterSet[keyIndex];
            }

            return key;
        }

        private string Repeat(string text, int count)
        {
            string result = "";

            int j = 0;
            for (int i = 0; i < count; i++)
            {
                if (j > text.Length - 1)
                    j = 0;
                result += text[j];

                j++;
            }
            return result;
        }

        private void GetTotalCount()
        {
            if (!File.Exists("count.txt"))
                return;

            string data = File.ReadAllText("count.txt");
            if (data.Length <= 0)
                return;

            TotalCount = Convert.ToInt32(data);
        }

        private void startRecordBtn_Click(object sender, EventArgs e)
        {
            if (IsVideoRecording)
            {
                MessageBox.Show("Zaten kayıttasınız!");
                return;
            }

            string plate = Interaction.InputBox("Plaka Giriniz", "Plaka", "Çuval Sayım");

            if (plate == null || plate == "")
            {
                MessageBox.Show("Plaka girmediniz!");
                return;
            }

            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            folderBrowserDialog.ShowDialog();
            string destinationPath = folderBrowserDialog.SelectedPath;

            if (destinationPath == null || destinationPath == "")
            {
                MessageBox.Show("Dosya seçmediniz!");
                return;
            }

            string date = DateTime.Now.ToString("MM-dd-yyyy HH.mm.ss");

            VideoW = new VideoWriter($@"{destinationPath}\{plate} {date}.avi", VideoWriter.Fourcc('D', 'I', 'V', '3'), 20.0, new Size(Frame.Width, Frame.Height), true);
            IsVideoRecording = true;
        }

        private void finishRecordingBtn_Click(object sender, EventArgs e)
        {
            if (!IsVideoRecording)
            {
                MessageBox.Show("Kayıtta değilsiniz!");
                return;
            }

            VideoW.Dispose();
            IsVideoRecording = false;
        }

        private void openSettingsBtn_Click(object sender, EventArgs e)
        {
            string password = Interaction.InputBox("Şifre giriniz", "Şifre");
            if (password != "0000")
            {
                MessageBox.Show("Yanlış şifre!");
                return;
            }

            Form AdminForm = new AdminForm();
            AdminForm.ShowDialog();
        }

        private void loadSettingsBtn_Click(object sender, EventArgs e)
        {
            LoadSettings();
        }

        private void resetBtn_Click(object sender, EventArgs e)
        {
            Count = 0;
            AimCount = 0;
            countLbl.Text = Count.ToString();
            aimCountNum.Value = AimCount;
            aimCountBtn.Enabled = true;
        }

        private void aimCountBtn_Click(object sender, EventArgs e)
        {
            if (!Licenced && AimCount > 50)
            {
                MessageBox.Show("Demo sürümde hedef sayımı 50'den fazla giremezsiniz!");
                return;
            }

            AimCount = Convert.ToInt32(aimCountNum.Value);
            aimCountBtn.Enabled = false;
        }

        private void fullVersionLbl_Click(object sender, EventArgs e)
        {
            if (Licenced)
                return;

            LicenceForm licenceForm = new LicenceForm();
            licenceForm.ShowDialog();
        }

        private void UserForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (Licenced)
                File.WriteAllText("count.txt", TotalCount.ToString());
        }

        private void UserForm_Load(object sender, EventArgs e)
        {

        }
    }
}
