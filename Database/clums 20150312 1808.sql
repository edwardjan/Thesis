-- MySQL Administrator dump 1.4
--
-- ------------------------------------------------------
-- Server version	5.0.27-community-nt


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;


--
-- Create schema dbclums
--

CREATE DATABASE IF NOT EXISTS dbclums;
USE dbclums;

--
-- Definition of table `tblbilling`
--

DROP TABLE IF EXISTS `tblbilling`;
CREATE TABLE `tblbilling` (
  `ID` int(10) unsigned NOT NULL auto_increment,
  `BillingInfoID` int(10) unsigned NOT NULL,
  `ItemNumber` varchar(45) NOT NULL,
  `ItemName` varchar(45) NOT NULL,
  `Category` varchar(45) NOT NULL,
  `Description` text NOT NULL,
  `Price` decimal(10,2) NOT NULL,
  `Quantity` int(10) unsigned NOT NULL,
  `TotalPrice` decimal(10,2) NOT NULL,
  PRIMARY KEY  (`ID`),
  KEY `tblbilling_ibfk_1` (`BillingInfoID`),
  CONSTRAINT `tblbilling_ibfk_1` FOREIGN KEY (`BillingInfoID`) REFERENCES `tblbillinginfo` (`ID`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tblbilling`
--

/*!40000 ALTER TABLE `tblbilling` DISABLE KEYS */;
INSERT INTO `tblbilling` (`ID`,`BillingInfoID`,`ItemNumber`,`ItemName`,`Category`,`Description`,`Price`,`Quantity`,`TotalPrice`) VALUES 
 (5,11,'1','Mum','Flower (Rose)','Red','5.00',1,'5.00'),
 (6,11,'1','Mum','Flower (Rose)','Red','5.00',1,'5.00');
/*!40000 ALTER TABLE `tblbilling` ENABLE KEYS */;


--
-- Definition of table `tblbillinginfo`
--

DROP TABLE IF EXISTS `tblbillinginfo`;
CREATE TABLE `tblbillinginfo` (
  `ID` int(10) unsigned NOT NULL auto_increment,
  `User` varchar(45) NOT NULL,
  `CustomerName` text NOT NULL,
  `CustomerAddress` text NOT NULL,
  `TotalItemsSold` int(10) unsigned NOT NULL,
  `TotalDue` double(10,2) NOT NULL,
  `BillDate` datetime default NULL,
  PRIMARY KEY  (`ID`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tblbillinginfo`
--

/*!40000 ALTER TABLE `tblbillinginfo` DISABLE KEYS */;
INSERT INTO `tblbillinginfo` (`ID`,`User`,`CustomerName`,`CustomerAddress`,`TotalItemsSold`,`TotalDue`,`BillDate`) VALUES 
 (11,' admin (Administrator)','Unknown','N/A',2,10.00,'2015-03-12 05:42:20');
/*!40000 ALTER TABLE `tblbillinginfo` ENABLE KEYS */;


--
-- Definition of table `tblcategory`
--

DROP TABLE IF EXISTS `tblcategory`;
CREATE TABLE `tblcategory` (
  `ID` int(10) unsigned NOT NULL auto_increment,
  `Name` varchar(45) NOT NULL,
  `Description` text NOT NULL,
  `Status` varchar(45) NOT NULL,
  PRIMARY KEY  (`ID`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tblcategory`
--

/*!40000 ALTER TABLE `tblcategory` DISABLE KEYS */;
INSERT INTO `tblcategory` (`ID`,`Name`,`Description`,`Status`) VALUES 
 (3,'Flower','Flower','Active');
/*!40000 ALTER TABLE `tblcategory` ENABLE KEYS */;


--
-- Definition of table `tblitem`
--

DROP TABLE IF EXISTS `tblitem`;
CREATE TABLE `tblitem` (
  `ItemNumber` int(10) unsigned NOT NULL auto_increment,
  `ItemName` varchar(45) NOT NULL,
  `MainCategory` varchar(45) NOT NULL,
  `SubCategory` varchar(45) NOT NULL,
  `Description` text NOT NULL,
  `Price` double(10,2) NOT NULL,
  `Stock` int(10) unsigned NOT NULL default '0',
  `NoOfItemSold` int(10) unsigned NOT NULL default '0',
  `DateAdded` text NOT NULL,
  `Image` text NOT NULL,
  `Status` varchar(45) NOT NULL,
  PRIMARY KEY  (`ItemNumber`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tblitem`
--

/*!40000 ALTER TABLE `tblitem` DISABLE KEYS */;
INSERT INTO `tblitem` (`ItemNumber`,`ItemName`,`MainCategory`,`SubCategory`,`Description`,`Price`,`Stock`,`NoOfItemSold`,`DateAdded`,`Image`,`Status`) VALUES 
 (1,'Mum','Flower','Rose','Red',5.00,89,11,'3/12/2015 4:59:55 PM','Chrysanthemum.jpg','Active');
/*!40000 ALTER TABLE `tblitem` ENABLE KEYS */;


--
-- Definition of table `tblsubcategory`
--

DROP TABLE IF EXISTS `tblsubcategory`;
CREATE TABLE `tblsubcategory` (
  `ID` int(10) unsigned NOT NULL auto_increment,
  `Name` varchar(45) NOT NULL,
  `Description` text NOT NULL,
  `MainCategory` varchar(45) NOT NULL,
  `Status` varchar(45) NOT NULL,
  PRIMARY KEY  (`ID`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tblsubcategory`
--

/*!40000 ALTER TABLE `tblsubcategory` DISABLE KEYS */;
INSERT INTO `tblsubcategory` (`ID`,`Name`,`Description`,`MainCategory`,`Status`) VALUES 
 (1,'Rose','Rose','Flower','Active'),
 (2,'Violet','Violet','Flower','Active');
/*!40000 ALTER TABLE `tblsubcategory` ENABLE KEYS */;


--
-- Definition of table `tbluser`
--

DROP TABLE IF EXISTS `tbluser`;
CREATE TABLE `tbluser` (
  `ID` int(10) unsigned NOT NULL auto_increment,
  `Username` varchar(45) NOT NULL,
  `Password` varchar(45) NOT NULL,
  `Usertype` varchar(45) NOT NULL,
  `Status` varchar(45) NOT NULL,
  PRIMARY KEY  (`ID`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tbluser`
--

/*!40000 ALTER TABLE `tbluser` DISABLE KEYS */;
INSERT INTO `tbluser` (`ID`,`Username`,`Password`,`Usertype`,`Status`) VALUES 
 (1,'admin','RNH4D9fHMcw2zbfLuMGlgA==','Administrator','Active');
/*!40000 ALTER TABLE `tbluser` ENABLE KEYS */;




/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
