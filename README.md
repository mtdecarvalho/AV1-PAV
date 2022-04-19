# AV1 - PAV

## Nesta etapa, devem ser criados:
- ~~Banco de dados~~ (FEITO)
- Recursos referentes a vendas **PENDENTE**
- Recursos referentes a contas a receber **PENDENTE**

### Venda
- Registrar vendas (PDV).
- Cancelar uma venda.
- Consultar vendas, permitindo filtrar por período e por cliente.
- Emitir relatório de vendas realizadas, permitindo filtrar por período e por cliente.

### Contas a Receber
- Gerar uma conta a receber a partir de uma compra.
- Baixar uma conta a receber
- Gerar boleto.
- Emitir relatório de contas a receber, com opção de selecionar contas a receber, a vencer, em atraso e pagas.

Para fazer esses dois recursos, precisaremos criar as tabelas dependentes, que são:

~~Cliente, FormaPagamento e FormaPagamentoVenda, ItemVenda, Produto~~ (FEITO)

~~Em Produto, podemos fazer o ID_FORNECEDOR referenciar o fornecedor 0 que vai servir como o "fornecedor nulo"~~ (FEITO)

~~Em Venda, também podemos fazer o ID_CLIENTE referenciar o cliente 0 que vai servir como o "cliente nulo"~~ (FEITO)