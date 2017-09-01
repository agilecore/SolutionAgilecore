using System;                                                                       
using System.Collections.Generic;								                      
using System.Linq;                                                                  
using System.Web;                                                                   
using System.Web.Mvc;                                                               
using Agilecore.Common;                                                   
using Agilecore.Domain;                                                   
                                                                                    
namespace Agilecore.WebUI.Controllers                                     
{                                                                                   
    public class ProjetoController : Base                                 
    {                                                                               
        internal Projeto _Projeto { get; set; }                 
                                                                                    
        public ProjetoController()                                        
        {                                                                           
            _Projeto = new Projeto();                           
        }                                                                           
                                                                                    
        public ActionResult List()                                                  
        {                                                                           
            var collectionProjeto = _Projeto.GetAll().ToList(); 
            return View(collectionProjeto);                               
        }                                                                           
                                                                                    
        public ActionResult Create()                                                
        {                                                                           
            return View(new ProjetoDto());                                
        }                                                                           
                                                                                    
        [HttpPost]                                                                  
        public ActionResult Save(ProjetoDto model)                        
        {                                                                           
            if (ModelState.IsValid)                                                 
            {                                                                       
                var Projeto = new Projeto();                    
                _Projeto.Save(model);                                     
                return RedirectToAction("List");                                  
            }                                                                       
            else                                                                    
            {                                                                       
                return RedirectToAction("Create", model);                         
            }                                                                       
        }                                                                           
    }                                                                               
}                                                                                   

