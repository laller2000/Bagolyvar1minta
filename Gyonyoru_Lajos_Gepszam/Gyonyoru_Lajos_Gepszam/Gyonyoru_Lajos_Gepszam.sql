-- MariaDB dump 10.19  Distrib 10.4.18-MariaDB, for Win64 (AMD64)
--
-- Host: localhost    Database: bagolyvar
-- ------------------------------------------------------
-- Server version	10.4.18-MariaDB

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;
Drop DATABASE If EXISTS bagolyvar;
CREATE DATABASE if EXISTS bagolyvar
		DEFAULT CHARACTER SET utf8
		COLLATE utf8_hungarian.ci;

USE bagolyvar;
--
-- Table structure for table `kolcsonzes`
--

DROP TABLE IF EXISTS `kolcsonzes`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `kolcsonzes` (
  `konyvID` varchar(4) DEFAULT NULL,
  `kolcsonzoID` int(2) DEFAULT NULL,
  `kivetelDatum` varchar(10) DEFAULT NULL,
  `peldany` int(1) DEFAULT NULL,
  KEY `fk_konyv` (`konyvID`),
  KEY `fk_kolcsonzo` (`kolcsonzoID`),
  CONSTRAINT `fk_kolcsonzo` FOREIGN KEY (`kolcsonzoID`) REFERENCES `kolcsonzo` (`ID`),
  CONSTRAINT `fk_konyv` FOREIGN KEY (`konyvID`) REFERENCES `konyvek` (`Kod`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `kolcsonzes`
--

LOCK TABLES `kolcsonzes` WRITE;
/*!40000 ALTER TABLE `kolcsonzes` DISABLE KEYS */;
INSERT INTO `kolcsonzes` VALUES ('J40',45,'2020-03-25',1),('M03B',5,'2020-03-31',3),('T64',37,'2020-03-28',2),('M21',10,'2020-04-09',1),('B32',4,'2020-03-22',3),('K33B',53,'2020-04-19',2),('J43',9,'2020-03-21',1),('T46',58,'2020-03-15',1),('A43B',43,'2020-04-02',3),('A32B',24,'2020-03-29',2),('UK04',15,'2020-03-22',1),('J26',62,'2020-03-26',2),('J17',34,'2020-04-19',3),('S18B',37,'2020-03-13',2),('UK03',16,'2020-03-23',2),('K03B',26,'2020-04-17',1),('D07',1,'2020-03-24',3),('T58',2,'2020-04-19',2),('T65',55,'2020-03-19',3),('A86',14,'2020-04-03',2),('A11B',26,'2020-04-17',2),('S24B',36,'2020-04-03',1),('M28',14,'2020-04-08',1),('J17',34,'2020-04-01',3),('A413',64,'2020-03-14',3),('T46',35,'2020-04-01',1),('UK09',61,'2020-04-10',2),('M09',44,'2020-03-29',2),('M16',20,'2020-04-19',1),('T45',56,'2020-03-24',2),('J38',39,'2020-03-29',2),('J41',57,'2020-04-06',3),('S48',7,'2020-03-30',1),('T13C',65,'2020-03-18',1),('M26',36,'2020-03-16',3),('S48',41,'2020-04-18',1),('T45',49,'2020-03-17',1),('T40',45,'2020-03-17',2),('UK06',54,'2020-04-19',1),('J32',17,'2020-04-05',2),('UK01',33,'2020-03-23',3),('A86',59,'2020-04-12',1),('M31',58,'2020-03-19',3),('A78B',30,'2020-04-16',2),('T45',63,'2020-03-21',1),('M19',6,'2020-03-24',3),('T31',43,'2020-04-02',3),('D07',8,'2020-04-03',2),('M29',59,'2020-04-15',3),('T58',58,'2020-04-02',3),('J48',50,'2020-04-17',1),('T31',30,'2020-03-15',1),('T58',26,'2020-03-31',1),('T51',6,'2020-03-13',2),('A86',27,'2020-04-08',1),('T14C',13,'2020-04-12',2),('T23A',53,'2020-04-12',2),('M09',29,'2020-03-26',3),('J17',2,'2020-04-09',1),('M21',60,'2020-04-14',1),('M28',21,'2020-03-25',1),('T64',42,'2020-04-09',2),('S18B',10,'2020-04-19',3),('T11C',47,'2020-04-07',1),('J41',61,'2020-03-14',2),('A11B',43,'2020-04-02',3),('M10',8,'2020-03-30',2),('M29',3,'2020-04-09',3),('T65',2,'2020-03-25',2),('J29',48,'2020-04-15',1),('K03B',34,'2020-03-24',3),('J32',7,'2020-04-03',2),('J37',51,'2020-04-05',1),('T22',30,'2020-03-25',3),('J37',8,'2020-04-03',3),('S18B',57,'2020-03-26',1),('J41',22,'2020-04-04',1),('M09',32,'2020-03-26',3),('T43',57,'2020-03-19',1),('J34',21,'2020-04-06',3),('J48',27,'2020-04-04',1),('T59',52,'2020-03-30',3),('J44',63,'2020-03-14',2),('K33B',24,'2020-03-28',2),('T50',66,'2020-03-27',3),('T13C',22,'2020-04-08',3),('A52B',1,'2020-03-26',3),('K40',46,'2020-03-22',1),('M26',16,'2020-03-20',2),('J15',18,'2020-04-02',3),('J41',50,'2020-04-14',3),('T37',9,'2020-03-18',1),('B32',32,'2020-03-17',1),('M32',52,'2020-04-11',1),('A52B',58,'2020-04-08',2),('J16',52,'2020-03-16',2),('J48',7,'2020-04-09',1),('M03B',35,'2020-04-02',1),('UK09',48,'2020-04-10',3),('T50',63,'2020-03-14',1),('M18',26,'2020-04-08',3),('T61',32,'2020-03-16',3),('A11B',4,'2020-04-11',3),('M16',54,'2020-04-07',2),('K05B',46,'2020-04-04',2),('J36',54,'2020-04-14',1),('J38',59,'2020-03-20',2),('T41B',6,'2020-03-13',3),('M23',17,'2020-03-31',1),('K40',56,'2020-04-09',1),('M09',16,'2020-04-04',3),('T51',20,'2020-03-25',3),('K07J',23,'2020-03-29',2),('UK03',19,'2020-03-14',3),('T22',11,'2020-04-01',1),('T58',55,'2020-03-15',2),('T38',59,'2020-03-31',1),('UK06',25,'2020-04-06',3),('T55',4,'2020-04-01',3),('M31',61,'2020-04-06',3),('T49',13,'2020-03-31',1),('UK04',62,'2020-04-14',3),('T11C',61,'2020-04-03',2),('M03B',16,'2020-03-21',3),('T22',48,'2020-03-20',3),('T58',53,'2020-04-03',1),('T23A',28,'2020-04-02',3),('T22',3,'2020-03-17',2),('T49',12,'2020-04-10',3),('T36',12,'2020-04-10',3),('M21',33,'2020-03-31',3),('J45',60,'2020-03-19',3),('T61',20,'2020-04-11',3),('K40',17,'2020-04-08',3),('T31',22,'2020-03-19',2),('T34',54,'2020-03-29',1),('UK09',62,'2020-03-30',1),('J46',33,'2020-04-14',2),('J17',60,'2020-04-18',1),('T64',12,'2020-04-05',3),('M28',1,'2020-03-28',3),('J44',59,'2020-03-16',2),('UK02',53,'2020-03-17',3),('T45',50,'2020-04-08',3),('M32',66,'2020-03-19',1),('J27',7,'2020-03-14',3),('T36',44,'2020-04-11',3),('A611',10,'2020-03-26',1),('T39',49,'2020-04-03',1),('J45',30,'2020-03-22',3),('T37',48,'2020-04-13',3),('UK03',6,'2020-04-13',1),('UK02',7,'2020-03-31',1),('UK02',11,'2020-04-14',2),('K41',40,'2020-04-09',3),('S48',21,'2020-04-07',1),('UK01',51,'2020-03-27',1),('A611',36,'2020-03-15',2),('T05E',44,'2020-03-15',2),('UK07',66,'2020-03-27',3),('J16',44,'2020-03-27',2),('K05B',45,'2020-03-24',2),('A611',10,'2020-03-30',2),('J30',52,'2020-04-17',3),('A51B',12,'2020-03-15',1),('A11B',29,'2020-03-18',3),('J31',11,'2020-03-22',1),('K03B',12,'2020-04-16',2),('J30',64,'2020-04-11',2),('J48',37,'2020-03-18',3),('T46',20,'2020-04-18',1),('M12',15,'2020-03-14',2),('K03B',35,'2020-03-18',1),('A51B',34,'2020-04-13',2),('M32',27,'2020-03-14',1),('S47',39,'2020-04-15',3),('M26',66,'2020-04-16',3),('T64',38,'2020-04-09',3),('T37',9,'2020-04-03',1),('M29',11,'2020-04-16',1),('J36',29,'2020-03-15',1),('J44',23,'2020-04-02',3),('T25B',42,'2020-04-03',3),('M19',31,'2020-03-26',3),('UK02',53,'2020-04-13',2),('T41B',7,'2020-04-05',3),('A43B',39,'2020-04-03',1),('A52B',10,'2020-03-29',1),('T64',58,'2020-03-14',3),('T64',41,'2020-04-16',1),('T67',20,'2020-04-02',1),('S48',20,'2020-04-09',3),('T55',30,'2020-04-19',1),('B32',1,'2020-03-14',2),('S48',57,'2020-04-06',2),('D07',14,'2020-04-02',1),('T58',49,'2020-04-04',2),('J15',1,'2020-04-13',1),('S18B',41,'2020-03-20',1),('T51',25,'2020-03-20',3),('K03B',19,'2020-03-14',2),('T61',58,'2020-03-30',2),('M16',12,'2020-04-17',1),('M10',40,'2020-03-16',3),('K33B',54,'2020-04-01',1),('M28',16,'2020-04-16',2),('S47',38,'2020-04-16',3),('T36',21,'2020-04-02',3),('T58',3,'2020-03-25',2),('A11B',10,'2021-3-17',1),('A11B',1,'2021-03-17',4),('A32B',2,'2021-03-17',4),('A43B',2,'2021-03-17',3);
/*!40000 ALTER TABLE `kolcsonzes` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `kolcsonzo`
--

DROP TABLE IF EXISTS `kolcsonzo`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `kolcsonzo` (
  `ID` int(2) NOT NULL AUTO_INCREMENT,
  `nev` varchar(14) DEFAULT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB AUTO_INCREMENT=68 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `kolcsonzo`
--

LOCK TABLES `kolcsonzo` WRITE;
/*!40000 ALTER TABLE `kolcsonzo` DISABLE KEYS */;
INSERT INTO `kolcsonzo` VALUES (1,'Patta N??ra'),(2,'P??r Zolt??n'),(3,'Pop Simon'),(4,'Remek Elek'),(5,'Beviz Elek'),(6,'Szalmon Ella'),(7,'Techno Kolos'),(8,'Trab Antal'),(9,'Ultra Viola'),(10,'Am Erika'),(11,'Bac Ilus'),(12,'Citad Ella'),(13,'Dil Emma'),(14,'Eszte Lenke'),(15,'Feles Elek'),(16,'Git ??ron'),(17,'Har M??nika'),(18,'Heu R??ka'),(19,'H?? Jen??'),(20,'Kukor Ica'),(21,'Kala P??l'),(22,'K??l?? N??ra'),(23,'K??rm ??d??n'),(24,'K??r Ede'),(25,'Major Anna'),(26,'Meg Gy??z??'),(27,'Vak Cina'),(28,'Veg Eta'),(29,'Virra D??ra'),(30,'V??g B??la'),(31,'Wincs Eszter'),(32,'Kasza Blanka'),(33,'Kisp??l Inka'),(34,'Pof?? Zolt??n'),(35,'Tank Aranka'),(36,'Bekre P??l'),(37,'Mortad Ella'),(38,'Trap Pista'),(39,'Fejet Lenke'),(40,'F?? Zolt??n'),(41,'Minden ??ron'),(42,'Csin Csilla'),(43,'Mor Zsolt'),(44,'Rabsz Olga'),(45,'Patk??m ??gnes'),(46,'Locsol??k Anna'),(47,'Riz Ott??'),(48,'Nemer Eszti'),(49,'Ne P??l'),(50,'Ka P??l'),(51,'Elektrom ??gnes'),(52,'H?? Z??ra'),(53,'Raj Z??ra'),(54,'Dia D??ra'),(55,'T??k ??d??n'),(56,'Ria D??ra'),(57,'Lev Elek'),(58,'Hot Elek'),(59,'Te??sk Anna'),(60,'B??rmi ??ron'),(61,'Metall Ica'),(62,'Bor Vir??g'),(63,'Ny??l K??lm??n'),(64,'Ipsz Ilonka'),(65,'Mikorka K??lm??n'),(66,'Szikla Szil??rd'),(67,'Eb??d Elek');
/*!40000 ALTER TABLE `kolcsonzo` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `konyvek`
--

DROP TABLE IF EXISTS `konyvek`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `konyvek` (
  `Kod` varchar(4) NOT NULL,
  `Szerzo` varchar(35) DEFAULT NULL,
  `C??m` varchar(74) DEFAULT NULL,
  `KiadasEve` int(4) DEFAULT NULL,
  `Ar` int(4) DEFAULT NULL,
  `ISBN` varchar(17) DEFAULT NULL,
  PRIMARY KEY (`Kod`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `konyvek`
--

LOCK TABLES `konyvek` WRITE;
/*!40000 ALTER TABLE `konyvek` DISABLE KEYS */;
INSERT INTO `konyvek` VALUES ('A11B','W. Steven Brown','13 V??gzetes hiba, amit menedzserek elk??vetnek',2000,2950,'963 907 171 4'),('A32B','Ries-Trout','A marketing 22 vast??rv??nye',2008,1450,'978 963 973 025 0'),('A413','Bob Burg','Meggy??z??s mesterfokon',2010,1950,'978 615 503 004 8'),('A43B','Milo O. Frank','Hogyan ??rvelj??nk r??viden ??s hat??sosan',2014,2950,'963 907 158 7'),('A51B','Fisher-Ury','T??rgyal??s neh??z emberekkel',2000,2950,'963 907 152 8'),('A52B','Fisher-Ury-Patton','A sikeres t??rgyal??s alapjai',2000,2950,'963 907 159 5'),('A53B','Herb Cohen','B??rmit meg tud t??rgyalni',2000,2950,'963 907 166 8'),('A611','Frank Bettger','Benjamin Franklin sikertitka',2008,1850,'978 963 673 064 9'),('A612','Og Mandino','Jobban ??lni',2010,1650,'978 963 973 915'),('A61B','Frank Bettger','Az ??zletk??t??s iskol??ja',2007,1850,'978 963 973 026 7'),('A71','Hyrum Smith','A sikeres id??gazd??lkod??s ??s ??letvitel 10 term??szett??rv??nye',1998,2950,'963 907 140 4'),('A711','Leo Babauta','A kevesebb ereje',2012,2490,'978-615-503-022-2'),('A78B','David Allen','Int??zz el mindent',2010,2950,'978-615-503-001-7'),('A86','Lee Wallek','Maffia menedzser',1998,2950,'963 919 733 5'),('B32','Gonzalez-Molina Coffman','Ezt az utat k??vesd!',2005,2950,'963 944 742 0'),('B33','Smith-Rutigliano','Fedezze fel ??zletk??t??i er??ss??geit',2004,2950,'963 944 747 1'),('D07','Guy Kawasaki','Szab??lyok forradalm??roknak',2010,2450,'978 963 973 079 3'),('J15','John C. Maxwell','Etika 101 - Amit mindenkinek tudnia kell',2008,1450,'978 963 944 790 5'),('J16','John C. Maxwell','A vezet?? 21 n??lk??l??zhetetlen tulajdons??ga',2008,1650,'978 963 944 795 0'),('J17','John C. Maxwell','25 m??dszer az emberek megnyer??s??re',2008,2950,'978 963 973 000 7'),('J20','Brian Tracy','Rep??l??si Terv',2009,1450,'978 963 973 070 0'),('J26','John C. Maxwell','Holnapra vezet?? lehetsz',2012,2450,'978 963 973 010 6'),('J27','John C. Maxwell','Nevelj vezet??ket!',2012,2450,'978 963 503 005 5'),('J29','Brian Tracy - Christina Tracy Stein','Cs??kold meg a b??k??t!',2013,2450,'978-615-5030-32-1'),('J30','Brian Tracy - Ron Arden','Vonzer?? - hogyan nyerj??nk meg b??rkit, b??rmilyen helyzetben?',2013,1950,'978-615-5030-33-8'),('J31','Brian Tracy','??nbizalom - hogyan lehetsz ellen??llhatatlan?',2013,2950,'978-615-5030-34-5'),('J32','Brian Tracy','Teremtsd ??jra az ??leted!',2013,2950,'978-615-5030-35-2'),('J34','Brian Tracy','A siker egy utaz??s',2014,2950,'978-615-5030-45-1'),('J35','Mark Sanborn','A Fred-faktor',2014,2450,'978-615-5030-48-2'),('J36','Brian Tracy','C??lok!',2014,2950,'978-615-5030-46-8'),('J37','Brian Tracy','Milli??kat ??r?? szok??sok',2014,2950,'978-615-5030-47-5'),('J38','Joachim de Posada','K??sleltetett jutalom - Ne edd meg r??gt??n a pillecukrot',2014,2450,'978-615-5030-50-5'),('J40','Jim Stovall','A v??gs?? aj??nd??k',2015,2450,'978 615 503 023 9'),('J41','John C. Maxwell','Siker 101',2015,1650,'978 615 503 055 0'),('J42','Brian Tracy - Christina Tracy Stein','SikerPont',2016,2450,'978-615-5030-57-4'),('J43','Brian Tracy','Telital??lat ??? a tiszt??nl??t??s ereje',2016,2450,'978-615-5030-60-4'),('J44','Max Gunther','Hogyan legy??l szerencs??s?',2016,2950,'978-615-5030-17-8'),('J45','Andy Andrews','Sorsford??t?? tal??lkoz??sok',2016,2950,'978-615-5030-58-1'),('J46','Les Giblin','Kapcsolat kalauz',2016,2950,'978 615 503 044 4'),('J48','Charlie Jones','Az ??let fantasztikus',2016,2450,'978-615-5030-63-5'),('K03B','Napoleon Hill','A siker titka: Pozit??v lelki be??ll??totts??g',2008,1950,'978 963 973 043 4'),('K05B','Ron Holland','Besz??lj ??s gazdagodj!',2010,1950,'978-615-503-000-0'),('K07J','Napoleon Hill','Gondolkozz ??s gazdagodj! Jubileumi kiad??s',2016,2950,'978-615-5030-75-8'),('K10B','Maxwell Maltz','Pszichokibernetika',2010,2950,'978 963 973 051 9'),('K17A','Denis Waitley','A kiv??l??s??g t??z titka',2011,2490,'978 963 973 002 1'),('K33B','Cavett Robert','Mi mozgatja az embereket?',2010,1650,'978 963 973 052 6'),('K40','Napoleon Hill','Mesterkulcs a gazdags??ghoz',2016,2950,'978 615 503 068 0'),('K41','Napoleon Hill','Gazdagodj lelki b??k??vel',2017,3450,'978 615 503 077 2'),('M03B','Robert Butwin','??t??k??pes network marketing',2007,1650,'978 963 973 036 6'),('M04','Tom Schreiter','Big Al mindent elmond a h??l??zat??p??t??sr??l ??s a szponzor??l??sr??l',1998,1450,'963 907 173 0'),('M08','Tom Schreiter','Big Al - szuper jel??ltkutat??s',2005,1450,'963 944 774 9'),('M09','Don Failla - Nancy Failla','Gyakran feltett k??rd??sek ??s vil??gos v??laszok a Network Marketingr??l',2006,1450,'963 944 787 0'),('M10','John Fuhrman','K??rem a k??vetkez??t!',2006,1650,'963 944 797 8'),('M11','Don Failla','A 45 m??sodperces prezent??ci??, amely megv??ltoztatja az ??letedet',2006,2450,'963 944 785 4'),('M12','Edward Ludbrook','??tt??r??s! Mi??rt vir??gzik ISM??T a Network Marketing?',2008,1650,'978 963 944 796 7'),('M16','Edward Ludbrook','10 Alapelv - Hogyan tehetsz szert tart??s H??L??ZATI j??vedelemre?',2008,1650,'978 963 973 047 2'),('M18','Brian Klemmer','??nt??rk??p',2008,1450,'978 963 973 056 4'),('M19','Edward Ludbrook','H??l??zat??p??t?? Mester',2008,1450,'978 963 973 046 5'),('M20','Rich DeVos','10 kulcsmondat pozit??v embereknek',2009,1850,'978 963 973 071'),('M21','David Cottrell','H??tf?? reggeli d??nt??sek - 12 l??p??s a kiv??l??s??gig',2009,1650,'978 963 973 065 6'),('M23','John Milton Fogg','A vil??g legnagyobb h??l??zatszervez??je',2009,1650,'978 963 973 072 4'),('M24','Bryan Thayer','Kapcsolati h??l??',2009,1450,'978 963 973 084 7'),('M26','John Milton Fogg','Besz??lget??sek a vil??g legnagyobb h??l??zatszervez??j??vel',2010,1950,'978-963-973-098-4'),('M27','Chris Taylor','Network Marketing SIKERrecept',2010,1950,'978 615 503 003 1'),('M28','Steve Shapiro','Figyelj oda - a sikered??rt!',2010,1200,'978 963 944 769 1'),('M29','Randy Gage','Hogyan ??p??ts??nk MLM p??nzgy??rat',2011,2490,'978 963 973 068 7'),('M31','Lupkin - Carter','Network marketing a Facebookon',2017,3450,'978 615 5030 796'),('M32','Devora Zack','Networking',2017,3450,'978 615 5030 80 2'),('S18B','Canfield-Hansen','Er??leves a l??leknek 3. - ??jabb 101 er??t ad?? ??s l??lekemel?? t??rt??net',2010,2850,'978 963 973 097 7'),('S24B','Keith Ellis','Csodal??mpa',2002,2950,'963 944 702 1'),('S47','William H. Danforth','Fogadjunk! Meg tudod csin??lni...',2009,1200,'978 963 973 067 0'),('S48','Canfield - Hansen - Hyman','Er??leves a h??l??zat??p??t?? l??leknek',2012,2950,'978 615 503 015 4'),('T05E','William Oncken, III.','Monkey Business - Vezet??i id??gazd??lkod??s',2000,1950,'963 919 775 0'),('T11C','Brian Tracy','Maxim??lis teljes??tm??ny (2013)',2013,3950,'978 615 503 038 3'),('T13C','Robert T. Kiyosaki','Gazdag papa, szeg??ny papa (2013)',2013,2950,'978 615 503 030 7'),('T14C','Robert T. Kiyosaki','CASHFLOW n??gysz??g (2013)',2013,3450,'978-615-5030-31-4'),('T22','David Owen','PapaBank',2004,2950,'963 944 739 0'),('T23A','Stephen R. Covey','A kiemelked??en eredm??nyes emberek 7 szok??sa',2014,3950,'978-615-5030-43-7'),('T25B','Dale Carnegie & Associates','??zletk??t?? kalauz',2010,2950,'978 615 503 002 4'),('T28','Robert T. Kiyosaki','Ki vette el a p??nzem?',2006,2950,'963 944 764 1'),('T31','T. Harv Eker','A milliomos elme titkai',2006,1950,'963 944 781 1'),('T34','Trump - Kiyosaki','Mi??rt szeretn??nk, hogy GAZDAGODJ',2008,2950,'978 963 973 042 7'),('T36','David J. Schwartz','Gondolj mer??szet',2008,2950,'978 963 973 054 0'),('T37','David J. Schwartz','Sikergondolkod??s',2008,1950,'978 963 973 055 7'),('T38','Stephen R. Covey','8. szok??s',2010,3450,'978 963 973 057 1'),('T39','Keith Cameron Smith','10 szok??s ami gazdagg?? tesz',2011,1490,'978 963 973 022 9'),('T40','Klontz-Klontz-Kahler','Gazdags??gra hangolva',2010,1950,'978 963 973 089 2'),('T41B','Dale Carnegie','Hogyan szerezz??nk bar??tokat ??s befoly??soljuk az embereket - Sikerkalauz 1.',2008,2950,'978 963 973 080 9'),('T42B','Dale Carnegie','Hogyan fejezz??k be az agg??d??st ??s kezdj??nk el ??lni - Sikerkalauz 2.',2008,3450,'978 963 973 077 9'),('T43','Jim Rohn','A j??l??t ??s boldogs??g 7 strat??gi??ja',2008,1650,'978 963 973 063 2'),('T45','Kim Kiyosaki','Gazdag n??',2010,2450,'978 963 973 078 6'),('T46','Napoleon Hill Foundation','H??rom l??bnyira az aranyt??l',2010,2490,'978 963 973 086 1'),('T49','David J. Schwartz','??jrakezd??s',2012,2450,'978 615 503 018 5'),('T50','Noah St. John','A siker titkos k??dja',2010,2490,'978-963-973-014-4'),('T51','Mark Fisher','A lusta milliomos',2012,1950,'978-615-503-024-6'),('T55','Trump - Kiyosaki','Midaszi ??rint??s',2012,2950,'978 615 503 021 5'),('T58','Stephen R. Covey','Nyer?? Csapat',2012,1450,'978 615 503 010 9'),('T59','Randy Gage','Kock??ztass - ha biztons??got keresel!',2013,2490,'978 615 503 036 9'),('T61','Greg McKeown','L??nyegl??t??s',2015,3950,'978 615 503 053 6'),('T62','Robert T. Kiyosaki','A 21. sz??zad ??zlete',2015,2950,'978 615 503 055 0'),('T64','Robert T. Kiyosaki','8 lecke a harct??ri vezet??sr??l - v??llalkoz??knak',2016,2950,'978-615-5030-61-1'),('T65','Robert T. Kiyosaki','??zleti iskola II.',2016,2950,'978-615-5030-62-8'),('T67','Brian Tracy','El??g a dum??b??l, csak csin??ld!',2016,2450,'978-615-5030-66-6'),('UK01','Brian Tracy','Az ??zleti siker 100 vast??rv??nye',2016,4950,'978-615-5030-69-7'),('UK02','Timothy Ferriss','4 ??r??s munkah??t - b??v??tett',2016,4950,'978-615-5030-67-3'),('UK03','Mark Joyner','Ellen??llhatatlan aj??nlat',2016,3950,'978-615-5030-70-3'),('UK04','Larry King','Hogyan besz??lj legy??g??z??en',2016,3950,'978-615-5030-65-9'),('UK05','Kory Kogon','5 d??nt??s',2016,4950,'978-615-5030-73-4'),('UK06','Brian Tracy','Csak okosan!',2016,3950,'978-615-5030-71-0'),('UK07','Fried - Hansson','REWORK - Profit ??jrat??ltve',2016,4950,'978 615 503 076 5'),('UK08','Fried - Hansson','REMOTE - T??vmunka ??jrat??ltve',2017,4950,'978 615 503 078 9'),('UK09','Brian Tracy','Tartsd k??zben az id??t, tartsd k??zben az ??leted',2017,3450,'978-615-5030-81-9');
/*!40000 ALTER TABLE `konyvek` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2021-03-18 15:35:15
