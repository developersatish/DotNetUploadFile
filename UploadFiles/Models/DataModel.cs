using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UploadFiles.Models
{
    public class DataModel
    {
        public DataModel()
        {
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public List<HttpPostedFileBase> File { get; set; }
       
    }
}