INSERT INTO Clientes(Nome, Sobrenome, Email, AceitaComunicados, DataCadastro)
VALUES('Alan','Max', 'sla@gmail.com', 1 , GETDATE())

SELECT *
FROM Clientes
WHERE Nome = 'Alan'

BEGIN TRAN

ROLLBACK

UPDATE Clientes
SET Email = 'email@email.com'
--WHERE Id = 1003

DELETE Clientes
WHERE Id = 1001

