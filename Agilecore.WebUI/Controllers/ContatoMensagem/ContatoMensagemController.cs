using System;                                                                       
using System.Collections.Generic;								                      
using System.Linq;                                                                  
using System.Web;                                                                   
using System.Web.Mvc;                                                               
using Agilecore.Common;                                                   
using Agilecore.Domain;                                                   
                                                                                    
namespace Agilecore.WebUI.Controllers                                     
{                                                                                   
    public class ContatoMensagemController : Base                                 
    {                                                                               
        internal ContatoMensagem _ContatoMensagem { get; set; }                 
                                                                                    
        public ContatoMensagemController()                                        
        {                                                                           
            _ContatoMensagem = new ContatoMensagem();                           
        }                                                                           
                                                                                    
        public ActionResult List()                                                  
        {                                                                           
            var collectionContatoMensagem = _ContatoMensagem.GetAll().ToList(); 
            return View(collectionContatoMensagem);                               
        }                                                                           
                                                                                    
        public ActionResult Create()                                                
        {                                                                           
            return View(new ContatoMensagemDto());                                
        }                                                                           
                                                                                    
        [HttpPost]                                                                  
        public ActionResult Save(ContatoMensagemDto model)                        
        {                                                                           
            if (ModelState.IsValid)                                                 
            {                                                                       
                var ContatoMensagem = new ContatoMensagem();                    
                _ContatoMensagem.Save(model);                                     
                return RedirectToAction("List");                                  
            }                                                                       
            else                                                                    
            {                                                                       
                return RedirectToAction("Create", model);                         
            }                                                                       
        }                                                                           
    }                                                                               
}                                                                                   

