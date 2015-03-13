-- phpMyAdmin SQL Dump
-- version 3.3.9
-- http://www.phpmyadmin.net
--
-- Host: localhost
-- Generation Time: Mar 07, 2015 at 09:01 AM
-- Server version: 5.1.53
-- PHP Version: 5.3.4

SET SQL_MODE="NO_AUTO_VALUE_ON_ZERO";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

--
-- Database: `dbclums`
--

-- --------------------------------------------------------

--
-- Table structure for table `tblbilling`
--

CREATE TABLE IF NOT EXISTS `tblbilling` (
  `ID` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `BillingInfoID` int(10) unsigned NOT NULL,
  `ItemNumber` varchar(45) NOT NULL,
  `ItemName` varchar(45) NOT NULL,
  `Category` varchar(45) NOT NULL,
  `Description` text NOT NULL,
  `Price` decimal(10,2) NOT NULL,
  `Quantity` int(10) unsigned NOT NULL,
  `TotalPrice` decimal(10,2) NOT NULL,
  PRIMARY KEY (`ID`),
  KEY `BillingInfoID` (`BillingInfoID`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=7 ;

--
-- Dumping data for table `tblbilling`
--

INSERT INTO `tblbilling` (`ID`, `BillingInfoID`, `ItemNumber`, `ItemName`, `Category`, `Description`, `Price`, `Quantity`, `TotalPrice`) VALUES
(1, 1, '5', 'Item12', 'Fertilizers', 'ItemDesc12', '12.00', 1, '12.00'),
(2, 2, '5', 'Item12', 'Fertilizers', 'ItemDesc12', '12.00', 1, '12.00'),
(3, 3, '5', 'Item12', 'Fertilizers', 'ItemDesc12', '12.00', 1, '12.00'),
(4, 4, '5', 'Item12', 'Fertilizers', 'ItemDesc12', '12.00', 1, '12.00'),
(5, 4, '5', 'Item12', 'Fertilizers', 'ItemDesc12', '12.00', 1, '12.00'),
(6, 5, '5', 'Item12', 'Fertilizers', 'ItemDesc12', '12.00', 1, '12.00');

-- --------------------------------------------------------

--
-- Table structure for table `tblbillinginfo`
--

CREATE TABLE IF NOT EXISTS `tblbillinginfo` (
  `ID` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `User` varchar(45) NOT NULL,
  `CustomerName` text NOT NULL,
  `CustomerAddress` text NOT NULL,
  `TotalItemsSold` int(10) unsigned NOT NULL,
  `TotalDue` decimal(10,2) NOT NULL,
  `BillDate` datetime DEFAULT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=6 ;

--
-- Dumping data for table `tblbillinginfo`
--

INSERT INTO `tblbillinginfo` (`ID`, `User`, `CustomerName`, `CustomerAddress`, `TotalItemsSold`, `TotalDue`, `BillDate`) VALUES
(1, ' admin (Administrator)', 'Ferdie', 'temp address', 1, '12.00', '2015-03-07 00:00:00'),
(2, ' admin (Administrator)', 'Ferdie', 'temp address', 1, '12.00', '2015-03-07 00:00:00'),
(3, ' admin (Administrator)', 'Unknown', 'N/A', 1, '12.00', '2015-03-07 00:00:00'),
(4, ' admin (Administrator)', 'Cing', 'N/A', 2, '24.00', '2015-03-07 00:00:00'),
(5, ' admin (Administrator)', 'Unknown2222', 'N/A', 1, '12.00', '2015-03-07 00:00:00');

-- --------------------------------------------------------

--
-- Table structure for table `tblcategory`
--

CREATE TABLE IF NOT EXISTS `tblcategory` (
  `ID` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `Name` varchar(45) NOT NULL,
  `Description` text NOT NULL,
  `Status` varchar(45) NOT NULL,
  PRIMARY KEY (`ID`),
  KEY `Name` (`Name`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=3 ;

--
-- Dumping data for table `tblcategory`
--

INSERT INTO `tblcategory` (`ID`, `Name`, `Description`, `Status`) VALUES
(1, 'Flowers', 'Flowers Collection', 'Active'),
(2, 'Fertilizers', 'Fertilizers', 'Active');

-- --------------------------------------------------------

--
-- Table structure for table `tblinventory`
--

CREATE TABLE IF NOT EXISTS `tblinventory` (
  `ItemNumber` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `ItemName` varchar(45) NOT NULL,
  `Category` varchar(45) NOT NULL,
  `Description` text NOT NULL,
  `Price` double(10,2) NOT NULL,
  `Stock` int(11) NOT NULL,
  `NoOfItemSold` int(11) NOT NULL DEFAULT '0',
  `DateAdded` text NOT NULL,
  `Image` text NOT NULL,
  `Status` varchar(45) NOT NULL,
  PRIMARY KEY (`ItemNumber`),
  KEY `Category` (`Category`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=7 ;

--
-- Dumping data for table `tblinventory`
--

INSERT INTO `tblinventory` (`ItemNumber`, `ItemName`, `Category`, `Description`, `Price`, `Stock`, `NoOfItemSold`, `DateAdded`, `Image`, `Status`) VALUES
(5, 'Item12', 'Fertilizers', 'ItemDesc12', 12.00, 96, 0, '3/7/2015 9:50:13 AM', 'Chrysanthemum.jpg', 'Active'),
(6, 'Red Rose', 'Fertilizers', 'Red Roses', 120.00, 12, 0, '3/7/2015 2:38:30 PM', 'Chrysanthemum.jpg', 'Active');

-- --------------------------------------------------------

--
-- Table structure for table `tbluser`
--

CREATE TABLE IF NOT EXISTS `tbluser` (
  `ID` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `Username` varchar(45) NOT NULL,
  `Password` varchar(45) NOT NULL,
  `Usertype` varchar(45) NOT NULL,
  `Status` varchar(45) NOT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=5 ;

--
-- Dumping data for table `tbluser`
--

INSERT INTO `tbluser` (`ID`, `Username`, `Password`, `Usertype`, `Status`) VALUES
(2, 'admin1', 'svkLRj9nYEgZo7gWDJD5IQ==', 'Administrator', 'Active'),
(3, 'grace', 'Wj7VoVOy/+7ytLNAvim/Yw==', 'Regular', 'Active'),
(4, 'ferdie', 'fc0iUkg331qk3V8HY6MWvQ==', 'Administrator', 'Active');

--
-- Constraints for dumped tables
--

--
-- Constraints for table `tblbilling`
--
ALTER TABLE `tblbilling`
  ADD CONSTRAINT `tblbilling_ibfk_1` FOREIGN KEY (`BillingInfoID`) REFERENCES `tblbillinginfo` (`ID`);

--
-- Constraints for table `tblinventory`
--
ALTER TABLE `tblinventory`
  ADD CONSTRAINT `tblinventory_ibfk_1` FOREIGN KEY (`Category`) REFERENCES `tblcategory` (`Name`) ON DELETE NO ACTION ON UPDATE NO ACTION;
