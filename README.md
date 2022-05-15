# AV1 - PAV

## O que foi feito

01. Banco de dados
00. Venda (Adicionar, remover, listar)
00. Produto (Adicionar, remover, listar)
00. Fornecedor (Adicionar, remover, listar)
00. Contas a receber (Adicionar, dar baixa, listar)
 
## O que falta

01. Contas a pagar (Adicionar, pagar, listar)
00. Controle de caixa

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

### Créditos:
- [Pacote de ícones (Ui Gradient)](https://www.flaticon.com/br/packs/ui-82?style_id=1259&family_id=333&group_id=621)
- [Pacote de ícones Ecommerce (Flat Gradient)](https://www.flaticon.com/br/packs/ecommerce-498)
