using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace WcfNews
{
    [ServiceContract(Namespace = "INewsOperate")]
    public interface INewsOperate
    {
        bool UpLoadImage();

    }
}
