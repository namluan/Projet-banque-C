-- phpMyAdmin SQL Dump
-- version 5.0.2
-- https://www.phpmyadmin.net/
--
-- Hôte : 127.0.0.1:3306
-- Généré le : mer. 16 mars 2022 à 16:44
-- Version du serveur :  8.0.21
-- Version de PHP : 7.4.9

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de données : `comptes`
--
CREATE DATABASE comptes;
USE comptes;
-- --------------------------------------------------------

--
-- Structure de la table `client`
--

CREATE TABLE IF NOT EXISTS `client` (
  `numero` int NOT NULL,
  `nom` varchar(20) NOT NULL,
  `prenom` varchar(20) NOT NULL,
  `adresse` varchar(50) NOT NULL,
  PRIMARY KEY (`numero`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Déchargement des données de la table `client`
--

INSERT INTO `client` (`numero`, `nom`, `prenom`, `adresse`) VALUES
(1, 'bgn', 'bvn', 'test1'),
(15, 'cv', 'cv', 'cv'),
(110, 'ab', 'cd', '13 rue des platanes1'),
(120, 'ef', 'gh', '14 rue des oliviers'),
(150, 'fd', 'dfdf', '10 rue des plantes'),
(160, 'a', 'a', 'a'),
(170, 'z', 'z', 'z'),
(200, 'a', 'ab', 'dfre'),
(210, 'vgg', 'fgfg', 'fgfgfgfgg'),
(1000, 'n', 'n', 'n'),
(1150, 'd', 'd', 'd');

-- --------------------------------------------------------

--
-- Structure de la table `compte`
--

DROP TABLE IF EXISTS `compte`;
CREATE TABLE IF NOT EXISTS `compte` (
  `numCompte` int NOT NULL,
  `solde` int NOT NULL,
  `numClient` int NOT NULL,
  PRIMARY KEY (`numCompte`),
  KEY `numClient` (`numClient`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Déchargement des données de la table `compte`
--

INSERT INTO `compte` (`numCompte`, `solde`, `numClient`) VALUES
(1, 20, 110),
(2, 1520, 120),
(3, 1000, 110),
(4, 500, 120),
(5, 10, 170);

-- --------------------------------------------------------

--
-- Structure de la table `comptecourant`
--

DROP TABLE IF EXISTS `comptecourant`;
CREATE TABLE IF NOT EXISTS `comptecourant` (
  `numCompte` int NOT NULL,
  `decouvert` int NOT NULL,
  PRIMARY KEY (`numCompte`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Déchargement des données de la table `comptecourant`
--

INSERT INTO `comptecourant` (`numCompte`, `decouvert`) VALUES
(2, 200);

-- --------------------------------------------------------

--
-- Structure de la table `compteepargne`
--

DROP TABLE IF EXISTS `compteepargne`;
CREATE TABLE IF NOT EXISTS `compteepargne` (
  `numCompte` int NOT NULL,
  `tauxInteret` double NOT NULL,
  PRIMARY KEY (`numCompte`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Déchargement des données de la table `compteepargne`
--

INSERT INTO `compteepargne` (`numCompte`, `tauxInteret`) VALUES
(1, 0.5),
(3, 0),
(4, 2.56),
(5, 2);

--
-- Contraintes pour les tables déchargées
--

--
-- Contraintes pour la table `compte`
--
ALTER TABLE `compte`
  ADD CONSTRAINT `compte_ibfk_1` FOREIGN KEY (`numClient`) REFERENCES `client` (`numero`);

--
-- Contraintes pour la table `comptecourant`
--
ALTER TABLE `comptecourant`
  ADD CONSTRAINT `fk_constraint2` FOREIGN KEY (`numCompte`) REFERENCES `compte` (`numCompte`);

--
-- Contraintes pour la table `compteepargne`
--
ALTER TABLE `compteepargne`
  ADD CONSTRAINT `compteepargne_ibfk_1` FOREIGN KEY (`numCompte`) REFERENCES `compte` (`numCompte`) ON DELETE CASCADE ON UPDATE CASCADE;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
