using System;                                                                       
using System.Collections.Generic;								                      
using System.Linq;                                                                  
using System.Web;                                                                   
using System.Web.Mvc;                                                               
using Agilecore.Common;                                                   
using Agilecore.Domain;                                                   
                                                                                    
namespace Agilecore.WebUI.Controllers                                     
{                                                                                   
    public class DeliveryController : Base                                 
    {                                                                               
        internal Delivery _Delivery { get; set; }                 
                                                                                    
        public DeliveryController()                                        
        {                                                                           
            _Delivery = new Delivery();                           
        }                                                                           
                                                                                    
        public ActionResult List()                                                  
        {                                                                           
            var collectionDelivery = _Delivery.GetAll().ToList(); 
            return View(collectionDelivery);                               
        }                                                                           
                                                                                    
        public ActionResult Create()                                                
        {                                                                           
            return View(new DeliveryDto());                                
        }                                                                           
                                                                                    
        [HttpPost]                                                                  
        public ActionResult Save(DeliveryDto model)                        
        {                                                                           
            if (ModelState.IsValid)                                                 
            {                                                                       
                var Delivery = new Delivery();                    
                _Delivery.Save(model);                                     
                return RedirectToAction("List");                                  
            }                                                                       
            else                                                                    
            {                                                                       
                return RedirectToAction("Create", model);                         
            }                                                                       
        }                                                                           
    }                                                                               
}                                                                                   

