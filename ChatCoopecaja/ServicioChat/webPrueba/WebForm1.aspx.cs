using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using System.Web.Hosting;

namespace webPrueba
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string FilePath = HostingEnvironment.MapPath("~/Files");

            int length = 0;
            using (FileStream writer = new FileStream(FilePath, FileMode.Create))
            {
                //    int readCount;
                //    var buffer = new byte[8192];
                //    while ((readCount = stream.Read(buffer, 0, buffer.Length)) != 0)
                //    {
                //        writer.Write(buffer, 0, readCount);
                //        length += readCount;
                //    }
            }
        }
    }
}