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

INSERT INTO Usuario (Email,Senha,Tipo,Nome)VALUES('victor@gmail.com','escobar123','Artista','Victor Escobar');
INSERT INTO Usuario (Email,Senha,Tipo,Nome)VALUES('renato@gmail.com','renato2112','Artista','Renato Loureiro');
INSERT INTO Usuario (Email,Senha,Tipo,Nome)VALUES('camila@gmail.com','camila321','Artista','Camila Almeida');
INSERT INTO Usuario (Email,Senha,Tipo,Nome)VALUES('emersongondin@gmail.com','bolivamonstro','Artista','Emerson Gondin');
INSERT INTO Usuario (Email,Senha,Tipo,Nome)VALUES('grazicampesi@gmail.com','grazipikachu','Artista','Grazieli Campesi');
INSERT INTO Usuario (Email,Senha,Tipo,Nome)VALUES('banda_rush@gmail.com','rushband','Banda','Rush');
INSERT INTO Usuario (Email,Senha,Tipo,Nome)VALUES('banda_led_zeppelin@gmail.com','ledzep','Banda','Led Zeppelin');
INSERT INTO Usuario (Email,Senha,Tipo,Nome)VALUES('banda_deep_purple@gmail.com','deepurple','Banda','Deep Purple');
INSERT INTO Usuario (Email,Senha,Tipo,Nome)VALUES('banda_pearl_jam@gmail.com','pearljam1990','Banda','Pearl Jam');
INSERT INTO Usuario (Email,Senha,Tipo,Nome)VALUES('banda_calypso@gmail.com','bandacalypso','Banda','Calypso');


INSERT INTO Postagem (IdUser, Data,Curtidas,Conteudo) VALUES (1, '10-11-2016', 26, 'https://www.youtube.com/embed/8BdYe3FPYRk');
INSERT INTO Postagem (IdUser, Data,Curtidas,Conteudo) VALUES (1, '11-11-2016', 10, 'https://www.youtube.com/embed/fA8kZCM5qsE');
INSERT INTO Postagem (IdUser, Data,Curtidas,Conteudo) VALUES (1, '12-10-2016', 5, 'https://www.youtube.com/embed/NznnI2cfS_8');
INSERT INTO Postagem (IdUser, Data,Curtidas,Conteudo) VALUES (1, '13-11-2016', 9, 'https://www.youtube.com/embed/xtk5q1N8tyQ');
INSERT INTO Postagem (IdUser, Data,Curtidas,Conteudo) VALUES (1, '14-11-2016', 30, 'https://www.youtube.com/embed/QVF_w5XvlLg');

INSERT INTO Postagem (IdUser, Data,Curtidas,Conteudo) VALUES (2, '10-11-2016', 11, 'https://www.youtube.com/embed/uwndjcH4mh8');
INSERT INTO Postagem (IdUser, Data,Curtidas,Conteudo) VALUES (2, '13-11-2016', 12, 'https://www.youtube.com/embed/RzLKxo0lJtA');
INSERT INTO Postagem (IdUser, Data,Curtidas,Conteudo) VALUES (2, '19-10-2016', 56, 'https://www.youtube.com/embed/6zQjt0AB8Vc');
INSERT INTO Postagem (IdUser, Data,Curtidas,Conteudo) VALUES (2, '21-11-2016', 96, 'https://www.youtube.com/embed/Z45rHn0G-IA');
INSERT INTO Postagem (IdUser, Data,Curtidas,Conteudo) VALUES (2, '25-11-2016', 20, 'https://www.youtube.com/embed/hwXCpG9za_Y');

INSERT INTO Postagem (IdUser, Data,Curtidas,Conteudo) VALUES (3, '10-11-2016', 57, 'https://www.youtube.com/embed/aNZihxUenUI');
INSERT INTO Postagem (IdUser, Data,Curtidas,Conteudo) VALUES (3, '12-11-2016', 23, 'https://www.youtube.com/embed/UXkLokXsK28');
INSERT INTO Postagem (IdUser, Data,Curtidas,Conteudo) VALUES (3, '14-10-2016', 12, 'https://www.youtube.com/embed/Wn-fQW2kIWQ');
INSERT INTO Postagem (IdUser, Data,Curtidas,Conteudo) VALUES (3, '18-11-2016', 31, 'https://www.youtube.com/embed/0Gu9RMUpnko');
INSERT INTO Postagem (IdUser, Data,Curtidas,Conteudo) VALUES (3, '21-11-2016', 12, 'https://www.youtube.com/embed/uNxBeJNyAqA');

INSERT INTO Postagem (IdUser, Data,Curtidas,Conteudo) VALUES (4, '10-11-2016', 15, 'https://www.youtube.com/embed/5P0xD3d74SI');
INSERT INTO Postagem (IdUser, Data,Curtidas,Conteudo) VALUES (4, '01-11-2016', 14, 'https://www.youtube.com/embed/zfFhsmymcu0');
INSERT INTO Postagem (IdUser, Data,Curtidas,Conteudo) VALUES (4, '14-10-2016', 56, 'https://www.youtube.com/embed/w19lMBU6-ws');
INSERT INTO Postagem (IdUser, Data,Curtidas,Conteudo) VALUES (4, '16-10-2016', 26, 'https://www.youtube.com/embed/JZzOpKa8cfE');
INSERT INTO Postagem (IdUser, Data,Curtidas,Conteudo) VALUES (4, '10-11-2016', 10, 'https://www.youtube.com/embed/W7RGAE3lUos');

INSERT INTO Postagem (IdUser, Data,Curtidas,Conteudo) VALUES (5, '10-11-2016', 14, 'https://www.youtube.com/embed/6PahLq2daio');
INSERT INTO Postagem (IdUser, Data,Curtidas,Conteudo) VALUES (5, '01-11-2016', 19, 'https://www.youtube.com/embed/gs2hokF-Qtk');
INSERT INTO Postagem (IdUser, Data,Curtidas,Conteudo) VALUES (5, '14-10-2016', 29, 'https://www.youtube.com/embed/9-hJU-68pFQ');
INSERT INTO Postagem (IdUser, Data,Curtidas,Conteudo) VALUES (5, '16-10-2016', 59, 'https://www.youtube.com/embed/Ddn4MGaS3N4');
INSERT INTO Postagem (IdUser, Data,Curtidas,Conteudo) VALUES (5, '10-11-2016', 20, 'https://www.youtube.com/embed/JsD6uEZsIsU');

INSERT INTO Postagem (IdUser, Data,Curtidas,Conteudo) VALUES (6, '10-11-2016', 14, 'https://www.youtube.com/embed/1eSlvoO3Vw8');
INSERT INTO Postagem (IdUser, Data,Curtidas,Conteudo) VALUES (6, '01-11-2016', 19, 'https://www.youtube.com/embed/FFpZFnJ6ZT8');
INSERT INTO Postagem (IdUser, Data,Curtidas,Conteudo) VALUES (6, '14-10-2016', 29, 'https://www.youtube.com/embed/LWRMOJQDiLU');
INSERT INTO Postagem (IdUser, Data,Curtidas,Conteudo) VALUES (6, '16-10-2016', 59, 'https://www.youtube.com/embed/WJoTxywiRG0');
INSERT INTO Postagem (IdUser, Data,Curtidas,Conteudo) VALUES (6, '10-11-2016', 20, 'https://www.youtube.com/embed/HXKoZxi1cUU');

INSERT INTO Postagem (IdUser, Data,Curtidas,Conteudo) VALUES (7, '10-11-2016', 14, 'https://www.youtube.com/embed/9Q7Vr3yQYWQ');
INSERT INTO Postagem (IdUser, Data,Curtidas,Conteudo) VALUES (7, '01-11-2016', 19, 'https://www.youtube.com/embed/uiLKT5rPHBA');
INSERT INTO Postagem (IdUser, Data,Curtidas,Conteudo) VALUES (7, '14-10-2016', 29, 'https://www.youtube.com/embed/jtN8oBjMr_E');
INSERT INTO Postagem (IdUser, Data,Curtidas,Conteudo) VALUES (7, '16-10-2016', 59, 'https://www.youtube.com/embed/RlNhD0oS5pk');
INSERT INTO Postagem (IdUser, Data,Curtidas,Conteudo) VALUES (7, '10-11-2016', 20, 'https://www.youtube.com/embed/hW_WLxseq0o');

INSERT INTO Postagem (IdUser, Data,Curtidas,Conteudo) VALUES (8, '10-11-2016', 14, 'https://www.youtube.com/embed/s1sAkZF7SCQ');
INSERT INTO Postagem (IdUser, Data,Curtidas,Conteudo) VALUES (8, '01-11-2016', 19, 'https://www.youtube.com/embed/BxgVpSVpH6Y');
INSERT INTO Postagem (IdUser, Data,Curtidas,Conteudo) VALUES (8, '14-10-2016', 29, 'https://www.youtube.com/embed/DE9WUxyyAs');
INSERT INTO Postagem (IdUser, Data,Curtidas,Conteudo) VALUES (8, '16-10-2016', 59, 'https://www.youtube.com/embed/5GsqL_xlkh0');
INSERT INTO Postagem (IdUser, Data,Curtidas,Conteudo) VALUES (8, '10-11-2016', 20, 'https://www.youtube.com/embed/JfwpJFS6Pgk');

INSERT INTO Postagem (IdUser, Data,Curtidas,Conteudo) VALUES (9, '10-11-2016', 14, 'https://www.youtube.com/embed/n3r9KWth84Y');
INSERT INTO Postagem (IdUser, Data,Curtidas,Conteudo) VALUES (9, '01-11-2016', 19, 'https://www.youtube.com/embed/n_jF_2YwpoM');
INSERT INTO Postagem (IdUser, Data,Curtidas,Conteudo) VALUES (9, '14-10-2016', 29, 'https://www.youtube.com/embed/sJT3vIMsCQo');
INSERT INTO Postagem (IdUser, Data,Curtidas,Conteudo) VALUES (9, '16-10-2016', 59, 'https://www.youtube.com/embed/CxKWTzr-k6s');
INSERT INTO Postagem (IdUser, Data,Curtidas,Conteudo) VALUES (9, '10-11-2016', 20, 'https://www.youtube.com/embed/Nkgv3LoQY2o');

INSERT INTO Postagem (IdUser, Data,Curtidas,Conteudo) VALUES (10, '10-11-2016', 14, 'https://www.youtube.com/embed/9v1U73kfSBA');
INSERT INTO Postagem (IdUser, Data,Curtidas,Conteudo) VALUES (10, '01-11-2016', 19, 'https://www.youtube.com/embed/BYv4-W2P2Ro');
INSERT INTO Postagem (IdUser, Data,Curtidas,Conteudo) VALUES (10, '14-10-2016', 29, 'https://www.youtube.com/embed/CzF7ij4TxNA');
INSERT INTO Postagem (IdUser, Data,Curtidas,Conteudo) VALUES (10, '16-10-2016', 59, 'https://www.youtube.com/embed/Kfn8CMIlvuU');
INSERT INTO Postagem (IdUser, Data,Curtidas,Conteudo) VALUES (10, '10-11-2016', 20, 'https://www.youtube.com/embed/Aq7E6bFu7cM');

INSERT INTO Duelo (IdCriador, Tipo, Inicio, Termino) VALUES (1,'Guitarra','16-11-2016','30-11-2016');
INSERT INTO Duelo (IdCriador, Tipo, Inicio, Termino) VALUES (1,'Guitarra','17-11-2016','25-11-2016');

INSERT INTO Duelo (IdCriador, Tipo, Inicio, Termino) VALUES (2,'Bateria','11-11-2016','30-11-2016');
INSERT INTO Duelo (IdCriador, Tipo, Inicio, Termino) VALUES (2,'Bateria','12-11-2016','25-11-2016');

INSERT INTO Duelo (IdCriador, Tipo, Inicio, Termino) VALUES (3,'Guitarra','13-11-2016','30-11-2016');
INSERT INTO Duelo (IdCriador, Tipo, Inicio, Termino) VALUES (3,'Guitarra','13-11-2016','25-11-2016');

INSERT INTO Duelo (IdCriador, Tipo, Inicio, Termino) VALUES (4,'Bateria','21-11-2016','30-11-2016');
INSERT INTO Duelo (IdCriador, Tipo, Inicio, Termino) VALUES (4,'Bateria','21-11-2016','25-11-2016');

INSERT INTO Duelo (IdCriador, Tipo, Inicio, Termino) VALUES (5,'Teclado','22-11-2016','30-11-2016');
INSERT INTO Duelo (IdCriador, Tipo, Inicio, Termino) VALUES (5,'Teclado','22-11-2016','25-11-2016');

INSERT INTO Duelo (IdCriador, Tipo, Inicio, Termino) VALUES (6,'Banda','15-11-2016','30-11-2016');
INSERT INTO Duelo (IdCriador, Tipo, Inicio, Termino) VALUES (6,'Banda','11-11-2016','25-11-2016');

INSERT INTO Duelo (IdCriador, Tipo, Inicio, Termino) VALUES (7,'Teclado','13-11-2016','30-11-2016');
INSERT INTO Duelo (IdCriador, Tipo, Inicio, Termino) VALUES (7,'Teclado','12-11-2016','25-11-2016');

INSERT INTO Duelo (IdCriador, Tipo, Inicio, Termino) VALUES (8,'Banda','10-11-2016','30-11-2016');
INSERT INTO Duelo (IdCriador, Tipo, Inicio, Termino) VALUES (8,'Banda','09-11-2016','25-11-2016');

INSERT INTO Duelo (IdCriador, Tipo, Inicio, Termino) VALUES (9,'Banda','11-11-2016','30-11-2016');
INSERT INTO Duelo (IdCriador, Tipo, Inicio, Termino) VALUES (9,'Banda','12-11-2016','25-11-2016');

INSERT INTO Duelo (IdCriador, Tipo, Inicio, Termino) VALUES (10,'Banda','13-11-2016','30-11-2016');
INSERT INTO Duelo (IdCriador, Tipo, Inicio, Termino) VALUES (10,'Banda','17-11-2016','25-11-2016');

INSERT INTO Inscricao (IdDuelo,IdUser, Data, Pontuacao) VALUES (5,1,'10-11-2016', 10);
INSERT INTO Inscricao (IdDuelo,IdUser, Data, Pontuacao) VALUES (6,1,'10-11-2016', 12);

INSERT INTO Inscricao (IdDuelo,IdUser, Data, Pontuacao) VALUES (7,2,'10-11-2016', 30);
INSERT INTO Inscricao (IdDuelo,IdUser, Data, Pontuacao) VALUES (8,2,'10-11-2016', 50);

INSERT INTO Inscricao (IdDuelo,IdUser, Data, Pontuacao) VALUES (1,3,'10-11-2016', 63);
INSERT INTO Inscricao (IdDuelo,IdUser, Data, Pontuacao) VALUES (2,3,'10-11-2016', 21);

INSERT INTO Inscricao (IdDuelo,IdUser, Data, Pontuacao) VALUES (3,4,'10-11-2016', 22);
INSERT INTO Inscricao (IdDuelo,IdUser, Data, Pontuacao) VALUES (4,4,'10-11-2016', 29);

INSERT INTO Inscricao (IdDuelo,IdUser, Data, Pontuacao) VALUES (13,5,'10-11-2016', 35);
INSERT INTO Inscricao (IdDuelo,IdUser, Data, Pontuacao) VALUES (14,5,'10-11-2016', 67);

INSERT INTO Inscricao (IdDuelo,IdUser, Data, Pontuacao) VALUES (15,6,'10-11-2016', 49);
INSERT INTO Inscricao (IdDuelo,IdUser, Data, Pontuacao) VALUES (16,6,'05-11-2016', 51);

INSERT INTO Inscricao (IdDuelo,IdUser, Data, Pontuacao) VALUES (9,7,'10-11-2016', 45);
INSERT INTO Inscricao (IdDuelo,IdUser, Data, Pontuacao) VALUES (10,7,'10-11-2016', 64);

INSERT INTO Inscricao (IdDuelo,IdUser, Data, Pontuacao) VALUES (17,8,'10-11-2016', 10);
INSERT INTO Inscricao (IdDuelo,IdUser, Data, Pontuacao) VALUES (18,8,'10-11-2016', 60);

INSERT INTO Inscricao (IdDuelo,IdUser, Data, Pontuacao) VALUES (19,9,'10-11-2016', 22);
INSERT INTO Inscricao (IdDuelo,IdUser, Data, Pontuacao) VALUES (20,9,'10-11-2016', 21);

INSERT INTO Inscricao (IdDuelo,IdUser, Data, Pontuacao) VALUES (11,10,'10-11-2016', 16);
INSERT INTO Inscricao (IdDuelo,IdUser, Data, Pontuacao) VALUES (12,10,'10-11-2016', 19);

INSERT INTO Ranking (Pontos, Vitorias, Duelos, IdUser) VALUES (22, 1, 2, 1);
INSERT INTO Ranking (Pontos, Vitorias, Duelos, IdUser) VALUES (80, 1, 2, 2);
INSERT INTO Ranking (Pontos, Vitorias, Duelos, IdUser) VALUES (84, 1, 2, 3);
INSERT INTO Ranking (Pontos, Vitorias, Duelos, IdUser) VALUES (51, 1, 2, 4);
INSERT INTO Ranking (Pontos, Vitorias, Duelos, IdUser) VALUES (102, 1, 2, 5);
INSERT INTO Ranking (Pontos, Vitorias, Duelos, IdUser) VALUES (100, 1, 2, 6);
INSERT INTO Ranking (Pontos, Vitorias, Duelos, IdUser) VALUES (109, 1, 2, 7);
INSERT INTO Ranking (Pontos, Vitorias, Duelos, IdUser) VALUES (70, 1, 2, 8);
INSERT INTO Ranking (Pontos, Vitorias, Duelos, IdUser) VALUES (43, 1, 2, 9);
INSERT INTO Ranking (Pontos, Vitorias, Duelos, IdUser) VALUES (35, 1, 2, 10);
