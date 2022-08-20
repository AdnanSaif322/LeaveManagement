-- phpMyAdmin SQL Dump
-- version 5.1.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Jan 05, 2022 at 08:35 AM
-- Server version: 10.4.22-MariaDB
-- PHP Version: 7.3.33

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `leave management`
--

-- --------------------------------------------------------

--
-- Table structure for table `admin_login`
--

CREATE TABLE `admin_login` (
  `User_Name` varchar(50) NOT NULL,
  `Password` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `admin_login`
--

INSERT INTO `admin_login` (`User_Name`, `Password`) VALUES
('admin', 'admin');

-- --------------------------------------------------------

--
-- Table structure for table `employee_application`
--

CREATE TABLE `employee_application` (
  `Id` int(11) NOT NULL,
  `Employee_Id` int(10) NOT NULL,
  `Employee_Name` varchar(50) NOT NULL,
  `Designation` varchar(50) NOT NULL,
  `From_Date` date NOT NULL,
  `To_Date` date NOT NULL,
  `Leave_Status` varchar(50) NOT NULL,
  `Status_Approve_or_not` varchar(50) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `employee_application`
--

INSERT INTO `employee_application` (`Id`, `Employee_Id`, `Employee_Name`, `Designation`, `From_Date`, `To_Date`, `Leave_Status`, `Status_Approve_or_not`) VALUES
(1, 5, 'df', 'fg', '2022-01-02', '2022-01-02', 'Half-Day', 'Rejected'),
(2, 5, 'df', 'fg', '2022-01-02', '2022-01-02', 'Full-Day', 'Rejected'),
(3, 5, 'df', 'fg', '2022-01-10', '2022-01-10', 'Half-Day', 'Accepted'),
(4, 4, 'we', 'de', '2022-01-02', '2022-01-02', 'Half-Day', 'Accepted'),
(5, 4, 'we', 'de', '2022-01-03', '2022-01-03', 'Full-Day', 'Accepted'),
(6, 3, 'ra', 'IT', '2022-01-02', '2022-01-02', 'Half-Day', 'Accepted'),
(7, 3, 'ra', 'IT', '2022-01-04', '2022-01-04', 'Full-Day', 'Rejected');

-- --------------------------------------------------------

--
-- Table structure for table `employee_database`
--

CREATE TABLE `employee_database` (
  `Employee_Id` int(10) NOT NULL,
  `Security_Id` varchar(50) NOT NULL,
  `Employee_Name` varchar(50) NOT NULL,
  `Designation` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `employee_database`
--

INSERT INTO `employee_database` (`Employee_Id`, `Security_Id`, `Employee_Name`, `Designation`) VALUES
(1, '12', 'sa', 'ew'),
(2, '123', 'saif', 'IT'),
(3, '12', 'ra', 'IT'),
(4, '12', 'we', 'de'),
(5, '12', 'df', 'fg');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `employee_application`
--
ALTER TABLE `employee_application`
  ADD PRIMARY KEY (`Id`),
  ADD KEY `fk_cat` (`Employee_Id`);

--
-- Indexes for table `employee_database`
--
ALTER TABLE `employee_database`
  ADD PRIMARY KEY (`Employee_Id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `employee_application`
--
ALTER TABLE `employee_application`
  MODIFY `Id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=8;

--
-- AUTO_INCREMENT for table `employee_database`
--
ALTER TABLE `employee_database`
  MODIFY `Employee_Id` int(10) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `employee_application`
--
ALTER TABLE `employee_application`
  ADD CONSTRAINT `fk_cat` FOREIGN KEY (`Employee_Id`) REFERENCES `employee_database` (`Employee_Id`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
