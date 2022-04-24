-- MySQL Script generated by MySQL Workbench
-- Sun Apr 24 12:00:02 2022
-- Model: New Model    Version: 1.0
-- MySQL Workbench Forward Engineering

SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0;
SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0;
SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION';

-- -----------------------------------------------------
-- Schema PAV_AV1
-- -----------------------------------------------------

-- -----------------------------------------------------
-- Schema PAV_AV1
-- -----------------------------------------------------
CREATE SCHEMA IF NOT EXISTS `PAV_AV1` DEFAULT CHARACTER SET utf8 ;
USE `PAV_AV1` ;

-- -----------------------------------------------------
-- Table `PAV_AV1`.`Fornecedor`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `PAV_AV1`.`Fornecedor` (
  `id_fornecedor` INT NOT NULL,
  `nome` VARCHAR(45) NOT NULL,
  `cpf_cnpj` VARCHAR(14) NOT NULL,
  `logradouro` VARCHAR(45) NOT NULL,
  `numero` INT NOT NULL,
  `complemento` VARCHAR(45) NULL,
  `bairro` VARCHAR(45) NOT NULL,
  `cidade` VARCHAR(45) NOT NULL,
  `estado` VARCHAR(2) NOT NULL,
  `cep` VARCHAR(8) NOT NULL,
  `telefone` VARCHAR(11) NOT NULL,
  `email` VARCHAR(45) NOT NULL,
  PRIMARY KEY (`id_fornecedor`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `PAV_AV1`.`Produto`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `PAV_AV1`.`Produto` (
  `id_produto` INT NOT NULL,
  `nome` VARCHAR(45) NOT NULL,
  `quantidade_estoque` INT NOT NULL,
  `preco` DOUBLE NOT NULL,
  `unidade` VARCHAR(3) NOT NULL,
  `id_fornecedor` INT NULL,
  PRIMARY KEY (`id_produto`),
  INDEX `fk_fornecedor_idx` (`id_fornecedor` ASC) VISIBLE,
  CONSTRAINT `fk_Produto_Fornecedor`
    FOREIGN KEY (`id_fornecedor`)
    REFERENCES `PAV_AV1`.`Fornecedor` (`id_fornecedor`)
    ON DELETE SET NULL
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `PAV_AV1`.`Cliente`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `PAV_AV1`.`Cliente` (
  `id_cliente` INT NOT NULL,
  `nome` VARCHAR(45) NOT NULL,
  `cpf_cnpj` VARCHAR(14) NOT NULL,
  `logradouro` VARCHAR(45) NOT NULL,
  `numero` INT NOT NULL,
  `complemento` VARCHAR(45) NULL,
  `bairro` VARCHAR(45) NOT NULL,
  `cidade` VARCHAR(45) NOT NULL,
  `estado` VARCHAR(2) NOT NULL,
  `cep` VARCHAR(8) NOT NULL,
  `telefone` VARCHAR(11) NOT NULL,
  `email` VARCHAR(45) NOT NULL,
  PRIMARY KEY (`id_cliente`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `PAV_AV1`.`FormaPagamento`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `PAV_AV1`.`FormaPagamento` (
  `id_forma_pagamento` INT NOT NULL,
  `nome` VARCHAR(45) NOT NULL,
  PRIMARY KEY (`id_forma_pagamento`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `PAV_AV1`.`Venda`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `PAV_AV1`.`Venda` (
  `id_venda` INT NOT NULL,
  `data` DATE NOT NULL,
  `hora` TIME NOT NULL,
  `id_cliente` INT NULL,
  `total_venda` DOUBLE NOT NULL,
  `situacao_venda` VARCHAR(45) NOT NULL,
  PRIMARY KEY (`id_venda`),
  INDEX `fk_cliente_idx` (`id_cliente` ASC) VISIBLE,
  CONSTRAINT `fk_Venda_Cliente`
    FOREIGN KEY (`id_cliente`)
    REFERENCES `PAV_AV1`.`Cliente` (`id_cliente`)
    ON DELETE SET NULL
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `PAV_AV1`.`ItemVenda`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `PAV_AV1`.`ItemVenda` (
  `id_venda` INT NOT NULL,
  `numero_item` INT NOT NULL,
  `id_produto` INT NULL,
  `quantidade` INT UNSIGNED NOT NULL,
  `valor_unitario` DOUBLE NOT NULL,
  `total_item` DOUBLE NOT NULL,
  PRIMARY KEY (`id_venda`, `numero_item`),
  INDEX `fk_produto_idx` (`id_produto` ASC) VISIBLE,
  CONSTRAINT `fk_ItemVenda_Venda`
    FOREIGN KEY (`id_venda`)
    REFERENCES `PAV_AV1`.`Venda` (`id_venda`)
    ON DELETE CASCADE
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_ItemVenda_Produto`
    FOREIGN KEY (`id_produto`)
    REFERENCES `PAV_AV1`.`Produto` (`id_produto`)
    ON DELETE SET NULL
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `PAV_AV1`.`FormaPagamentoVenda`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `PAV_AV1`.`FormaPagamentoVenda` (
  `id_venda` INT NOT NULL,
  `id_forma_pagamento` INT NOT NULL,
  `valor` DOUBLE NOT NULL,
  PRIMARY KEY (`id_venda`, `id_forma_pagamento`),
  INDEX `id_forma_pagamento_idx` (`id_forma_pagamento` ASC) VISIBLE,
  CONSTRAINT `fk_FormaPagamentoVenda_FormaPagamento`
    FOREIGN KEY (`id_forma_pagamento`)
    REFERENCES `PAV_AV1`.`FormaPagamento` (`id_forma_pagamento`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_FormaPagamentoVenda_Venda`
    FOREIGN KEY (`id_venda`)
    REFERENCES `PAV_AV1`.`Venda` (`id_venda`)
    ON DELETE CASCADE
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `PAV_AV1`.`Compra`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `PAV_AV1`.`Compra` (
  `id_compra` INT NOT NULL,
  `data` DATE NOT NULL,
  `hora` TIME NOT NULL,
  `id_fornecedor` INT NULL,
  `total_compra` DOUBLE NOT NULL,
  `situacao_compra` VARCHAR(45) NOT NULL,
  PRIMARY KEY (`id_compra`),
  INDEX `fk_fornecedor_idx` (`id_fornecedor` ASC) VISIBLE,
  CONSTRAINT `fk_Compra_Fornecedor`
    FOREIGN KEY (`id_fornecedor`)
    REFERENCES `PAV_AV1`.`Fornecedor` (`id_fornecedor`)
    ON DELETE SET NULL
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `PAV_AV1`.`ItemCompra`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `PAV_AV1`.`ItemCompra` (
  `id_compra` INT NOT NULL,
  `numero_item` INT NOT NULL,
  `id_produto` INT NULL,
  `quantidade` INT NOT NULL,
  `valor_unitario` DOUBLE NOT NULL,
  `total_item` DOUBLE NOT NULL,
  PRIMARY KEY (`id_compra`, `numero_item`),
  INDEX `fk_produto_idx` (`id_produto` ASC) VISIBLE,
  CONSTRAINT `fk_ItemCompra_Compra`
    FOREIGN KEY (`id_compra`)
    REFERENCES `PAV_AV1`.`Compra` (`id_compra`)
    ON DELETE CASCADE
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_ItemCompra_Produto`
    FOREIGN KEY (`id_produto`)
    REFERENCES `PAV_AV1`.`Produto` (`id_produto`)
    ON DELETE SET NULL
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `PAV_AV1`.`ContaReceber`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `PAV_AV1`.`ContaReceber` (
  `id_conta_receber` INT NOT NULL,
  `descricao` VARCHAR(45) NOT NULL,
  `id_cliente` INT NULL,
  `data_lancamento` DATE NOT NULL,
  `data_vencimento` DATE NOT NULL,
  `valor` DOUBLE NOT NULL,
  `recebido` VARCHAR(45) NOT NULL,
  `data_recebimento` DATE NOT NULL,
  `valor_recebimento` DOUBLE NOT NULL,
  PRIMARY KEY (`id_conta_receber`),
  INDEX `fk_cliente_idx` (`id_cliente` ASC) VISIBLE,
  CONSTRAINT `fk_ContaReceber_Cliente`
    FOREIGN KEY (`id_cliente`)
    REFERENCES `PAV_AV1`.`Cliente` (`id_cliente`)
    ON DELETE SET NULL
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `PAV_AV1`.`ContaPagar`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `PAV_AV1`.`ContaPagar` (
  `id_conta_pagar` INT NOT NULL,
  `descricao` VARCHAR(45) NOT NULL,
  `id_fornecedor` INT NULL,
  `data_lancamento` DATE NOT NULL,
  `data_vencimento` DATE NOT NULL,
  `valor` DOUBLE NOT NULL,
  `pago` VARCHAR(45) NOT NULL,
  `data_pagamento` DATE NOT NULL,
  `valor_pagamento` DOUBLE NOT NULL,
  PRIMARY KEY (`id_conta_pagar`),
  INDEX `fk_fornecedor_idx` (`id_fornecedor` ASC) VISIBLE,
  CONSTRAINT `fk_ContaPagar_Fornecedor`
    FOREIGN KEY (`id_fornecedor`)
    REFERENCES `PAV_AV1`.`Fornecedor` (`id_fornecedor`)
    ON DELETE SET NULL
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `PAV_AV1`.`Caixa`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `PAV_AV1`.`Caixa` (
  `id_caixa` INT NOT NULL,
  `nome` VARCHAR(45) NOT NULL,
  `saldo` DOUBLE NOT NULL,
  PRIMARY KEY (`id_caixa`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `PAV_AV1`.`MovimentoCaixa`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `PAV_AV1`.`MovimentoCaixa` (
  `id_caixa` INT NOT NULL,
  `numero_movimento` INT NOT NULL,
  `data_movimento` DATE NOT NULL,
  `hora_movimento` TIME NOT NULL,
  `descricao` VARCHAR(45) NOT NULL,
  `tipo_movimento` VARCHAR(45) NOT NULL,
  `valor` DOUBLE NOT NULL,
  PRIMARY KEY (`id_caixa`, `numero_movimento`),
  CONSTRAINT `fk_MovimentoCaixa_Caixa`
    FOREIGN KEY (`id_caixa`)
    REFERENCES `PAV_AV1`.`Caixa` (`id_caixa`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


SET SQL_MODE=@OLD_SQL_MODE;
SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS;
SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS;
