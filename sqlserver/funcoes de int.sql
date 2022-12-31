SELECT *
FROM Produtos

SELECT COUNT(*) QuantidadeProdutos
FROM Produtos

SELECT COUNT(*) QuantidadeProdutosTamanhoM
FROM Produtos
WHERE Tamanho = 'M'

SELECT SUM(Preco) PrecoTotalDosProdutos
FROM Produtos
WHERE Tamanho = 'M'

SELECT MIN(Preco) ProdutoMaisBarato
FROM Produtos

SELECT MAX(Preco) ProdutoMaisCaro
FROM Produtos

SELECT AVG(Preco) MediaDosPrecos
FROM Produtos
