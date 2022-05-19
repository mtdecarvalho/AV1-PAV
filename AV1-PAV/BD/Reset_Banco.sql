use pav_av1;

-- Limpa tabelas

DELETE FROM ContaReceber WHERE id_conta_receber > -1;
DELETE FROM ItemVenda WHERE id_venda > -1;
DELETE FROM Venda WHERE id_venda > -1;
DELETE FROM FormaPagamento WHERE id_forma_pagamento > -1;
DELETE FROM Cliente WHERE id_cliente > -1;

DELETE FROM Produto WHERE id_produto > -1;
DELETE FROM ItemCompra WHERE id_compra > -1;
DELETE FROM Compra WHERE id_compra > -1;
DELETE FROM ContaPagar WHERE id_conta_pagar > -1;
DELETE FROM Fornecedor WHERE id_fornecedor > -1;

DELETE FROM MovimentoCaixa WHERE id_caixa > -1;
DELETE FROM Caixa WHERE id_caixa > -1;

-- Tabela clientes

INSERT INTO cliente(id_cliente, nome, cpf_cnpj, logradouro, numero, complemento, bairro, cidade, estado, cep, telefone, email)
VALUES (0,"Cliente não identificado", "00000000000", "", 0,"","","","","","","");

INSERT INTO cliente(id_cliente, nome, cpf_cnpj, logradouro, numero, complemento, bairro, cidade, estado, cep, telefone, email)
VALUES (1,"Vinícius Correia Fernandes", "25307158580", "Rua Edmundo Brito Mugnaine", 1186,"","Jardim Arruda","Limeira","SP",
"13482350","1974043066","ViniciusCorreiaFernandes@dayrep.com");

INSERT INTO cliente(id_cliente, nome, cpf_cnpj, logradouro, numero, complemento, bairro, cidade, estado, cep, telefone, email)
VALUES (2,"Ryan Fernandes Almeida", "76854586593", "Rua Campo Verde", 1770,"","Praia do Futuro II","Fortaleza","CE","60182502","8525224904","RyanFernandesAlmeida@teleworm.us");

INSERT INTO cliente(id_cliente, nome, cpf_cnpj, logradouro, numero, complemento, bairro, cidade, estado, cep, telefone, email)
VALUES (3,"Grace Hogan", "28274454766", "Rua Braúlio", 1711,"","Santo Elias","Mesquita","RJ","26560581","2185829925","GraceHogan@dayrep.com");

INSERT INTO cliente(id_cliente, nome, cpf_cnpj, logradouro, numero, complemento, bairro, cidade, estado, cep, telefone, email)
VALUES (4,"Fen Tsao", "74736575697", "Rua Peroba", 1234,"","Matinha","Abreu e Lima","PE","53550390","8162884940","FenTsao@jourrapide.com");

INSERT INTO cliente(id_cliente, nome, cpf_cnpj, logradouro, numero, complemento, bairro, cidade, estado, cep, telefone, email)
VALUES (5,"Melissa Marino", "81253272824", "Rua Mato Grosso", 1159,"","Bela Vista","Nova Friburgo","RJ","28623030","2241667853","MelissaMarino@teleworm.us");

INSERT INTO cliente(id_cliente, nome, cpf_cnpj, logradouro, numero, complemento, bairro, cidade, estado, cep, telefone, email)
VALUES (6, "Scott Ferguson", "58668727818", "Rua Luiz Mariano Bueno", 0,"","Jardim Santa Clara","Campinas","SP","13058320","1993479433","scottfag@rhyta.com");

INSERT INTO cliente(id_cliente, nome, cpf_cnpj, logradouro, numero, complemento, bairro, cidade, estado, cep, telefone, email)
VALUES (7,"Daniel Tingle", "98825417985", "Praça Presidente Castelo Branco 365", 0,"","Areal","Areal","RJ","25845970","3153906968","HarrisonLeeson@dayrep.com");

INSERT INTO cliente(id_cliente, nome, cpf_cnpj, logradouro, numero, complemento, bairro, cidade, estado, cep, telefone, email)
VALUES (8,"Lincoln Potter", "79682070619", "Rua Bela Cintra 71", 0,"","Água Vermelha","Água Vermelha","SP","13578970","telefone","email");

INSERT INTO cliente(id_cliente, nome, cpf_cnpj, logradouro, numero, complemento, bairro, cidade, estado, cep, telefone, email)
VALUES (9,"Thomas Shelby", "23912745137", "Rua Joaquim Machado 48", 0,"","Centro","Estrela do Indaiá","MG","35613970","4998682628",
"friocalculista@blinders.com.br");

INSERT INTO cliente(id_cliente, nome, cpf_cnpj, logradouro, numero, complemento, bairro, cidade, estado, cep, telefone, email)
VALUES (10,"Elon Zuckerberg Jobs Gates Buffet", "94333411637", "Avenida Getulio Vargas 19 Loja A", 0,"Silicon Valley","Centro","Arraial do Cabo","RJ","28930970","6593159251","facebook@apple.outlook.com");

-- Tabela formapagamento

INSERT INTO formapagamento(id_forma_pagamento, nome)
VALUES (0, "Dinheiro");

INSERT INTO formapagamento(id_forma_pagamento, nome)
VALUES (1, "Cartão de Crédito");

INSERT INTO formapagamento(id_forma_pagamento, nome)
VALUES (2, "Cartão de Débito");

INSERT INTO formapagamento(id_forma_pagamento, nome)
VALUES (3, "Boleto Bancário");

-- Tabela fornecedor

INSERT INTO fornecedor(id_fornecedor, nome, cpf_cnpj, logradouro, numero, complemento, bairro, cidade, estado, cep, telefone, email)
VALUES (0, "Fornecedor nao identificado", "00000000000000", "", 0, "", "", "", "", "", "", "");

INSERT INTO fornecedor(id_fornecedor, nome, cpf_cnpj, logradouro, numero, complemento, bairro, cidade, estado, cep, telefone, email)
VALUES (1, "Camila e Henry Adega Ltda", "11006056000170", "Rua Nadir", 507, "", "Chacaras Arcampo", "Duque de Caxias", "RJ", "25251560",
 "2127872567", "comercial@camilaehenryadegaltda.com.br");

INSERT INTO fornecedor(id_fornecedor, nome, cpf_cnpj, logradouro, numero, complemento, bairro, cidade, estado, cep, telefone, email)
VALUES (2, "Bianca e Esther Distribuidora Ltda", "23551355000174", "Rua Interna Principal", 659, "", "Dois de Julho", "Camaçari", "BA",
 "42800600", "7128555663", "contato@biancaeestherdistribuidoraltda.com.br");

INSERT INTO fornecedor(id_fornecedor, nome, cpf_cnpj, logradouro, numero, complemento, bairro, cidade, estado, cep, telefone, email)
VALUES (3, "Vinicius e Emilly Alimentos Ltda", "95929829000180", "Travessa Vinte e Dois de Agosto", 306, "", "Perola do Maica", "Santarem",
 "PA", "68046090", "9328635514", "comercial@viniciuseemillyalimentosltda.com.br");

INSERT INTO fornecedor(id_fornecedor, nome, cpf_cnpj, logradouro, numero, complemento, bairro, cidade, estado, cep, telefone, email)
VALUES (4, "Alimentos Nova Era Ltda", "25232222046233", "Pernambuco", 306, "Aeroporto 6", "Vila Nova", "Boa Vista", "PA", "72391614",
 "95168254815", "contato@alimentos-nova-era.com.br");

INSERT INTO fornecedor(id_fornecedor, nome, cpf_cnpj, logradouro, numero, complemento, bairro, cidade, estado, cep, telefone, email)
VALUES (5, "Carolina e Emanuel Adega ME", "52776254000108", "Rua Betania", 437, "", "Maracacuera (Icoaraci)", "Belem", "PA", "66815457",
 "9125502887", "compras@carolinaeemanueladegame.com.br");

INSERT INTO fornecedor(id_fornecedor, nome, cpf_cnpj, logradouro, numero, complemento, bairro, cidade, estado, cep, telefone, email)
VALUES (6, "Açougue Bye Com","24446444000113", "Rua A", 1106, "Fazenda 6", " Alameda das Jabuticabeiras", "Vargem", "SP", "05936813", 
"11993596732", "contato@acouguebye.com");

INSERT INTO fornecedor(id_fornecedor, nome, cpf_cnpj, logradouro, numero, complemento, bairro, cidade, estado, cep, telefone, email)
VALUES (7, "Francisca Santos Moraes", "11020651016", "Rua Belo Horizonte", 7662, "Anexo 8", "Sao Cristovao", "Sao Paulo", "SP", "10265447",
 "11352648647", "contato@bancosantoagostinho.com");

INSERT INTO fornecedor(id_fornecedor, nome, cpf_cnpj, logradouro, numero, complemento, bairro, cidade, estado, cep, telefone, email)
VALUES (8, "Comércio Rainha", "35157656000105", "Rua Nei Palmeiro", 1978, "", "Barra da Tijuca", "Rio de Janeiro", "RJ", "22640240",
 "2148236407", "contato@comérciorainha.com");

INSERT INTO fornecedor(id_fornecedor, nome, cpf_cnpj, logradouro, numero, complemento, bairro, cidade, estado, cep, telefone, email)
VALUES (9, "Peixaria Dois Irmaos", "30517686000153", "Rua Durvalino Peliciari", 813, "", "Distrito Industrial Antonio Della - Torre",
 "Franca", "SP", "14406120", "1636463321", "doisirmaos@teuemail.com");

INSERT INTO fornecedor(id_fornecedor, nome, cpf_cnpj, logradouro, numero, complemento, bairro, cidade, estado, cep, telefone, email)
VALUES (10, "Abatedouro das Galinha", "21489214000143", "Travessa Rodolfo Conceição e Silva", 210, "", "Cooperativa", "São Bernardo do Campo",
 "SP", "09851683", "16986106864", "abatedouro@seinaoemail.com.br");

-- Tabela produto

INSERT INTO produto(id_produto, nome, quantidade_estoque, preco, unidade, id_fornecedor)
VALUES (0,"Produto não identificado", 0, 0, "KG", 0);

INSERT INTO produto(id_produto, nome, quantidade_estoque, preco, unidade, id_fornecedor)
VALUES (1,"Batata", 10, 3.00, "KG", 3);

INSERT INTO produto(id_produto, nome, quantidade_estoque, preco, unidade, id_fornecedor)
VALUES (2,"Batata doce", 10, 3.50, "KG", 2);

INSERT INTO produto(id_produto, nome, quantidade_estoque, preco, unidade, id_fornecedor)
VALUES (3,"Vinho Tinto", 10, 30.99, "Un", 5);

INSERT INTO produto(id_produto, nome, quantidade_estoque, preco, unidade, id_fornecedor)
VALUES (4,"Vinho Branco", 10, 35.00, "Un", 1);

INSERT INTO produto(id_produto, nome, quantidade_estoque, preco, unidade, id_fornecedor)
VALUES (5,"Barra de Chocolate Nestle", 10, 4.32, "Un", 4);

INSERT INTO produto(id_produto, nome, quantidade_estoque, preco, unidade, id_fornecedor)
VALUES (6,"Barra de Chocolate Garoto", 10, 5.00, "Un", 0);

INSERT INTO produto(id_produto, nome, quantidade_estoque, preco, unidade, id_fornecedor)
VALUES (7,"Alcatra", 100, 50.00, "KG", 6);

INSERT INTO produto(id_produto, nome, quantidade_estoque, preco, unidade, id_fornecedor)
VALUES (8,"Bacon", 50, 20.00, "KG", 6);

INSERT INTO produto(id_produto, nome, quantidade_estoque, preco, unidade, id_fornecedor)
VALUES (9,"Suspiro", 10, 3.00, "Un", 7);

INSERT INTO produto(id_produto, nome, quantidade_estoque, preco, unidade, id_fornecedor)
VALUES (10,"Vodka Smirnoff", 50, 50.00, "UN", 10);

INSERT INTO produto(id_produto, nome, quantidade_estoque, preco, unidade, id_fornecedor)
VALUES (11,"Salmao", 20, 50.00, "UN", 9);

INSERT INTO produto(id_produto, nome, quantidade_estoque, preco, unidade, id_fornecedor)
VALUES (12,"Asa de frango", 50, 20.00, "KG", 10);

INSERT INTO produto(id_produto, nome, quantidade_estoque, preco, unidade, id_fornecedor)
VALUES (13,"Coraçao de galinha", 50, 35.00, "KG", 10);

INSERT INTO produto(id_produto, nome, quantidade_estoque, preco, unidade, id_fornecedor)
VALUES (14,"Cafe pele", 30, 25.00, "UN", 8);

INSERT INTO produto(id_produto, nome, quantidade_estoque, preco, unidade, id_fornecedor)
VALUES (15,"Cafe pilao", 20, 20.00, "UN", 8);

INSERT INTO produto(id_produto, nome, quantidade_estoque, preco, unidade, id_fornecedor)
VALUES (16,"Cafe tres coraçoes", 10, 15.00, "UN", 8);

INSERT INTO produto(id_produto, nome, quantidade_estoque, preco, unidade, id_fornecedor)
VALUES (17,"Arroz Tio joao", 20, 30.00, "UN", 4);

INSERT INTO produto(id_produto, nome, quantidade_estoque, preco, unidade, id_fornecedor)
VALUES (18,"Arroz Camil", 60, 25.00, "UN", 4);

INSERT INTO produto(id_produto, nome, quantidade_estoque, preco, unidade, id_fornecedor)
VALUES (19,"Feijao Maximo", 50, 6.00, "UN", 4);

INSERT INTO produto(id_produto, nome, quantidade_estoque, preco, unidade, id_fornecedor)
VALUES (20,"Feijao Urbana", 50, 15.39, "UN", 4);

INSERT INTO produto(id_produto, nome, quantidade_estoque, preco, unidade, id_fornecedor)
VALUES (21,"Tilapia", 20, 30.00, "UN", 9);

INSERT INTO produto(id_produto, nome, quantidade_estoque, preco, unidade, id_fornecedor)
VALUES (22,"Sambiquira", 20, 5.00, "KG", 10);

INSERT INTO produto(id_produto, nome, quantidade_estoque, preco, unidade, id_fornecedor)
VALUES (23,"Cigarro", 20, 4.20, "UN", 10);

-- Tabela caixa

INSERT INTO caixa(id_caixa, nome, saldo)
VALUES ('0', 'Dinheiro', 5000);

INSERT INTO caixa(id_caixa, nome, saldo)
VALUES ('1', 'Cartão de Crédito', 5000);

INSERT INTO caixa(id_caixa, nome, saldo)
VALUES ('2', 'Cartão de Débito', 5000);

INSERT INTO caixa(id_caixa, nome, saldo)
VALUES ('3', 'Boleto Bancário', 5000);