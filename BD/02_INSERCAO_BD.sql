USE InLock_Games_Tarde;

-- INSERINDO DOIS REGISTROS NA TABELA Usuarios
INSERT INTO Usuarios(Email, Senha, TipoUsuario)
	VALUES	('admin@admin.com', 'admin', 'ADMINISTRADOR'),
			('cliente@cliente.com', 'cliente', 'CLIENTE')

-- INSSERINDO TR�S REGISTROS NA TABELA Estudios
INSERT INTO Estudios(NomeEstudio)
	VALUES	('Blizzard'),
			('Rockstar Studios'),
			('Square Enix')

SELECT * FROM ESTUDIOS
SELECT * FROM JOGOS
INSERT INTO Jogos(NomeJogo, Descricao, DataLancamento, Valor, EstudioId)
	VALUES	('Diablo 3', '� um jogo que cont�m bastante a��o e � viciante, seja voc� um novato ou um f�', '15-05-2012', 99.00, 1),
			('Red Dead Redemption II', 'jogo eletr�nico de a��o-aventura western', '26-10-2018', 120, 2)