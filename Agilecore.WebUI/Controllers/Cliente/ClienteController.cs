using System;                                                                       
using System.Collections.Generic;								                      
using System.Linq;                                                                  
using System.Web;                                                                   
using System.Web.Mvc;                                                               
using Agilecore.Common;                                                   
using Agilecore.Domain;                                                   
                                                                                    
namespace Agilecore.WebUI.Controllers                                     
{                                                                                   
    public class ClienteController : Base                                 
    {                                                                               
        internal Cliente _Cliente { get; set; }                 
                                                                                    
        public ClienteController()                                        
        {                                                                           
            _Cliente = new Cliente();                           
        }                                                                           
                                                                                    
        public ActionResult List()                                                  
        {                                                                           
            var collectionCliente = _Cliente.GetAll().ToList(); 
            return View(collectionCliente);                               
        }                                                                           
                                                                                    
        public ActionResult Create()                                                
        {                                                                           
            return View(new ClienteDto());                                
        }                                                                           
                                                                                    
        [HttpPost]                                                                  
        public ActionResult Save(ClienteDto model)                        
        {                                                                           
            if (ModelState.IsValid)                                                 
            {                                                                       
                var Cliente = new Cliente();                    
                _Cliente.Save(model);                                     
                return RedirectToAction("List");                                  
            }                                                                       
            else                                                                    
            {                                                                       
                return RedirectToAction("Create", model);                         
            }                                                                       
        }                                                                           
    }                                                                               
}                                                                                   

