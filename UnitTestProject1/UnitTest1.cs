using System;
using System.IO;
using System.Text.RegularExpressions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Drawing;
using System.Runtime.Serialization;
using System.Windows;
using NewImplementation;
using RestSharp;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            const string pattern = @"^[0-9\-\s\(\)]*$";
            
            Regex regex = new Regex(pattern);
            
            const string inputData = @"010-122301dfg1";
            bool isMatch = regex.IsMatch(inputData);

            //"传真格式为:XXX-12345678或1234567"
        }

        [TestMethod]
        public void PostTest()
        {
            //http://stackoverflow.com/questions/9734941/upload-file-from-html-form-multipart-form-data-to-wcf-rest-service-as-a-stream

            var image = System.Drawing.Image.FromFile("C:\\Users\\Guest\\Desktop\\sample.png");
            MemoryStream ms = new MemoryStream();
            image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
            byte[] imageArray = ms.ToArray();
            ms.Close();

            AttachmentRequestDto objAttachmentRequestDto = new AttachmentRequestDto();
            objAttachmentRequestDto.Title = "Sample";
            objAttachmentRequestDto.Description = "Sample book";
            objAttachmentRequestDto.FileName = "SampleBook.png";

            var serializer = new DataContractSerializer(typeof(AttachmentRequestDto));
            var ms2 = new MemoryStream();
            serializer.WriteObject(ms2, objAttachmentRequestDto);
            ms2.Position = 0;
            var reader = new StreamReader(ms2);
            string requestBody = reader.ReadToEnd();

            // http://restsharp.org/
            var client = new RestClient();
            client.BaseUrl = new Uri("http://localhost/SampleService/Service1.svc");
            var request = new RestRequest(Method.POST);
            if (requestBody != null)
                request.AddParameter("objAttachmentRequestDto", requestBody);
            request.AddFile("stream", imageArray, "Array.png");
            var response = client.Execute(request);
        }
    }
}
