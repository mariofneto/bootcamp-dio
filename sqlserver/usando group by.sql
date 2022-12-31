SELECT 
	Tamanho,
	COUNT(*) Quantidade
FROM Produtos
GROUP BY Tamanho


SELECT 
	Tamanho,
	COUNT(*) Quantidade
FROM Produtos
WHERE Tamanho <> ''
GROUP BY Tamanho
ORDER BY Quantidade DESC
