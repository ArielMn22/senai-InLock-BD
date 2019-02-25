USE InLock_Games_Tarde;

-- INSERINDO DOIS REGISTROS NA TABELA Usuarios
INSERT INTO Usuarios(Email, Senha, TipoUsuario)
	VALUES	('admin@admin.com', 'admin', 'ADMINISTRADOR'),
			('cliente@cliente.com', 'cliente', 'CLIENTE')

-- INSSERINDO TRÊS REGISTROS NA TABELA Estudios
INSERT INTO Estudios(NomeEstudio)
	VALUES	('Blizzard'),
			('Rockstar Studios'),
			('Square Enix')

SELECT * FROM ESTUDIOS
SELECT * FROM JOGOS
INSERT INTO Jogos(NomeJogo, Descricao, DataLancamento, Valor, EstudioId)
	VALUES	('Diablo 3', 'é um jogo que contém bastante ação e é viciante, seja você um novato ou um fã', '15-05-2012', 99.00, 1),
			('Red Dead Redemption II', 'jogo eletrônico de ação-aventura western', '26-10-2018', 120, 2)