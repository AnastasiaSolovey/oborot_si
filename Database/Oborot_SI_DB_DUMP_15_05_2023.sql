CREATE DATABASE  IF NOT EXISTS `oborot_si` /*!40100 DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci */ /*!80016 DEFAULT ENCRYPTION='N' */;
USE `oborot_si`;
-- MySQL dump 10.13  Distrib 8.0.28, for Win64 (x86_64)
--
-- Host: avitube    Database: oborot_si
-- ------------------------------------------------------
-- Server version	8.0.28

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!50503 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `conclusion`
--

DROP TABLE IF EXISTS `conclusion`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `conclusion` (
  `id_conclusion` int NOT NULL AUTO_INCREMENT,
  `conclusion` varchar(30) COLLATE utf8mb4_unicode_ci NOT NULL,
  PRIMARY KEY (`id_conclusion`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `conclusion`
--

LOCK TABLES `conclusion` WRITE;
/*!40000 ALTER TABLE `conclusion` DISABLE KEYS */;
INSERT INTO `conclusion` VALUES (1,'Брак'),(2,'Годен');
/*!40000 ALTER TABLE `conclusion` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `condition`
--

DROP TABLE IF EXISTS `condition`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `condition` (
  `id_condition` int NOT NULL AUTO_INCREMENT,
  `condition` varchar(100) COLLATE utf8mb4_unicode_ci NOT NULL,
  PRIMARY KEY (`id_condition`),
  UNIQUE KEY `condition_UNIQUE` (`condition`)
) ENGINE=InnoDB AUTO_INCREMENT=13 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `condition`
--

LOCK TABLES `condition` WRITE;
/*!40000 ALTER TABLE `condition` DISABLE KEYS */;
INSERT INTO `condition` VALUES (1,'В эксплуатации'),(2,'На складе');
/*!40000 ALTER TABLE `condition` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `department`
--

DROP TABLE IF EXISTS `department`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `department` (
  `id_department` int NOT NULL AUTO_INCREMENT,
  `department` varchar(20) COLLATE utf8mb4_unicode_ci NOT NULL,
  PRIMARY KEY (`id_department`),
  UNIQUE KEY `belong_to_UNIQUE` (`department`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `department`
--

LOCK TABLES `department` WRITE;
/*!40000 ALTER TABLE `department` DISABLE KEYS */;
INSERT INTO `department` VALUES (1,'Отдел 117'),(2,'Отдел 131'),(3,'Отдел 65'),(4,'Цех № 10'),(5,'Цех № 9');
/*!40000 ALTER TABLE `department` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `employee`
--

DROP TABLE IF EXISTS `employee`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `employee` (
  `id_employee` int NOT NULL AUTO_INCREMENT,
  `surname` varchar(50) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci NOT NULL,
  `name` varchar(50) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci NOT NULL,
  `patronymic` varchar(50) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  PRIMARY KEY (`id_employee`)
) ENGINE=InnoDB AUTO_INCREMENT=14 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `employee`
--

LOCK TABLES `employee` WRITE;
/*!40000 ALTER TABLE `employee` DISABLE KEYS */;
INSERT INTO `employee` VALUES (5,'Соловей','Анастасия','Александровна'),(8,'Пагавян','Леонтий','Николаевич'),(9,'Чекмезов','Никита','Егорович'),(10,'Кондратюк','Анита','Владимировна'),(11,'Недрожанов','Павел','Савельевич'),(12,'Селезненко','Зоя','Павловна');
/*!40000 ALTER TABLE `employee` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `employee_data`
--

DROP TABLE IF EXISTS `employee_data`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `employee_data` (
  `id_employee_data` int NOT NULL AUTO_INCREMENT,
  `id_employee` int NOT NULL,
  `date_of_certification` date NOT NULL,
  `login` varchar(25) COLLATE utf8mb4_unicode_ci NOT NULL,
  `password_hash` varchar(256) COLLATE utf8mb4_unicode_ci NOT NULL,
  `salt` varchar(64) COLLATE utf8mb4_unicode_ci NOT NULL,
  `id_role` int NOT NULL,
  `is_active` tinyint NOT NULL DEFAULT '1',
  PRIMARY KEY (`id_employee_data`),
  UNIQUE KEY `login_UNIQUE` (`login`),
  KEY `id_employee_idx` (`id_employee`),
  KEY `id_role_idx` (`id_role`),
  CONSTRAINT `id_employee` FOREIGN KEY (`id_employee`) REFERENCES `employee` (`id_employee`) ON UPDATE CASCADE,
  CONSTRAINT `id_role` FOREIGN KEY (`id_role`) REFERENCES `role` (`id_role`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `employee_data`
--

LOCK TABLES `employee_data` WRITE;
/*!40000 ALTER TABLE `employee_data` DISABLE KEYS */;
INSERT INTO `employee_data` VALUES (4,5,'2023-05-15','solovey.aa','495aed0f75b9cc26ed401aa79249af6ce89cb5941c3f01172aeaf40da693f358','%6j3A!rou&+_WUfZ6%%C^JgkDKiq%№NL?:XP*guazQ@%ODC#trCgF$p7cJb№',1,1);
/*!40000 ALTER TABLE `employee_data` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `journal`
--

DROP TABLE IF EXISTS `journal`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `journal` (
  `id_journal` int NOT NULL AUTO_INCREMENT,
  `num_journal` int NOT NULL,
  `schedule_reference` int NOT NULL,
  `id_conclusion` int NOT NULL,
  `year` int NOT NULL,
  PRIMARY KEY (`id_journal`),
  UNIQUE KEY `schedule_reference_UNIQUE` (`schedule_reference`),
  UNIQUE KEY `num_year_uq` (`num_journal`,`year`),
  KEY `id_conclusion_idx` (`id_conclusion`),
  KEY `journal_schedule_ref_fk_idx` (`schedule_reference`),
  CONSTRAINT `id_conclusion` FOREIGN KEY (`id_conclusion`) REFERENCES `conclusion` (`id_conclusion`) ON UPDATE CASCADE,
  CONSTRAINT `journal_schedule_ref_fk` FOREIGN KEY (`schedule_reference`) REFERENCES `schedule` (`id_schedule`) ON DELETE RESTRICT ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=46 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `journal`
--

LOCK TABLES `journal` WRITE;
/*!40000 ALTER TABLE `journal` DISABLE KEYS */;
INSERT INTO `journal` VALUES (1,1,3,2,2023),(2,2,4,1,2023),(3,3,5,2,2023),(4,4,6,2,2023),(5,5,7,2,2023),(6,6,8,1,2023),(7,7,9,2,2023),(8,8,10,2,2023),(9,9,11,2,2023),(10,10,12,1,2023),(11,11,13,1,2023),(12,12,15,2,2023),(13,13,16,1,2023),(14,14,17,2,2023),(15,15,29,1,2023),(16,16,30,1,2023),(17,17,31,2,2023),(18,18,32,1,2023),(19,19,33,2,2023),(20,20,34,1,2023),(21,21,35,1,2023),(22,22,36,2,2023),(23,23,37,2,2023),(24,24,38,2,2023),(25,25,39,2,2023),(26,26,40,2,2023),(27,27,41,2,2023),(28,28,42,2,2023),(29,29,43,1,2023),(30,30,44,2,2023),(31,31,45,1,2023),(32,32,46,1,2023),(33,33,47,1,2023),(34,34,48,1,2023),(35,35,49,2,2023),(36,36,50,1,2023),(37,37,51,1,2023),(38,38,52,2,2023),(39,39,53,2,2023),(40,40,54,2,2023),(41,41,55,1,2023),(42,42,56,1,2023),(43,43,57,2,2023),(44,44,59,2,2023),(45,45,60,1,2023);
/*!40000 ALTER TABLE `journal` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `measuring_instrument`
--

DROP TABLE IF EXISTS `measuring_instrument`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `measuring_instrument` (
  `id_measuring_instrument` int NOT NULL AUTO_INCREMENT,
  `id_name_instrument` int NOT NULL,
  `type` varchar(100) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci NOT NULL,
  `manufacturer` varchar(100) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci NOT NULL,
  `measuring_range` varchar(100) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci NOT NULL,
  `inventory_number` varchar(50) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `factory_number` varchar(50) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `etalon` tinyint NOT NULL,
  `id_condition` int NOT NULL,
  `equipment` longtext CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci NOT NULL,
  `description` longtext CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci NOT NULL,
  `id_department` int NOT NULL,
  PRIMARY KEY (`id_measuring_instrument`),
  UNIQUE KEY `idx_inventory_factory_num` (`inventory_number`,`factory_number`),
  KEY `FK_si_card_condition` (`id_condition`),
  KEY `FK_si_card_department` (`id_department`),
  KEY `id_name_instrument_idx` (`id_name_instrument`),
  CONSTRAINT `id_belong_to` FOREIGN KEY (`id_department`) REFERENCES `department` (`id_department`) ON UPDATE CASCADE,
  CONSTRAINT `id_condition` FOREIGN KEY (`id_condition`) REFERENCES `condition` (`id_condition`) ON UPDATE CASCADE,
  CONSTRAINT `id_name_instrument` FOREIGN KEY (`id_name_instrument`) REFERENCES `name_instrument` (`id_name_instrument`) ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=386 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `measuring_instrument`
--

LOCK TABLES `measuring_instrument` WRITE;
/*!40000 ALTER TABLE `measuring_instrument` DISABLE KEYS */;
INSERT INTO `measuring_instrument` VALUES (271,1,'ЛМ - 1','Textronix','100 mV - 500V ± 1,5','0','8827',0,1,'Прибор, сетевой шнур, руководство по эксплуатации','Красивый',1),(272,1,'М-1200','Gwinstek','101 mV - 500V ± 1,5','5982','66463',0,2,'Прибор, сетевой шнур, руководство по эксплуатации','Точный',2),(273,1,'ЛМ - 1','РИП-Импульс','102 mV - 500V ± 1,5','6145','1783',0,1,'Прибор, сетевой шнур, руководство по эксплуатации','Лучший',3),(274,2,'ЛМ-1','Textronix','103 mV - 500V ± 1,5','0','9314',0,2,'Прибор, сетевой шнур, руководство по эксплуатации','Красивый',4),(275,2,'М - 231','Gwinstek','104 mV - 500V ± 1,5','8698','350',0,1,'Прибор, сетевой шнур, руководство по эксплуатации','Точный',5),(277,3,'ЛМ – 1','Textronix','106 mV - 500V ± 1,5','0','8907',1,1,'Прибор, сетевой шнур, руководство по эксплуатацииhjh','Средство измерения (эталон)',2),(278,3,'В 3 - 38','Gwinstek','107 mV - 500V ± 1,5','30868','2206',1,1,'Прибор, сетевой шнур, руководство по эксплуатации','Средство измерения (эталон)',3),(279,4,'В7 – 16А','РИП-Импульс','108 mV - 500V ± 1,5','31795','К07268',1,2,'Прибор, сетевой шнур, руководство по эксплуатации1','Средство измерения (эталон)',4),(280,5,'В 7 – 22А','Textronix','109 mV - 500V ± 1,5','31087','7292',0,1,'Прибор, сетевой шнур, руководство по эксплуатации','Красивый',5),(281,6,'В 7 - 38','Gwinstek','110 mV - 500V ± 1,5','31424','4419',0,2,'Прибор, сетевой шнур, руководство по эксплуатации','Точный',1),(282,1,'sdsdfsd','апрпа','dhdf','31663','190690',1,1,'bbbm211231','hggh',1),(283,5,'В7-78/2','Textronix','112 mV - 500V ± 1,5','4470234','TW00026449',1,2,'Прибор, сетевой шнур, руководство по эксплуатации','Красивый',3),(284,5,'Ц 4352','Gwinstek','113 mV - 500V ± 1,5','8828','278553',0,1,'Прибор, сетевой шнур, руководство по эксплуатации','Точный',4),(285,5,'GDM-8245','РИП-Импульс','114 mV - 500V ± 1,5','4470297','GCS814548',0,1,'Прибор, сетевой шнур, руководство по эксплуатации','Лучший',5),(286,4,'Agilent 34401A','Textronix','115 mV - 500V ± 1,5','0','MY45032004',0,2,'Прибор, сетевой шнур, руководство по эксплуатации123','Красивый',1),(287,3,'MY-63','Gwinstek','116 mV - 500V ± 1,5','0','MBEB091091',0,1,'Прибор, сетевой шнур, руководство по эксплуатации','Точный',2),(288,5,'MY-67','РИП-Импульс','117 mV - 500V ± 1,5','0','11070091929',0,2,'Прибор, сетевой шнур, руководство по эксплуатации','Лучший',3),(289,10,'Fluke 17В+','Textronix','118 mV - 500V ± 1,5','4470232','36871524WS',0,2,'Прибор, сетевой шнур, руководство по эксплуатации','Красивый',4),(290,11,'М-830','Gwinstek','119 mV - 500V ± 1,5','0','41V',0,1,'Прибор, сетевой шнур, руководство по эксплуатации','Точный',5),(291,12,'M-838','РИП-Импульс','120 mV - 500V ± 1,5','0','1',0,1,'Прибор, сетевой шнур, руководство по эксплуатации','Лучший',1),(292,1,'DT-830B','Textronix','121 mV - 500V ± 1,5','0','1080212673',0,2,'Прибор, сетевой шнур, руководство по эксплуатацииААААААААААА','Красивый',2),(293,1,'В7-61','Gwinstek','122 mV - 500V ± 1,5','4470240','5737',0,2,'Прибор, сетевой шнур, руководство по эксплуатации','Точный',3),(294,1,' В7-80','РИП-Импульс','123 mV - 500V ± 1,5','4470251','1677',1,1,'Прибор, сетевой шнур, руководство по эксплуатации1','Средство измерения (эталон)',4),(295,1,'АРРА-73','Textronix','124 mV - 500V ± 1,5','4470025','35912887',1,2,'Прибор, сетевой шнур, руководство по эксплуатации111','Средство измерения (эталон)',5),(296,1,'АРРА-73','Gwinstek','125 mV - 500V ± 1,5','','',0,1,'Прибор, сетевой шнур, руководство по эксплуатации11','Точный',1),(297,8,'Б1 – 9','Textronix','139 mV - 500V ± 1,5','0','1071199',0,2,'Прибор, сетевой шнур, руководство по эксплуатации','Красивый',2),(298,8,'Б5 - 7','Gwinstek','140 mV - 500V ± 1,5','0','8614',0,1,'Прибор, сетевой шнур, руководство по эксплуатации','Точный',3),(299,8,'Б5-43А','РИП-Импульс','141 mV - 500V ± 1,5','31541','3522',1,1,'Прибор, сетевой шнур, руководство по эксплуатации','Средство измерения (эталон)',4),(300,8,'Б5-44А','Textronix','142 mV - 500V ± 1,5','31732','15836',1,2,'Прибор, сетевой шнур, руководство по эксплуатации','Средство измерения (эталон)',5),(301,8,'Б5 - 45','Gwinstek','143 mV - 500V ± 1,5','31739','13038',1,2,'Прибор, сетевой шнур, руководство по эксплуатации','Средство измерения (эталон)',1),(302,8,'Б5 - 45А','РИП-Импульс','144 mV - 500V ± 1,5','31740','12983',0,1,'Прибор, сетевой шнур, руководство по эксплуатации','Лучший',2),(303,8,'Б 5 - 47','Textronix','145 mV - 500V ± 1,5','31310','7635',0,2,'Прибор, сетевой шнур, руководство по эксплуатации','Красивый',3),(304,8,'Б5 - 48','Gwinstek','146 mV - 500V ± 1,5','31393','7254',0,1,'Прибор, сетевой шнур, руководство по эксплуатации','Точный',4),(305,10,'Б5 - 70','РИП-Импульс','147 mV - 500V ± 1,5','31799','3389107',0,2,'Прибор, сетевой шнур, руководство по эксплуатации','Лучший',5),(306,20,'Б5 - 71','Textronix','148 mV - 500V ± 1,5','0','2101024',0,1,'Прибор, сетевой шнур, руководство по эксплуатации','Красивый',1),(307,15,'Б5-71/м','Gwinstek','149 mV - 500V ± 1,5','4470089','80456',0,2,'Прибор, сетевой шнур, руководство по эксплуатации','Точный',2),(308,15,'Б5-88','РИП-Импульс','150 mV - 500V ± 1,5','4470238','216',0,1,'Прибор, сетевой шнур, руководство по эксплуатации','Лучший',3),(309,14,'ТЕС - 14','Textronix','151 mV - 500V ± 1,5','30743','226',1,2,'Прибор, сетевой шнур, руководство по эксплуатации','Средство измерения (эталон)',4),(310,14,'ТЕС-18','Gwinstek','152 mV - 500V ± 1,5','31189','815',0,1,'Прибор, сетевой шнур, руководство по эксплуатации','Точный',5),(311,14,'Xantrex XDC 100-60HV','РИП-Импульс','153 mV - 500V ± 1,5','4470063','E 00132228',0,2,'Прибор, сетевой шнур, руководство по эксплуатации','Лучший',1),(312,14,'GPC-1850D','Textronix','154 mV - 500V ± 1,5','44470034','Е 852854',0,1,'Прибор, сетевой шнур, руководство по эксплуатации','Красивый',1),(313,14,'PST-3201','Gwinstek','155 mV - 500V ± 1,5','4470090','B210157',0,1,'Прибор, сетевой шнур, руководство по эксплуатации','Точный',2),(314,14,'PST-3202','РИП-Импульс','156 mV - 500V ± 1,5','4470088','В 200719',0,2,'Прибор, сетевой шнур, руководство по эксплуатации','Лучший',3),(315,14,'SPS - 3610','Textronix','157 mV - 500V ± 1,5','4470010','D 110401',0,1,'Прибор, сетевой шнур, руководство по эксплуатации','Красивый',4),(316,14,'SPS - 606','Gwinstek','158 mV - 500V ± 1,5','4470404','GEU860349',0,2,'Прибор, сетевой шнур, руководство по эксплуатации','Точный',5),(317,14,'PSH - 3610','РИП-Импульс','159 mV - 500V ± 1,5','0','EI 220981',0,1,'Прибор, сетевой шнур, руководство по эксплуатации','Лучший',1),(318,14,'PSH-73630','Textronix','160 mV - 500V ± 1,5','4470188','EN853197',1,2,'Прибор, сетевой шнур, руководство по эксплуатации','Средство измерения (эталон)',2),(319,14,'PSH-3630','Gwinstek','161 mV - 500V ± 1,5','4470074','EG220350',0,1,'Прибор, сетевой шнур, руководство по эксплуатации','Точный',3),(320,14,'PSP-405','РИП-Импульс','162 mV - 500V ± 1,5','4470082','EH141341',0,2,'Прибор, сетевой шнур, руководство по эксплуатации','Лучший',4),(321,14,'PSW7 30-108','Textronix','163 mV - 500V ± 1,5','0','GEP142846',1,2,'Прибор, сетевой шнур, руководство по эксплуатации','Средство измерения (эталон)',5),(322,17,'1851 IN','Gwinstek','164 mV - 500V ± 1,5','4470163','1315419',0,1,'Прибор, сетевой шнур, руководство по эксплуатации','Точный',1),(323,18,'МЕГЕОН 13130','РИП-Импульс','165 mV - 500V ± 1,5','4470407','15056535',0,2,'Прибор, сетевой шнур, руководство по эксплуатации','Лучший',2),(324,12,'МЕГЕОН 13121','Textronix','166 mV - 500V ± 1,5','4470410','ИСЗ №1',0,1,'Прибор, сетевой шнур, руководство по эксплуатации','Красивый',3),(325,14,'Р - 33','Gwinstek','167 mV - 500V ± 1,5','8421','27968',0,2,'Прибор, сетевой шнур, руководство по эксплуатации','Точный',4),(326,16,'МО – 62','РИП-Импульс','168 mV - 500V ± 1,5','30438','7070',0,1,'Прибор, сетевой шнур, руководство по эксплуатации','Лучший',5),(327,15,'МСР - 63','Textronix','169 mV - 500V ± 1,5','5849','15224',0,1,'Прибор, сетевой шнур, руководство по эксплуатации','Красивый',1),(328,19,'Ф  410','Gwinstek','170 mV - 500V ± 1,5','8736','3144',0,2,'Прибор, сетевой шнур, руководство по эксплуатации','Точный',2),(329,20,'Ф  415','РИП-Импульс','171 mV - 500V ± 1,5','0','762',0,1,'Прибор, сетевой шнур, руководство по эксплуатации','Лучший',3),(330,4,'MMR-620','Textronix','172 mV - 500V ± 1,5','0','323285',1,2,'Прибор, сетевой шнур, руководство по эксплуатации','Средство измерения (эталон)',4),(331,6,'Ф  4101','Gwinstek','173 mV - 500V ± 1,5','31169','60994',0,1,'Прибор, сетевой шнур, руководство по эксплуатации','Точный',5),(332,9,'М 1101','РИП-Импульс','174 mV - 500V ± 1,5','6840','507092',0,2,'Прибор, сетевой шнур, руководство по эксплуатации','Лучший',1),(333,3,'Ф - 291','Textronix','175 mV - 500V ± 1,5','31285','68',0,1,'Прибор, сетевой шнур, руководство по эксплуатации','Красивый',2),(334,2,'Ч 3 - 57','Gwinstek','176 mV - 500V ± 1,5','31076','210098',0,1,'Прибор, сетевой шнур, руководство по эксплуатации','Точный',3),(335,6,'Ф 2 - 34','РИП-Импульс','177 mV - 500V ± 1,5','4470366','2223',0,2,'Прибор, сетевой шнур, руководство по эксплуатации1','Лучший',4),(336,7,'LCROY','Textronix','178 mV - 500V ± 1,5','0','LCRY3602C00341',0,1,'Прибор, сетевой шнур, руководство по эксплуатации','Красивый',5),(337,17,'SMY02','Gwinstek','179 mV - 500V ± 1,5','4470058','8375771013',0,2,'Прибор, сетевой шнур, руководство по эксплуатации','Точный',1),(338,21,'FCC-TG-115A','РИП-Импульс','180 mV - 500V ± 1,5','0','111126',1,1,'Прибор, сетевой шнур, руководство по эксплуатации','Средство измерения (эталон)',2),(339,21,'Г 3 -15','Textronix','181 mV - 500V ± 1,5','31081','12148',1,2,'Прибор, сетевой шнур, руководство по эксплуатации','Средство измерения (эталон)',3),(340,21,'Г 3 - 112','Gwinstek','182 mV - 500V ± 1,5','31469','29733',1,1,'Прибор, сетевой шнур, руководство по эксплуатации','Средство измерения (эталон)',4),(341,21,'Г3-33','РИП-Импульс','183 mV - 500V ± 1,5','0','45241',0,1,'Прибор, сетевой шнур, руководство по эксплуатации','Лучший',5),(342,21,'Г 6 - 27','Textronix','184 mV - 500V ± 1,5','31380','10504',0,2,'Прибор, сетевой шнур, руководство по эксплуатации','Красивый',1),(343,21,'Г 6 - 37','Gwinstek','185 mV - 500V ± 1,5','0','31242',1,2,'Прибор, сетевой шнур, руководство по эксплуатации','Средство измерения (эталон)',2),(344,14,'С1 - 83','РИП-Импульс','186 mV - 500V ± 1,5','31254','С 04530',0,1,'Прибор, сетевой шнур, руководство по эксплуатации','Лучший',3),(345,15,'С1-93','Textronix','187 mV - 500V ± 1,5','31682','К04810',1,2,'Прибор, сетевой шнур, руководство по эксплуатации','Средство измерения (эталон)',4),(346,16,'Магистр','Gwinstek','188 mV - 500V ± 1,5','7700833','201927',0,1,'Прибор, сетевой шнур, руководство по эксплуатации','Точный',5),(347,17,'ПВ – 53Л','РИП-Импульс','189 mV - 500V ± 1,5','0','5305614',0,2,'Прибор, сетевой шнур, руководство по эксплуатации','Хороший',1),(348,1,'Аппа 4012','Textronix','106 mV - 500V ± 1,5','111','111',1,1,'Прибор, сетевой шнур, руководство по эксплуатации','Средство измерения (эталон)',2),(349,2,'GDM-8245','РИП-Импульс','114 mV - 500V ± 1,5','1111','1111',0,2,'Устройство, шнур','Замечательный',3),(350,3,'LCROY','Textronix','178 mV - 500V ± 1,5','2222','2222',0,1,'Устройство','Замечательный',4),(351,4,'Б1 – 9','Textronix','139 mV - 500V ± 1,5','3333','3333',0,2,'Устройство, шнур1','Замечательный',5),(352,5,'М - 231','Textronix','100 mV - 500V ± 1,5','0','12019',1,1,'Прибор, сетевой шнур, руководство по эксплуатации','Средство измерения (эталон)',1),(355,8,'ЛМ - 1','Textronix','100 mV - 500V ± 1,5','123123','1234567',1,1,'Прибор, сетевой шнур,\nруководство по эксплуатации','Красивый',4),(356,9,'В 7 – 40 / 4','РИП-Импульс','110 mV - 500V ± 1,5','666444','12ee33',1,2,'sdsd','dsdsd',5),(357,10,'С1 - 83','РИП-Импульс','176 mV - 500V ± 1,5','14062209','5778749185',1,1,'Шнур, вилка','Шикарненький',1),(358,11,'В 7 – 22А','Textronix','109 mV - 500V ± 1,5','31087','729290',0,2,'Прибор, сетевой шнур, руководство по эксплуатации','Красивый',2),(359,12,'R900','Ozon','103 mV - 500V ± 1,5','1406','2209',1,1,'Прибор','Самый идеальный',3),(362,1,'12313','211331','123231','012313','0131313',0,1,'13131311','11313',1),(363,1,'wer','werwer','qwerqrw','1235453','12sd12',1,2,'sdsd','dfgdfg',3),(365,1,'dfg','dfhsed','hsdhs','w5yw5y','xcnx',1,1,'xnx','',3),(366,8,'sdgsdf','sdhs','2ghds','345346','4563',0,1,'shsdfh','',3),(370,7,'sdfsdfsdfsdf','sdfsdf','xcfggc','1235124','15236',1,1,'dfyhdfh1','dfgdfg',3),(371,1,'gdgsdg','sdgfsdg','sdgscg','w2352sdg','wfh4ts',1,2,'dscg','sdfs',4),(373,1,'fghbfgb','dfbdfb','dfbdf','gfdf','sdgs',1,1,'нананна','dfgdfg',2),(375,1,'gvjcvg','cvbc','xfgdxf','0sdfs','sdfdf',1,1,'fgdfg','dfgdf',2),(376,8,'cvcv','vcbc','xcbxc','656','8827',0,2,'ghf','fghfh',5),(377,8,'cvcv','vcbc','xcbxc','0','8826',0,2,'ghf','fghfh',5),(379,6,'scxsc','zxczx','zxzx','1','1',1,2,'dvscv','zxczx',3),(381,5,'cvbcv','dfgdfttttttt','3453','0','8821',1,1,'rthrt','rtrth',3),(382,22,'гыр','гыр','гыр','гыр','гыр',1,1,'гыр','гыр',3),(385,6,'wwef','234','2edfs','0','14051927',1,2,'fghfg','gfhfg',3);
/*!40000 ALTER TABLE `measuring_instrument` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `name_instrument`
--

DROP TABLE IF EXISTS `name_instrument`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `name_instrument` (
  `id_name_instrument` int NOT NULL AUTO_INCREMENT,
  `name_instrument` varchar(200) COLLATE utf8mb4_unicode_ci NOT NULL,
  PRIMARY KEY (`id_name_instrument`),
  UNIQUE KEY `name_instrument_UNIQUE` (`name_instrument`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `name_instrument`
--

LOCK TABLES `name_instrument` WRITE;
/*!40000 ALTER TABLE `name_instrument` DISABLE KEYS */;
INSERT INTO `name_instrument` VALUES (1,'Ампервольтметр'),(2,'Амперметр'),(3,'Вольтметр'),(4,'Вольтмиллиамперметр'),(5,'Генератор'),(6,'Измеритель'),(7,'Измеритель сопр. изоляции'),(8,'Измеритель температуры'),(9,'Источник питания'),(10,'Комбинированный прибор'),(11,'Магазин сопротивлений'),(12,'Мегаомметр'),(13,'Микроампервольтметр'),(14,'Микроамперметр'),(15,'Микроомметр'),(16,'Миллиамперметр'),(17,'Милливольтметр'),(18,'Мост'),(19,'Мультиметр цифровой'),(20,'Омметр'),(21,'Осциллограф'),(22,'Фазометр'),(23,'Частотомер'),(24,'Электросекундомер');
/*!40000 ALTER TABLE `name_instrument` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `protocol`
--

DROP TABLE IF EXISTS `protocol`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `protocol` (
  `id_protocol` int NOT NULL AUTO_INCREMENT,
  `num_protocol` int NOT NULL,
  `id_journal` int NOT NULL,
  `note` longtext CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci,
  `id_employee` int NOT NULL,
  PRIMARY KEY (`id_protocol`),
  KEY `FK_protocol_employee` (`id_employee`),
  KEY `FK_protocol_journal_idx` (`id_journal`),
  CONSTRAINT `FK_protocol_employee` FOREIGN KEY (`id_employee`) REFERENCES `employee` (`id_employee`) ON UPDATE CASCADE,
  CONSTRAINT `FK_protocol_journal` FOREIGN KEY (`id_journal`) REFERENCES `journal` (`id_journal`)
) ENGINE=InnoDB AUTO_INCREMENT=42 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `protocol`
--

LOCK TABLES `protocol` WRITE;
/*!40000 ALTER TABLE `protocol` DISABLE KEYS */;
INSERT INTO `protocol` VALUES (1,1,1,'Есть дефект на устройстве не сказывающися в его работе',8),(2,2,2,'',11),(3,3,3,'Есть дефект на самом устройстве но не влияющий на работу устройства',10),(4,4,4,'При измерении выдает ошибку',10),(5,5,5,'Есть дефект не влияющий на работу устройства',10),(15,6,6,'',8),(16,7,7,'',8),(17,8,8,'Все хорошо',5),(19,9,9,'Я пытался',5),(20,10,10,'Я очень старался',5),(21,11,11,'Аниме девочки лучшие',8),(22,12,12,'ывывв',8),(23,13,13,'Все норм',5),(24,14,14,'eereee',8),(25,15,15,'',12),(26,16,16,'',11),(27,17,17,'',10),(28,18,18,'',11),(29,19,19,'hello',8),(30,20,20,'',10),(31,21,21,'[t[t[',8),(32,22,22,'',9),(33,23,23,'hjhj',9),(34,24,24,'ddfd',10),(35,25,25,'',9),(36,26,26,'',5),(37,27,27,'',10),(38,28,28,'fdfdf',10),(39,29,29,'',11),(40,44,44,'Все хорошо',5),(41,45,45,'Не очень рабочий',8);
/*!40000 ALTER TABLE `protocol` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `role`
--

DROP TABLE IF EXISTS `role`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `role` (
  `id_role` int NOT NULL AUTO_INCREMENT,
  `role` varchar(20) COLLATE utf8mb4_unicode_ci NOT NULL,
  PRIMARY KEY (`id_role`),
  UNIQUE KEY `role_UNIQUE` (`role`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `role`
--

LOCK TABLES `role` WRITE;
/*!40000 ALTER TABLE `role` DISABLE KEYS */;
INSERT INTO `role` VALUES (1,'Администратор'),(2,'Сотрудник');
/*!40000 ALTER TABLE `role` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `schedule`
--

DROP TABLE IF EXISTS `schedule`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `schedule` (
  `id_schedule` int NOT NULL AUTO_INCREMENT,
  `id_measuring_instrument` int NOT NULL,
  `old_date` date NOT NULL,
  `frequency` tinyint NOT NULL,
  `old_venue` int DEFAULT NULL,
  `next_date` date NOT NULL,
  `new_venue` int DEFAULT NULL,
  `id_type_work` int NOT NULL,
  PRIMARY KEY (`id_schedule`),
  KEY `id_measuring_instrument_idx` (`id_measuring_instrument`),
  KEY `old_venue_idx` (`old_venue`),
  KEY `new_venue_idx` (`new_venue`),
  KEY `id_type_work_idx` (`id_type_work`),
  CONSTRAINT `id_type_work` FOREIGN KEY (`id_type_work`) REFERENCES `type_of_work` (`id_type_work`) ON UPDATE CASCADE,
  CONSTRAINT `measuring_instrument` FOREIGN KEY (`id_measuring_instrument`) REFERENCES `measuring_instrument` (`id_measuring_instrument`) ON UPDATE CASCADE,
  CONSTRAINT `new_venue` FOREIGN KEY (`new_venue`) REFERENCES `venue` (`id_venue`) ON UPDATE CASCADE,
  CONSTRAINT `old_venue` FOREIGN KEY (`old_venue`) REFERENCES `venue` (`id_venue`) ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=61 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `schedule`
--

LOCK TABLES `schedule` WRITE;
/*!40000 ALTER TABLE `schedule` DISABLE KEYS */;
INSERT INTO `schedule` VALUES (3,271,'2006-12-20',12,1,'2001-01-20',1,1),(4,271,'2007-12-20',18,2,'2012-01-20',2,2),(5,271,'2007-12-20',24,3,'2021-01-20',3,3),(6,271,'2007-12-20',36,4,'2010-01-20',4,1),(7,271,'2007-12-20',48,5,'2004-02-20',5,2),(8,271,'2009-12-20',6,6,'2017-02-20',6,3),(9,271,'2009-12-20',12,7,'2009-03-20',7,1),(10,271,'2009-12-20',12,8,'2009-03-20',8,2),(11,271,'2023-02-02',12,1,'2010-03-20',1,3),(12,271,'2023-03-17',12,2,'2013-06-20',2,1),(13,271,'2023-03-25',12,3,'2006-12-20',3,2),(15,271,'2023-03-29',12,4,'2008-12-20',4,3),(16,271,'2023-03-29',12,5,'2008-12-20',5,1),(17,271,'2023-03-29',12,6,'2015-03-20',6,2),(29,271,'2023-04-01',36,3,'2026-03-28',2,3),(30,271,'2023-04-13',12,8,'2024-03-31',4,1),(31,271,'2023-04-13',24,2,'2025-03-31',8,2),(32,279,'2007-12-20',12,5,'2017-02-20',1,3),(33,377,'2023-05-02',24,3,'2025-05-01',5,1),(34,385,'2023-05-01',24,2,'2025-04-30',7,2),(35,371,'2023-05-03',24,2,'2025-05-02',7,3),(36,371,'2023-05-02',12,2,'2024-05-01',3,1),(37,272,'2023-05-03',12,3,'2024-05-02',8,2),(38,338,'2023-05-03',18,7,'2024-11-02',6,3),(39,343,'2023-05-03',12,5,'2024-05-02',5,1),(40,363,'2023-05-03',12,5,'2024-05-02',5,2),(41,382,'2023-05-03',18,5,'2024-11-02',5,3),(42,382,'2023-05-01',48,5,'2027-04-30',5,1),(43,382,'2023-05-03',6,5,'2023-11-02',5,2),(44,382,'2023-05-01',36,8,'2026-04-30',1,3),(45,382,'2023-05-02',48,4,'2027-05-01',6,1),(46,371,'2023-05-01',24,7,'2025-04-30',5,3),(47,329,'2023-05-01',48,8,'2027-04-30',8,2),(48,329,'2023-02-09',18,8,'2024-08-08',8,1),(49,283,'2023-05-02',6,5,'2023-11-01',5,3),(50,350,'2023-05-03',36,7,'2026-05-02',1,3),(51,293,'2023-05-01',6,1,'2023-10-31',6,3),(52,281,'2023-05-03',48,7,'2027-05-02',8,1),(53,324,'2023-04-24',12,7,'2024-04-23',3,1),(54,324,'2023-04-24',12,3,'2024-04-23',7,2),(55,324,'2023-02-14',12,7,'2024-02-13',1,3),(56,326,'2023-05-04',12,3,'2024-05-03',8,1),(57,326,'2023-02-08',12,7,'2024-02-07',1,3),(58,335,'2023-03-02',12,1,'2024-03-01',8,2),(59,336,'2023-05-15',12,3,'2024-05-14',1,2),(60,326,'2023-05-12',24,5,'2025-05-11',5,1);
/*!40000 ALTER TABLE `schedule` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `type_of_work`
--

DROP TABLE IF EXISTS `type_of_work`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `type_of_work` (
  `id_type_work` int NOT NULL AUTO_INCREMENT,
  `type_of_work` varchar(100) COLLATE utf8mb4_unicode_ci NOT NULL,
  PRIMARY KEY (`id_type_work`),
  UNIQUE KEY `type_of_work_UNIQUE` (`type_of_work`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `type_of_work`
--

LOCK TABLES `type_of_work` WRITE;
/*!40000 ALTER TABLE `type_of_work` DISABLE KEYS */;
INSERT INTO `type_of_work` VALUES (1,'Калибровка'),(2,'Поверка'),(3,'Проверка');
/*!40000 ALTER TABLE `type_of_work` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `venue`
--

DROP TABLE IF EXISTS `venue`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `venue` (
  `id_venue` int NOT NULL AUTO_INCREMENT,
  `venue` varchar(150) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci NOT NULL,
  PRIMARY KEY (`id_venue`),
  UNIQUE KEY `venue_UNIQUE` (`venue`)
) ENGINE=InnoDB AUTO_INCREMENT=9 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `venue`
--

LOCK TABLES `venue` WRITE;
/*!40000 ALTER TABLE `venue` DISABLE KEYS */;
INSERT INTO `venue` VALUES (5,'БелГИМ'),(2,'ЗАО «ПриСТ»'),(3,'ООО «НПФ АДСилаб»'),(7,'ООО НПК «Эталон-Тест»'),(8,'РФЯЦ-ВНИИТФ'),(1,'ФБУ «Ростест-Москва»'),(4,'ФГБУ \"ГНМЦ\"\" МО\"'),(6,'ФГУП «ВННИМС»');
/*!40000 ALTER TABLE `venue` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping events for database 'oborot_si'
--
/*!50106 SET @save_time_zone= @@TIME_ZONE */ ;
/*!50106 DROP EVENT IF EXISTS `update_si_card_hourly` */;
DELIMITER ;;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;;
/*!50003 SET character_set_client  = utf8mb4 */ ;;
/*!50003 SET character_set_results = utf8mb4 */ ;;
/*!50003 SET collation_connection  = utf8mb4_general_ci */ ;;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;;
/*!50003 SET @saved_time_zone      = @@time_zone */ ;;
/*!50003 SET time_zone             = '+00:00' */ ;;
/*!50106 CREATE*/ /*!50117 DEFINER=`root`@`%`*/ /*!50106 EVENT `update_si_card_hourly` ON SCHEDULE EVERY 1 HOUR STARTS '2023-03-21 17:01:00' ON COMPLETION PRESERVE ENABLE DO CALL UPDATE_SI_CARD() */ ;;
/*!50003 SET time_zone             = @saved_time_zone */ ;;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;;
/*!50003 SET character_set_client  = @saved_cs_client */ ;;
/*!50003 SET character_set_results = @saved_cs_results */ ;;
/*!50003 SET collation_connection  = @saved_col_connection */ ;;
DELIMITER ;
/*!50106 SET TIME_ZONE= @save_time_zone */ ;

--
-- Dumping routines for database 'oborot_si'
--
/*!50003 DROP FUNCTION IF EXISTS `CheckIfUserIsActive` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` FUNCTION `CheckIfUserIsActive`(in_login varchar(255)) RETURNS tinyint(1)
    READS SQL DATA
BEGIN
    if(
		SELECT `employee_data`.`is_active`
		FROM `oborot_si`.`employee_data`
        WHERE `login` = in_login
    )
    then
		return true;
	else
		return false;
	end if;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP FUNCTION IF EXISTS `CheckUserPassword` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` FUNCTION `CheckUserPassword`(in_login varchar(255), pass varchar(255)) RETURNS tinyint(1)
    READS SQL DATA
BEGIN
	DECLARE pass_hash varchar(256) default null;
    DECLARE salt_string varchar(64) default null;
    declare user_is_active boolean default null;
    
    
    SELECT 
		`employee_data`.`password_hash`,
		`employee_data`.`salt`,
		`employee_data`.`is_active`
	INTO pass_hash, salt_string, user_is_active
	FROM `oborot_si`.`employee_data`
    WHERE `login` = in_login;


    
    if(not user_is_active)
    then
		RETURN FALSE;
	end if;

	if(BINARY pass_hash=sha2(concat(pass, salt_string),256))
	then
		RETURN TRUE;
	else
		DO SLEEP(3);
	end if;
    
RETURN FALSE;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP FUNCTION IF EXISTS `date_diff` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`%` FUNCTION `date_diff`(start_date DATE, finish_date DATE) RETURNS varchar(150) CHARSET utf8mb4 COLLATE utf8mb4_unicode_ci
    DETERMINISTIC
BEGIN 
	DECLARE days INT; 
	DECLARE message VARCHAR(150); 
	SET days = DATEDIFF(start_date, finish_date); 
	CASE 
		WHEN (days=365) THEN SET message = ' OK';
		WHEN (days>365) THEN SET message = ' WARNING'; 
        WHEN (days<1) THEN SET message = ' ERROR'; 
	END CASE; 
	RETURN CONCAT(days, message); 
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP FUNCTION IF EXISTS `GetLastDateFromSchedule` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`admin`@`%` FUNCTION `GetLastDateFromSchedule`(mes_ins_id int) RETURNS varchar(255) CHARSET utf8mb4 COLLATE utf8mb4_unicode_ci
    READS SQL DATA
BEGIN
	declare last_date DATE default null;
    declare type_of_work VARCHAR(100) default null;
    
    SELECT MAX(`schedule`.`old_date`), `type_of_work`.`type_of_work`
	INTO last_date, type_of_work
	FROM `oborot_si`.`schedule`
    JOIN `oborot_si`.`type_of_work` on `type_of_work`.`id_type_work` = `schedule`.`id_type_work`
	WHERE `schedule`.`id_measuring_instrument` = mes_ins_id;
    
RETURN concat(last_date,';',type_of_work);
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP FUNCTION IF EXISTS `GetVenueNameByID` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`admin`@`%` FUNCTION `GetVenueNameByID`(id int) RETURNS varchar(150) CHARSET utf8mb4 COLLATE utf8mb4_unicode_ci
    READS SQL DATA
BEGIN
	declare venue_str VARCHAR(150) default null;
    
    SELECT `venue`.`venue` INTO venue_str FROM `oborot_si`.`venue` WHERE `venue`.`id_venue` = id;
RETURN venue_str;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP FUNCTION IF EXISTS `GET_ALL_CHILDREN` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`%` FUNCTION `GET_ALL_CHILDREN`(start_node INT) RETURNS text CHARSET utf8mb4 COLLATE utf8mb4_unicode_ci
    READS SQL DATA
BEGIN
DECLARE result TEXT;
SELECT GROUP_CONCAT(`children_ids` SEPARATOR ',')  INTO result FROM (select `id_si`, @parent_values:= (SELECT GROUP_CONCAT(`id_si` SEPARATOR ',')
FROM `si_card` WHERE FIND_IN_SET(`id_si`, @parent_values) > 0 ) AS `children_ids` 
FROM `si_card` JOIN (SELECT @parent_values := start_node) AS `initialisation` 
WHERE `id_si` IN (@parent_values) ) AS `data`;
RETURN result; 
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP FUNCTION IF EXISTS `GET_PATH_TO_ROOT` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`%` FUNCTION `GET_PATH_TO_ROOT`(start_node INT) RETURNS text CHARSET utf8mb4 COLLATE utf8mb4_unicode_ci
    READS SQL DATA
BEGIN 
DECLARE path_to_root TEXT;  
DECLARE current_node TEXT; 
DECLARE EXIT HANDLER FOR NOT FOUND RETURN path_to_root; 
SET current_node = start_node; 
 SET path_to_root = start_node; 
 LOOP 
 SELECT `naimenovanie`  
 INTO current_node  
 FROM `si_card` 
 WHERE  `id_si` = current_node;  
 IF (current_node IS NOT NULL) 
 THEN 
 SET path_to_root = CONCAT(path_to_root, ',', current_node);  
 END IF; 
 END LOOP; 
 END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP FUNCTION IF EXISTS `RandomString` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` FUNCTION `RandomString`(length int) RETURNS varchar(1024) CHARSET utf8mb4
    NO SQL
BEGIN
	SET @chars = 'abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ!@#$%^&*()-=+_№%:?1234567890~';
	SET @charLen = length(@chars);

	SET @randomPassword = '';

	WHILE length(@randomPassword) < length
		DO
		SET @randomPassword = concat(@randomPassword, substring(@chars,CEILING(RAND() * @charLen),1));
	END WHILE;

	RETURN @randomPassword ;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP FUNCTION IF EXISTS `SplitString` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`admin`@`%` FUNCTION `SplitString`(x VARCHAR(255), delim VARCHAR(12) ,pos INT) RETURNS varchar(255) CHARSET utf8mb4 COLLATE utf8mb4_unicode_ci
    NO SQL
BEGIN
	RETURN REPLACE(SUBSTRING(SUBSTRING_INDEX(x, delim, pos),
       LENGTH(SUBSTRING_INDEX(x, delim, pos -1)) + 1),
       delim, '');
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `!CreateUser` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `!CreateUser`(in in_login varchar(255), in pass varchar(255), in employeeRecordID int,
				in certificationDate date, in roleRecordId int)
BEGIN
	DECLARE randomString varchar(64);
    SET randomString =  (SELECT `oborot_si`.`RandomString`(64));
    
    INSERT INTO `oborot_si`.`employee_data`
	(`id_employee`,
	`date_of_certification`,
	`login`,
	`password_hash`,
	`salt`,
	`id_role`)
	VALUES
	(employeeRecordID,
	certificationDate,
	in_login,
	sha2(concat(pass, randomString),256),
	randomString,
	roleRecordId);
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `!UpdateUserPassword` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `!UpdateUserPassword`(in in_login varchar(255), in new_pass varchar(255))
BEGIN
	DECLARE randomString varchar(64);
    SET randomString =  (SELECT `oborot_si`.`RandomString`(64));


	UPDATE `oborot_si`.`employee_data`
	SET
		`login` = in_login,
		`password_hash` = sha2(concat(new_pass, randomString),256),
		`salt` = randomString
	WHERE `login` = in_login;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `COMPACT_KEYS` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`%` PROCEDURE `COMPACT_KEYS`(IN table_name VARCHAR(150), 
IN pk_name VARCHAR(150), 
OUT keys_changed INT)
BEGIN 
SET keys_changed = 0; 
SELECT 
CONCAT('Point 1. table_name = ', table_name, ', pk_name = ',  
pk_name, ', keys_changed = ', IFNULL(keys_changed, 'NULL')); 

SET @empty_key_query = 
CONCAT('SELECT MIN(`empty_key`) AS `empty_key` INTO @empty_key_value 
FROM  (SELECT `left`.`', pk_name, '` + 1 AS `empty_key` 
FROM  `', table_name, '` AS `left` 
LEFT OUTER JOIN `', table_name, '` AS `right` 
ON `left`.`', pk_name, 
'` + 1 = `right`.`', pk_name, '` 
WHERE  `right`.`', pk_name, '` IS NULL 
UNION 
SELECT 1 AS `empty_key` 
FROM  `', table_name, '` 
WHERE  NOT EXISTS(SELECT `', pk_name, '` 
FROM  `', table_name, '` 
WHERE  `', pk_name, '` = 1)) AS `prepared_data` 
WHERE `empty_key` < (SELECT MAX(`', pk_name, '`) 
FROM  `', table_name, '`)'); 
 
SET @max_key_query = 
CONCAT('SELECT MAX(`', pk_name, '`) 
INTO @max_key_value FROM `', table_name, '`'); 
SELECT CONCAT('Point 2. empty_key_query = ', @empty_key_query, 

'max_key_query = ', @max_key_query); 
PREPARE empty_key_stmt FROM @empty_key_query; 
 
 PREPARE max_key_stmt FROM @max_key_query; 
while_loop: LOOP 
EXECUTE empty_key_stmt; 
 SELECT CONCAT('Point 3. @empty_key_value = ', @empty_key_value); 
  
 IF (@empty_key_value IS NULL) 
 THEN LEAVE while_loop; 
END IF; 

EXECUTE max_key_stmt; 
SET @update_key_query = 
CONCAT('UPDATE `', table_name, '` SET `', pk_name, 
'` = @empty_key_value WHERE `', pk_name, '` = ', @max_key_value); 
 SELECT CONCAT('Point 4. @update_key_query = ', @update_key_query); 

 PREPARE update_key_stmt FROM @update_key_query; 
EXECUTE update_key_stmt; 
DEALLOCATE PREPARE update_key_stmt; 

SET keys_changed = keys_changed + 1; 
ITERATE while_loop; 

 END LOOP while_loop; 
 DEALLOCATE PREPARE max_key_stmt; 
DEALLOCATE PREPARE empty_key_stmt; 
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `GetCertificateByInventoryFactoryNumbers` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`OborotSiAdmin`@`%` PROCEDURE `GetCertificateByInventoryFactoryNumbers`(in inventory_num varchar(50), in factory_num varchar(50))
BEGIN
		SELECT `protocol`.`id_protocol`, 
                `protocol`.`num_protocol`, 
                `name_instrument`.`name_instrument`, 
                `measuring_instrument`.`factory_number`, 
                `measuring_instrument`.`inventory_number`, 
                `department`.`department`,
				`schedule`.`old_date`,
                `schedule`.`next_date`,
                (SELECT CONCAT (`employee`.`surname`,' ',
                (SELECT LEFT(`employee`.`name`,1)),'.',
                (SELECT LEFT(`employee`.`patronymic`,1)),'.')) As employee_name
                FROM `oborot_si`.`protocol` 
                JOIN `oborot_si`.`employee` 
                ON `employee`.`id_employee` = `protocol`.`id_employee` 
                JOIN `oborot_si`.`journal` 
                on  `journal`.`id_journal` = `protocol`.`id_journal` 
			    JOIN  `oborot_si`.`schedule`
                on `schedule`.`id_schedule` = `journal`.`schedule_reference` 
                JOIN `oborot_si`.`measuring_instrument`
                on `measuring_instrument`.`id_measuring_instrument` = `schedule`.`id_measuring_instrument` 
                JOIN  `oborot_si`.`department`
                on `department`.`id_department` = `measuring_instrument`.`id_department` 
                JOIN `oborot_si`.`conclusion` 
                on `conclusion`.`id_conclusion` = `journal`.`id_conclusion` 
                JOIN `oborot_si`.`name_instrument`
                on `name_instrument`.`id_name_instrument` = `measuring_instrument`.`id_name_instrument` 
                JOIN `oborot_si`.`type_of_work`  
                on `type_of_work`.`id_type_work` = `schedule`.`id_type_work` 
                WHERE `measuring_instrument`.`inventory_number` LIKE CONCAT ('%',inventory_num,'%' )
				AND `measuring_instrument`.`factory_number`  LIKE CONCAT ('%',factory_num,'%' )
                ORDER BY `protocol`.`num_protocol`;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `GetCertificateDGV` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`OborotSiAdmin`@`%` PROCEDURE `GetCertificateDGV`()
BEGIN
		SELECT `protocol`.`id_protocol`, 
                `protocol`.`num_protocol`, 
                `name_instrument`.`name_instrument`, 
                `measuring_instrument`.`factory_number`, 
                `measuring_instrument`.`inventory_number`, 
                `department`.`department`,
				`schedule`.`old_date`,
                `schedule`.`next_date`,
                (SELECT CONCAT (`employee`.`surname`,' ',
                (SELECT LEFT(`employee`.`name`,1)),'.',
                (SELECT LEFT(`employee`.`patronymic`,1)),'.')) As employee_name
                FROM `oborot_si`.`protocol` 
                JOIN `oborot_si`.`employee` 
                ON `employee`.`id_employee` = `protocol`.`id_employee` 
                JOIN `oborot_si`.`journal` 
                on  `journal`.`id_journal` = `protocol`.`id_journal` 
			    JOIN  `oborot_si`.`schedule`
                on `schedule`.`id_schedule` = `journal`.`schedule_reference` 
                JOIN `oborot_si`.`measuring_instrument`
                on `measuring_instrument`.`id_measuring_instrument` = `schedule`.`id_measuring_instrument` 
                JOIN  `oborot_si`.`department`
                on `department`.`id_department` = `measuring_instrument`.`id_department` 
                JOIN `oborot_si`.`conclusion` 
                on `conclusion`.`id_conclusion` = `journal`.`id_conclusion` 
                JOIN `oborot_si`.`name_instrument`
                on `name_instrument`.`id_name_instrument` = `measuring_instrument`.`id_name_instrument` 
                JOIN `oborot_si`.`type_of_work`  
                on `type_of_work`.`id_type_work` = `schedule`.`id_type_work` 
                ORDER BY `protocol`.`num_protocol`;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `GetJournalDGV` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`OborotSiAdmin`@`%` PROCEDURE `GetJournalDGV`()
BEGIN
	SELECT 
		`journal`.`id_journal`,
		`journal`.`num_journal`,
		`name_ins`.`name_instrument`, 
		`mes_ins`.`type`,
		`mes_ins`.`inventory_number`,
		`mes_ins`.`factory_number`, 
		`con`.`conclusion`,
		`type_of_work`.`type_of_work` 
	FROM `oborot_si`.`journal`
	JOIN `oborot_si`.`schedule` sch on  `sch`.`id_schedule` = `journal`.`schedule_reference`
	JOIN `oborot_si`.`measuring_instrument` mes_ins on `mes_ins`.`id_measuring_instrument` = `sch`.`id_measuring_instrument`
	JOIN `oborot_si`.`conclusion` con on `con`.`id_conclusion` = `journal`.`id_conclusion`
	JOIN `oborot_si`.`name_instrument` name_ins on `name_ins`.`id_name_instrument` = `mes_ins`.`id_name_instrument`
	JOIN `oborot_si`.`type_of_work` on `type_of_work`.`id_type_work` = `sch`.`id_type_work`
    ORDER BY `journal`.`num_journal`;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `GetJournalDGVByInventoryFactory` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`OborotSiAdmin`@`%` PROCEDURE `GetJournalDGVByInventoryFactory`(in inventory_num varchar(50), in factory_num varchar(50))
BEGIN
SELECT 
`journal`.`id_journal`,
`journal`.`num_journal`,
`name_instrument`.`name_instrument`, 
`measuring_instrument`.`type`,
`measuring_instrument`.`inventory_number`,
`measuring_instrument`.`factory_number`, 
`conclusion`.`conclusion`,
`type_of_work`.`type_of_work` 
FROM `measuring_instrument`
JOIN `oborot_si`.`name_instrument`  
ON `measuring_instrument`.`id_name_instrument` = `name_instrument`.`id_name_instrument` 
JOIN `oborot_si`.`schedule` 
ON `measuring_instrument`.`id_measuring_instrument` = `schedule`.`id_measuring_instrument`  
JOIN  `oborot_si`.`journal` 
ON `schedule`.`id_schedule` = `journal`.`schedule_reference`
JOIN  `oborot_si`.`conclusion` 
ON `journal`.`id_conclusion` = `conclusion`.`id_conclusion`
JOIN  `oborot_si`.`type_of_work` 
ON `schedule`.`id_type_work` = `type_of_work`.`id_type_work` 
WHERE `measuring_instrument`.`inventory_number` LIKE CONCAT ('%',inventory_num,'%' )
AND `measuring_instrument`.`factory_number`  LIKE CONCAT ('%',factory_num,'%' )
GROUP BY 
`journal`.`id_journal`
ORDER BY `journal`.`num_journal`;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `GetProtocolDGV` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`OborotSiAdmin`@`%` PROCEDURE `GetProtocolDGV`()
BEGIN
	SELECT `protocol`.`id_protocol`, 
                `protocol`.`num_protocol`, 
                `name_instrument`.`name_instrument`, 
                `measuring_instrument`.`type`, 
                `measuring_instrument`.`inventory_number`, 
                `measuring_instrument`.`factory_number`, 
                `type_of_work`.`type_of_work` ,
				`protocol`.`note`,
                `conclusion`.`conclusion`, 
                (SELECT CONCAT (`employee`.`surname`,' ',
                (SELECT LEFT(`employee`.`name`,1)),'.',
                (SELECT LEFT(`employee`.`patronymic`,1)),'.')) As employee_name
                FROM `oborot_si`.`protocol` 
                JOIN `oborot_si`.`employee` 
                ON `employee`.`id_employee` = `protocol`.`id_employee` 
                JOIN `oborot_si`.`journal` 
                on  `journal`.`id_journal` = `protocol`.`id_journal` 
				JOIN  `oborot_si`.`schedule`
                on `schedule`.`id_schedule` = `journal`.`schedule_reference` 
                JOIN `oborot_si`.`measuring_instrument`
                on `measuring_instrument`.`id_measuring_instrument` = `schedule`.`id_measuring_instrument` 
                JOIN `oborot_si`.`conclusion` 
                on `conclusion`.`id_conclusion` = `journal`.`id_conclusion` 
                JOIN `oborot_si`.`name_instrument`
                on `name_instrument`.`id_name_instrument` = `measuring_instrument`.`id_name_instrument` 
                JOIN `oborot_si`.`type_of_work`  
                on `type_of_work`.`id_type_work` = `schedule`.`id_type_work` 
                ORDER BY `protocol`.`num_protocol`;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `GetProtocolDGVByInventoryFactoryNumbers` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`OborotSiAdmin`@`%` PROCEDURE `GetProtocolDGVByInventoryFactoryNumbers`(in inventory_num varchar(50), in factory_num varchar(50))
BEGIN
	SELECT `protocol`.`id_protocol`, 
                `protocol`.`num_protocol`, 
                `name_instrument`.`name_instrument`, 
                `measuring_instrument`.`type`, 
                `measuring_instrument`.`inventory_number`, 
                `measuring_instrument`.`factory_number`, 
                `type_of_work`.`type_of_work` ,
				`protocol`.`note`,
                `conclusion`.`conclusion`, 
                (SELECT CONCAT (`employee`.`surname`,' ',
                (SELECT LEFT(`employee`.`name`,1)),'.',
                (SELECT LEFT(`employee`.`patronymic`,1)),'.')) As employee_name
                FROM `oborot_si`.`protocol` 
                JOIN `oborot_si`.`employee` 
                ON `employee`.`id_employee` = `protocol`.`id_employee` 
                JOIN `oborot_si`.`journal` 
                on  `journal`.`id_journal` = `protocol`.`id_journal` 
				JOIN  `oborot_si`.`schedule`
                on `schedule`.`id_schedule` = `journal`.`schedule_reference` 
                JOIN `oborot_si`.`measuring_instrument`
                on `measuring_instrument`.`id_measuring_instrument` = `schedule`.`id_measuring_instrument` 
                JOIN `oborot_si`.`conclusion` 
                on `conclusion`.`id_conclusion` = `journal`.`id_conclusion` 
                JOIN `oborot_si`.`name_instrument`
                on `name_instrument`.`id_name_instrument` = `measuring_instrument`.`id_name_instrument` 
                JOIN `oborot_si`.`type_of_work`  
                on `type_of_work`.`id_type_work` = `schedule`.`id_type_work` 
                WHERE `measuring_instrument`.`inventory_number` LIKE CONCAT ('%',inventory_num,'%' )
				AND `measuring_instrument`.`factory_number`  LIKE CONCAT ('%',factory_num,'%' )
                ORDER BY `protocol`.`num_protocol`;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `GetScheduleCalibrationByNextData` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`OborotSiAdmin`@`%` PROCEDURE `GetScheduleCalibrationByNextData`(in nextDate date)
BEGIN
SELECT 
		`schedule`.`id_schedule`, 
		`name_instrument`.`name_instrument`, 
		`measuring_instrument`.`type`, 
		`measuring_instrument`.`factory_number`, 
		`measuring_instrument`.`inventory_number`, 
        `department`.`department`,
		`schedule`.`old_date`, 
		(Select CONCAT(`schedule`.`frequency`, ' мес.')) AS 'frequency', 
		`schedule`.`next_date`, 
        `type_of_work`.`type_of_work`
	FROM `oborot_si`.`measuring_instrument`  
	JOIN `oborot_si`.`name_instrument`  
		ON `measuring_instrument`.`id_name_instrument` = `name_instrument`.`id_name_instrument` 
	JOIN `oborot_si`.`department`  
		ON `measuring_instrument`.`id_department` = `department`.`id_department` 
	JOIN `oborot_si`.`schedule` 
		ON `measuring_instrument`.`id_measuring_instrument` = `schedule`.`id_measuring_instrument` 
	JOIN  `oborot_si`.`type_of_work` 
		ON `schedule`.`id_type_work` = `type_of_work`.`id_type_work` 
	WHERE `schedule`.`next_date`= nextDate  AND (`type_of_work`.`type_of_work`= 'Проверка' OR `type_of_work`.`type_of_work`= 'Калибровка')
	GROUP BY (`schedule`.`id_schedule`) 
	ORDER BY `schedule`.`next_date`;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `GetScheduleCalibrationCheckArchive` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`OborotSiAdmin`@`%` PROCEDURE `GetScheduleCalibrationCheckArchive`()
BEGIN
SELECT 
		`schedule`.`id_schedule`, 
		`name_instrument`.`name_instrument`, 
		`measuring_instrument`.`type`, 
		`measuring_instrument`.`factory_number`, 
		`measuring_instrument`.`inventory_number`, 
        `department`.`department`,
		`schedule`.`old_date`, 
		(Select CONCAT(`schedule`.`frequency`, ' мес.')) AS 'frequency', 
		`schedule`.`next_date`, 
        `type_of_work`.`type_of_work`
	FROM `oborot_si`.`measuring_instrument`  
	JOIN `oborot_si`.`name_instrument`  
		ON `measuring_instrument`.`id_name_instrument` = `name_instrument`.`id_name_instrument` 
	JOIN `oborot_si`.`department`  
		ON `measuring_instrument`.`id_department` = `department`.`id_department` 
	JOIN `oborot_si`.`schedule` 
		ON `measuring_instrument`.`id_measuring_instrument` = `schedule`.`id_measuring_instrument` 
	JOIN  `oborot_si`.`type_of_work` 
		ON `schedule`.`id_type_work` = `type_of_work`.`id_type_work` 
    WHERE `type_of_work`.`type_of_work`= 'Проверка' OR `type_of_work`.`type_of_work`= 'Калибровка'
	GROUP BY (`schedule`.`id_schedule`) 
	ORDER BY `schedule`.`next_date`;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `GetScheduleCalibrationCheckArchiveByData` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`OborotSiAdmin`@`%` PROCEDURE `GetScheduleCalibrationCheckArchiveByData`(in nextDate date)
BEGIN
SELECT 
		`schedule`.`id_schedule`, 
		`name_instrument`.`name_instrument`, 
		`measuring_instrument`.`type`, 
		`measuring_instrument`.`factory_number`, 
		`measuring_instrument`.`inventory_number`, 
        `department`.`department`,
		`schedule`.`old_date`, 
		(Select CONCAT(`schedule`.`frequency`, ' мес.')) AS 'frequency', 
		`schedule`.`next_date`, 
        `type_of_work`.`type_of_work`
	FROM `oborot_si`.`measuring_instrument`  
	JOIN `oborot_si`.`name_instrument`  
		ON `measuring_instrument`.`id_name_instrument` = `name_instrument`.`id_name_instrument` 
	JOIN `oborot_si`.`department`  
		ON `measuring_instrument`.`id_department` = `department`.`id_department` 
	JOIN `oborot_si`.`schedule` 
		ON `measuring_instrument`.`id_measuring_instrument` = `schedule`.`id_measuring_instrument` 
	JOIN  `oborot_si`.`type_of_work` 
		ON `schedule`.`id_type_work` = `type_of_work`.`id_type_work` 
        WHERE `schedule`.`next_date`= nextDate  AND (`type_of_work`.`type_of_work`= 'Проверка' OR `type_of_work`.`type_of_work`= 'Калибровка')
	GROUP BY (`schedule`.`id_schedule`) 
	ORDER BY `schedule`.`next_date`;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `GetScheduleCalibrationCheckArchiveByInventoryFactory` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`OborotSiAdmin`@`%` PROCEDURE `GetScheduleCalibrationCheckArchiveByInventoryFactory`(in inventory_num varchar(50), in factory_num varchar(50))
BEGIN
SELECT 
		`schedule`.`id_schedule`, 
		`name_instrument`.`name_instrument`, 
		`measuring_instrument`.`type`, 
		`measuring_instrument`.`factory_number`, 
		`measuring_instrument`.`inventory_number`, 
        `department`.`department`,
		`schedule`.`old_date`, 
		(Select CONCAT(`schedule`.`frequency`, ' мес.')) AS 'frequency', 
		`schedule`.`next_date`, 
        `type_of_work`.`type_of_work`
	FROM `oborot_si`.`measuring_instrument`  
	JOIN `oborot_si`.`name_instrument`  
		ON `measuring_instrument`.`id_name_instrument` = `name_instrument`.`id_name_instrument` 
	JOIN `oborot_si`.`department`  
		ON `measuring_instrument`.`id_department` = `department`.`id_department` 
	JOIN `oborot_si`.`schedule` 
		ON `measuring_instrument`.`id_measuring_instrument` = `schedule`.`id_measuring_instrument` 
	JOIN  `oborot_si`.`type_of_work` 
		ON `schedule`.`id_type_work` = `type_of_work`.`id_type_work` 
	WHERE `measuring_instrument`.`inventory_number` LIKE CONCAT ('%',inventory_num,'%' )
		AND `measuring_instrument`.`factory_number`  LIKE CONCAT ('%',factory_num,'%' )
        AND  (`type_of_work`.`type_of_work`= 'Проверка' OR `type_of_work`.`type_of_work`= 'Калибровка')
	GROUP BY (`schedule`.`id_schedule`) 
	ORDER BY `schedule`.`next_date`;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `GetScheduleCalibrationCheckByData` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`OborotSiAdmin`@`%` PROCEDURE `GetScheduleCalibrationCheckByData`(in nextDate date)
BEGIN
SELECT 		
		`schedule`.`id_schedule`, 
		`name_instrument`.`name_instrument`, 
		`measuring_instrument`.`type`, 
		`measuring_instrument`.`factory_number`, 
		`measuring_instrument`.`inventory_number`, 
        `department`.`department`,
		`schedule`.`old_date`, 
		(Select CONCAT(`schedule`.`frequency`, ' мес.')) AS 'frequency', 
		`schedule`.`next_date`, 
        `type_of_work`.`type_of_work`
	FROM `oborot_si`.`measuring_instrument`  
	JOIN `oborot_si`.`name_instrument`  
		ON `measuring_instrument`.`id_name_instrument` = `name_instrument`.`id_name_instrument` 
	JOIN `oborot_si`.`department`  
		ON `measuring_instrument`.`id_department` = `department`.`id_department` 
	JOIN `oborot_si`.`schedule` 
		ON `measuring_instrument`.`id_measuring_instrument` = `schedule`.`id_measuring_instrument` 
	JOIN  `oborot_si`.`type_of_work` 
		ON `schedule`.`id_type_work` = `type_of_work`.`id_type_work` 
	WHERE `schedule`.`next_date`>= nextDate AND (`type_of_work`.`type_of_work`= 'Проверка' OR `type_of_work`.`type_of_work`= 'Калибровка')
	GROUP BY (`schedule`.`id_schedule`) 
	ORDER BY `schedule`.`next_date`;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `GetScheduleCalibrationCheckDataByInventoryFactoryNumbers` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`OborotSiAdmin`@`%` PROCEDURE `GetScheduleCalibrationCheckDataByInventoryFactoryNumbers`(in nextDate date, in inventory_num varchar(50), in factory_num varchar(50))
BEGIN
SELECT 
		`schedule`.`id_schedule`, 
		`name_instrument`.`name_instrument`, 
		`measuring_instrument`.`type`, 
		`measuring_instrument`.`factory_number`, 
		`measuring_instrument`.`inventory_number`, 
        `department`.`department`,
		`schedule`.`old_date`, 
		(Select CONCAT(`schedule`.`frequency`, ' мес.')) AS 'frequency', 
		`schedule`.`next_date`, 
        `type_of_work`.`type_of_work`
	FROM `oborot_si`.`measuring_instrument`  
	JOIN `oborot_si`.`name_instrument`  
		ON `measuring_instrument`.`id_name_instrument` = `name_instrument`.`id_name_instrument` 
	JOIN `oborot_si`.`department`  
		ON `measuring_instrument`.`id_department` = `department`.`id_department` 
	JOIN `oborot_si`.`schedule` 
		ON `measuring_instrument`.`id_measuring_instrument` = `schedule`.`id_measuring_instrument` 
	JOIN  `oborot_si`.`type_of_work` 
		ON `schedule`.`id_type_work` = `type_of_work`.`id_type_work` 
	WHERE `schedule`.`next_date`>= nextDate AND `measuring_instrument`.`inventory_number` LIKE CONCAT ('%',inventory_num,'%' )
AND `measuring_instrument`.`factory_number`  LIKE CONCAT ('%',factory_num,'%' )  AND (`type_of_work`.`type_of_work`= 'Проверка' OR `type_of_work`.`type_of_work`= 'Калибровка')
	GROUP BY (`schedule`.`id_schedule`) 
	ORDER BY `schedule`.`next_date`;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `GetScheduleData` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`admin`@`%` PROCEDURE `GetScheduleData`(in nextDate date)
BEGIN
	SELECT 
		`schedule`.`id_schedule`, 
		`name_instrument`.`name_instrument`, 
		`measuring_instrument`.`type`, 
		`measuring_instrument`.`inventory_number`, 
		`measuring_instrument`.`factory_number`, 
		`schedule`.`frequency`, 
		`schedule`.`old_date`, 
		`oborot_si`.`GetVenueNameByID`(`schedule`.`old_venue`) AS'old_ven', 
		`schedule`.`next_date`, 
        `oborot_si`.`GetVenueNameByID`(`schedule`.`new_venue`) AS'new_ven', 
		`conclusion`.`conclusion`, 
		`type_of_work`.`type_of_work` 
	FROM `oborot_si`.`measuring_instrument`  
	JOIN `oborot_si`.`name_instrument`  
		ON `measuring_instrument`.`id_name_instrument` = `name_instrument`.`id_name_instrument` 
	JOIN `oborot_si`.`schedule` 
		ON `measuring_instrument`.`id_measuring_instrument` = `schedule`.`id_measuring_instrument` 
	JOIN `oborot_si`.`journal` 
		ON `measuring_instrument`.`id_measuring_instrument` = `journal`.`id_measuring_instrument` 
	JOIN `oborot_si`.`conclusion` 
		ON `journal`.`id_conclusion` = `conclusion`.`id_conclusion` 
	JOIN  `oborot_si`.`type_of_work` 
		ON `journal`.`id_type_work` = `type_of_work`.`id_type_work` 
	WHERE `schedule`.`next_date`>= nextDate 
	GROUP BY (`schedule`.`id_schedule`) 
	ORDER BY `schedule`.`next_date`;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `GetScheduleOnlyCalibrationArchive` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`OborotSiAdmin`@`%` PROCEDURE `GetScheduleOnlyCalibrationArchive`()
BEGIN
SELECT 
		`schedule`.`id_schedule`, 
		`name_instrument`.`name_instrument`, 
		`measuring_instrument`.`type`, 
		`measuring_instrument`.`factory_number`, 
		`measuring_instrument`.`inventory_number`, 
        `department`.`department`,
		`schedule`.`old_date`, 
		(Select CONCAT(`schedule`.`frequency`, ' мес.')) AS 'frequency', 
		`schedule`.`next_date`, 
        `type_of_work`.`type_of_work`
	FROM `oborot_si`.`measuring_instrument`  
	JOIN `oborot_si`.`name_instrument`  
		ON `measuring_instrument`.`id_name_instrument` = `name_instrument`.`id_name_instrument` 
	JOIN `oborot_si`.`department`  
		ON `measuring_instrument`.`id_department` = `department`.`id_department` 
	JOIN `oborot_si`.`schedule` 
		ON `measuring_instrument`.`id_measuring_instrument` = `schedule`.`id_measuring_instrument` 
	JOIN  `oborot_si`.`type_of_work` 
		ON `schedule`.`id_type_work` = `type_of_work`.`id_type_work` 
	WHERE `type_of_work`.`type_of_work`= 'Калибровка'
	GROUP BY (`schedule`.`id_schedule`) 
	ORDER BY `schedule`.`next_date`;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `GetScheduleOnlyCalibrationArchiveByInventoryFactory` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`OborotSiAdmin`@`%` PROCEDURE `GetScheduleOnlyCalibrationArchiveByInventoryFactory`(in inventory_num varchar(50), in factory_num varchar(50))
BEGIN
SELECT 
		`schedule`.`id_schedule`, 
		`name_instrument`.`name_instrument`, 
		`measuring_instrument`.`type`, 
		`measuring_instrument`.`factory_number`, 
		`measuring_instrument`.`inventory_number`, 
        `department`.`department`,
		`schedule`.`old_date`, 
		(Select CONCAT(`schedule`.`frequency`, ' мес.')) AS 'frequency', 
		`schedule`.`next_date`, 
        `type_of_work`.`type_of_work`
	FROM `oborot_si`.`measuring_instrument`  
	JOIN `oborot_si`.`name_instrument`  
		ON `measuring_instrument`.`id_name_instrument` = `name_instrument`.`id_name_instrument` 
	JOIN `oborot_si`.`department`  
		ON `measuring_instrument`.`id_department` = `department`.`id_department` 
	JOIN `oborot_si`.`schedule` 
		ON `measuring_instrument`.`id_measuring_instrument` = `schedule`.`id_measuring_instrument` 
	JOIN  `oborot_si`.`type_of_work` 
		ON `schedule`.`id_type_work` = `type_of_work`.`id_type_work` 
	WHERE `measuring_instrument`.`inventory_number` LIKE CONCAT ('%',inventory_num,'%' )
		AND `measuring_instrument`.`factory_number`  LIKE CONCAT ('%',factory_num,'%' )
		AND `type_of_work`.`type_of_work`= 'Калибровка'
	GROUP BY (`schedule`.`id_schedule`) 
	ORDER BY `schedule`.`next_date`;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `GetScheduleOnlyCalibrationByData` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`OborotSiAdmin`@`%` PROCEDURE `GetScheduleOnlyCalibrationByData`(in nextDate date)
BEGIN
SELECT 		
		`schedule`.`id_schedule`, 
		`name_instrument`.`name_instrument`, 
		`measuring_instrument`.`type`, 
		`measuring_instrument`.`factory_number`, 
		`measuring_instrument`.`inventory_number`, 
        `department`.`department`,
		`schedule`.`old_date`, 
		(Select CONCAT(`schedule`.`frequency`, ' мес.')) AS 'frequency', 
		`schedule`.`next_date`, 
        `type_of_work`.`type_of_work`
	FROM `oborot_si`.`measuring_instrument`  
	JOIN `oborot_si`.`name_instrument`  
		ON `measuring_instrument`.`id_name_instrument` = `name_instrument`.`id_name_instrument` 
	JOIN `oborot_si`.`department`  
		ON `measuring_instrument`.`id_department` = `department`.`id_department` 
	JOIN `oborot_si`.`schedule` 
		ON `measuring_instrument`.`id_measuring_instrument` = `schedule`.`id_measuring_instrument` 
	JOIN  `oborot_si`.`type_of_work` 
		ON `schedule`.`id_type_work` = `type_of_work`.`id_type_work` 
	WHERE `schedule`.`next_date`>= nextDate AND `type_of_work`.`type_of_work`= 'Калибровка'
	GROUP BY (`schedule`.`id_schedule`) 
	ORDER BY `schedule`.`next_date`;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `GetScheduleOnlyCalibrationByNextData` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`OborotSiAdmin`@`%` PROCEDURE `GetScheduleOnlyCalibrationByNextData`(in nextDate date)
BEGIN
SELECT 
		`schedule`.`id_schedule`, 
		`name_instrument`.`name_instrument`, 
		`measuring_instrument`.`type`, 
		`measuring_instrument`.`factory_number`, 
		`measuring_instrument`.`inventory_number`, 
        `department`.`department`,
		`schedule`.`old_date`, 
		(Select CONCAT(`schedule`.`frequency`, ' мес.')) AS 'frequency', 
		`schedule`.`next_date`, 
        `type_of_work`.`type_of_work`
	FROM `oborot_si`.`measuring_instrument`  
	JOIN `oborot_si`.`name_instrument`  
		ON `measuring_instrument`.`id_name_instrument` = `name_instrument`.`id_name_instrument` 
	JOIN `oborot_si`.`department`  
		ON `measuring_instrument`.`id_department` = `department`.`id_department` 
	JOIN `oborot_si`.`schedule` 
		ON `measuring_instrument`.`id_measuring_instrument` = `schedule`.`id_measuring_instrument` 
	JOIN  `oborot_si`.`type_of_work` 
		ON `schedule`.`id_type_work` = `type_of_work`.`id_type_work` 
	WHERE `schedule`.`next_date`= nextDate AND `type_of_work`.`type_of_work`= 'Калибровка'
	GROUP BY (`schedule`.`id_schedule`) 
	ORDER BY `schedule`.`next_date`;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `GetScheduleOnlyCalibrationDataByInventoryFactoryNumbers` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`OborotSiAdmin`@`%` PROCEDURE `GetScheduleOnlyCalibrationDataByInventoryFactoryNumbers`(in nextDate date, in inventory_num varchar(50), in factory_num varchar(50))
BEGIN
SELECT 
		`schedule`.`id_schedule`, 
		`name_instrument`.`name_instrument`, 
		`measuring_instrument`.`type`, 
		`measuring_instrument`.`factory_number`, 
		`measuring_instrument`.`inventory_number`, 
        `department`.`department`,
		`schedule`.`old_date`, 
		(Select CONCAT(`schedule`.`frequency`, ' мес.')) AS 'frequency', 
		`schedule`.`next_date`, 
        `type_of_work`.`type_of_work`
	FROM `oborot_si`.`measuring_instrument`  
	JOIN `oborot_si`.`name_instrument`  
		ON `measuring_instrument`.`id_name_instrument` = `name_instrument`.`id_name_instrument` 
	JOIN `oborot_si`.`department`  
		ON `measuring_instrument`.`id_department` = `department`.`id_department` 
	JOIN `oborot_si`.`schedule` 
		ON `measuring_instrument`.`id_measuring_instrument` = `schedule`.`id_measuring_instrument` 
	JOIN  `oborot_si`.`type_of_work` 
		ON `schedule`.`id_type_work` = `type_of_work`.`id_type_work` 
	WHERE `schedule`.`next_date`>= nextDate AND `measuring_instrument`.`inventory_number` LIKE CONCAT ('%',inventory_num,'%' )
AND `measuring_instrument`.`factory_number`  LIKE CONCAT ('%',factory_num,'%' ) AND `type_of_work`.`type_of_work`= 'Калибровка'
	GROUP BY (`schedule`.`id_schedule`) 
	ORDER BY `schedule`.`next_date`;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `GetScheduleOnlyCheckArchive` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`OborotSiAdmin`@`%` PROCEDURE `GetScheduleOnlyCheckArchive`()
BEGIN
SELECT 
		`schedule`.`id_schedule`, 
		`name_instrument`.`name_instrument`, 
		`measuring_instrument`.`type`, 
		`measuring_instrument`.`factory_number`, 
		`measuring_instrument`.`inventory_number`, 
        `department`.`department`,
		`schedule`.`old_date`, 
		(Select CONCAT(`schedule`.`frequency`, ' мес.')) AS 'frequency', 
		`schedule`.`next_date`, 
        `type_of_work`.`type_of_work`
	FROM `oborot_si`.`measuring_instrument`  
	JOIN `oborot_si`.`name_instrument`  
		ON `measuring_instrument`.`id_name_instrument` = `name_instrument`.`id_name_instrument` 
	JOIN `oborot_si`.`department`  
		ON `measuring_instrument`.`id_department` = `department`.`id_department` 
	JOIN `oborot_si`.`schedule` 
		ON `measuring_instrument`.`id_measuring_instrument` = `schedule`.`id_measuring_instrument` 
	JOIN  `oborot_si`.`type_of_work` 
		ON `schedule`.`id_type_work` = `type_of_work`.`id_type_work` 
	WHERE `type_of_work`.`type_of_work`= 'Проверка'
	GROUP BY (`schedule`.`id_schedule`) 
	ORDER BY `schedule`.`next_date`;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `GetScheduleOnlyCheckArchiveByInventoryFactory` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`OborotSiAdmin`@`%` PROCEDURE `GetScheduleOnlyCheckArchiveByInventoryFactory`(in inventory_num varchar(50), in factory_num varchar(50))
BEGIN
SELECT 
		`schedule`.`id_schedule`, 
		`name_instrument`.`name_instrument`, 
		`measuring_instrument`.`type`, 
		`measuring_instrument`.`factory_number`, 
		`measuring_instrument`.`inventory_number`, 
        `department`.`department`,
		`schedule`.`old_date`, 
		(Select CONCAT(`schedule`.`frequency`, ' мес.')) AS 'frequency', 
		`schedule`.`next_date`, 
        `type_of_work`.`type_of_work`
	FROM `oborot_si`.`measuring_instrument`  
	JOIN `oborot_si`.`name_instrument`  
		ON `measuring_instrument`.`id_name_instrument` = `name_instrument`.`id_name_instrument` 
	JOIN `oborot_si`.`department`  
		ON `measuring_instrument`.`id_department` = `department`.`id_department` 
	JOIN `oborot_si`.`schedule` 
		ON `measuring_instrument`.`id_measuring_instrument` = `schedule`.`id_measuring_instrument` 
	JOIN  `oborot_si`.`type_of_work` 
		ON `schedule`.`id_type_work` = `type_of_work`.`id_type_work` 
	WHERE `measuring_instrument`.`inventory_number` LIKE CONCAT ('%',inventory_num,'%' )
		AND `measuring_instrument`.`factory_number`  LIKE CONCAT ('%',factory_num,'%' )
		AND `type_of_work`.`type_of_work`= 'Проверка'
	GROUP BY (`schedule`.`id_schedule`) 
	ORDER BY `schedule`.`next_date`;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `GetScheduleOnlyCheckByData` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`OborotSiAdmin`@`%` PROCEDURE `GetScheduleOnlyCheckByData`(in nextDate date)
BEGIN
SELECT 		
		`schedule`.`id_schedule`, 
		`name_instrument`.`name_instrument`, 
		`measuring_instrument`.`type`, 
		`measuring_instrument`.`factory_number`, 
		`measuring_instrument`.`inventory_number`, 
        `department`.`department`,
		`schedule`.`old_date`, 
		(Select CONCAT(`schedule`.`frequency`, ' мес.')) AS 'frequency', 
		`schedule`.`next_date`, 
        `type_of_work`.`type_of_work`
	FROM `oborot_si`.`measuring_instrument`  
	JOIN `oborot_si`.`name_instrument`  
		ON `measuring_instrument`.`id_name_instrument` = `name_instrument`.`id_name_instrument` 
	JOIN `oborot_si`.`department`  
		ON `measuring_instrument`.`id_department` = `department`.`id_department` 
	JOIN `oborot_si`.`schedule` 
		ON `measuring_instrument`.`id_measuring_instrument` = `schedule`.`id_measuring_instrument` 
	JOIN  `oborot_si`.`type_of_work` 
		ON `schedule`.`id_type_work` = `type_of_work`.`id_type_work` 
	WHERE `schedule`.`next_date`>= nextDate AND `type_of_work`.`type_of_work`= 'Проверка'
	GROUP BY (`schedule`.`id_schedule`) 
	ORDER BY `schedule`.`next_date`;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `GetScheduleOnlyCheckByNextData` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`OborotSiAdmin`@`%` PROCEDURE `GetScheduleOnlyCheckByNextData`(in nextDate date)
BEGIN
SELECT 
		`schedule`.`id_schedule`, 
		`name_instrument`.`name_instrument`, 
		`measuring_instrument`.`type`, 
		`measuring_instrument`.`factory_number`, 
		`measuring_instrument`.`inventory_number`, 
        `department`.`department`,
		`schedule`.`old_date`, 
		(Select CONCAT(`schedule`.`frequency`, ' мес.')) AS 'frequency', 
		`schedule`.`next_date`, 
        `type_of_work`.`type_of_work`
	FROM `oborot_si`.`measuring_instrument`  
	JOIN `oborot_si`.`name_instrument`  
		ON `measuring_instrument`.`id_name_instrument` = `name_instrument`.`id_name_instrument` 
	JOIN `oborot_si`.`department`  
		ON `measuring_instrument`.`id_department` = `department`.`id_department` 
	JOIN `oborot_si`.`schedule` 
		ON `measuring_instrument`.`id_measuring_instrument` = `schedule`.`id_measuring_instrument` 
	JOIN  `oborot_si`.`type_of_work` 
		ON `schedule`.`id_type_work` = `type_of_work`.`id_type_work` 
	WHERE `schedule`.`next_date`= nextDate AND `type_of_work`.`type_of_work`= 'Проверка'
	GROUP BY (`schedule`.`id_schedule`) 
	ORDER BY `schedule`.`next_date`;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `GetScheduleOnlyCheckDataByInventoryFactoryNumbers` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`OborotSiAdmin`@`%` PROCEDURE `GetScheduleOnlyCheckDataByInventoryFactoryNumbers`(in nextDate date, in inventory_num varchar(50), in factory_num varchar(50))
BEGIN
SELECT 
		`schedule`.`id_schedule`, 
		`name_instrument`.`name_instrument`, 
		`measuring_instrument`.`type`, 
		`measuring_instrument`.`factory_number`, 
		`measuring_instrument`.`inventory_number`, 
        `department`.`department`,
		`schedule`.`old_date`, 
		(Select CONCAT(`schedule`.`frequency`, ' мес.')) AS 'frequency', 
		`schedule`.`next_date`, 
        `type_of_work`.`type_of_work`
	FROM `oborot_si`.`measuring_instrument`  
	JOIN `oborot_si`.`name_instrument`  
		ON `measuring_instrument`.`id_name_instrument` = `name_instrument`.`id_name_instrument` 
	JOIN `oborot_si`.`department`  
		ON `measuring_instrument`.`id_department` = `department`.`id_department` 
	JOIN `oborot_si`.`schedule` 
		ON `measuring_instrument`.`id_measuring_instrument` = `schedule`.`id_measuring_instrument` 
	JOIN  `oborot_si`.`type_of_work` 
		ON `schedule`.`id_type_work` = `type_of_work`.`id_type_work` 
	WHERE `schedule`.`next_date`>= nextDate AND `measuring_instrument`.`inventory_number` LIKE CONCAT ('%',inventory_num,'%' )
AND `measuring_instrument`.`factory_number`  LIKE CONCAT ('%',factory_num,'%' ) AND `type_of_work`.`type_of_work`= 'Проверка'
	GROUP BY (`schedule`.`id_schedule`) 
	ORDER BY `schedule`.`next_date`;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `GetScheduleVerificationArchive` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`OborotSiAdmin`@`%` PROCEDURE `GetScheduleVerificationArchive`()
BEGIN
SELECT 
		`schedule`.`id_schedule`, 
		`name_instrument`.`name_instrument`, 
		`measuring_instrument`.`type`, 
		`measuring_instrument`.`factory_number`, 
		`measuring_instrument`.`inventory_number`, 
        `department`.`department`,
		`schedule`.`old_date`, 
		(Select CONCAT(`schedule`.`frequency`, ' мес.')) AS 'frequency', 
		`oborot_si`.`GetVenueNameByID`(`schedule`.`old_venue`) AS'old_ven', 
		`schedule`.`next_date`, 
        `oborot_si`.`GetVenueNameByID`(`schedule`.`new_venue`) AS'new_ven'
	FROM `oborot_si`.`measuring_instrument`  
	JOIN `oborot_si`.`name_instrument`  
		ON `measuring_instrument`.`id_name_instrument` = `name_instrument`.`id_name_instrument` 
	JOIN `oborot_si`.`department`  
		ON `measuring_instrument`.`id_department` = `department`.`id_department` 
	JOIN `oborot_si`.`schedule` 
		ON `measuring_instrument`.`id_measuring_instrument` = `schedule`.`id_measuring_instrument` 
	JOIN  `oborot_si`.`type_of_work` 
		ON `schedule`.`id_type_work` = `type_of_work`.`id_type_work` 
    WHERE `type_of_work`.`type_of_work`= 'Поверка'
	GROUP BY (`schedule`.`id_schedule`) 
	ORDER BY `schedule`.`next_date`;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `GetScheduleVerificationArchiveByData` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`OborotSiAdmin`@`%` PROCEDURE `GetScheduleVerificationArchiveByData`(in nextDate date)
BEGIN
SELECT 
		`schedule`.`id_schedule`, 
		`name_instrument`.`name_instrument`, 
		`measuring_instrument`.`type`, 
		`measuring_instrument`.`factory_number`, 
		`measuring_instrument`.`inventory_number`, 
        `department`.`department`,
		`schedule`.`old_date`, 
		(Select CONCAT(`schedule`.`frequency`, ' мес.')) AS 'frequency', 
		`oborot_si`.`GetVenueNameByID`(`schedule`.`old_venue`) AS'old_ven', 
		`schedule`.`next_date`, 
        `oborot_si`.`GetVenueNameByID`(`schedule`.`new_venue`) AS'new_ven'
	FROM `oborot_si`.`measuring_instrument`  
	JOIN `oborot_si`.`name_instrument`  
		ON `measuring_instrument`.`id_name_instrument` = `name_instrument`.`id_name_instrument` 
	JOIN `oborot_si`.`department`  
		ON `measuring_instrument`.`id_department` = `department`.`id_department` 
	JOIN `oborot_si`.`schedule` 
		ON `measuring_instrument`.`id_measuring_instrument` = `schedule`.`id_measuring_instrument` 
	JOIN  `oborot_si`.`type_of_work` 
		ON `schedule`.`id_type_work` = `type_of_work`.`id_type_work` 
        WHERE `schedule`.`next_date`= nextDate  AND `type_of_work`.`type_of_work`= 'Поверка'
	GROUP BY (`schedule`.`id_schedule`) 
	ORDER BY `schedule`.`next_date`;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `GetScheduleVerificationArchiveByInventoryFactory` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`OborotSiAdmin`@`%` PROCEDURE `GetScheduleVerificationArchiveByInventoryFactory`(in inventory_num varchar(50), in factory_num varchar(50))
BEGIN
SELECT 
        `schedule`.`id_schedule`, 
		`name_instrument`.`name_instrument`, 
		`measuring_instrument`.`type`, 
		`measuring_instrument`.`factory_number`, 
		`measuring_instrument`.`inventory_number`, 
        `department`.`department`,
		`schedule`.`old_date`, 
		(Select CONCAT(`schedule`.`frequency`, ' мес.')) AS 'frequency', 
		`oborot_si`.`GetVenueNameByID`(`schedule`.`old_venue`) AS'old_ven', 
		`schedule`.`next_date`, 
        `oborot_si`.`GetVenueNameByID`(`schedule`.`new_venue`) AS'new_ven'
	FROM `oborot_si`.`measuring_instrument`  
	JOIN `oborot_si`.`name_instrument`  
		ON `measuring_instrument`.`id_name_instrument` = `name_instrument`.`id_name_instrument` 
	JOIN `oborot_si`.`department`  
		ON `measuring_instrument`.`id_department` = `department`.`id_department` 
	JOIN `oborot_si`.`schedule` 
		ON `measuring_instrument`.`id_measuring_instrument` = `schedule`.`id_measuring_instrument` 
	JOIN  `oborot_si`.`type_of_work` 
		ON `schedule`.`id_type_work` = `type_of_work`.`id_type_work` 
	WHERE `measuring_instrument`.`inventory_number` LIKE CONCAT ('%',inventory_num,'%' )
		AND `measuring_instrument`.`factory_number`  LIKE CONCAT ('%',factory_num,'%' )
		AND `type_of_work`.`type_of_work`= 'Поверка'
	GROUP BY (`schedule`.`id_schedule`) 
	ORDER BY `schedule`.`next_date`;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `GetScheduleVerificationByData` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`OborotSiAdmin`@`%` PROCEDURE `GetScheduleVerificationByData`(in nextDate date)
BEGIN
SELECT 		
		`schedule`.`id_schedule`, 
		`name_instrument`.`name_instrument`, 
		`measuring_instrument`.`type`, 
		`measuring_instrument`.`factory_number`, 
		`measuring_instrument`.`inventory_number`, 
        `department`.`department`,
		`schedule`.`old_date`, 
		(Select CONCAT(`schedule`.`frequency`, ' мес.')) AS 'frequency', 
		`oborot_si`.`GetVenueNameByID`(`schedule`.`old_venue`) AS'old_ven', 
		`schedule`.`next_date`, 
        `oborot_si`.`GetVenueNameByID`(`schedule`.`new_venue`) AS'new_ven'
	FROM `oborot_si`.`measuring_instrument`  
	JOIN `oborot_si`.`name_instrument`  
		ON `measuring_instrument`.`id_name_instrument` = `name_instrument`.`id_name_instrument` 
	JOIN `oborot_si`.`department`  
		ON `measuring_instrument`.`id_department` = `department`.`id_department` 
	JOIN `oborot_si`.`schedule` 
		ON `measuring_instrument`.`id_measuring_instrument` = `schedule`.`id_measuring_instrument` 
	JOIN  `oborot_si`.`type_of_work` 
		ON `schedule`.`id_type_work` = `type_of_work`.`id_type_work` 
	WHERE `schedule`.`next_date`>= nextDate AND `type_of_work`.`type_of_work`= 'Поверка'
	GROUP BY (`schedule`.`id_schedule`) 
	ORDER BY `schedule`.`next_date`;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `GetScheduleVerificationByNextDataFilter` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`OborotSiAdmin`@`%` PROCEDURE `GetScheduleVerificationByNextDataFilter`(in nextDate date)
BEGIN
SELECT 
		`schedule`.`id_schedule`, 
		`name_instrument`.`name_instrument`, 
		`measuring_instrument`.`type`, 
		`measuring_instrument`.`factory_number`, 
		`measuring_instrument`.`inventory_number`, 
        `department`.`department`,
		`schedule`.`old_date`, 
		(Select CONCAT(`schedule`.`frequency`, ' мес.')) AS 'frequency', 
		`oborot_si`.`GetVenueNameByID`(`schedule`.`old_venue`) AS'old_ven', 
		`schedule`.`next_date`, 
        `oborot_si`.`GetVenueNameByID`(`schedule`.`new_venue`) AS'new_ven'
	FROM `oborot_si`.`measuring_instrument`  
	JOIN `oborot_si`.`name_instrument`  
		ON `measuring_instrument`.`id_name_instrument` = `name_instrument`.`id_name_instrument` 
	JOIN `oborot_si`.`department`  
		ON `measuring_instrument`.`id_department` = `department`.`id_department` 
	JOIN `oborot_si`.`schedule` 
		ON `measuring_instrument`.`id_measuring_instrument` = `schedule`.`id_measuring_instrument` 
	JOIN  `oborot_si`.`type_of_work` 
		ON `schedule`.`id_type_work` = `type_of_work`.`id_type_work` 
	WHERE `schedule`.`next_date`= nextDate  AND `type_of_work`.`type_of_work`= 'Поверка'
	GROUP BY (`schedule`.`id_schedule`) 
	ORDER BY `schedule`.`next_date`;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `GetScheduleVerificationDataByInventoryFactoryNumbers` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`OborotSiAdmin`@`%` PROCEDURE `GetScheduleVerificationDataByInventoryFactoryNumbers`(in nextDate date, in inventory_num varchar(50), in factory_num varchar(50))
BEGIN
SELECT 
		`schedule`.`id_schedule`, 
		`name_instrument`.`name_instrument`, 
		`measuring_instrument`.`type`, 
		`measuring_instrument`.`factory_number`, 
		`measuring_instrument`.`inventory_number`, 
        `department`.`department`,
		`schedule`.`old_date`, 
		(Select CONCAT(`schedule`.`frequency`, ' мес.')) AS 'frequency', 
		`oborot_si`.`GetVenueNameByID`(`schedule`.`old_venue`) AS'old_ven', 
		`schedule`.`next_date`, 
        `oborot_si`.`GetVenueNameByID`(`schedule`.`new_venue`) AS'new_ven'
	FROM `oborot_si`.`measuring_instrument`  
	JOIN `oborot_si`.`name_instrument`  
		ON `measuring_instrument`.`id_name_instrument` = `name_instrument`.`id_name_instrument` 
	JOIN `oborot_si`.`department`  
		ON `measuring_instrument`.`id_department` = `department`.`id_department` 
	JOIN `oborot_si`.`schedule` 
		ON `measuring_instrument`.`id_measuring_instrument` = `schedule`.`id_measuring_instrument` 
	JOIN  `oborot_si`.`type_of_work` 
		ON `schedule`.`id_type_work` = `type_of_work`.`id_type_work` 
	WHERE `schedule`.`next_date`>= nextDate AND `measuring_instrument`.`inventory_number` LIKE CONCAT ('%',inventory_num,'%' )
AND `measuring_instrument`.`factory_number`  LIKE CONCAT ('%',factory_num,'%' ) AND `type_of_work`.`type_of_work`= 'Поверка'
	GROUP BY (`schedule`.`id_schedule`) 
	ORDER BY `schedule`.`next_date`;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `UPDATE_SI_CARD` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`%` PROCEDURE `UPDATE_SI_CARD`()
BEGIN 
IF (NOT EXISTS(SELECT * 
FROM `information_schema`.`tables` 
WHERE `table_schema` = DATABASE()
AND `table_name` = 'si_card')) 
THEN 
SIGNAL SQLSTATE '45001'
SET MESSAGE_TEXT = 'The `si_card` table is missing.', 
MYSQL_ERRNO = 1001; 
END IF;
UPDATE `si_card`  
SET opisanie = 'Средство измерения (эталон)'
WHERE `etalon` = 1; 
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2023-05-15 18:42:13
