using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;
using MyTODO_list.Models;
namespace MyTODO_list.Controllers

{
    public class ListController : Controller
    {
        public ActionResult Create()
        {
            TempData["DataList"] = MvcHtmlString.Create("<h3>" + "Create your TODO-list here" + "<a class=\"clear\" href=\"\">Clear all</a>" + "</h3>" + "<br/>");
            var model = new ListItem();
            return Create(model);
        }

        [HttpPost]
        public ActionResult Create(ListItem data)
        {
            if (ModelState.IsValid)
            {
                if(data.Description!=null)
                TempData["DataList"] = MvcHtmlString.Create( $"{TempData["DataList"]} <div class=\"list\"> {data.Description} {data.When.ToString("dd/mm/yyyy")} {data.Duration} min </div>");
            }
            else
            {
                ModelState.AddModelError("",
                "The data you entered was not valid");
            }

            return View();
        }
    }
}