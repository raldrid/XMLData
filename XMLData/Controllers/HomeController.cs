using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Xml;
using XMLData.Models;

namespace XMLData.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index(int id = 1)
        {
            ViewBag.Title = "Santa Catalina Mountains, Tucson, AZ";
            List<Photos> photos = new List<Photos>();
            XmlDocument doc = new XmlDocument();
            doc.Load(Server.MapPath("~/App_Data/SantaCatalinaPhotos.xml"));
            foreach(XmlNode node in doc.SelectNodes("/photos/photo"))
            {
                photos.Add(new Photos
                {
                    PhotoId = int.Parse(node["id"].InnerText),
                    File = node["file"].InnerText, 
                    Caption = node["caption"].InnerText,
                    TCaption = node["tcaption"].InnerText,
                    Date = node["date"].InnerText,
                    TFile = node["tfile"].InnerText 
                });
            }
            ViewBag.PhotoCount = photos.Count;
            return View(photos.Where(p => p.PhotoId == id));
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}