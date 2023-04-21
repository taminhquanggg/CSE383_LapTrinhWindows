using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Threading;
using System.Diagnostics;
using Emgu.CV;
using Emgu.CV.Structure;
using Emgu.CV.Face;
using Emgu.CV.CvEnum;

namespace FaceRecognitionApp
{
    public partial class Form1 : Form
    {
        #region Variables
        int testid = 0;
        private Capture videoCapture = null;
        private Image<Bgr, Byte> currentFrame = null;
        Mat frame = new Mat();
        private bool facesDetectionEnabled = false;
        CascadeClassifier faceCasacdeClassifier = new CascadeClassifier(@"D:\project\CSharp\FaceRecognitionApp\FaceRecognitionApp\haarcascade_frontalface_alt.xml");
        Image<Bgr, Byte> faceResult = null;
        List<Image<Gray, Byte>> TrainedFaces = new List<Image<Gray, byte>>();
        List<int> PersonsLabes = new List<int>();

        bool EnableSaveImage = false;
        private bool isTrained = false;
        EigenFaceRecognizer recognizer;

        List<string> PersonsNames = new List<string>();

        #endregion

        public Form1()
        {
            InitializeComponent();
        }

        private void ProcessFrame(object sender, EventArgs e)
        {
            //Step 1: Video Capture
            if (videoCapture != null && videoCapture.Ptr != IntPtr.Zero)
            {
                videoCapture.Retrieve(frame, 0);
                currentFrame = frame.ToImage<Bgr, Byte>().Resize(pic_Capture.Width, pic_Capture.Height, Inter.Cubic);

                //Step 2: Face Detection
                if (facesDetectionEnabled)
                {

                    //Convert from Bgr to Gray Image
                    Mat grayImage = new Mat();
                    CvInvoke.CvtColor(currentFrame, grayImage, ColorConversion.Bgr2Gray);
                    //Enhance the image to get better result
                    CvInvoke.EqualizeHist(grayImage, grayImage);

                    Rectangle[] faces = faceCasacdeClassifier.DetectMultiScale(grayImage, 1.1, 3, Size.Empty, Size.Empty);
                    //If faces detected
                    if (faces.Length > 0)
                    {

                        foreach (var face in faces)
                        {
                            //Draw square around each face 
                            // CvInvoke.Rectangle(currentFrame, face, new Bgr(Color.Red).MCvScalar, 2);

                            //Step 3: Add Person 
                            //Assign the face to the picture Box face picDetected
                            Image<Bgr, Byte> resultImage = currentFrame.Convert<Bgr, Byte>();
                            resultImage.ROI = face;
                            pic_Detected.SizeMode = PictureBoxSizeMode.StretchImage;
                            pic_Detected.Image = resultImage.Bitmap;

                            if (EnableSaveImage)
                            {
                                //We will create a directory if does not exists!
                                string path = Directory.GetCurrentDirectory() + @"\TrainedImages";
                                if (!Directory.Exists(path))
                                    Directory.CreateDirectory(path);
                                //we will save 10 images with delay a second for each image 
                                //to avoid hang GUI we will create a new task
                                Task.Factory.StartNew(() => {
                                    for (int i = 0; i < 10; i++)
                                    {
                                        //resize the image then saving it
                                        resultImage.Resize(200, 200, Inter.Cubic).Save(path + @"\" + tb_Name.Text + "_" + DateTime.Now.ToString("dd-mm-yyyy-hh-mm-ss") + ".jpg");
                                        Thread.Sleep(1000);
                                    }
                                });

                            }
                            EnableSaveImage = false;

                            if (btn_Add.InvokeRequired)
                            {
                                btn_Add.Invoke(new ThreadStart(delegate {
                                    btn_Add.Enabled = true;
                                }));
                            }

                            // Step 5: Recognize the face 
                            if (isTrained)
                            {
                                Image<Gray, Byte> grayFaceResult = resultImage.Convert<Gray, Byte>().Resize(200, 200, Inter.Cubic);
                                CvInvoke.EqualizeHist(grayFaceResult, grayFaceResult);
                                var result = recognizer.Predict(grayFaceResult);
                                pictureBox1.Image = grayFaceResult.Bitmap;
                                pictureBox2.Image = TrainedFaces[result.Label].Bitmap;
                                Debug.WriteLine(result.Label + ". " + result.Distance);
                                //Here results found known faces
                                if (result.Label != -1 && result.Distance < 2000)
                                {
                                    CvInvoke.PutText(currentFrame, PersonsNames[result.Label], new Point(face.X - 2, face.Y - 2),
                                        FontFace.HersheyComplex, 1.0, new Bgr(Color.Orange).MCvScalar);
                                    CvInvoke.Rectangle(currentFrame, face, new Bgr(Color.Green).MCvScalar, 2);
                                }
                                //here results did not found any know faces
                                else
                                {
                                    CvInvoke.PutText(currentFrame, "Unknown", new Point(face.X - 2, face.Y - 2),
                                        FontFace.HersheyComplex, 1.0, new Bgr(Color.Orange).MCvScalar);
                                    CvInvoke.Rectangle(currentFrame, face, new Bgr(Color.Red).MCvScalar, 2);

                                }
                            }
                        }
                    }
                }

                //Render the video capture into the Picture Box picCapture
                pic_Capture.Image = currentFrame.Bitmap;
            }

            //Dispose the Current Frame after processing it to reduce the memory consumption.
            if (currentFrame != null)
                currentFrame.Dispose();
        }

        
        //Step 4: train Images .. we will use the saved images from the previous example 
        private bool TrainImagesFromDir()
        {
            int ImagesCount = 0;
            double Threshold = 2000;
            TrainedFaces.Clear();
            PersonsLabes.Clear();
            PersonsNames.Clear();
            try
            {
                string path = Directory.GetCurrentDirectory() + @"\TrainedImages";
                string[] files = Directory.GetFiles(path, "*.jpg", SearchOption.AllDirectories);

                foreach (var file in files)
                {
                    Image<Gray, byte> trainedImage = new Image<Gray, byte>(file).Resize(200, 200, Inter.Cubic);
                    CvInvoke.EqualizeHist(trainedImage, trainedImage);
                    TrainedFaces.Add(trainedImage);
                    PersonsLabes.Add(ImagesCount);
                    string name = file.Split('\\').Last().Split('_')[0];
                    PersonsNames.Add(name);
                    ImagesCount++;
                    Debug.WriteLine(ImagesCount + ". " + name);

                }

                if (TrainedFaces.Count() > 0)
                {
                    // recognizer = new EigenFaceRecognizer(ImagesCount,Threshold);
                    recognizer = new EigenFaceRecognizer(ImagesCount, Threshold);
                    recognizer.Train(TrainedFaces.ToArray(), PersonsLabes.ToArray());

                    isTrained = true;
                    //Debug.WriteLine(ImagesCount);
                    //Debug.WriteLine(isTrained);
                    return true;
                }
                else
                {
                    isTrained = false;
                    return false;
                }
            }
            catch (Exception ex)
            {
                isTrained = false;
                MessageBox.Show("Error in Train Images: " + ex.Message);
                return false;
            }

        }

        private void btn_Capture_Click(object sender, EventArgs e)
        {
            //Dispose of Capture if it was created before
            if (videoCapture != null) videoCapture.Dispose();
            videoCapture = new Capture();
            //videoCapture.ImageGrabbed += ProcessFrame;
            Application.Idle += ProcessFrame;
            // videoCapture.Start();
        }

        private void btn_Detect_Click(object sender, EventArgs e)
        {
            facesDetectionEnabled = true;
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            btn_Add.Enabled = false;
            EnableSaveImage = true;
        }

        private void btn_Train_Click(object sender, EventArgs e)
        {
            TrainImagesFromDir();
        }






        //#region Variables
        //private Capture _videoCapture = null;
        //private Image<Bgr, Byte> _curentFrame = null;
        //Mat _frame = new Mat();
        //private bool _faceDetectEnabled = false;
        //CascadeClassifier _faceCasacdeClassifier = new CascadeClassifier(@"D:\project\CSharp\FaceRecognitionApp\FaceRecognitionApp\haarcascade_frontalface_alt.xml");
        //bool _enableSaveImg = false;
        //private static bool _isTrained = false;
        //EigenFaceRecognizer _recognizer;

        //private static List<Image<Gray, Byte>> _TrainedFaces = new List<Image<Gray, byte>>();
        //private static List<int> _PersonsLabes = new List<int>();
        //private static List<string> _PersonsNames = new List<string>();

        //#endregion
        //public Form1()
        //{
        //    InitializeComponent();
        //}

        //private void btn_Capture_Click(object sender, EventArgs e)
        //{
        //    _videoCapture = new Capture();
        //    _videoCapture.ImageGrabbed += ProcessFrame;
        //    _videoCapture.Start();
        //}

        //private void ProcessFrame(object sender, EventArgs e)
        //{
        //    //Step 1: Video capture
        //    _videoCapture.Retrieve(_frame, 0);
        //    _curentFrame = _frame.ToImage<Bgr, Byte>().Resize(pic_Capture.Width, pic_Capture.Height, Inter.Cubic);

        //    //Step 2: Face detection 
        //    if (_faceDetectEnabled)
        //    {
        //        //Convert from Bgr to Gray Image
        //        Mat _grayImage = new Mat();
        //        CvInvoke.CvtColor(_curentFrame, _grayImage, ColorConversion.Bgr2Gray);
        //        //Enhance the image to get better result 
        //        CvInvoke.EqualizeHist(_grayImage, _grayImage);

        //        Rectangle[] _faces = _faceCasacdeClassifier.DetectMultiScale(_grayImage, 1.1, 3, Size.Empty, Size.Empty);
        //        //If faces detected 
        //        if (_faces.Length > 0)
        //        {
        //            int _faceID = 0;
        //            //Draw square around each face
        //            foreach (var _face in _faces)
        //            {
        //                //Draw square around each face
        //                CvInvoke.Rectangle(_curentFrame, _face, new Bgr(Color.Green).MCvScalar, 2);


        //                //Step 3: Add Person
        //                //Assign the face to the picture Box face pic_Detected
        //                Image<Bgr, Byte> _resultImage = _curentFrame.Convert<Bgr, Byte>();
        //                _resultImage.ROI = _face;
        //                pic_Detected.SizeMode = PictureBoxSizeMode.StretchImage;
        //                pic_Detected.Image = _resultImage.Bitmap;

        //                if (_enableSaveImg)
        //                {
        //                    //Create a directory if does not exitst

        //                    string _path = Directory.GetCurrentDirectory() + @"\TrainedImages";
        //                    if (!Directory.Exists(_path))
        //                    {
        //                        Directory.CreateDirectory(_path);
        //                    }
        //                    Task.Factory.StartNew(() =>
        //                    {
        //                        for (int i = 0; i < 10; i++)
        //                        {
        //                            //resize the image when saving
        //                            _resultImage.Resize(200, 200, Inter.Cubic).Save(_path + @"\" + tb_Name.Text + "_" + DateTime.Now.ToString("dd-mm-yyyy-hh-mm-ss") + ".jpg");
        //                            Thread.Sleep(1000);
        //                    }
        //                    });
        //                    //save 10 images with delay a second for each image

        //                }
        //                _enableSaveImg = false;

        //                if (btn_Add.InvokeRequired)
        //                {
        //                    btn_Add.Invoke(new ThreadStart(delegate
        //                    {
        //                        btn_Add.Enabled = true;
        //                    }));
        //                }

        //                //step 5: recognize the face
        //                if (_isTrained)
        //                {
        //                    Image<Gray, Byte> _grayFaceResult = _resultImage.Convert<Gray, Byte>().Resize(200, 200, Inter.Cubic);
        //                    CvInvoke.EqualizeHist(_grayFaceResult, _grayFaceResult);

        //                    var _result = _recognizer.Predict(_grayFaceResult);
        //                    pictureBox1.Image = _grayFaceResult.Bitmap;
        //                    pictureBox2.Image = _TrainedFaces[_result.Label].Bitmap;

        //                    Debug.Write(_result.Label + ". " + _result.Distance);


        //                    //Results found known faces
        //                    if (_result.Label != -1 && _result.Distance < 2000)
        //                    {
        //                        CvInvoke.PutText(_curentFrame, _PersonsNames[_result.Label], new Point(_face.X - 2, _face.Y - 2),
        //                            FontFace.HersheyComplex, 1.0, new Bgr(Color.Orange).MCvScalar);

        //                        CvInvoke.Rectangle(_curentFrame, _face, new Bgr(Color.Green).MCvScalar, 2);
        //                    }
        //                    //Result did not found any known faces
        //                    else
        //                    {
        //                        CvInvoke.PutText(_curentFrame, "Unknown", new Point(_face.X - 2, _face.Y - 2),
        //                            FontFace.HersheyComplex, 1.0, new Bgr(Color.Orange).MCvScalar);
        //                    }
        //                }
        //            }   
        //        }
        //    }

        //    //Render the video capture into the Picture Box
        //    pic_Capture.Image = _curentFrame.Bitmap;



        //}

        //private void btn_Detect_Click(object sender, EventArgs e)
        //{
        //    _faceDetectEnabled = true;


        //}

        //private void btn_Add_Click(object sender, EventArgs e)
        //{
        //    btn_Add.Enabled = false;
        //    _enableSaveImg = true;
        //}

        //private void btn_Train_Click(object sender, EventArgs e)
        //{
        //    TrainImagesFromDir();
        //}

        ////Step 4: train Images ... use the saved images from the previous example
        //private static bool TrainImagesFromDir()
        //{
        //    int _ImagesCount = 0;
        //    double _threshold = -1;
        //    _TrainedFaces.Clear();
        //    _PersonsLabes.Clear();
        //    try
        //    {
        //        string _path = Directory.GetCurrentDirectory() + @"\TrainedImages\";
        //        string[] _files = Directory.GetFiles(_path, "*.jpg", SearchOption.AllDirectories);

        //        foreach (var _file in _files)
        //        {
        //            Image<Gray, Byte> _trainedImage = new Image<Gray, byte>(_file);
        //            _TrainedFaces.Add(_trainedImage);
        //            _PersonsLabes.Add(_ImagesCount);

        //            _ImagesCount++;

        //        }

        //        EigenFaceRecognizer _recognizer = new EigenFaceRecognizer(_ImagesCount, _threshold);
        //        _recognizer.Train(_TrainedFaces.ToArray(), _PersonsLabes.ToArray());

        //        _isTrained = true;

        //        return true;
        //    }
        //    catch(Exception ex)
        //    {
        //        _isTrained = false;
        //        MessageBox.Show("Error is Train Images: " + ex.Message);
        //        return false;
        //    }


        //}
    }
}
