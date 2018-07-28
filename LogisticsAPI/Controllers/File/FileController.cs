using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LogisticsAPI.Controllers.File
{
    public class FileController : Controller
    {
        //
        // GET: /FileController/

        public ActionResult Version(string _fileName)
        {
            string file = System.AppDomain.CurrentDomain.SetupInformation.ApplicationBase +
                          @"Update\" + _fileName;
            if (System.IO.File.Exists(file))
            {
                FileVersionInfo fv =
                    FileVersionInfo.GetVersionInfo(file);
                return Content(fv.FileVersion);
            }
            else
            {
                return Content("0.0");
            }
        }
    }
}
