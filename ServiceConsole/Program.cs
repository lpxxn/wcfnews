using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using NewImplementation;


namespace ServiceConsole
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                using (var host = new ServiceHost(typeof(NewsOperate)))
                {
                    host.Opened += host_Opened;
                    host.Open();
                    Console.ReadLine();
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.ToString());
                Console.ReadLine();
            }
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

        static void host_Opened(object sender, EventArgs e)
        {
            Console.WriteLine("Service Runing....");
        }
    }
}
