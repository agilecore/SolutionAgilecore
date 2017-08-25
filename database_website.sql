create table usuario  
(
    id_usuario			int identity(1,1) primary key            ,
    nome	 			varchar(100) not null	                 ,
    email   			varchar(100) not null                    ,
    senha   			varchar(50)  not null                    ,
	cpf					varchar(30)  not null                    ,
    dt_nascimento  		date not null     	                     ,		
	dt_cadastro  		date not null     	                     ,	
	status   			char(1)	not null       	                 
);                                                               
                                                                 
create table perfil                                              
(                                                                
    id_perfil					int identity(1,1) primary key    ,
    nome	 			        varchar(255) not null	         ,
	dt_cadastro  		        date not null     	             ,	
	status   			        char(1)	not null       	         
);                                                               
                                                                 
create table perfil_usuario                                      
(                                                                
    id_perfil_usuario			int identity(1,1) primary key    , -- id da tabela
    id_usuario	 			    int not null	                 , -- id do usuario que usara o acesso
	id_perfil  					int not null	                 , -- id do perfil que tera acesso
	id_usuario_concedeu         int not null	                 , -- id do usuario que concedeu o acesso
	dt_cadastro  		        date not null                    ,       
	foreign key (id_usuario)    references usuario(id_usuario)   ,
	foreign key (id_perfil)     references perfil(id_perfil)		          
);

create table st_institucional                                              
(                                                                
    id_institucional    		int identity(1,1) primary key    ,
    titulo	 			        varchar(255) not null	         ,
	descricao			        text null						 ,
	dt_cadastro  		        date not null     	             ,	
	ordem                       int not null                     ,
	status   			        char(1)	not null       	         
); 

create table log_acesso  
(
    id_log_acesso			    int identity(1,1) primary key    ,
    ipv6	 			        varchar(100) not null	         ,
	domain	 			        varchar(100) not null	         ,
	browser	 			        varchar(100) not null	         ,
	browser_version  	        varchar(100) not null	         ,
	so  						varchar(100) not null	         ,
	device        	            varchar(100) not null	         ,
    dt_acesso    		        date not null     	             ,	
	status   			        char(1)	not null       	                 
);   

create table st_atuacao                                              
(                                                                
    id_atuacao          		int identity(1,1) primary key    ,
    titulo	 			        varchar(255) not null	         ,
	descricao			        text null	                     ,
	dt_cadastro  		        date not null     	             ,	
	ordem                       int not null                     ,
	status   			        char(1)	not null       	         
); 

create table st_contato                                             
(                                                                
    id_contato          		int identity(1,1) primary key    ,
    titulo	 			        varchar(255) not null	         ,
	dt_cadastro  		        date not null     	             ,	
	status   			        char(1)	not null       	         
); 

create table st_contato_mensagem                                             
(                                                                
    id_contato_mensagem         int identity(1,1) primary key    ,
	id_contato          		int not null				     ,
	email_from                  varchar(100) not null	         ,
	email_to                    varchar(100) not null	         ,
	nome                        varchar(100) not null	         ,
    titulo	 			        varchar(255) not null	         ,
	descricao			        text null	                     ,
	dt_envio     		        date not null     	             ,	
	status   			        char(1)	not null       	         
	foreign key (id_contato)    references st_contato(id_contato),
); 




