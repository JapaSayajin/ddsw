-- phpMyAdmin SQL Dump
-- version 4.5.1
-- http://www.phpmyadmin.net
--
-- Host: 127.0.0.1
-- Generation Time: 05-Maio-2017 às 15:54
-- Versão do servidor: 10.1.13-MariaDB
-- PHP Version: 5.5.35

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `ddsw`
--

-- --------------------------------------------------------

--
-- Estrutura da tabela `contato`
--

CREATE TABLE `contato` (
  `cod` int(11) NOT NULL COMMENT 'Código único de contato (auto incrementado)',
  `nome` varchar(70) NOT NULL COMMENT 'Nome do cliente que está entrando em contato',
  `empresa` varchar(120) DEFAULT NULL COMMENT 'nome da empresa do cliente',
  `cargo` varchar(255) DEFAULT NULL COMMENT 'Cargo do cliente',
  `Email` varchar(255) NOT NULL COMMENT 'Email do cliente',
  `Obs` varchar(255) DEFAULT NULL COMMENT 'Observações sobre o projeto desejado pelo cliente',
  `Data` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP COMMENT 'data de registro do contato'
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Extraindo dados da tabela `contato`
--

INSERT INTO `contato` (`cod`, `nome`, `empresa`, `cargo`, `Email`, `Obs`, `Data`) VALUES
(3, 'lucas52', 'ELO', 'gerente de produÃ§Ã£o', 'luandasilvabezerra@gmail.com', 'Tenho urgencia no para enterga do trabalho para dia 28/11/2016', '2016-11-28 11:57:20');

-- --------------------------------------------------------

--
-- Estrutura da tabela `func`
--

CREATE TABLE `func` (
  `Cod` int(11) NOT NULL COMMENT 'Código único do funcionário (auto incrementado)',
  `Nome` varchar(255) NOT NULL COMMENT 'Nome do Funcionário',
  `CPF` int(11) NOT NULL COMMENT 'CPF do funcionário',
  `CEP` int(11) NOT NULL COMMENT 'código postal do endereço do funcionário',
  `num` varchar(255) NOT NULL COMMENT 'número da residência do funcionário',
  `comp` varchar(255) DEFAULT NULL COMMENT 'complemento do endereço do funcionário',
  `Email` varchar(255) DEFAULT NULL COMMENT 'Email de contato do funcionário',
  `RG` varchar(255) NOT NULL COMMENT 'RG do funcionário'
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Extraindo dados da tabela `func`
--

INSERT INTO `func` (`Cod`, `Nome`, `CPF`, `CEP`, `num`, `comp`, `Email`, `RG`) VALUES
(9, 'ddsw', 0, 2, '0000', '0000', 'ddsw@gmail.com', '000000');

-- --------------------------------------------------------

--
-- Estrutura da tabela `func_tarefas`
--

CREATE TABLE `func_tarefas` (
  `cod_func` int(11) DEFAULT NULL,
  `cod_tarefas` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estrutura da tabela `proj`
--

CREATE TABLE `proj` (
  `Cod` int(11) NOT NULL COMMENT 'código único de projeto (auto incrementado)',
  `codcontato` int(11) DEFAULT NULL COMMENT 'código do contato a qual o projeto se refere',
  `NomeProj` varchar(255) NOT NULL COMMENT 'Nome do projeto',
  `Obs` varchar(255) NOT NULL COMMENT 'Observações do projeto'
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Extraindo dados da tabela `proj`
--

INSERT INTO `proj` (`Cod`, `codcontato`, `NomeProj`, `Obs`) VALUES
(13, 3, 'Projeto Desentupidora', 'Site responsivo');

-- --------------------------------------------------------

--
-- Estrutura da tabela `tarefas`
--

CREATE TABLE `tarefas` (
  `cod` int(11) NOT NULL COMMENT 'código único de tarefa (auto incrementado)',
  `codproj` int(11) NOT NULL COMMENT 'código do projeto a qual a tarefa se refere',
  `descr` varchar(255) NOT NULL COMMENT 'descrição da tarefa',
  `done` datetime NOT NULL COMMENT 'Indica se tarefa está feita',
  `predecessora` int(11) DEFAULT NULL COMMENT 'código da tarefa predecessora',
  `previsao` datetime NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Extraindo dados da tabela `tarefas`
--

INSERT INTO `tarefas` (`cod`, `codproj`, `descr`, `done`, `predecessora`, `previsao`) VALUES
(20, 13, 'Testeteeee', '2017-05-05 00:00:00', NULL, '2017-05-26 00:00:00'),
(26, 13, ' aaaa ', '0000-00-00 00:00:00', NULL, '2017-05-06 00:00:00');

-- --------------------------------------------------------

--
-- Estrutura da tabela `users`
--

CREATE TABLE `users` (
  `cod` int(11) NOT NULL COMMENT 'código único de usuário',
  `User` varchar(25) NOT NULL COMMENT 'Nome de usuário',
  `Pass` varchar(50) NOT NULL COMMENT 'Senha',
  `Niv` int(11) NOT NULL COMMENT 'Nível de acesso do usuário'
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Extraindo dados da tabela `users`
--

INSERT INTO `users` (`cod`, `User`, `Pass`, `Niv`) VALUES
(9, 'ddsw', 'C1B90E6FED87AC2BE2DEB7C05D089290', 0);

--
-- Indexes for dumped tables
--

--
-- Indexes for table `contato`
--
ALTER TABLE `contato`
  ADD PRIMARY KEY (`cod`);

--
-- Indexes for table `func`
--
ALTER TABLE `func`
  ADD PRIMARY KEY (`Cod`);

--
-- Indexes for table `func_tarefas`
--
ALTER TABLE `func_tarefas`
  ADD KEY `cod_func` (`cod_func`),
  ADD KEY `cod_tarefas` (`cod_tarefas`);

--
-- Indexes for table `proj`
--
ALTER TABLE `proj`
  ADD PRIMARY KEY (`Cod`),
  ADD KEY `proj_fk` (`codcontato`);

--
-- Indexes for table `tarefas`
--
ALTER TABLE `tarefas`
  ADD PRIMARY KEY (`cod`),
  ADD KEY `tarefas_fk1` (`codproj`);

--
-- Indexes for table `users`
--
ALTER TABLE `users`
  ADD PRIMARY KEY (`cod`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `contato`
--
ALTER TABLE `contato`
  MODIFY `cod` int(11) NOT NULL AUTO_INCREMENT COMMENT 'Código único de contato (auto incrementado)', AUTO_INCREMENT=4;
--
-- AUTO_INCREMENT for table `func`
--
ALTER TABLE `func`
  MODIFY `Cod` int(11) NOT NULL AUTO_INCREMENT COMMENT 'Código único do funcionário (auto incrementado)', AUTO_INCREMENT=10;
--
-- AUTO_INCREMENT for table `proj`
--
ALTER TABLE `proj`
  MODIFY `Cod` int(11) NOT NULL AUTO_INCREMENT COMMENT 'código único de projeto (auto incrementado)', AUTO_INCREMENT=14;
--
-- AUTO_INCREMENT for table `tarefas`
--
ALTER TABLE `tarefas`
  MODIFY `cod` int(11) NOT NULL AUTO_INCREMENT COMMENT 'código único de tarefa (auto incrementado)', AUTO_INCREMENT=27;
--
-- Constraints for dumped tables
--

--
-- Limitadores para a tabela `func_tarefas`
--
ALTER TABLE `func_tarefas`
  ADD CONSTRAINT `func_tarefas_ibfk_1` FOREIGN KEY (`cod_func`) REFERENCES `func` (`Cod`),
  ADD CONSTRAINT `func_tarefas_ibfk_2` FOREIGN KEY (`cod_tarefas`) REFERENCES `tarefas` (`cod`);

--
-- Limitadores para a tabela `proj`
--
ALTER TABLE `proj`
  ADD CONSTRAINT `proj_fk` FOREIGN KEY (`codcontato`) REFERENCES `contato` (`cod`) ON DELETE SET NULL ON UPDATE CASCADE;

--
-- Limitadores para a tabela `tarefas`
--
ALTER TABLE `tarefas`
  ADD CONSTRAINT `tarefas_fk1` FOREIGN KEY (`codproj`) REFERENCES `proj` (`Cod`) ON DELETE CASCADE;

--
-- Limitadores para a tabela `users`
--
ALTER TABLE `users`
  ADD CONSTRAINT `users_fk1` FOREIGN KEY (`cod`) REFERENCES `func` (`Cod`) ON DELETE CASCADE;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
