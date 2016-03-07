using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Threading.Tasks;

namespace WcfNews
{
    [ServiceContract(Namespace = "INewsOperate")]
    public interface INewsOperate
    {
        [OperationContract,
        WebInvoke(Method = "POST", UriTemplate = "/UpLoadImage")]        
        bool UpLoadImage(Stream stream);

    }
}
