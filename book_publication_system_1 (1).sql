-- phpMyAdmin SQL Dump
-- version 4.6.4
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Dec 03, 2016 at 03:59 AM
-- Server version: 5.7.14
-- PHP Version: 5.6.25

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `book_publication_system_1`
--

DELIMITER $$
--
-- Procedures
--
CREATE DEFINER=`root`@`localhost` PROCEDURE `get_employee_details` (IN `employee_id` INT(11), OUT `fname` VARCHAR(50), OUT `lname` VARCHAR(50), OUT `desig` ENUM('Editor','HR','Contract Manager','Vendor Manager'), OUT `dept` VARCHAR(50))  BEGIN
Select first_name into fname from Employee_PersonalDetails epd inner join Employee_OrganizationalDetails eod on epd.emp_id = eod.emp_id inner join Department d on eod.dept_id = d.dept_id  where epd.emp_id=employee_id;

Select last_name into lname from Employee_PersonalDetails epd inner join Employee_OrganizationalDetails eod on epd.emp_id = eod.emp_id inner join Department d on eod.dept_id = d.dept_id  where epd.emp_id=employee_id;

Select designation into desig from Employee_PersonalDetails epd inner join Employee_OrganizationalDetails eod on epd.emp_id = eod.emp_id inner join Department d on eod.dept_id = d.dept_id  where epd.emp_id=employee_id;

Select dept_name into dept from Employee_PersonalDetails epd inner join Employee_OrganizationalDetails eod on epd.emp_id = eod.emp_id inner join Department d on eod.dept_id = d.dept_id  where epd.emp_id=employee_id;
End$$

DELIMITER ;

-- --------------------------------------------------------

--
-- Table structure for table `author_contract`
--

CREATE TABLE `author_contract` (
  `contract_id` int(11) NOT NULL,
  `contract_manager_id` int(11) NOT NULL,
  `author_id` int(11) NOT NULL,
  `contract_start_date` date NOT NULL,
  `contract_end_date` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `author_contract`
--

INSERT INTO `author_contract` (`contract_id`, `contract_manager_id`, `author_id`, `contract_start_date`, `contract_end_date`) VALUES
(1, 1, 3, '2016-06-01', '2017-02-03'),
(2, 3, 3, '2016-11-06', '2017-01-15'),
(3, 3, 4, '2016-11-02', '2017-01-12'),
(4, 3, 4, '2016-12-02', '2016-12-02');

-- --------------------------------------------------------

--
-- Table structure for table `author_personaldetails`
--

CREATE TABLE `author_personaldetails` (
  `author_id` int(11) NOT NULL,
  `first_name` varchar(50) NOT NULL,
  `last_name` varchar(50) NOT NULL,
  `addr_line_1` varchar(200) NOT NULL,
  `addr_line_2` varchar(200) NOT NULL,
  `city` varchar(20) NOT NULL,
  `state` varchar(20) NOT NULL,
  `country` varchar(20) NOT NULL,
  `zip_code` varchar(10) NOT NULL,
  `email_id` varchar(250) NOT NULL,
  `phone` varchar(15) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `author_personaldetails`
--

INSERT INTO `author_personaldetails` (`author_id`, `first_name`, `last_name`, `addr_line_1`, `addr_line_2`, `city`, `state`, `country`, `zip_code`, `email_id`, `phone`) VALUES
(1, 'Dan', 'Brown', 'NEw York', '', 'New York', 'New York', 'USA', '4678', 'Dan@d.com', '34567'),
(3, 'J K', 'Rowlling', 'kjjjf 222', 'jekek 6960', 'Charlotte', 'NC', 'USA', '12345', 'jk@rowllin.com', '56789'),
(4, 'Sydney', 'Sheldon', '34 the street', 'thhwk', 'NYC', 'New York', 'USA', '34561', 'sysdney_sheldon@gmail.com', '23340000');

-- --------------------------------------------------------

--
-- Table structure for table `book`
--

CREATE TABLE `book` (
  `book_id` int(11) NOT NULL,
  `book_name` varchar(500) NOT NULL,
  `status` enum('Assign to Editor','Editing','Author Review','Edited','Designing','Ready to Print','Printing','Published') DEFAULT NULL,
  `start_date` date NOT NULL,
  `end_date` date DEFAULT NULL,
  `last_updated` date DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `book`
--

INSERT INTO `book` (`book_id`, `book_name`, `status`, `start_date`, `end_date`, `last_updated`) VALUES
(1, 'Deception Point', 'Printing', '2016-11-02', '2016-12-15', '2016-11-21'),
(2, 'Harry Potter', 'Printing', '2016-11-02', '2016-11-09', '2016-11-20'),
(3, 'If Tomorrow Comes', 'Printing', '2016-11-02', '2016-11-17', '2016-11-20'),
(4, 'Inferno', 'Printing', '2016-11-03', '2016-11-11', '2016-11-21');

--
-- Triggers `book`
--
DELIMITER $$
CREATE TRIGGER `before_book_insert` BEFORE INSERT ON `book` FOR EACH ROW BEGIN
set new.last_updated=CURDATE();
End
$$
DELIMITER ;
DELIMITER $$
CREATE TRIGGER `before_book_update` BEFORE UPDATE ON `book` FOR EACH ROW BEGIN
set new.last_updated=CURDATE();
End
$$
DELIMITER ;

-- --------------------------------------------------------

--
-- Table structure for table `book_author`
--

CREATE TABLE `book_author` (
  `book_id` int(11) NOT NULL,
  `author_id` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `book_author`
--

INSERT INTO `book_author` (`book_id`, `author_id`) VALUES
(1, 1),
(2, 3),
(3, 4);

-- --------------------------------------------------------

--
-- Table structure for table `book_editor`
--

CREATE TABLE `book_editor` (
  `book_id` int(11) NOT NULL,
  `editor_id` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `book_editor`
--

INSERT INTO `book_editor` (`book_id`, `editor_id`) VALUES
(1, 1),
(2, 1),
(3, 6);

-- --------------------------------------------------------

--
-- Table structure for table `book_genre`
--

CREATE TABLE `book_genre` (
  `book_id` int(11) NOT NULL,
  `genre` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `book_genre`
--

INSERT INTO `book_genre` (`book_id`, `genre`) VALUES
(1, 'Fiction'),
(2, 'Fiction'),
(3, 'Drama');

-- --------------------------------------------------------

--
-- Table structure for table `department`
--

CREATE TABLE `department` (
  `dept_id` int(11) NOT NULL,
  `dept_name` varchar(50) NOT NULL,
  `description` varchar(200) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `department`
--

INSERT INTO `department` (`dept_id`, `dept_name`, `description`) VALUES
(1, 'Finance', 'Finance'),
(2, 'Editing', 'Editing'),
(3, 'HR', 'HR'),
(4, 'Contracts', 'Contracts'),
(5, 'Vendor ', 'Vendor ');

-- --------------------------------------------------------

--
-- Table structure for table `employee_organizationaldetails`
--

CREATE TABLE `employee_organizationaldetails` (
  `emp_id` int(11) NOT NULL,
  `DOJ` date NOT NULL,
  `dept_id` int(11) NOT NULL,
  `designation` enum('Editor','HR','Contract Manager','Vendor Manager') DEFAULT NULL,
  `salary` float NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `employee_organizationaldetails`
--

INSERT INTO `employee_organizationaldetails` (`emp_id`, `DOJ`, `dept_id`, `designation`, `salary`) VALUES
(1, '2016-10-04', 2, 'Editor', 112345),
(2, '2016-11-01', 3, 'HR', 457567),
(3, '2016-11-02', 4, 'Contract Manager', 5756870),
(6, '2016-10-12', 3, 'Editor', 6666670),
(7, '2016-11-03', 5, 'Vendor Manager', 456790);

-- --------------------------------------------------------

--
-- Table structure for table `employee_personaldetails`
--

CREATE TABLE `employee_personaldetails` (
  `emp_id` int(11) NOT NULL,
  `SSN` bigint(20) NOT NULL,
  `first_name` varchar(50) NOT NULL,
  `last_name` varchar(50) NOT NULL,
  `DOB` date NOT NULL,
  `addr_line_1` varchar(200) NOT NULL,
  `addr_line_2` varchar(200) DEFAULT NULL,
  `city` varchar(20) NOT NULL,
  `state` varchar(20) NOT NULL,
  `country` varchar(20) NOT NULL,
  `zip_code` varchar(10) NOT NULL,
  `email_id` varchar(250) NOT NULL,
  `phone` varchar(15) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `employee_personaldetails`
--

INSERT INTO `employee_personaldetails` (`emp_id`, `SSN`, `first_name`, `last_name`, `DOB`, `addr_line_1`, `addr_line_2`, `city`, `state`, `country`, `zip_code`, `email_id`, `phone`) VALUES
(1, 1234567, 'HH', 'HH', '2014-11-01', 'Charlotte', NULL, 'Charlotte', 'NC', 'USA', '1234', 'hh@hh.com', '132453536'),
(2, 87584688, 'SS', 'SS', '2012-11-02', 'UN Road', NULL, 'Charlotte', 'NC', 'USA', '2345', 'SS@ss.com', '345678'),
(3, 97675757, 'QQ', 'QQ', '2010-11-02', 'Chicago', NULL, 'Chicago', 'Illinois', 'USA', '1234', 'QQ@qq.com', '345465757'),
(6, 2427628, 'Rachel', 'Green', '2016-02-03', '262hhh', 'rrtyui', 'Charlotte', 'NC', 'USA', '252728', 'fff@hhh.com', '5555555'),
(7, 87585555, 'St', 'Stuu', '2012-11-02', 'UN Road', NULL, 'Charlotte', 'NC', 'USA', '23452424', 'St@st.com', '34567525');

-- --------------------------------------------------------

--
-- Table structure for table `printingorder`
--

CREATE TABLE `printingorder` (
  `order_id` int(11) NOT NULL,
  `vendor_id` int(11) NOT NULL,
  `book_id` int(11) NOT NULL,
  `order_date` date NOT NULL,
  `quantity` int(11) NOT NULL,
  `order_status` enum('In Progress','Printed') DEFAULT NULL,
  `last_updated` date DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `printingorder`
--

INSERT INTO `printingorder` (`order_id`, `vendor_id`, `book_id`, `order_date`, `quantity`, `order_status`, `last_updated`) VALUES
(1, 1, 2, '2016-11-10', 15, 'In Progress', '2016-11-20'),
(2, 1, 1, '2016-11-03', 17, 'In Progress', '2016-11-19'),
(3, 1, 2, '2016-11-01', 34, 'In Progress', '2016-11-20'),
(4, 1, 3, '2016-11-20', 20, 'In Progress', '2016-11-21'),
(5, 3, 1, '2016-11-21', 10, 'In Progress', '2016-11-21'),
(6, 3, 4, '2016-11-21', 13, 'In Progress', '2016-11-21');

--
-- Triggers `printingorder`
--
DELIMITER $$
CREATE TRIGGER `before_printingorder_update` BEFORE UPDATE ON `printingorder` FOR EACH ROW set new.last_updated=CURDATE()
$$
DELIMITER ;
DELIMITER $$
CREATE TRIGGER `before_prtgord_insert` BEFORE INSERT ON `printingorder` FOR EACH ROW BEGIN
set new.last_updated=CURDATE();
Update Book set Book.status='Printing' where Book.book_id= new.book_id;
END
$$
DELIMITER ;

-- --------------------------------------------------------

--
-- Table structure for table `printingvendor`
--

CREATE TABLE `printingvendor` (
  `vendor_id` int(11) NOT NULL,
  `vendor_name` varchar(45) NOT NULL,
  `email` varchar(198) NOT NULL,
  `contact_number` varchar(100) NOT NULL,
  `addr_line_1` varchar(100) NOT NULL,
  `addr_line_2` varchar(100) NOT NULL,
  `city` varchar(100) NOT NULL,
  `state` varchar(100) NOT NULL,
  `country` varchar(100) NOT NULL,
  `zip_code` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `printingvendor`
--

INSERT INTO `printingvendor` (`vendor_id`, `vendor_name`, `email`, `contact_number`, `addr_line_1`, `addr_line_2`, `city`, `state`, `country`, `zip_code`) VALUES
(1, 'The XYZ Printers', 'xyz@gmail.com', '37327898932', '655jjjj', '5555jjjj', 'Charlotte', 'NC', 'USA', '152526'),
(2, 'Print-Zone', 'USA', '23456', 'ertt@ttt.com', '23467', '46ryyy', '77bbbb', 'Charlotte', 'NC'),
(3, 'Print Ocean', 'USA', '246362', 'the@gmail.com', '2638992', 'ryry 26626', 'retwywy 46747', 'Charlotte', 'NC');

-- --------------------------------------------------------

--
-- Table structure for table `user`
--

CREATE TABLE `user` (
  `emp_id` int(11) NOT NULL,
  `password` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `user`
--

INSERT INTO `user` (`emp_id`, `password`) VALUES
(1, 'qwerty123'),
(2, 'asdfg123'),
(3, 'qwerty123'),
(6, 'qwerty123'),
(7, 'asdfg123');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `author_contract`
--
ALTER TABLE `author_contract`
  ADD PRIMARY KEY (`contract_id`),
  ADD KEY `fk_auth_id` (`author_id`),
  ADD KEY `idx_emp_id` (`contract_manager_id`);

--
-- Indexes for table `author_personaldetails`
--
ALTER TABLE `author_personaldetails`
  ADD PRIMARY KEY (`author_id`),
  ADD KEY `idx_lname` (`last_name`);

--
-- Indexes for table `book`
--
ALTER TABLE `book`
  ADD PRIMARY KEY (`book_id`),
  ADD KEY `idx_book_name` (`book_name`);

--
-- Indexes for table `book_author`
--
ALTER TABLE `book_author`
  ADD PRIMARY KEY (`book_id`,`author_id`),
  ADD KEY `fk_auth_id` (`author_id`),
  ADD KEY `idx_book_id` (`book_id`);

--
-- Indexes for table `book_editor`
--
ALTER TABLE `book_editor`
  ADD PRIMARY KEY (`book_id`,`editor_id`),
  ADD KEY `fk_emp_id` (`editor_id`),
  ADD KEY `idx_book_id` (`book_id`);

--
-- Indexes for table `book_genre`
--
ALTER TABLE `book_genre`
  ADD PRIMARY KEY (`book_id`,`genre`),
  ADD KEY `idx_book_id` (`book_id`),
  ADD KEY `idx_genre_id` (`genre`);

--
-- Indexes for table `department`
--
ALTER TABLE `department`
  ADD PRIMARY KEY (`dept_id`),
  ADD KEY `idx_dept_name` (`dept_name`);

--
-- Indexes for table `employee_organizationaldetails`
--
ALTER TABLE `employee_organizationaldetails`
  ADD KEY `fk_emp_id` (`emp_id`),
  ADD KEY `idx_dept_id` (`dept_id`);

--
-- Indexes for table `employee_personaldetails`
--
ALTER TABLE `employee_personaldetails`
  ADD PRIMARY KEY (`emp_id`),
  ADD KEY `idx_ssn` (`SSN`);

--
-- Indexes for table `printingorder`
--
ALTER TABLE `printingorder`
  ADD PRIMARY KEY (`order_id`),
  ADD KEY `vendor_id` (`vendor_id`),
  ADD KEY `book_id` (`book_id`);

--
-- Indexes for table `printingvendor`
--
ALTER TABLE `printingvendor`
  ADD PRIMARY KEY (`vendor_id`),
  ADD KEY `idx_vendor_name` (`vendor_name`);

--
-- Indexes for table `user`
--
ALTER TABLE `user`
  ADD PRIMARY KEY (`emp_id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `author_contract`
--
ALTER TABLE `author_contract`
  MODIFY `contract_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;
--
-- AUTO_INCREMENT for table `author_personaldetails`
--
ALTER TABLE `author_personaldetails`
  MODIFY `author_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;
--
-- AUTO_INCREMENT for table `book`
--
ALTER TABLE `book`
  MODIFY `book_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;
--
-- AUTO_INCREMENT for table `department`
--
ALTER TABLE `department`
  MODIFY `dept_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;
--
-- AUTO_INCREMENT for table `employee_personaldetails`
--
ALTER TABLE `employee_personaldetails`
  MODIFY `emp_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=8;
--
-- AUTO_INCREMENT for table `printingorder`
--
ALTER TABLE `printingorder`
  MODIFY `order_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;
--
-- AUTO_INCREMENT for table `printingvendor`
--
ALTER TABLE `printingvendor`
  MODIFY `vendor_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;
--
-- Constraints for dumped tables
--

--
-- Constraints for table `author_contract`
--
ALTER TABLE `author_contract`
  ADD CONSTRAINT `author_contract_ibfk_1` FOREIGN KEY (`contract_manager_id`) REFERENCES `employee_personaldetails` (`emp_id`),
  ADD CONSTRAINT `author_contract_ibfk_2` FOREIGN KEY (`author_id`) REFERENCES `author_personaldetails` (`author_id`);

--
-- Constraints for table `book_author`
--
ALTER TABLE `book_author`
  ADD CONSTRAINT `book_author_ibfk_1` FOREIGN KEY (`book_id`) REFERENCES `book` (`book_id`),
  ADD CONSTRAINT `book_author_ibfk_2` FOREIGN KEY (`author_id`) REFERENCES `author_personaldetails` (`author_id`);

--
-- Constraints for table `book_editor`
--
ALTER TABLE `book_editor`
  ADD CONSTRAINT `book_editor_ibfk_1` FOREIGN KEY (`book_id`) REFERENCES `book` (`book_id`),
  ADD CONSTRAINT `book_editor_ibfk_2` FOREIGN KEY (`editor_id`) REFERENCES `employee_personaldetails` (`emp_id`);

--
-- Constraints for table `book_genre`
--
ALTER TABLE `book_genre`
  ADD CONSTRAINT `book_genre_ibfk_1` FOREIGN KEY (`book_id`) REFERENCES `book` (`book_id`);

--
-- Constraints for table `employee_organizationaldetails`
--
ALTER TABLE `employee_organizationaldetails`
  ADD CONSTRAINT `employee_organizationaldetails_ibfk_1` FOREIGN KEY (`emp_id`) REFERENCES `employee_personaldetails` (`emp_id`),
  ADD CONSTRAINT `employee_organizationaldetails_ibfk_2` FOREIGN KEY (`dept_id`) REFERENCES `department` (`dept_id`);

--
-- Constraints for table `printingorder`
--
ALTER TABLE `printingorder`
  ADD CONSTRAINT `printingorder_ibfk_1` FOREIGN KEY (`vendor_id`) REFERENCES `printingvendor` (`vendor_id`),
  ADD CONSTRAINT `printingorder_ibfk_2` FOREIGN KEY (`book_id`) REFERENCES `book` (`book_id`);

--
-- Constraints for table `user`
--
ALTER TABLE `user`
  ADD CONSTRAINT `user_ibfk_1` FOREIGN KEY (`emp_id`) REFERENCES `employee_personaldetails` (`emp_id`);

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
