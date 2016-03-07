using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewImplementation
{
    public class OperateImage
    {
        public void ParseImage(Stream stream)
        {
            if (!stream.CanRead)
                return;
        }
    }
}


// http://stackoverflow.com/questions/9734941/upload-file-from-html-form-multipart-form-data-to-wcf-rest-service-as-a-stream
// http://stackoverflow.com/questions/27759829/wcf-receive-stream-from-afnetworking/27772504#27772504