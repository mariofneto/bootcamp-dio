SELECT * FROM Enderecos

INSERT INTO Enderecos(Id, IdCliente, Rua, Bairro, Cidade, Estado)
VALUES(1, 5, 'Rua Teste', 'Bairro Teste', 'Cidade Teste', 'SP')

SELECT 
	Clientes.Nome, 
	Clientes.Email, 
	Enderecos.Estado
FROM Clientes
	INNER JOIN Enderecos ON Clientes.Id = Enderecos.IdCliente
WHERE Clientes.Id = 5