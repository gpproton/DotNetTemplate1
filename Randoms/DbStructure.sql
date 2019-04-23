# Host: localhost  (Version 5.6.37)
# Date: 2019-04-23 10:02:37
# Generator: MySQL-Front 6.1  (Build 1.26)


#
# Structure for table "category"
#

DROP TABLE IF EXISTS `category`;
CREATE TABLE `category` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `name` varchar(255) DEFAULT NULL,
  `desc` varchar(255) DEFAULT NULL,
  `categoryid` int(11) DEFAULT NULL,
  PRIMARY KEY (`Id`),
  KEY `categoryid` (`categoryid`),
  CONSTRAINT `category_ibfk_1` FOREIGN KEY (`categoryid`) REFERENCES `category` (`Id`) ON DELETE SET NULL ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

#
# Data for table "category"
#


#
# Structure for table "users"
#

DROP TABLE IF EXISTS `users`;
CREATE TABLE `users` (
  `Id` varchar(255) NOT NULL DEFAULT '',
  `fname` varchar(255) DEFAULT NULL,
  `lname` varchar(255) DEFAULT NULL,
  `uname` varchar(255) DEFAULT NULL,
  `email` varchar(1024) DEFAULT NULL,
  `password` varchar(1024) DEFAULT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

#
# Data for table "users"
#


#
# Structure for table "items"
#

DROP TABLE IF EXISTS `items`;
CREATE TABLE `items` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `suject` varchar(1024) DEFAULT NULL,
  `body` varchar(4000) DEFAULT NULL,
  `categoryid` int(11) DEFAULT NULL,
  `userid` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`Id`),
  KEY `userid` (`userid`),
  KEY `categoryid` (`categoryid`),
  CONSTRAINT `items_ibfk_1` FOREIGN KEY (`userid`) REFERENCES `users` (`Id`) ON DELETE SET NULL ON UPDATE NO ACTION,
  CONSTRAINT `items_ibfk_2` FOREIGN KEY (`categoryid`) REFERENCES `category` (`Id`) ON DELETE SET NULL ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

#
# Data for table "items"
#

