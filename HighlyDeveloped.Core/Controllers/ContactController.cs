using HighlyDeveloped.Core.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using Umbraco.Web.Mvc;

namespace HighlyDeveloped.Core.Controllers
{/// <summary>
/// This is the stage where we create the controller after creating and 
/// editing the macro files, make sure to inherit from the SurfaceController
/// this class if for all the operations regarding a contact form
/// </summary>
    public class ContactController : SurfaceController
    {
        //Create the action result

        public ActionResult RenderContactForm() 
        {
            //Then return the partial view for contact form that we need to create
            //and pass a view model that we need to create

            var vm = new ContactFormViewModel();
            return PartialView("~/Views/Partials/Contact Form.cshtml", vm);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult HandleContactForm(ContactFormViewModel vm)
        {
            return null;
        }
        
    }
}
