use BestProjectTest;

CREATE TABLE Produto (
    Id int NOT NULL,
    Nome varchar(50) NOT NULL,
    Preco float(10) not null,
	IdCategoria int not null
    PRIMARY KEY (Id)
);

ALTER TABLE Produto
ADD FOREIGN KEY (Id) REFERENCES ItemVenda(Id); 

CREATE TABLE ItemVenda (
    Id int NOT NULL,
    IdProduto int NOT NULL,
    IdVenda int not null,
	Quantidade int not null
    PRIMARY KEY (Id)
);

CREATE TABLE Categoria (
    Id int NOT NULL,
    Nome varchar(50) NOT NULL,
    PRIMARY KEY (Id),
    FOREIGN KEY (Id) REFERENCES Produto(Id)
);

CREATE TABLE Venda (
    Id int NOT NULL,
    Codigo varchar(10) NOT NULL,
	Datas Date not null,
	Faturado bit not null
    PRIMARY KEY (Id),
    FOREIGN KEY (Id) REFERENCES ItemVenda(Id)
);

select * from Categoria;

INSERT INTO Categoria
VALUES (2, 'Vestuário'),
(3,	'Calçados'),
(4,	'Acessórios');

select * from Produto;

INSERT INTO Produto
VALUES 
(2,	'Bermuda',	80,	2),
(3,	'Camiseta',	60,	2),
(4,	'Polo',	80,	2),
(5,	'Sapato Masculino',	100,	3),
(6,	'Sapato Feminino',	150,	3),
(7,	'Jaqueta',	150,	2),
(8,	'Meias',	8,	2),
(9,	'Camisa Social',	90,	2),
(10,	'Sandália',	50,	3),
(12,	'Brinco',	25.8, 	4),
(14,	'Pulseira',	10.9,	4),
(15,	'Tênis',	400,	3);



INSERT INTO ItemVenda
VALUES (3, 3, 1, 8),
(4,	9, 1, 5),
(5,	4,	2,	10),
(6,	3,	2,	5),
(7,	4,	3,	20),
(8,	4,	3,	20),
(9,	7,	3,	20),
(10, 8,	3,	100),
(11, 9,	4,	100),
(12, 1,	4,	100),
(13,	4,	4,	80),
(14,	2,	5,	10),
(15,	8,	5,	40),
(16,	1,	7,	20),
(17,	2,	7,	40),
(18,	3,	7,	40),
(19,	4,	7,	40),
(20,	8,	7,	40),
(21,	1,	9,	300),
(22,	1,	9,	300),
(23,	4,	10,	50),
(24,	3,	10,	50),
(25,	1,	12,	500),
(26,	8,	13,	100),
(27,	9,	13,	50),
(28,	4,	13,	50),
(29,	2,	15,	30),
(30,	3,	15,	60);


select * from Venda;

INSERT INTO Venda
VALUES (2,	'C02',	'2018-07-15',	1),
(3,	'C03',	'2018-07-16',	1),
(4,	'C04',	'2018-07-16',	1),
(5,	'C05',	'2018-07-20',	1),
(7,	'C06',	'2018-07-20',	1),
(9,	'C07',	'2018-07-28',	0),
(10,	'C08',	'2018-07-28',	1),
(12,	'C09',	'2018-07-28',	1),
(13,	'C10',	'2018-07-30',	1),
(14,	'V01',	'2018-08-01',	1),
(15,	'C11',	'2018-08-01',	0);


select * from ItemVenda;


-- Questão 1
SELECT P.Nome, P.Preco, C.Nome FROM Produto AS P
JOIN Categoria AS C ON C.Id = P.Id
WHERE C.Nome = 'SAPATO' OR C.Id = 2
order by p.Preco desc;

-- Questão 2
SELECT v.Codigo, v.Faturado, i.Quantidade FROM ItemVenda AS I
JOIN Produto AS P ON P.Id = I.Id
JOIN Venda AS V ON V.Id = I.Id
WHERE V.Faturado = 1 and i.Quantidade > 2;

-- Questão 3
SELECT p.Nome, SUM(p.Preco) AS TotalVendas, SUM(i.Quantidade) as TotalQuantidade, Ven.Datas, Ven.Id FROM Produto AS P
JOIN Venda AS Ven ON Ven.Id = p.Id
JOIN ItemVenda as I on I.Id = P.Id
WHERE Ven.Datas >= '2018-07-20'and Ven.Datas <= '2018-07-30' and Ven.Faturado = 1
GROUP BY  p.Nome, Ven.Datas, Ven.Id
ORDER BY Ven.Datas;


-- Questão 4
SELECT C.Nome, P.Nome, P.IdCategoria, P.Preco,
CASE
    WHEN P.Preco >= 100 THEN 'Quantidades maiores que 100'
    WHEN P.Preco <= 100 THEN 'Quantidades menores que 100'
END AS Produto
FROM Categoria AS C
JOIN Produto AS P ON C.Id = P.Id;

-- Questão 5
-- Resposta: Criar um campo na tabela Categoria chamado IdProduto 
--e relacionar a chave estrangeira da tabela IdProduto com a tabela produto