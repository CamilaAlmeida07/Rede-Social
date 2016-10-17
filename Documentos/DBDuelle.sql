CREATE TABLE usuario 
( 
	idUser varchar(10) primary key,
	senha  varchar(16) not null,
	tipo   varchar(10) not null,
	nome   varchar(50) not null
);

CREATE TABLE ranking
(
	idUser varchar(10) primary key, 
	posicao int not null,
	pontos int default 0 not null,
	vitorias int default 0 not null,
	duelos int default 0 not null
);