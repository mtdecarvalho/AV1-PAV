use pav_av1;

-- Tabela clientes
INSERT INTO cliente(id_cliente, nome, cpf_cnpj, logradouro, numero, complemento, bairro, cidade, estado, cep, telefone, email)
VALUES (0,"Cliente não identificado", 00000000000, "", 0,"","","","","","","");
INSERT INTO cliente(id_cliente, nome, cpf_cnpj, logradouro, numero, complemento, bairro, cidade, estado, cep, telefone, email)
VALUES (1,"Vinícius Correia Fernandes", 25307158580, "Rua Edmundo Brito Mugnaine", 1186,"","Jardim Arruda","Limeira","SP","13482350","1974043066","ViniciusCorreiaFernandes@dayrep.com");

select * from cliente;
