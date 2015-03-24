using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Web.Services;

namespace RestService
{

    public class Service1 : IService1
    {
        public string GetDataUsingMethodName(string value)
        {
            return value + ", I am returned by method name ";
        }


        public string GetDataUsingURI(string value)
        {
            return value + ", I am returned by URI name ";
        }

        public Stream GetImage()
        {
            FileStream image = File.OpenRead(@"C:\Users\Noreen Ward\Pictures\CC.jpg");
            WebOperationContext.Current.OutgoingResponse.ContentType = "image/jpeg";
            return image;
        }

    }
}
