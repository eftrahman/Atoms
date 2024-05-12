-- phpMyAdmin SQL Dump
-- version 5.1.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Nov 24, 2021 at 05:22 PM
-- Server version: 10.4.20-MariaDB
-- PHP Version: 8.0.9

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `atomdata`
--

-- --------------------------------------------------------

--
-- Table structure for table `abundance`
--

CREATE TABLE `abundance` (
  `atomic_number` decimal(4,0) DEFAULT NULL,
  `atomic_symbol` varchar(5) NOT NULL,
  `universe` varchar(25) DEFAULT NULL,
  `solar` varchar(25) DEFAULT NULL,
  `meteor` varchar(25) DEFAULT NULL,
  `crust` varchar(25) DEFAULT NULL,
  `ocean` varchar(25) DEFAULT NULL,
  `human` varchar(25) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `abundance`
--

INSERT INTO `abundance` (`atomic_number`, `atomic_symbol`, `universe`, `solar`, `meteor`, `crust`, `ocean`, `human`) VALUES
('47', 'Ag', '6.0E-8%', '1.0E-7%', '0.000014%', '7.9E-6%', '1.0E-8%', 'N/A'),
('13', 'Al', '0.005%', '0.0060%', '0.91%', '8.1%', '5.0E-7%', '0.00009%'),
('18', 'Ar', '0.02%', '0.007%', 'N/A', '0.00015%', '0.000045%', 'N/A'),
('33', 'As', '8.0E-7%', 'N/A', '0.00018%', '0.00021%', '2.3E-7%', '5.0E-6%'),
('5', 'B', '1.00E-7%', '2.0E-7%', '0.00016%', '0.00086%', '0.00044%', '0.000070%'),
('4', 'Be', '1.00E-7%', '1.0E-8%', '2.9E-6%', '0.00019%', '6.0E-11%', '4.0E-8%'),
('35', 'Br', '7.0E-7%', 'N/A', '0.00012%', '0.0003%', '0.0067%', '0.00029%'),
('6', 'C', '0.50%', '0.30%', '1.5%', '0.18%', '0.0028%', '23%'),
('20', 'Ca', '0.0070%', '0.007%', '1.1%', '5%', '0.00042%', '1.4%'),
('48', 'Cd', '2.0E-7%', '6.0E-7%', '0.000044%', '0.000015%', '5.0E-9%', '0.00007%'),
('17', 'Cl', '0.0001%', '0.0008%', '0.037%', '0.017%', '2%', '0.12%'),
('27', 'Co', '0.0003%', '0.0004%', '0.059%', '0.030%', '8.0E-9%', '2.0E-6%'),
('24', 'Cr', '0.0015%', '0.002%', '0.3%', '0.014%', '6.0E-8%', '3.0E-6%'),
('29', 'Cu', '6.0E-6%', '0.00007%', '0.011%', '0.0068%', '3.0E-7%', '0.0001%'),
('9', 'F', '0.00004%', '0.00005%', '0.0087%', '0.054%', '0.00013%', '0.0037%'),
('26', 'Fe', '0.11%', '0.10%', '22%', '6.3%', '3.0E-7%', '0.006%'),
('31', 'Ga', '1.00E-6%', '4.0E-6%', '0.00076%', '0.0019%', '0.0E-9%', 'N/A%'),
('32', 'Ge', '0.00002%', '0.00002%', '0.0021%', '0.00014%', '6.0E-6%', 'N/A%'),
('1', 'H', '75%', '75%', '2.4%', '0.15%', '11%', '10%'),
('2', 'He', '23%', '23%', 'N/A', '5.5E-7%', '7.2E-10%', 'N/A'),
('49', 'In', '3.0E-8%', '4.0E-7%', '4.4E-6%', '0.000016%', '1.0E-11%', 'N/A'),
('19', 'K', '0.0003%', '0.0004%', '0.07%', '1.5%', '0.042%', '0.2%'),
('36', 'Kr', '4.0E-6%', 'N/A', 'N/A', '1.5E-8%', '2.1E-8%', 'N/A'),
('3', 'Li', '6.0E-7%', '6.0E-9%', '0.00017%', '0.0017%', '0.000018%', '3.0E-6%'),
('12', 'Mg', '0.060%', '0.07%', '12%', '2.9%', '0.13%', '0.027%'),
('25', 'Mn', '0.0008%', '0.001%', '0.27%', '0.11%', '2.0E-7%', '0.00002%'),
('42', 'Mo', '5.0E-7%', '9.0E-7%', '0.00012%', '0.00011%', '1.0E-6%', '0.00001%'),
('7', 'N', '0.100%', '0.10%', '0.14%', '0.0020%', '0.000050%', '2.6%'),
('11', 'Na', '0.002%', '0.004%', '0.55%', '2.3%', '1.1%', '0.14%'),
('41', 'Nb', '2.0E-7%', '4.0E-7%', '0.000019%', '0.0017%', '1.0E-1%', 'N/A%'),
('10', 'Ne', '0.13%', '0.10%', 'N/A', '3.0E-7%', '1.2E-8%', 'N/A'),
('28', 'Ni', '0.006%', '0.008%', '1.3%', '0.0089%', '2.0E-7%', '0.00001%'),
('8', 'O', '1%', '0.90%', '40%', '46%', '86%', '61%'),
('15', 'P', '0.0007%', '0.0007%', '0.11%', '0.099%', '7.0E-6%', '1.1%'),
('46', 'Pd', '2.0E-7%', '3.0E-7%', '0.000066%', '6.3E-7%', 'N/A', 'N/A'),
('37', 'Rb', '1.0E-6%', '3.0E-6%', '0.00032%', '0.006%', '0.000012%', '0.00046%'),
('45', 'Rh', '6.0E-8%', '2.0E-7%', '0.000018%', '7.0E-8%', 'N/A', 'N/A'),
('44', 'Ru', '4.0E-7%', '5.0E-7%', '0.000081%', '9.9E-8%', '7.0E-11%', 'N/A%'),
('16', 'S', '0.05%', '0.04%', '4%', '0.042%', '0.093%', '0.2%'),
('21', 'Sc', '3.0E-6%', '4.0E-6%', '0.00064%', '0.0026%', '1.5E-10%', 'N/A'),
('34', 'Se', '3.0E-6%', 'N/A', '0.0013%', '5.0E-6%', '4.5E-8%', '5.0E-6%'),
('14', 'Si', '0.070%', '0.90%', '14%', '27%', '0.0001%', '0.026%'),
('50', 'Sn', '4.0E-7%', '9.0E-7%', '0.00012%', '0.00022%', '1.0E-9%', '0.00001%'),
('38', 'Sr', '4.0E-6%', '5.0E-6%', '0.00087%', '0.036%', '0.00081%', '0.00046%'),
('22', 'T', '0.0003%', '0.0004%', '0.054%', '0.66%', '1.0E-7%', 'N/A'),
('43', 'Tc', '0%', '0%', '0%', '0%', '0%', '0%'),
('23', 'V', '0.0001%', '0.00004%', '0.0061%', '0.019%', '1.5E-7%', '3.0E-6%'),
('39', 'Y', '7.0E-7%', '1.0E-6%', '0.00019%', '0.0029%', '1.3E-9%', 'N/A'),
('30', 'Zn', '0.00003%', '0.0002%', '0.018%', '0.0078%', '5.0E-7%', '0.0033%'),
('40', 'Zr', '5.0E-6%', '4.0E-6%', '0.00066%', '0.013%', '2.6E-9%', '5.0E-6%');

-- --------------------------------------------------------

--
-- Table structure for table `atoms`
--

CREATE TABLE `atoms` (
  `atomic_number` decimal(4,0) NOT NULL,
  `atomic_symbol` varchar(5) NOT NULL,
  `name` varchar(15) DEFAULT NULL,
  `discovered` varchar(12) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `atoms`
--

INSERT INTO `atoms` (`atomic_number`, `atomic_symbol`, `name`, `discovered`) VALUES
('1', 'H', 'Hydrogen', '1766'),
('2', 'He', 'Helium', '1895'),
('3', 'Li', 'Lithium', '1817'),
('4', 'Be', 'Beryllium', '1797'),
('5', 'B', 'Boron', '1808'),
('6', 'C', 'Carbon', '3750_BCE'),
('7', 'N', 'Nitrogen', '1772'),
('8', 'O', 'Oxygen', '1774'),
('9', 'F', 'Fluorine', '1886'),
('10', 'Ne', 'Neon', '1898'),
('11', 'Na', 'Sodium', '1807'),
('12', 'Mg', 'Magnesium', '1755'),
('13', 'Al', 'Aluminium', '1825'),
('14', 'Si', 'Silicon', '1823'),
('15', 'P', 'Phosphorus', '1669'),
('16', 'S', 'Sulfur', '500_BCE'),
('17', 'Cl', 'Chlorine', '1774'),
('18', 'Ar', 'Argon', '1894'),
('19', 'K', 'Potassium', '1807'),
('20', 'Ca', 'Calcium', '1808'),
('21', 'Sc', 'Scandium', '1879'),
('22', 'Ti', 'Titanium', '1791'),
('23', 'V', 'Vandium', '1801'),
('24', 'Cr', 'Chromium', '1797'),
('25', 'Mn', 'Manganese', '1774'),
('26', 'Fe', 'Iron', '2000_BCE'),
('27', 'Co', 'Cobalt', '1735'),
('28', 'Ni', 'Nickel', '1751'),
('29', 'Cu', 'Copper', '8000_BCE'),
('30', 'Zn', 'Zinc', '1500'),
('31', 'Ga', 'Gallium', '1875'),
('32', 'Ge', 'Germanium', '1886'),
('33', 'As', 'Arsenic', '1250'),
('34', 'Se', 'Selenium', '1817'),
('35', 'Br', 'Bromine', '1826'),
('36', 'Kr', 'Krypton', '1898'),
('37', 'Rb', 'Rubidium', '1861'),
('38', 'Sr', 'Strontium', '1790'),
('39', 'Y', 'Yttrium', '1794'),
('40', 'Zr', 'Zirconium', '1789'),
('41', 'Nb', 'Niobium', '1801'),
('42', 'Mo', 'Molybdenum', '1781'),
('43', 'Tc', 'Technetium', '1937'),
('44', 'Ru', 'Ruthenium', '1844'),
('45', 'Rh', 'Rhodium', '1803'),
('46', 'Pd', 'Palladium', '1803'),
('47', 'Ag', 'Silver', '3000_BCE'),
('48', 'Cd', 'Cadmium', '1817'),
('49', 'In', 'Indium', '1863'),
('50', 'Sn', 'Tin', '3000_BCE'),
('51', 'Sb', 'Antimony', '3000_BCE'),
('52', 'Te', 'Tellurium', '1783'),
('53', 'I', 'Iodine', '1811'),
('54', 'Xe', 'Xenon', '1898'),
('55', 'Cs', 'Caesium', '1860'),
('56', 'Ba', 'Barium', '1808'),
('57', 'La', 'Lanthanum', '1839'),
('58', 'Ce', 'Cerium', '1803'),
('59', 'Pr', 'Praseodymium', '1885'),
('60', 'Nd', 'Neodymium', '1885'),
('61', 'Pm', 'Promethium', '1945'),
('62', 'Sm', 'Samarium', '1879'),
('63', 'Eu', 'Europium', '1901'),
('64', 'Gd', 'Gadolinium', '1880'),
('65', 'Tb', 'Terbium', '1843'),
('66', 'Dy', 'Dysprosium', '1886'),
('67', 'Ho', 'Holmium', '1878'),
('68', 'Er', 'Erbium', '1803'),
('69', 'Tm', 'Thulium', '1879'),
('70', 'Yb', 'Ytterbium', '1878'),
('71', 'Lu', 'Lutetium', '1907'),
('72', 'Hf', 'Hafnium', '1923'),
('73', 'Ta', 'Tantalum', '1802'),
('74', 'W', 'Tungsten', '1783'),
('75', 'Re', 'Rhenium', '1925'),
('76', 'Os', 'Osmium', '1803'),
('77', 'Ir', 'Iridium', '1803'),
('78', 'Pt', 'Platinum', '1735'),
('79', 'Au', 'Gold', '2500_BCE'),
('80', 'Hg', 'Mercury', '1500_BCE'),
('81', 'Tl', 'Thallium', '1861'),
('82', 'Pb', 'Lead', '4000_BCE'),
('83', 'Bi', 'Bismuth', '1400'),
('84', 'Po', 'Polonium', '1898'),
('85', 'At', 'Astatine', '1940'),
('86', 'Rn', 'Radon', '1900'),
('87', 'Fr', 'Francium', '1939'),
('88', 'Ra', 'Radium', '1898'),
('89', 'Ac', 'Actinium', '1899'),
('90', 'Th', 'Thorium', '1829'),
('91', 'Pa', 'Protactinium', '1913'),
('92', 'U', 'Uranium', '1789'),
('93', 'Np', 'Neptunium', '1940'),
('94', 'Pu', 'Plutonium', '1940'),
('95', 'Am', 'Americium', '1944'),
('96', 'Cm', 'Curium', '1944'),
('97', 'Bk', 'Berkelium', '1949'),
('98', 'Cf', 'Californium', '1950'),
('99', 'Es', 'Einsteinium', '1952'),
('100', 'Fm', 'Fermium', '1952'),
('101', 'Md', 'Mendelevium', '1955'),
('102', 'No', 'Nobelium', '1958'),
('103', 'Lr', 'Lawrencium', '1961'),
('104', 'Rf', 'Rutherfordium', '1964'),
('105', 'Db', 'Dubnium', '1967'),
('106', 'Sg', 'Seaborgium', '1974'),
('107', 'Bh', 'Bohrium', '1981'),
('108', 'Hs', 'Hassium', '1984'),
('109', 'Mt', 'Meitnerium', '1982'),
('110', 'Ds', 'Darmstadtium', '1994'),
('111', 'Rg', 'Roentgenium', '1994'),
('112', 'Cn', 'Copernicium', '1996'),
('113', 'Nh', 'Nihonium', '2004'),
('114', 'Fl', 'Flerovium', '1998'),
('115', 'Ms', 'Moscovium', '2004'),
('116', 'Lv', 'Livermorium', '2000'),
('117', 'Ts', 'Tennessine', '2010'),
('118', 'Og', 'Oganesson', '2006');

-- --------------------------------------------------------

--
-- Table structure for table `electrons`
--

CREATE TABLE `electrons` (
  `atomic_number` decimal(4,0) DEFAULT NULL,
  `atomic_symbol` varchar(5) NOT NULL,
  `oxidation_states` varchar(25) DEFAULT NULL,
  `energy_level` varchar(25) DEFAULT NULL,
  `quantum_number` varchar(25) DEFAULT NULL,
  `isotopes` varchar(10) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `electrons`
--

INSERT INTO `electrons` (`atomic_number`, `atomic_symbol`, `oxidation_states`, `energy_level`, `quantum_number`, `isotopes`) VALUES
('89', 'Ac', '2,3', '2,8,18,32,18,9,2', 'l=2,m=-2,n=6', '31'),
('47', 'Ag', '1,2,3,4', '2,8,18,18,1', 'l=2,m=2,n=4', '38'),
('13', 'Al', '1,2,3', '2,8,3', 'l=1,m=-1,n=3', '22'),
('95', 'Am', '2,3,4,5,6', '2,8,18,32,25,8,2', 'l=3,m=3,n=5', '19'),
('18', 'Ar', '-N/A', '2,8,8', 'l=1,m=1,n=3', '24'),
('33', 'As', '-3,2,3,5', '2,8,18,5', 'l=1,m=1,n=4', '33'),
('85', 'At', '-1,1,3,5,7', '2,8,18,32,18,7', 'l=1,m=0,n=6', '31'),
('79', 'Au', '-1,1,2,3,5', '2,8,18,32,18,1', 'l=2,m=2,n=5', '37'),
('5', 'B', '1,2,3', '2,3', 'l=1,m=-1,n=2', '14'),
('56', 'Ba', '2', '2,8,18,18,8,2', 'l=0,m=0,n=6', '40'),
('4', 'Be', '1,2', '2,2', 'l=0,m=0,n=2', '12'),
('107', 'Bh', '7', '2,8,18,32,32,13,2', 'l=2,m=2,n=6', '16'),
('83', 'Bi', '-3,3,5', '2,8,18,32,18,5', 'l=1,m=1,n=6', '36'),
('97', 'Bk', '3,4', '2,8,18,32,27,8,2', 'l=3,m=-2,n=5', '20'),
('35', 'Br', '-1,1,3,4,5,7', '2,8,18,7', 'l=1,m=0,n=4', '31'),
('6', 'C', '-4,-3,-2,-1,1,2,3,4', '2,4', 'l=1,m=0,n=2', '15'),
('20', 'Ca', '1,2', '2,8,8,2', 'l=0,m=0,n=4', '24'),
('48', 'Cd', '1,2', '2,8,18,18,2', 'l=2,m=2,n=4', '38'),
('58', 'Ce', '2,3,4', '2,8,18,19,9,2', 'l=2,m=-2,n=5', '39'),
('98', 'Cf', '2,3,4', '2,8,18,32,28,8,2', 'l=3,m=-1,n=5', '20'),
('17', 'Cl', '-1,1,2,3,4,5,6,7', '2,8,7', 'l=1,m=0,n=3', '24'),
('96', 'Cm', '3,4', '2,8,18,32,25,9,2', 'l=2,m=-2,n=6', '20'),
('112', 'Cn', 'N/A', '2,8,18,32,32,18,2', 'l=2,m=2,n=6', '9'),
('27', 'Co', '-1,1,2,3,4,5', '2,8,15,2', 'l=2,m=-1,n=3', '29'),
('24', 'Cr', '-2,-1,1,2,3,4,5,6', '2,8,13,1', 'l=2,m=2,n=3', '26'),
('55', 'Cs', '-1,1', '2,8,18,18,8,1', 'l=0,m=0,n=6', '40'),
('29', 'Cu', '1,2,3,4', '2,8,18,1', 'l=2,m=2,n=3', '29'),
('105', 'Db', '5', '2,8,18,32,32,11,2', 'l=2,m=0,n=6', '16'),
('110', 'Ds', 'N/A', '2,8,18,32,32,17,1', 'l=2,m=1,n=6', '15'),
('66', 'Dy', '2,3', '2,8,18,28,8,2', 'l=3,m=-1,n=4', '36'),
('68', 'Er', '3', '2,8,18,30,8,2', 'l=3,m=1,n=4', '35'),
('99', 'Es', '2,3', '2,8,18,32,29,8,2', 'l=3,m=0,n=5', '19'),
('63', 'Eu', '2,3', '2,8,18,25,8,2', 'l=3,m=3,n=4', '38'),
('9', 'F', '-1', '2,7', 'l=1,m=0,n=2', '18'),
('26', 'Fe', '-2,-1,1,2,3,4,5,6', '2,8,14,2', 'l=2,m=-2,n=3', '28'),
('114', 'Fl', 'N/A', '2,8,18,32,32,18,4', 'l=1,m=0,n=7', '5'),
('100', 'Fm', '2,3', '2,8,18,32,30,8,2', 'l=3,m=1,n=5', '19'),
('87', 'Fr', '1', '2,8,18,32,18,8,1', 'l=0,m=0,n=7', '34'),
('31', 'Ga', '1,2,3', '2,8,18,3', 'l=1,m=-1,n=4', '31'),
('64', 'Gd', '1,2,3', '2,8,18,25,9,2', 'l=2,m=-2,n=5', '36'),
('32', 'Ge', '-4,1,2,3,4', '2,8,18,4', 'l=1,m=0,n=4', '32'),
('1', 'H', '-1,1', '1', 'l=0,m=0,n=1', '7'),
('2', 'He', 'N/A', '2', 'l=0,m=0,n=1', '9'),
('72', 'Hf', '2,3,4', '2,8,18,32,10,2', 'l=2,m=-1,n=5', '36'),
('80', 'Hg', '1,2,4', '2,8,18,32,18,2', 'l=2,m=2,n=5', '40'),
('67', 'Ho', '3', '2,8,18,29,8,2', 'l=3,m=0,n=4', '36'),
('108', 'Hs', '8', '2,8,18,32,32,14,2', 'l=2,m=-2,n=6', '15'),
('53', 'I', '-1,1,3,4,5,7', '2,8,18,18,7', 'l=1,m=0,n=5', '37'),
('49', 'In', '1,2,3', '2,8,18,18,3', 'l=1,m=-1,n=5', '39'),
('77', 'Ir', '-3,-1,1,2,3,4,5,6,7,8', '2,8,18,32,15,2', 'l=2,m=-1,n=5', '36'),
('19', 'K', '-1,1', '2,8,8,1', 'l=0,m=0,n=4', '24'),
('36', 'Kr', '2', '2,8,18,8', 'l=1,m=1,n=4', '32'),
('57', 'La', '2,3', '2,8,18,18,9,2', 'l=2,m=-2,n=5', '39'),
('3', 'Li', '1', '2,1', 'l=0,m=0,n=2', '10'),
('103', 'Lr', '3', '2,8,18,32,32,8,3', 'l=1,m=-1,n=7', '16'),
('71', 'Lu', '3', '2,8,18,32,9,2', 'l=2,m=-2,n=5', '35'),
('116', 'Lv', 'N/A', '2,8,18,32,32,18,6', 'l=1,m=-1,n=7', '4'),
('115', 'Mc', 'N/A', '2,8,18,32,32,18,5', 'l=1,m=1,n=7', '5'),
('101', 'Md', '2,3', '2,8,18,32,31,8,2', 'l=3,m=2,n=5', '18'),
('12', 'Mg', '1,2', '2,8,2', 'l=0,m=0,n=3', '22'),
('25', 'Mn', '-3,-2,-1,1,2,3,4,5,6,7', '2,8,13,2', 'l=2,m=2,n=3', '26'),
('42', 'Mo', '-2,-1,1,2,3,4,5,6', '2,8,18,13,1', 'l=2,m=2,n=4', '33'),
('109', 'Mt', 'N/A', '2,8,18,32,32,15,2', 'l=2,m=-1,n=6', '15'),
('7', 'N', '-3,-2,-1,1,2,3,4,5', '2,5', 'l=1,m=1,n=2', '16'),
('11', 'Na', '-1,1', '2,8,1', 'l=0,m=0,n=3', '20'),
('41', 'Nb', '-1,2,3,4,5', '2,8,18,12,1', 'l=2,m=1,n=4', '33'),
('60', 'Nd', '2,3', '2,8,18,22,8,2', 'l=3,m=0,n=4', '38'),
('10', 'Ne', 'N/A', '2,8', 'l=1,m=1,n=2', '19'),
('113', 'Nh', 'N/A', '2,8,18,32,32,18,3', 'l=1,m=-1,n=7', '5'),
('28', 'Ni', '-1,1,2,3,4', '2,8,16,2', 'l=2,m=0,n=3', '31'),
('102', 'No', '2,3', '2,8,18,32,32,8,2', 'l=3,m=3,n=5', '17'),
('93', 'Np', '3,4,5,6,7', '2,8,18,32,22,9,2', 'l=2,m=-2,n=6', '20'),
('8', 'O', '-2,-1,1,2', '2,6', 'l=1,m=-1,n=2', '17'),
('118', 'Og', 'N/A', '2,8,18,32,32,18,8', 'l=1,m=1,n=7', '1'),
('76', 'Os', '-2,1,2,3,4,5,6,7,8', '2,8,18,32,14,2', 'l=2,m=-2,n=5', '35'),
('15', 'P', '-3,-2,-1,1,2,3,4,5', '2,8,5', 'l=1,m=1,n=3', '23'),
('91', 'Pa', '2,3,4,5', '2,8,18,32,20,9,2', 'l=2,m=-2,n=6', '29'),
('82', 'Pb', '-4,2,4', '2,8,18,32,18,4', 'l=1,m=0,n=6', '38'),
('46', 'Pd', '2,4', '2,8,18,18', 'l=2,m=2,n=4', '34'),
('61', 'Pm', '3', '2,8,18,23,8,2', 'l=3,m=1,n=4', '38'),
('84', 'Po', '-2,2,4,6', '2,8,18,32,18,6', 'l=1,m=-1,n=6', '33'),
('59', 'Pr', '2,3,4', '2,8,18,21,8,2', 'l=3,m=-1,n=4', '39'),
('78', 'Pt', '2,4,5,6', '2,8,18,32,17,1', 'l=2,m=1,n=5', '37'),
('94', 'Pu', '3,4,5,6,7,8', '2,8,18,32,24,8,2', 'l=3,m=2,n=5', '20'),
('88', 'Ra', '2', '2,8,18,32,18,8,2', 'l=0,m=0,n=7', '33'),
('37', 'Rb', '-1,1', '2,8,18,8,1', 'l=0,m=0,n=5', '32'),
('75', 'Re', '-3,-1,1,2,3,4,5,6,7', '2,8,18,32,13,2', 'l=2,m=2,n=5', '35'),
('104', 'Rf', '4', '2,8,18,32,32,10,2', 'l=2,m=-1,n=6', '16'),
('111', 'Rg', 'N/A', '2,8,18,32,32,17,2', 'l=2,m=1,n=6', '12'),
('45', 'Rh', '-1,1,2,3,4,5,6', '2,8,18,16,1', 'l=2,m=0,n=4', '34'),
('86', 'Rn', '2', '2,8,18,32,18,8', 'l=1,m=1,n=6', '34'),
('44', 'Ru', '-2,1,2,3,4,5,6,7,8', '2,8,18,15,1', 'l=2,m=-1,n=4', '34'),
('16', 'S', '-2,-1,1,2,3,4,5,6', '2,8,6', 'l=1,m=-1,n=3', '24'),
('51', 'Sb', '-3,3,5', '2,8,18,18,5', 'l=1,m=1,n=5', '37'),
('21', 'Sc', '1,2,3', '2,8,9,2', 'l=2,m=-2,n=3', '25'),
('34', 'Se', '-2,1,2,4,6', '2,8,18,6', 'l=1,m=-1,n=4', '30'),
('106', 'Sg', '6', '2,8,18,32,32,12,2', 'l=2,m=1,n=6', '16'),
('14', 'Si', '-4,-3,-2,-1,1,2,3,4', '2,8,4', 'l=1,m=0,n=3', '23'),
('62', 'Sm', '2,3', '2,8,18,24,8,2', 'l=3,m=2,n=4', '38'),
('50', 'Sn', '-4,2,4', '2,8,18,18,4', 'l=1,m=0,n=5', '39'),
('38', 'Sr', '1,2', '2,8,18,8,2', 'l=0,m=0,n=5', '33'),
('73', 'Ta', '-1,2,3,4,5', '2,8,18,32,11,2', 'l=2,m=0,n=5', '36'),
('65', 'Tb', '1,3,4', '2,8,18,27,8,2', 'l=3,m=-2,n=4', '36'),
('43', 'Tc', '-3,-1,1,2,3,4,5,6,7', '2,8,18,13,2', 'l=2,m=2,n=4', '34'),
('52', 'Te', '-2,2,4,5,6', '2,8,18,18,6', 'l=1,m=-1,n=5', '38'),
('90', 'Th', '2,3,4', '2,8,18,32,18,10,2', 'l=2,m=-1,n=6', '30'),
('22', 'Ti', '-1,2,3,4', '2,8,10,2', 'l=2,m=-1,n=3', '26'),
('81', 'Tl', '1,3', '2,8,18,32,18,3', 'l=1,m=-1,n=6', '37'),
('69', 'Tm', '2,3', '2,8,18,31,8,2', 'l=3,m=2,n=4', '35'),
('117', 'Ts', 'N/A', '2,8,18,32,32,18,7', 'l=1,m=0,n=7', '4'),
('92', 'U', '2,3,4,5,6', '2,8,18,32,21,9,2', 'l=2,m=-2,n=6', '26'),
('23', 'V', '-1,1,2,3,4,5', '2,8,11,2', 'l=2,m=0,n=3', '26'),
('74', 'W', '-2,-1,1,2,3,4,5,6', '2,8,18,32,12,2', 'l=2,m=1,n=5', '35'),
('54', 'Xe', '2,4,6,8', '2,8,18,18,8', 'l=1,m=1,n=5', '38'),
('39', 'Y', '1,2,3', '2,8,18,9,2', 'l=2,m=-2,n=4', '33'),
('70', 'Yb', '2,3', '2,8,18,32,8,2', 'l=3,m=3,n=4', '35'),
('30', 'Zn', '1,2', '2,8,18,2', 'l=2,m=2,n=3', '30'),
('40', 'Zr', '1,2,3,4', '2,8,18,10,2', 'l=2,m=-1,n=4', '33');

-- --------------------------------------------------------

--
-- Table structure for table `hdc`
--

CREATE TABLE `hdc` (
  `atomic_number` decimal(4,0) NOT NULL,
  `atomic_symbol` varchar(5) DEFAULT NULL,
  `hardness` varchar(30) DEFAULT NULL,
  `density` varchar(30) DEFAULT NULL,
  `conductivity` varchar(30) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `hdc`
--

INSERT INTO `hdc` (`atomic_number`, `atomic_symbol`, `hardness`, `density`, `conductivity`) VALUES
('1', 'H', 'N/A', '0.0899 kg/m³', '0.1805 W/mK'),
('2', 'He', 'N/A', '0.1785  kg/m³', 'o.1513 W/mK'),
('3', 'Li', 'N/A', '535  kg/m³', '85 W/mK'),
('4', 'Be', '600 MPa', '1848  kg/m³', '190 W/mK'),
('5', 'B', 'N/A', '2460 kg/m³', '27 W/mK'),
('6', 'C', 'N/A', '2260 kg/m³', '140 W/mK'),
('7', 'N', 'N/A', '1.251 kg/m³', '0.02583 W/mK'),
('8', 'O', 'N/A', '1.429 kg/m³', '0.02658 W/mK');

-- --------------------------------------------------------

--
-- Table structure for table `modulus_heat`
--

CREATE TABLE `modulus_heat` (
  `atomic_number` decimal(4,0) NOT NULL,
  `atomic_symbol` varchar(5) DEFAULT NULL,
  `modulus` varchar(30) DEFAULT NULL,
  `heat` varchar(30) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `modulus_heat`
--

INSERT INTO `modulus_heat` (`atomic_number`, `atomic_symbol`, `modulus`, `heat`) VALUES
('1', 'H', 'N/A', '14300 J/kgK'),
('2', 'He', 'N/A', '5193.1 J/kgK'),
('3', 'Li', '11 GPa', '3570 J/kgK'),
('4', 'Be', '130 GPa', '1820 J/kgK'),
('5', 'B', '320 GPa', '1030 J/kgK'),
('6', 'C', '33 GPa', '710 J/kgK'),
('7', 'N', 'N/A', '1040 J/kgK'),
('8', 'O', 'N/A', '919 J/kgK');

-- --------------------------------------------------------

--
-- Table structure for table `properties`
--

CREATE TABLE `properties` (
  `atomic_number` decimal(4,0) DEFAULT NULL,
  `atomic_symbol` varchar(5) NOT NULL,
  `series` varchar(30) DEFAULT NULL,
  `weight` varchar(30) DEFAULT NULL,
  `energy_level` varchar(30) DEFAULT NULL,
  `electronegativity` varchar(30) DEFAULT NULL,
  `melting_point` varchar(30) DEFAULT NULL,
  `boiling_point` varchar(30) DEFAULT NULL,
  `electron_affinity` varchar(30) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `properties`
--

INSERT INTO `properties` (`atomic_number`, `atomic_symbol`, `series`, `weight`, `energy_level`, `electronegativity`, `melting_point`, `boiling_point`, `electron_affinity`) VALUES
('89', 'Ac', 'Actinoid', '227 u', '2,8,18,32,18,9,2', '1.1', '1050 °C', '3200 °C', 'N/A kJ/mol'),
('47', 'Ag', 'Transition metal', '107.8682 u', '2,8,18,18,1', '1.93', '961.780 °C', '2162 °C', '125.6 kJ/mol'),
('13', 'Al', 'Post-transition metal', '26.9815385 u', '2,8,3', '1.61', '660.32 °C', '2519 °C', '42.5 kJ/mol'),
('95', 'Am', 'Actinoid', '243 u', '2,8,18,32,25,8,2', '1.3', '1176 °C', '2011 °C', 'N/A kJ/mol'),
('18', 'Ar', 'Noble Gas', '39.948 u', '2,8,8', 'N/A', '-189 °C', '-186 °C', '0 kJ/mol'),
('33', 'As', 'Metalloid', '74.921595 u', '2,8,18,5', '2.18', '816.9 °C', '614 °C', '78 kJ/mol'),
('85', 'At', 'Metalloid', '210 u', '2,8,18,32,18,7', '2.2', '302 °C', '350 °C', '270.1 kJ/mol'),
('79', 'Au', 'Transition metal', '196.966569 u', '2,8,18,32,18,1', '2.54', '1064.18°C', '2856 °C', '222.8 kJ/mol'),
('5', 'B', 'Metalloids', '10.81 u', '2,3', '2.04', '2075 °C', '4000 °C', '26.7 kJ/mol'),
('56', 'Ba', 'Alkaline  earth metal', '137.327 u', '2,8,18,18,8,2', '0.89', '730 °C', '1870 °C', '13.95 kJ/mol'),
('4', 'Be', 'Alkaline Earth Metal', '9.012183 u', '2,2', '1.57', '1287 °C', '2470 °C', '0 kJ/mol'),
('107', 'Bh', 'Transition metal', '270 u', '2,8,18,32,32,13,2', 'N/A', 'N/A °C', 'N/A °C', 'N/A kJ/mol'),
('83', 'Bi', 'Post-transition metal', '208.98040 u', '2,8,18,32,18,5', '2.02', '271.3 °C', '1564 °C', '91.2 kJ/mol'),
('97', 'Bk', 'Actinoid', '247 u', '2,8,18,32,27,8,2', '1.3', '1050 °C', 'N/A °C', 'N/A kJ/mol'),
('35', 'Br', 'Reactive nonmetal', '79.904 u', '2,8,18,7', '2.96', '-7.350 °C', '58.9 °C', '324.6 kJ/mol'),
('6', 'C', 'Reactive Non-metal', '12.011 u', '2,4', '2.55', '3642 °C', '3642 °C', '153.9 kJ/mol'),
('20', 'Ca', 'Alkaline earth metal', '40.078 u', '2,8,8,2', '1.0', '841.9 °C', '1484 °C', '2.37 kJ/mol'),
('48', 'Cd', 'Transition metal', '112.414 u', '2,8,18,18,2', '1.69', '321.07 °C', '766.9 °C', '0 kJ/mol'),
('58', 'Ce', 'Lanthanoide', '140.116 u', '2,8,18,19,9,2', '1.12', '797.9 °C', '3360 °C', '50 kJ/mol'),
('98', 'Cf', 'Actinoid', '251 u', '2,8,18,32,28,8,2', '1.3', '899.9 °C', 'N/A °C', 'N/A kJ/mol'),
('17', 'Cl', 'Reactive nonmetal', '35.45 u', '2,8,7', '3.16', '-101.5 °C', '-34.040 °C', '349 kJ/mol'),
('96', 'Cm', 'Actinoid', '247 u', '2,8,18,32,25,9,2', '1.3', '1345 °C', '3110 °C', 'N/A kJ/mol'),
('112', 'Cn', 'N/A', '285 u', '2,8,18,32,32,18,2', 'N/A', 'N/A °C', 'N/A °C', 'N/A kJ/mol'),
('27', 'Co', 'Transition metal', '58.933194 u', '2,8,15,2', '1.88', '1495 °C', '2900 °C', '63.7 kJ/mol'),
('24', 'Cr', 'Transition metal', '51.9961 u', '2,8,13,1', '1.66', '1907 °C', '2671 °C', '64.3 kJ/mol'),
('55', 'Cs', 'Alkali metal', '132.90545196 u', '2,8,18,18,8,1', '0.79', '28.440 °C', '671 °C', '45.5 kJ/mol'),
('29', 'Cu', 'Transition metal', '63.546 u', '2,8,18,1', '1.90', '1084.62 °C', '2562 °C', '118.4 kJ/mol'),
('105', 'Db', 'Transition metal', '268 u', '2,8,18,32,32,11,2', 'N/A', 'N/A °C', 'N/A °C', 'N/A kJ/mol'),
('110', 'Ds', 'N/A', '281 u', '2,8,18,32,32,17,1', 'N/A', 'N/A °C', 'N/A °C', 'N/A kJ/mol'),
('66', 'Dy', 'Lanthanide', '162.500 u', '2,8,18,28,8,2', '1.22', '1412 °C', '2567 °C', '50 kJ/mol'),
('68', 'Er', 'Lanthanide', '167.259 u', '2,8,18,30,8,2', '1.24', '1497 °C', '2868 °C', '50 kJ/mol'),
('99', 'Es', 'Actinoid', '252 u', '2,8,18,32,29,8,2', '1.3', '859.9 °C', 'N/A °C', 'N/A kJ/mol'),
('63', 'Eu', 'Lanthanide', '151.964 u', '2,8,18,25,8,2', 'N/A', '821.9 °C', '1500 °C', '50 kJ/mol'),
('9', 'F', 'Reactive nonmetal', '18.998403163 u', '2,7', '3.98', '-220 °C', '-188.1 °C', '328 kJ/mol'),
('26', 'Fe', 'Transition metal', '55.845 u', '2,8,14,2', '1.83', '1538 °C', '2861 °C', '15.7 kJ/mol'),
('114', 'Fl', 'N/A', '289 u', '2,8,18,32,32,18,4', 'N/A', 'N/A °C', 'N/A °C', 'N/A kJ/mol'),
('100', 'Fm', 'Actinoid', '257 u', '2,8,18,32,30,8,2', '1.3', '1500 °C', 'N/A °C', 'N/A kJ/mol'),
('87', 'Fr', 'Alkali metal', '223 u', '2,8,18,32,18,8,1', '0.7', '20.9 °C', '650 °C', 'N/A kJ/mol'),
('31', 'Ga', 'Post-transition metal', '69.723 u', '2,8,18,3', '1.81', '29.760 °C', '2204 °C', '28.9 kJ/mol'),
('64', 'Gd', 'Lanthanide', '157.25 u', '2,8,18,25,9,2', '1.20', '1313 °C', '3250 °C', '50 kJ/mol'),
('32', 'Ge', 'Metalloid', '72.63 u', '2,8,18,4', '2.01', '938.25 °C', '2820 °C', '119 kJ/mol'),
('1', 'H', 'Reactive Non-metal', '1.008 u', '1', '2.20', '-259.1 °C', '-252.9 °C', '72.8 kJ/mol'),
('2', 'He', 'Noble Gas', '4.002602 u', '2', 'N/A', 'N/A °C', '-269 °C', '0 kJ/mol'),
('72', 'Hf', 'Transition metal', '178.486 u', '2,8,18,32,10,2', '1.3', '2233 °C', '4603 °C', '0 kJ/mol'),
('80', 'Hg', 'Transition metal', '200.59 u', '2,8,18,32,18.2', '2.0', '-38.830 °C', '356.73 °C', '0 kJ/mol'),
('67', 'Ho', 'Lanthanide', '164.93033 u', '2,8,18,29,8,2', '1.23', '1474 °C', '2700 °C', '50 kJ/mol'),
('108', 'Hs', 'Transition metal', '270 u', '2,8,18,32,32,14,2', 'N/A', 'N/A °C', 'N/A°C', 'N/A kJ/mol'),
('53', 'I', 'Reactive nonmetal', '126.90447 u', '2,8,18,18,7', '2.66', '113.70 °C', '184.3 °C', '295.2 kJ/mol'),
('49', 'In', 'Post-transition metal', '114.818 u', '2,8,18,18,3', '1.78', '156.60 °C', '2072 °C', '28.9 kJ/mol'),
('77', 'Ir', 'Transition metal', '192.217 u', '2,8,18,32,15,2', '2.20', '2466 °C', '4428 °C', '151 kJ/mol'),
('19', 'K', 'Alkali metal', '39.0983 u', '2,8,8,1', '0.82', '63.380 °C', '758.9 °C', '48.4 kJ/mol'),
('36', 'Kr', 'Noble Gas', '83.798 u', '2,8,18,8', '3.0', '-157.36 °C', '-153.22 °C', '0 kJ/mol'),
('57', 'La', 'Lanthanoide', '138.90547 u', '2,8,18,18,9,2', '1.19', '919.9 °C', '3464 °C', '48 kJ/mol'),
('3', 'Li', 'Alkali', '6.94 u', '2,1', '0.98', '180.54 °C', '1342 °C', '59.6 kJ/mol'),
('103', 'Lr', 'Actinoid', '266 u', '2,8,18,32,32,8,3', 'N/A', '1600 °C', 'N/A °C', 'N/A kJ/mol'),
('71', 'Lu', 'Lanthanide', '174.9668 u', '2,8,18,32,9,2', '1.27', '1663 °C', '3402 °C', '50 kJ/mol'),
('116', 'Lv', 'N/A', '293 u', '2,8,18,32,32,18,6', 'N/A', 'N/A °C', 'N/A °C', 'N/A kJ/mol'),
('115', 'Mc', 'N/A', '290 u', '2,8,18,32,32,18,5', 'N/A', 'N/A °C', 'N/A °C', 'N/A kJ/mol'),
('101', 'Md', 'Actinoid', '258 u', '2,8,18,32,31,8,2', '1.3', '830 °C', 'N/A °C', 'N/A kJ/mol'),
('12', 'Mg', 'Alkaline earth metal', '24.305 u', '2,8,2', '1.31', '650 °C', '1090 °C', '0 kJ/mol'),
('25', 'Mn', 'Transition metal', '54.938044 u', '2,8,13,2', '1.55', '1246 °C', '2061 °C', '0 kJ/mol'),
('42', 'Mo', 'Transition metal', '95.95 u', '2,8,18,13,1', '2.16', '2623 °C', '4639 °C', '71.9 kJ/mol'),
('109', 'Mt', 'N/A', '278 u', '2,8,18,32,32,15,2', 'N/A', 'N/A °C', 'N/A °C', 'N/A kJ/mol'),
('7', 'N', 'Reactive Non-metal', '14.007 u', '2,5', '3.04', '-210.1 °C', '-195.8 °C', '7 kJ/mol'),
('11', 'Na', 'Alkali metal', '22.98976928 u', '2,8,1', '0.93', '97.720 °C', '882.9 °C', '52.8 kJ/mol'),
('41', 'Nb', 'Transition metal', '92.90637 u', '2,8,18,12,1', '1.6', '2477 °C', '4744 °C', '86.1 kJ/mol'),
('60', 'Nd', 'Lanthanide', '144.242 u', '2,8,18,22,8,2', '1.14', '1021 °C', '3100 °C', '50 kJ/mol'),
('10', 'Ne', 'Noble Gas', '20.1797 u', '2,8', 'N/A', '-248.6 °C', '-246.1 °C', '0 kJ/mol'),
('113', 'Nh', 'N/A', '286 u', '2,8,18,32,32,18,3', 'N/A', 'N/A °C', 'N/A °C', 'N/A kJ/mol'),
('28', 'Ni', 'Transition metal', '58.6934 u', '2,8,16,2', '1.91', '1455 °C', '2913 °C', '112 kJ/mol'),
('102', 'No', 'Actinoid', '259 u', '2,8,18,32,32,8,2', '1.3', '830 °C', 'N/A °C', 'N/A kJ/mol'),
('93', 'Np', 'Actinoid', '237 u', '2,8,18,32,22,9,2', '1.36', '644 °C', '4000 °C', 'N/A kJ/mol'),
('8', 'O', 'Reactive Non-metal', '15.999 u', '2,6', '3.44', '-218 °C', '-183 °C', '141 kJ/mol'),
('118', 'Og', 'N/A', '294 u', '2,8,18,32,32,18,8', 'N/A', 'N/A °C', 'N/A °C', 'N/A kJ/mol'),
('76', 'Os', 'Transition metal', '190.23 u', '2,8,18,32,14,2', '2.2', '3033 °C', '5012 °C', '106.1 kJ/mol'),
('15', 'P', 'Reactive nonmetal', '30.973761998 u', '2,8,5', '2.19', '44.15 °C', '280.5 °C', '72 kJ/mol'),
('91', 'Pa', 'Actinoid', '231.03588 u', '2,8,18,32,20,9,2', '1.5', '1572 °C', '4000 °C', 'N/A kJ/mol'),
('82', 'Pb', 'Post-transition metal', '207.2 u', '2,8,18,32,18,4', '2.33', '327.46 °C', '1749 °C', '35.1 kJ/mol'),
('46', 'Pd', 'Transition metal', '106.42 u', '2,8,18,18', '2.20', '1554.90 °C', '2963 °C', '53.7 kJ/mol'),
('61', 'Pm', 'Lanthanide', '145 u', '2,8,18,23,8,2', 'N/A', '1100 °C', '3000 °C', '50 kJ/mol'),
('84', 'Po', 'Post-transition metal', '209 u', '2,8,18,32,18,6', '2.0', '255 °C', '961.9 °C', '183.3 kJ/mol'),
('59', 'Pr', 'Lanthanide', '140.90766 u', '2,8,18,21,8,2', '1.13', '930.9 °C', '3290 °C', '50 kJ/mol'),
('78', 'Pt', 'Transition metal', '195.084 u', '2,8,18,32,17,1', '2.28', '1768.3°C', '3825 °C', '205.3 kJ/mol'),
('94', 'Pu', 'Actinoid', '244 u', '2,8,18,32,24,8,2', '1.28', '640 °C', '3230 °C', 'N/A kJ/mol'),
('88', 'Ra', 'Alkaline earth metal', '226 u', '2,8,18,32,18,8,2', '0.9', '700 °C', '1737 °C', 'N/A kJ/mol'),
('37', 'Rb', 'Alkali metal', '85.4678 u', '2,8,18,8,1', '0.82', '39.310 °C', '688 °C', '46.9 kJ/mol'),
('75', 'Re', 'Transition metal', '186.207 u', '2,8,18,32,13,2', '1.9', '3186 °C', '5596 °C', '14.5 kJ/mol'),
('104', 'Rf', 'Transition metal', '267 u', '2,8,18,32,32,10,2', 'N/A', 'N/A °C', 'N/A °C', 'N/A kJ/mol'),
('111', 'Rg', 'N/A', '282 u', '2,8,18,32,32,17,2', 'N/A', 'N/A °C', 'N/A °C', 'N/A kJ/mol'),
('45', 'Rh', 'Transition metal', '102.90550 u', '2,8,18,16,1', '2.28', '1964 °C', '3695 °C', '109.7 kJ/mol'),
('86', 'Rn', 'Noble Gas', '222 u', '2,8,18,32,18,8', 'N/A', '-71.1 °C', '-61.85 °C', '0 kJ/mol'),
('44', 'Ru', 'Transition metal', '101.07 u', '2,8,18,15,1', '2.2', '2334 °C', '4150 °C', '101.3 kJ/mol'),
('16', 'S', 'Reactive nonmetal', '32.06 u', '2,8,6', '2.58', '115.21 °C', '444.72 °C', '200 kJ/mol'),
('51', 'Sb', 'Metalloid', '121.760 u', '2,8,18,18,5', '2.05', '630.63 °C', '1587 °C', '103.2 kJ/mol'),
('21', 'Sc', 'Transition metal', '44.955908 u', '2,8,9,2', '1.36', '1541 °C', '2830 °C', '18.1 kJ/mol'),
('34', 'Se', 'Reactive nonmetal', '78.971 u', '2,8,18,6', '2.55', '221 °C', '685 °C', '195 kJ/mol'),
('106', 'Sg', 'Transition metal', '269 u', '2,8,18,32,32,12,2', 'N/A', 'N/A °C', 'N/A °C', 'N/A kJ/mol'),
('14', 'Si', 'Metalloid', '28.085 u', '2,8,4', '1.90', '1414 °C', '2900 °C', '133.6 kJ/mol'),
('62', 'Sm', 'Lanthanide', '150.36 u', '2,8,18,24,8,2', '1.17', '1072 °C', '1803 °C', '50 kJ/mol'),
('50', 'Sn', 'Post-transition metal', '118.710 u', '2,8,18,18,4', '1.96', '231.93 °C', '2602 °C', '107.3 kJ/mol'),
('38', 'Sr', 'Alkaline earth metal', '87.62 u', '2,8,18,8,2', '0.95', '776.9 °C', '1382 °C', '5.03 kJ/mol'),
('73', 'Ta', 'Transition metal', '180.94788 u', '2,8,18,32,11,2', '1.5', '3017 °C', '5458 °C', '31 kJ/mol'),
('65', 'Tb', 'Lanthanide', '158.92535 u', '2,8,18,27,8,2', 'N/A', '1356 °C', '3230 °C', '50 kJ/mol'),
('43', 'Tc', 'Transition metal', '98 u', '2,8,18,13,2', '1.9', '2157 °C', '4265 °C', '53 kJ/mol'),
('52', 'Te', 'Metalloid', '127.60 u', '2,8,18,18,6', '2.1', '449.51 °C', '987.9 °C', '190.2 kJ/mol'),
('90', 'Th', 'Actinoid', '232.0377 u', '2,8,18,32,18,10,2', '1.3', '1750 °C', '4820 °C', 'N/A kJ/mol'),
('22', 'Ti', 'Transition metal', '47.867 u', '2,8,10,2', '1.54', '1668 °C', '3287 °C', '7.6 kJ/mol'),
('81', 'Tl', 'Post-transition metal', '204.38 u', '2,8,18,32,18,3', '1.62', '304 °C', '1473 °C', '19.2 kJ/mol'),
('69', 'Tm', 'Lanthanide', '168.93422 u', '2,8,18,31,8,2', '1.25', '1545 °C', '1950 °C', '50 kJ/mol'),
('117', 'Ts', 'N/A', '294 u', '2,8,18,32,32,18,7', 'N/A', 'N/A °C', 'N/A °C', 'N/A kJ/mol'),
('92', 'U', 'Actinoid', '238.02891 u', '2,8,18,32,21,9,2', '1.38', '1135 °C', '3900 °C', 'N/A kJ/mol'),
('23', 'V', 'Transition metal', '50.9415 u', '2,8,11,2', '1.68', '1910 °C', '3407 °C', '50.6 kJ/mol'),
('74', 'W', 'Transition metal', '183.84 u', '2,8,18,32,12,2', '2.36', '3422 °C', '5555 °C', '78.6 kJ/mol'),
('54', 'Xe', 'Noble Gas', '131.293 u', '2,8,18,18,8', '2.6', '-111.8 °C', '-108.0 °C', '0 kJ/mol'),
('39', 'Y', 'Transition metal', '88.90584 u', '2,8,18,9,2', '1.22', '1526 °C', '3345 °C', '29.6 kJ/mol'),
('70', 'Yb', 'Lanthanide', '173.045 u', '2,8,18,32,8,2', 'N/A', '818.9 °C', '1196 °C', '50 kJ/mol'),
('30', 'Zn', 'Transition metal', '65.38 u', '2,8,18,2', '1.65', '419.53 °C', '906.9 °C', '0 kJ/mol'),
('40', 'Zr', 'Transition metal', '91.224 u', '2,8,18,10,2', '1.33', '1855 °C', '4409 °C', '41.1 kJ/mol');

-- --------------------------------------------------------

--
-- Table structure for table `radius`
--

CREATE TABLE `radius` (
  `atomic_number` decimal(4,0) NOT NULL,
  `atomic_symbol` varchar(5) DEFAULT NULL,
  `radius` varchar(15) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `radius`
--

INSERT INTO `radius` (`atomic_number`, `atomic_symbol`, `radius`) VALUES
('1', 'H', '53 pm'),
('2', 'He', '31 pm'),
('3', 'Li', '167 pm'),
('4', 'Be', '112 pm'),
('5', 'B', '87 pm'),
('6', 'C', '67 pm'),
('7', 'N', '56 pm'),
('8', 'O', '48 pm');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `abundance`
--
ALTER TABLE `abundance`
  ADD PRIMARY KEY (`atomic_symbol`),
  ADD KEY `atomic_number` (`atomic_number`);

--
-- Indexes for table `atoms`
--
ALTER TABLE `atoms`
  ADD PRIMARY KEY (`atomic_number`,`atomic_symbol`);

--
-- Indexes for table `electrons`
--
ALTER TABLE `electrons`
  ADD PRIMARY KEY (`atomic_symbol`),
  ADD KEY `atomic_number` (`atomic_number`);

--
-- Indexes for table `hdc`
--
ALTER TABLE `hdc`
  ADD PRIMARY KEY (`atomic_number`),
  ADD KEY `atomic_symbol` (`atomic_symbol`);

--
-- Indexes for table `modulus_heat`
--
ALTER TABLE `modulus_heat`
  ADD PRIMARY KEY (`atomic_number`),
  ADD KEY `atomic_symbol` (`atomic_symbol`);

--
-- Indexes for table `properties`
--
ALTER TABLE `properties`
  ADD PRIMARY KEY (`atomic_symbol`),
  ADD KEY `atomic_number` (`atomic_number`);

--
-- Indexes for table `radius`
--
ALTER TABLE `radius`
  ADD PRIMARY KEY (`atomic_number`),
  ADD KEY `atomic_symbol` (`atomic_symbol`);

--
-- Constraints for dumped tables
--

--
-- Constraints for table `abundance`
--
ALTER TABLE `abundance`
  ADD CONSTRAINT `abundance_ibfk_1` FOREIGN KEY (`atomic_number`) REFERENCES `atoms` (`atomic_number`) ON DELETE SET NULL;

--
-- Constraints for table `electrons`
--
ALTER TABLE `electrons`
  ADD CONSTRAINT `electrons_ibfk_1` FOREIGN KEY (`atomic_number`) REFERENCES `atoms` (`atomic_number`) ON DELETE SET NULL;

--
-- Constraints for table `hdc`
--
ALTER TABLE `hdc`
  ADD CONSTRAINT `hdc_ibfk_1` FOREIGN KEY (`atomic_symbol`) REFERENCES `properties` (`atomic_symbol`) ON DELETE SET NULL;

--
-- Constraints for table `modulus_heat`
--
ALTER TABLE `modulus_heat`
  ADD CONSTRAINT `modulus_heat_ibfk_1` FOREIGN KEY (`atomic_symbol`) REFERENCES `properties` (`atomic_symbol`) ON DELETE SET NULL;

--
-- Constraints for table `properties`
--
ALTER TABLE `properties`
  ADD CONSTRAINT `properties_ibfk_1` FOREIGN KEY (`atomic_number`) REFERENCES `atoms` (`atomic_number`) ON DELETE SET NULL;

--
-- Constraints for table `radius`
--
ALTER TABLE `radius`
  ADD CONSTRAINT `radius_ibfk_1` FOREIGN KEY (`atomic_symbol`) REFERENCES `properties` (`atomic_symbol`) ON DELETE SET NULL;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
