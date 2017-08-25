using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Agilecore.Data;

namespace Agilecore.Data
{
    public class UnitOfWork                                                                                
    {                                                                                                      
        private AgilecoreContext _dbContext = new AgilecoreContext();  
        public Type _type { get; set; }                                                                    
        public Repository<TEntityType> GetRepository<TEntityType>() where TEntityType : class              
        {                                                                                                  
            return (new Repository<TEntityType>(this._dbContext));                                         
        }                                                                                                  
        public void SaveChage()                                                                            
        {                                                                                                  
            _dbContext.SaveChanges();                                                                      
        }                                                                                                  
        public void SaveChageAsync()                                                                       
        {                                                                                                  
            _dbContext.SaveChangesAsync();                                                                 
        }                                                                                                  
    }                                                                                                      
}                                                                                                          

