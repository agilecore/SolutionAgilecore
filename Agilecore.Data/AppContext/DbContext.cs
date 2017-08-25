using System.Data.Entity;                                                               
using Agilecore.Common;                                                       
                                                                                        
namespace Agilecore.Data                                                      
{                                                                                       
    public class AgilecoreContext : DbContext                         
    {                                                                                   
             public DbSet<UsuarioDto> Usuario { get; set; }
             public DbSet<PerfilDto> Perfil { get; set; }
             public DbSet<PerfilUsuarioDto> PerfilUsuario { get; set; }
             public DbSet<LogAcessoDto> LogAcesso { get; set; }
             public DbSet<AtuacaoDto> Atuacao { get; set; }
             public DbSet<ContatoDto> Contato { get; set; }
             public DbSet<ContatoMensagemDto> ContatoMensagem { get; set; }
             public DbSet<InstitucionalDto> Institucional { get; set; }
                                                                                         
        static AgilecoreContext()                                      
        {                                                                                
             Database.SetInitializer<AgilecoreContext>(null);          
        }                                                                                
                                                                                         
        public AgilecoreContext() : base("Name = DefaultConnection") 
        {                                                                                
             this.Configuration.AutoDetectChangesEnabled = true;                         
             this.Configuration.ValidateOnSaveEnabled = false;                           
             this.Configuration.LazyLoadingEnabled = false;                              
             this.Configuration.ProxyCreationEnabled = false;                            
             this.Configuration.UseDatabaseNullSemantics = true;                         
        }                                                                                
                                                                                         
        protected override void OnModelCreating(DbModelBuilder ModelBuilder)             
        {                                                                                
             ModelBuilder.Configurations.Add(new UsuarioMapper());   
             ModelBuilder.Configurations.Add(new PerfilMapper());   
             ModelBuilder.Configurations.Add(new PerfilUsuarioMapper());   
             ModelBuilder.Configurations.Add(new LogAcessoMapper());   
             ModelBuilder.Configurations.Add(new AtuacaoMapper());   
             ModelBuilder.Configurations.Add(new ContatoMapper());   
             ModelBuilder.Configurations.Add(new ContatoMensagemMapper());   
             ModelBuilder.Configurations.Add(new InstitucionalMapper());   
        }                                                                                
    }                                                                                    
}                                                                                        

