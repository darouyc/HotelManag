-- phpMyAdmin SQL Dump
-- version 4.8.4
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1:3306
-- Generation Time: Jul 04, 2021 at 06:40 PM
-- Server version: 5.7.24
-- PHP Version: 7.3.1

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `hotelman`
--

-- --------------------------------------------------------

--
-- Table structure for table `reservation`
--

DROP TABLE IF EXISTS `reservation`;
CREATE TABLE IF NOT EXISTS `reservation` (
  `res_id` int(11) NOT NULL AUTO_INCREMENT,
  `res_date` datetime NOT NULL,
  `room_num` int(11) NOT NULL,
  PRIMARY KEY (`res_id`)
) ENGINE=MyISAM AUTO_INCREMENT=24 DEFAULT CHARSET=latin1;

--
-- Dumping data for table `reservation`
--

INSERT INTO `reservation` (`res_id`, `res_date`, `room_num`) VALUES
(1, '2021-07-03 00:00:00', 1),
(2, '2021-07-03 00:00:00', 7),
(3, '2021-07-03 00:00:00', 4),
(4, '2021-07-03 00:00:00', 10),
(5, '2021-07-03 19:50:34', 11),
(6, '2021-07-03 19:57:14', 11),
(7, '2021-07-03 19:59:17', 8),
(8, '2021-07-03 20:00:57', 11),
(9, '2021-07-03 20:01:00', 8),
(10, '2021-07-03 20:05:21', 11),
(11, '2021-07-16 20:08:56', 11),
(12, '2021-07-03 20:23:31', 11),
(13, '2021-07-03 20:46:20', 11),
(14, '2021-07-03 20:46:27', 12),
(15, '2021-07-03 20:47:59', 11),
(16, '2021-07-03 20:49:55', 8),
(17, '2021-07-03 21:39:44', 3),
(18, '2021-07-15 00:00:00', 11),
(19, '2021-07-24 22:18:34', 11),
(20, '2021-07-04 18:47:32', 11),
(21, '2021-07-17 19:05:52', 8),
(22, '2021-07-31 19:07:24', 5),
(23, '2021-07-04 19:11:03', 6);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
