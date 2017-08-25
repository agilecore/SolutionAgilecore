using System;                                                                       
using System.Collections.Generic;								                      
using System.Linq;                                                                  
using System.Web;                                                                   
using System.Web.Mvc;                                                               
using Agilecore.Common;                                                   
using Agilecore.Domain;                                                   
                                                                                    
namespace Agilecore.WebUI.Controllers                                     
{                                                                                   
    public class AtuacaoController : Base                                 
    {                                                                               
        internal Atuacao _Atuacao { get; set; }                 
                                                                                    
        public AtuacaoController()                                        
        {                                                                           
            _Atuacao = new Atuacao();                           
        }                                                                           
                                                                                    
        public ActionResult List()                                                  
        {                                                                           
            var collectionAtuacao = _Atuacao.GetAll().ToList(); 
            return View(collectionAtuacao);                               
        }                                                                           
                                                                                    
        public ActionResult Create()                                                
        {                                                                           
            return View(new AtuacaoDto());                                
        }                                                                           
                                                                                    
        [HttpPost]                                                                  
        public ActionResult Save(AtuacaoDto model)                        
        {                                                                           
            if (ModelState.IsValid)                                                 
            {                                                                       
                var Atuacao = new Atuacao();                    
                _Atuacao.Save(model);                                     
                return RedirectToAction("List");                                  
            }                                                                       
            else                                                                    
            {                                                                       
                return RedirectToAction("Create", model);                         
            }                                                                       
        }                                                                           
    }                                                                               
}                                                                                   

