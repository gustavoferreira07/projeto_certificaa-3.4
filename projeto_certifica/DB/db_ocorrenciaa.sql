-- --------------------------------------------------------
-- Servidor:                     127.0.0.1
-- Versão do servidor:           10.1.34-MariaDB - mariadb.org binary distribution
-- OS do Servidor:               Win32
-- HeidiSQL Versão:              9.5.0.5196
-- --------------------------------------------------------

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET NAMES utf8 */;
/*!50503 SET NAMES utf8mb4 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;


-- Copiando estrutura do banco de dados para db_ocorrencia
CREATE DATABASE IF NOT EXISTS `db_ocorrencia` /*!40100 DEFAULT CHARACTER SET latin1 */;
USE `db_ocorrencia`;

-- Copiando estrutura para tabela db_ocorrencia.tb_edit
CREATE TABLE IF NOT EXISTS `tb_edit` (
  `id_edit` int(11) NOT NULL AUTO_INCREMENT,
  `id_ocorrencia` varchar(10) DEFAULT NULL,
  `nm_usuario` varchar(20) DEFAULT NULL,
  `dia_edit` varchar(20) DEFAULT NULL,
  PRIMARY KEY (`id_edit`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- Exportação de dados foi desmarcado.
-- Copiando estrutura para tabela db_ocorrencia.tb_historico
CREATE TABLE IF NOT EXISTS `tb_historico` (
  `id_historico` int(11) NOT NULL AUTO_INCREMENT,
  `id_ocorrencia` varchar(10) DEFAULT NULL,
  `nm_usuari` varchar(20) DEFAULT NULL,
  `data_edit` datetime DEFAULT NULL,
  PRIMARY KEY (`id_historico`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- Exportação de dados foi desmarcado.
-- Copiando estrutura para tabela db_ocorrencia.tb_ocorrencia
CREATE TABLE IF NOT EXISTS `tb_ocorrencia` (
  `id_ocorrencia` varchar(15) NOT NULL,
  `nm_usuario` varchar(20) DEFAULT NULL,
  `status_ocorrencia` varchar(25) DEFAULT NULL,
  `nm_proprietario` varchar(60) DEFAULT NULL,
  `cpf_proprietario` varchar(15) DEFAULT NULL,
  `celular_proprietario` varchar(15) DEFAULT NULL,
  `endereco_proprietario` varchar(60) DEFAULT NULL,
  `rg_proprietario` varchar(13) DEFAULT NULL,
  `cnh_proprietario` varchar(20) DEFAULT NULL,
  `renavan` varchar(15) DEFAULT NULL,
  `modelo_carro` varchar(20) DEFAULT NULL,
  `placa` varchar(8) DEFAULT NULL,
  `cor` varchar(15) DEFAULT NULL,
  `ano` varchar(12) DEFAULT NULL,
  `ds_ocorrencia` varchar(500) DEFAULT NULL,
  `data_entrada` varchar(15) DEFAULT NULL,
  `hora_entrada` varchar(5) DEFAULT NULL,
  `area` varchar(1) DEFAULT NULL,
  `img_entrada` longblob,
  `img_saida` longblob,
  `img_avaria` longblob,
  `img_ocorrencia` longblob,
  `pergunta1` varchar(4) DEFAULT NULL,
  `pergunta2` varchar(4) DEFAULT NULL,
  `pergunta3` varchar(4) DEFAULT NULL,
  `pergunta4` varchar(4) DEFAULT NULL,
  `pergunta5` varchar(4) DEFAULT NULL,
  `pergunta6` varchar(4) DEFAULT NULL,
  `pergunta7` varchar(4) DEFAULT NULL,
  `pergunta8` varchar(4) DEFAULT NULL,
  PRIMARY KEY (`id_ocorrencia`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- Exportação de dados foi desmarcado.
-- Copiando estrutura para tabela db_ocorrencia.tb_orcamento
CREATE TABLE IF NOT EXISTS `tb_orcamento` (
  `id_orcamento` int(11) NOT NULL AUTO_INCREMENT,
  `id_ocorrencia` varchar(20) DEFAULT NULL,
  `status_orcamento` varchar(30) DEFAULT NULL,
  `tipo_orcamento` varchar(30) DEFAULT NULL,
  `ds_orcamento` varchar(600) DEFAULT NULL,
  `data_conclusao` varchar(11) DEFAULT NULL,
  `valor` double DEFAULT NULL,
  `motivo_status` varchar(600) DEFAULT NULL,
  `img_recibo` longblob,
  PRIMARY KEY (`id_orcamento`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- Exportação de dados foi desmarcado.
-- Copiando estrutura para tabela db_ocorrencia.tb_servico
CREATE TABLE IF NOT EXISTS `tb_servico` (
  `id_servico` int(11) NOT NULL AUTO_INCREMENT,
  `nm_servico` varchar(60) DEFAULT NULL,
  PRIMARY KEY (`id_servico`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- Exportação de dados foi desmarcado.
-- Copiando estrutura para tabela db_ocorrencia.tb_usuario
CREATE TABLE IF NOT EXISTS `tb_usuario` (
  `id_usuario` int(11) NOT NULL AUTO_INCREMENT,
  `nm_usuario` varchar(20) DEFAULT NULL,
  `nm_senha` varchar(100) DEFAULT NULL,
  `nm_cargo` varchar(20) DEFAULT NULL,
  PRIMARY KEY (`id_usuario`),
  UNIQUE KEY `nm_usuario` (`nm_usuario`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=latin1;

-- Exportação de dados foi desmarcado.
/*!40101 SET SQL_MODE=IFNULL(@OLD_SQL_MODE, '') */;
/*!40014 SET FOREIGN_KEY_CHECKS=IF(@OLD_FOREIGN_KEY_CHECKS IS NULL, 1, @OLD_FOREIGN_KEY_CHECKS) */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
