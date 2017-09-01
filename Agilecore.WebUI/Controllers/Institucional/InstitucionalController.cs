using System;                                                                       
using System.Collections.Generic;								                      
using System.Linq;                                                                  
using System.Web;                                                                   
using System.Web.Mvc;                                                               
using Agilecore.Common;                                                   
using Agilecore.Domain;                                                   
                                                                                    
namespace Agilecore.WebUI.Controllers                                     
{                                                                                   
    public class InstitucionalController : Base                                 
    {                                                                               
        internal Institucional _Institucional { get; set; }                 
                                                                                    
        public InstitucionalController()                                        
        {                                                                           
            _Institucional = new Institucional();                           
        }

        public ActionResult Index(int Id)
        {
            return View();
        }

        public ActionResult List()                                                  
        {                                                                           
            var collectionInstitucional = _Institucional.GetAll().ToList(); 
            return View(collectionInstitucional);                               
        }                                                                           
                                                                                    
        public ActionResult Create()                                                
        {                                                                           
            return View(new InstitucionalDto());                                
        }                                                                           
                                                                                    
        [HttpPost]                                                                  
        public ActionResult Save(InstitucionalDto model)                        
        {                                                                           
            if (ModelState.IsValid)                                                 
            {                                                                       
                var Institucional = new Institucional();                    
                _Institucional.Save(model);                                     
                return RedirectToAction("List");                                  
            }                                                                       
            else                                                                    
            {                                                                       
                return RedirectToAction("Create", model);                         
            }                                                                       
        }                                                                           
    }                                                                               
}                                                                                   

