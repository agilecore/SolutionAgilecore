using System;                                                                       
using System.Collections.Generic;								                      
using System.Linq;                                                                  
using System.Web;                                                                   
using System.Web.Mvc;                                                               
using Agilecore.Common;                                                   
using Agilecore.Domain;                                                   
                                                                                    
namespace Agilecore.WebUI.Controllers                                     
{                                                                                   
    public class ContatoController : Base                                 
    {                                                                               
        internal Contato _Contato { get; set; }                 
                                                                                    
        public ContatoController()                                        
        {                                                                           
            _Contato = new Contato();                           
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult List()                                                  
        {                                                                           
            var collectionContato = _Contato.GetAll().ToList(); 
            return View(collectionContato);                               
        }                                                                           
                                                                                    
        public ActionResult Create()                                                
        {                                                                           
            return View(new ContatoDto());                                
        }                                                                           
                                                                                    
        [HttpPost]                                                                  
        public ActionResult Save(ContatoDto model)                        
        {                                                                           
            if (ModelState.IsValid)                                                 
            {                                                                       
                var Contato = new Contato();                    
                _Contato.Save(model);                                     
                return RedirectToAction("List");                                  
            }                                                                       
            else                                                                    
            {                                                                       
                return RedirectToAction("Create", model);                         
            }                                                                       
        }                                                                           
    }                                                                               
}                                                                                   

