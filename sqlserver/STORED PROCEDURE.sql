ALTER PROCEDURE InserirNovoCliente
@Nome varchar(255),
@Sobrenome varchar(255),
@Email varchar(255),
@AceitaComunicados bit,
@DataCadastro datetime2

AS

INSERT INTO Clientes(Nome, Sobrenome, Email, AceitaComunicados)
VALUES(@Nome, @Sobrenome, @Email, @AceitaComunicados)
