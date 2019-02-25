USE InLock_Games_Tarde;

-- LISTA TODOS OS USUÁRIOS
SELECT * FROM Usuarios

-- LISTA TODOS OS ESTÚDIOS
SELECT * FROM Estudios

-- LISTA TODOS OS JOGOS
SELECT * FROM Jogos

-- LISTA OS JOGOS E SEUS RESPECTIVOS ESTÚDIOS
SELECT
	J.*,
	E.NomeEstudio
FROM
	Jogos J INNER JOIN Estudios E
ON
	J.EstudioId = E.EstudioId

-- LISTA TODOS OS ESTÚDIOS MESMO QUE NÃO CONTENHAM JOGOS
SELECT
	E.*,
	J.NomeJogo,
	J.Descricao,
	J.Descricao,
	J.DataLancamento,
	J.Valor
FROM
	Jogos J RIGHT JOIN Estudios E
ON
	J.EstudioId = E.EstudioId

-- BUSCA UM USUÁRIO POR E-MAIL E SENHA
SELECT
	U.Email,
	U.TipoUsuario
FROM
	Usuarios U WHERE Email = 'admin@admin.com' AND Senha = 'admin'

-- BUSCA UM JOGO POR ID
SELECT
	J.*
FROM
	Jogos J WHERE JogoId = 1

-- BUSCA UM ESTÚDIO POR ID
SELECT
	E.*
FROM
	Estudios E WHERE EstudioId = 1