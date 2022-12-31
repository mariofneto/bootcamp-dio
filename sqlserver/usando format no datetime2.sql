SELECT * 
FROM Produtos

ALTER TABLE Produtos
ADD DataCadastro DATETIME2

UPDATE Produtos
SET DataCadastro = GETDATE()

SELECT FORMAT(DataCadastro,'dd-MM-yyyy HH:mm') DataRegistro
FROM Produtos