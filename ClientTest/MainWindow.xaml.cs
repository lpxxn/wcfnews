using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ClientTest
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void PostMethod()
        {
            //http://stackoverflow.com/questions/9734941/upload-file-from-html-form-multipart-form-data-to-wcf-rest-service-as-a-stream

//            Image image = Image.FromFile("C:\\Users\\Guest\\Desktop\\sample.png");
//            MemoryStream ms = new MemoryStream();
//            image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
//            byte[] imageArray = ms.ToArray();
//            ms.Close();
//
//            AttachmentRequestDto objAttachmentRequestDto = new AttachmentRequestDto();
//            objAttachmentRequestDto.Title = "Sample";
//            objAttachmentRequestDto.Description = "Sample book";
//            objAttachmentRequestDto.FileName = "SampleBook.png";
//
//            var serializer = new DataContractSerializer(typeof(AttachmentRequestDto));
//            var ms = new MemoryStream();
//            serializer.WriteObject(ms, objAttachmentRequestDto);
//            ms.Position = 0;
//            var reader = new StreamReader(ms);
//            string requestBody = reader.ReadToEnd();
//
//            var client = new RestClient();
//            client.BaseUrl = "http://localhost/SampleService/Service1.svc";
//            var request = new RestRequest(method) { DateFormat = DataFormat.Xml.ToString(), Resource = resourceUrl };
//            if (requestBody != null)
//                request.AddParameter("objAttachmentRequestDto", requestBody);
//            request.AddFile("stream", image, "Array.png");
//            var response = client.Execute(request);
        }
    }
}
