CREATE TABLE Usuario(
	idUser INT IDENTITY PRIMARY KEY,
	email VARCHAR(150) UNIQUE,
	senha VARCHAR(20),
	tipo VARCHAR(20),
	nome VARCHAR(100)
);

CREATE TABLE Ranking(
	idUser INT PRIMARY KEY,
	pontos INT,
	vitoriaS INT,
	duelos INT,
	FOREIGN KEY(idUser) REFERENCES Usuario (idUser)
);

CREATE TABLE Amizade(
	idUserA INT,
	idUserB INT,
	inicio DATE,
	PRIMARY KEY (idUserA, idUserB),
	FOREIGN KEY(idUserA) REFERENCES Usuario (idUser),
	FOREIGN KEY(idUserB) REFERENCES Usuario (idUser)
);

CREATE TABLE Postagem(
	idPostagem INT IDENTITY PRIMARY KEY,
	idUser INT,
	data DATE,
	curtidas INT DEFAULT '0',
	conteudo VARCHAR(300),
	FOREIGN KEY(idUser) REFERENCES Usuario (idUser)
);

CREATE TABLE Duelo(
	idDuelo INT IDENTITY PRIMARY KEY,
	idCriador INT,
	tipo VARCHAR(20),
	inicio DATE,
	termino DATE,
	FOREIGN KEY(idCriador) REFERENCES Usuario (idUser)
);

CREATE TABLE Inscricao(
	idInscricao INT IDENTITY PRIMARY KEY,
	idUser INT,
	idDuelo INT,
	data DATE,
	pontuacao INT,
	FOREIGN KEY(idUser) REFERENCES Usuario (idUser),
	FOREIGN KEY(idDuelo) REFERENCES Duelo (idDuelo)
);

