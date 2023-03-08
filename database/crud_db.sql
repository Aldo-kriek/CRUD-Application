-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Jan 10, 2023 at 12:13 AM
-- Server version: 10.4.24-MariaDB
-- PHP Version: 8.1.6

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `crud_db`
--

-- --------------------------------------------------------

--
-- Table structure for table `tbldetails`
--

CREATE TABLE `tbldetails` (
  `ID` int(200) NOT NULL,
  `Name` varchar(250) NOT NULL,
  `Surname` varchar(250) NOT NULL,
  `Birthday` date NOT NULL,
  `Salary` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `tbldetails`
--

INSERT INTO `tbldetails` (`ID`, `Name`, `Surname`, `Birthday`, `Salary`) VALUES
(11, 'Sophie ', 'Cole', '1989-03-28', 'R10 000'),
(13, 'Annabella ', 'Griffiths', '1985-11-10', 'R60 000'),
(14, 'Rowan ', 'Murphy', '1994-10-03', 'R40 000'),
(15, 'Jessie ', 'Richards', '1978-11-14', 'R60 000'),
(16, 'Emerson ', 'Willis', '1990-05-14', 'R90 000'),
(17, 'Nancy ', 'Green', '1999-08-07', 'R80 000'),
(18, 'Penelope ', 'Holland', '1985-12-17', 'R70 000'),
(19, 'Lila ', 'Barker', '2001-10-07', 'R60 000'),
(20, 'Abigail ', 'Martin', '1985-03-09', 'R60 000'),
(21, 'Belle ', 'Matthews', '1985-11-01', 'R80 000'),
(22, 'Dakota ', 'Black', '1987-02-19', 'R40 000'),
(23, 'Tilly ', 'Hughes', '2000-05-14', 'R30 000'),
(24, 'Mateo ', 'Hill', '1983-04-15', 'R30 000'),
(25, 'Liam ', 'Nicholson', '1983-08-26', 'R40 000'),
(26, 'Spencer ', 'Reynolds', '1979-08-13', 'R90 000'),
(27, 'Billie ', 'Dixon', '1996-11-24', 'R50 000'),
(30, 'Juliette ', 'Cunningham', '1993-09-19', 'R30 000'),
(43, 'Sally', 'Timbers', '2007-05-20', 'R40 000'),
(53, 'Matilda', 'Rose', '1989-06-27', 'R90 000'),
(54, 'Henny', 'Van Tonder', '2000-04-08', 'R60 000'),
(55, 'Timothy', 'Smith', '2004-06-02', 'R20 000');

-- --------------------------------------------------------

--
-- Table structure for table `tblforminfo`
--

CREATE TABLE `tblforminfo` (
  `ID` int(11) NOT NULL,
  `FirstName` varchar(100) CHARACTER SET utf8 DEFAULT NULL,
  `Surname` varchar(100) CHARACTER SET utf8 DEFAULT NULL,
  `Birthday` datetime DEFAULT NULL,
  `Salary` varchar(100) CHARACTER SET utf8 DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Indexes for dumped tables
--

--
-- Indexes for table `tbldetails`
--
ALTER TABLE `tbldetails`
  ADD PRIMARY KEY (`ID`);

--
-- Indexes for table `tblforminfo`
--
ALTER TABLE `tblforminfo`
  ADD PRIMARY KEY (`ID`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `tbldetails`
--
ALTER TABLE `tbldetails`
  MODIFY `ID` int(200) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=56;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
