using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace XMLData.Models
{
    public class Photos
    {

    [Key]
    public int PhotoId { get; set; }
    public string File { get; set; }
    public string Caption { get; set; }
    public string TCaption { get; set; }
    public string Date { get; set; }
    public string TFile { get; set; }
    

    }
}