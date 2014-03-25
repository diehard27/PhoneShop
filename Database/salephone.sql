/*
Navicat MySQL Data Transfer

Source Server         : SalePhone
Source Server Version : 50616
Source Host           : localhost:3306
Source Database       : salephone

Target Server Type    : MYSQL
Target Server Version : 50616
File Encoding         : 65001

Date: 2014-03-14 17:13:40
*/

SET FOREIGN_KEY_CHECKS=0;

-- ----------------------------
-- Table structure for `customer`
-- ----------------------------
DROP TABLE IF EXISTS `customer`;
CREATE TABLE `customer` (
`customer_ID`  varchar(13) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL ,
`customer_Name`  varchar(150) CHARACTER SET utf8 COLLATE utf8_general_ci NULL DEFAULT NULL ,
`customer_Tel`  varchar(50) CHARACTER SET utf8 COLLATE utf8_general_ci NULL DEFAULT NULL ,
`customer_Address`  varchar(255) CHARACTER SET utf8 COLLATE utf8_general_ci NULL DEFAULT NULL ,
PRIMARY KEY (`customer_ID`)
)

DEFAULT CHARACTER SET=utf8 COLLATE=utf8_general_ci

;

-- ----------------------------
-- Records of customer
-- ----------------------------
BEGIN;
INSERT INTO `customer` VALUES ('1', 'บอม ธนิน', '0812345678', '99 ถนน 88 กทม.'), ('2', 'โฟกัส จิระกุล', '0825552253', '108 ถนนลาดพร้าว กทม.');
COMMIT;

-- ----------------------------
-- Table structure for `employee`
-- ----------------------------
DROP TABLE IF EXISTS `employee`;
CREATE TABLE `employee` (
`Employee_ID`  varchar(13) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL ,
`Employee_Name`  varchar(150) CHARACTER SET utf8 COLLATE utf8_general_ci NULL DEFAULT NULL ,
`Employee_Tel`  varchar(50) CHARACTER SET utf8 COLLATE utf8_general_ci NULL DEFAULT NULL ,
`Employee_Address`  varchar(255) CHARACTER SET utf8 COLLATE utf8_general_ci NULL DEFAULT NULL ,
PRIMARY KEY (`Employee_ID`)
)

DEFAULT CHARACTER SET=utf8 COLLATE=utf8_general_ci

;

-- ----------------------------
-- Records of employee
-- ----------------------------
BEGIN;
INSERT INTO `employee` VALUES ('1', 'บุญเจียงธรรมโส', '08000813342', 'ร.พ. ศรีธัญญา ปทุมธานี'), ('2', 'วาสนา ไก่', '08833432332', 'หฤทัยคอนโด นครนายก');
COMMIT;

-- ----------------------------
-- Table structure for `invoice`
-- ----------------------------
DROP TABLE IF EXISTS `invoice`;
CREATE TABLE `invoice` (
`Invoice_ID`  varchar(13) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL ,
`Order_ID`  varchar(13) CHARACTER SET utf8 COLLATE utf8_general_ci NULL DEFAULT NULL ,
`Invoice_Date`  datetime NULL DEFAULT NULL ,
`Employee_ID`  varchar(13) CHARACTER SET utf8 COLLATE utf8_general_ci NULL DEFAULT NULL ,
PRIMARY KEY (`Invoice_ID`)
)

DEFAULT CHARACTER SET=utf8 COLLATE=utf8_general_ci

;

-- ----------------------------
-- Records of invoice
-- ----------------------------
BEGIN;
COMMIT;

-- ----------------------------
-- Table structure for `orders`
-- ----------------------------
DROP TABLE IF EXISTS `orders`;
CREATE TABLE `orders` (
`Order_ID`  varchar(13) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL ,
`Customer_ID`  varchar(13) CHARACTER SET utf8 COLLATE utf8_general_ci NULL DEFAULT NULL ,
`Phone_ID`  varchar(13) CHARACTER SET utf8 COLLATE utf8_general_ci NULL DEFAULT NULL ,
`Employee_ID`  varchar(13) CHARACTER SET utf8 COLLATE utf8_general_ci NULL DEFAULT NULL ,
`Quantity`  int(11) NULL DEFAULT NULL ,
`Order_Date`  datetime NULL DEFAULT NULL ,
PRIMARY KEY (`Order_ID`)
)

DEFAULT CHARACTER SET=utf8 COLLATE=utf8_general_ci

;

-- ----------------------------
-- Records of orders
-- ----------------------------
BEGIN;
INSERT INTO `orders` VALUES ('1', '2', '2', '2', '2', '2014-03-14 00:00:00'), ('2', '1', '1', '1', '1', '2014-03-14 00:00:00'), ('3', '2', '1', '1', '5', '2014-03-14 00:00:00');
COMMIT;

-- ----------------------------
-- Table structure for `phone`
-- ----------------------------
DROP TABLE IF EXISTS `phone`;
CREATE TABLE `phone` (
`Phone_ID`  varchar(13) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL ,
`Phone_Brand`  varchar(50) CHARACTER SET utf8 COLLATE utf8_general_ci NULL DEFAULT NULL ,
`Phone_Model`  varchar(50) CHARACTER SET utf8 COLLATE utf8_general_ci NULL DEFAULT NULL ,
`Phone_Color`  varchar(20) CHARACTER SET utf8 COLLATE utf8_general_ci NULL DEFAULT NULL ,
`Phone_Spec`  varchar(250) CHARACTER SET utf8 COLLATE utf8_general_ci NULL DEFAULT NULL ,
`Phone_Price`  double NULL DEFAULT NULL ,
PRIMARY KEY (`Phone_ID`)
)

DEFAULT CHARACTER SET=utf8 COLLATE=utf8_general_ci

;

-- ----------------------------
-- Records of phone
-- ----------------------------
BEGIN;
INSERT INTO `phone` VALUES ('1', 'Samsung', 'Galaxy Y Duos', 'ดำ', 'สองซิม 3G Andriod Gingerbread 2.3.7', '4500'), ('2', 'Samsung', 'Galaxy Nexus', 'เงินดำ', 'Android Jelly bean 4.2.2 RAM 1GB', '10000');
COMMIT;
