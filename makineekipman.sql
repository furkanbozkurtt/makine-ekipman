-- phpMyAdmin SQL Dump
-- version 4.6.4
-- https://www.phpmyadmin.net/
--
-- Anamakine: 127.0.0.1
-- Üretim Zamanı: 05 Tem 2017, 16:10:06
-- Sunucu sürümü: 5.7.14
-- PHP Sürümü: 5.6.25

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Veritabanı: `makineekipman`
--

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `bicmemakinesi`
--

CREATE TABLE `bicmemakinesi` (
  `tip` varchar(25) NOT NULL,
  `agirlik` int(25) NOT NULL,
  `guc` int(25) NOT NULL,
  `uzunluk` int(25) NOT NULL,
  `genislik` int(25) NOT NULL,
  `yukseklik` int(25) NOT NULL,
  `bicaksayisi` int(25) NOT NULL,
  `markamodel` varchar(25) NOT NULL,
  `mensei` varchar(25) NOT NULL,
  `fiyat` int(25) NOT NULL,
  `firmaadi` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Tablo döküm verisi `bicmemakinesi`
--

INSERT INTO `bicmemakinesi` (`tip`, `agirlik`, `guc`, `uzunluk`, `genislik`, `yukseklik`, `bicaksayisi`, `markamodel`, `mensei`, `fiyat`, `firmaadi`) VALUES
('5', 2, 2, 2, 2, 2, 2, '2', '2', 2, '2'),
('asar', 5000, 350, 200, 400, 250, 4, 'falca', 'tr', 11111, 'sivas');

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `capamakinesi`
--

CREATE TABLE `capamakinesi` (
  `tip` varchar(25) NOT NULL,
  `agirlik` int(25) NOT NULL,
  `guc` int(25) NOT NULL,
  `uzunluk` int(25) NOT NULL,
  `genislik` int(25) NOT NULL,
  `yukseklik` int(25) NOT NULL,
  `ayaksayisi` int(25) NOT NULL,
  `markamodel` varchar(25) NOT NULL,
  `mensei` varchar(25) NOT NULL,
  `fiyat` int(25) NOT NULL,
  `firmaadi` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Tablo döküm verisi `capamakinesi`
--

INSERT INTO `capamakinesi` (`tip`, `agirlik`, `guc`, `uzunluk`, `genislik`, `yukseklik`, `ayaksayisi`, `markamodel`, `mensei`, `fiyat`, `firmaadi`) VALUES
('CAPA', 123, 123, 123, 123, 123, 34, 'SDLFKJ', 'TR', 234, '2');

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `dipkazan`
--

CREATE TABLE `dipkazan` (
  `tip` varchar(25) NOT NULL,
  `ayaksayisi` int(25) NOT NULL,
  `sasiyuksekligi` int(25) NOT NULL,
  `calismaderinligi` int(25) NOT NULL,
  `guc` int(25) NOT NULL,
  `uzunluk` int(25) NOT NULL,
  `genislik` int(25) NOT NULL,
  `yukseklik` int(25) NOT NULL,
  `markamodel` varchar(25) NOT NULL,
  `mensei` varchar(25) NOT NULL,
  `fiyat` int(25) NOT NULL,
  `firmaadi` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `ekimmakinesi`
--

CREATE TABLE `ekimmakinesi` (
  `tip` varchar(25) NOT NULL,
  `agirlik` int(25) NOT NULL,
  `guc` int(25) NOT NULL,
  `ayaksayisi` int(25) NOT NULL,
  `isgenisligi` int(25) NOT NULL,
  `genislik` int(25) NOT NULL,
  `yukseklik` int(25) NOT NULL,
  `uzunluk` int(25) NOT NULL,
  `markamodel` varchar(25) NOT NULL,
  `mensei` varchar(25) NOT NULL,
  `fiyat` int(25) NOT NULL,
  `firmaadi` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `firma`
--

CREATE TABLE `firma` (
  `firmaadi` varchar(50) NOT NULL,
  `vergino` int(20) NOT NULL,
  `vergidairesi` varchar(25) NOT NULL,
  `ticarisicilno` int(25) NOT NULL,
  `telefon` int(25) NOT NULL,
  `adres` varchar(2000) NOT NULL,
  `faks` int(25) DEFAULT NULL,
  `eposta` varchar(50) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Tablo döküm verisi `firma`
--

INSERT INTO `firma` (`firmaadi`, `vergino`, `vergidairesi`, `ticarisicilno`, `telefon`, `adres`, `faks`, `eposta`) VALUES
('2', 2, '2', 2, 2, '2', 2, '2'),
('asdf', 234234, 'jhgkjg', 5165, 651651, 'sd', 651, '61'),
('sivas', 585858, 'sivasvergi', 5812358, 22222222, 'sivasmahalles,', 22222222, 'asdcas@gmail.com');

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `goble`
--

CREATE TABLE `goble` (
  `tip` varchar(25) NOT NULL,
  `agirlik` int(25) NOT NULL,
  `disksayisi` int(25) NOT NULL,
  `guc` int(25) NOT NULL,
  `uzunluk` int(25) NOT NULL,
  `genislik` int(25) NOT NULL,
  `yukseklik` int(25) NOT NULL,
  `isgenisligi` int(25) NOT NULL,
  `markamodel` varchar(25) NOT NULL,
  `mensei` varchar(25) NOT NULL,
  `fiyat` int(25) NOT NULL,
  `firmaadi` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `gubreserpmemakinesi`
--

CREATE TABLE `gubreserpmemakinesi` (
  `tip` varchar(25) NOT NULL,
  `agirlik` int(25) NOT NULL,
  `guc` int(25) NOT NULL,
  `isgenisligi` int(25) NOT NULL,
  `genislik` int(25) NOT NULL,
  `uzunluk` int(25) NOT NULL,
  `yukseklik` int(25) NOT NULL,
  `kapasite` int(25) NOT NULL,
  `markamodel` varchar(25) NOT NULL,
  `mensei` varchar(25) NOT NULL,
  `fiyat` int(25) NOT NULL,
  `firmaadi` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `ilaclamamakinesi`
--

CREATE TABLE `ilaclamamakinesi` (
  `tip` varchar(25) NOT NULL,
  `guc` int(25) NOT NULL,
  `kapasite` int(25) NOT NULL,
  `debi` int(25) DEFAULT NULL,
  `markamodel` varchar(25) NOT NULL,
  `mensei` varchar(25) NOT NULL,
  `fiyat` int(25) NOT NULL,
  `firmaadi` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `kultuvator`
--

CREATE TABLE `kultuvator` (
  `tip` varchar(25) NOT NULL,
  `agirlik` int(25) NOT NULL,
  `guc` int(25) NOT NULL,
  `isgenisligi` int(25) NOT NULL,
  `ayaksayisi` int(25) NOT NULL,
  `genislik` int(25) NOT NULL,
  `yukseklik` int(25) NOT NULL,
  `uzunluk` int(25) NOT NULL,
  `markamodel` varchar(25) NOT NULL,
  `mensei` varchar(25) NOT NULL,
  `fiyat` int(25) NOT NULL,
  `firmaadi` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `merdane`
--

CREATE TABLE `merdane` (
  `tip` varchar(25) NOT NULL,
  `agirlik` int(25) NOT NULL,
  `guc` int(25) NOT NULL,
  `isgenisligi` int(25) NOT NULL,
  `genislik` int(25) NOT NULL,
  `yukseklik` int(25) NOT NULL,
  `uzunluk` int(25) NOT NULL,
  `sira` int(25) NOT NULL,
  `cap` int(25) DEFAULT NULL,
  `markamodel` varchar(25) NOT NULL,
  `mensei` varchar(25) NOT NULL,
  `fiyat` int(25) NOT NULL,
  `firmaadi` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `pulluk`
--

CREATE TABLE `pulluk` (
  `tip` int(25) NOT NULL,
  `agirlik` int(25) NOT NULL,
  `guc` int(25) NOT NULL,
  `isgenisligi` int(25) NOT NULL,
  `ayaksayisi` int(25) NOT NULL,
  `govdearasi` int(25) NOT NULL,
  `uzunluk` int(25) DEFAULT NULL,
  `genislik` int(25) DEFAULT NULL,
  `yukseklik` int(25) DEFAULT NULL,
  `markamodel` varchar(25) NOT NULL,
  `mensei` varchar(25) NOT NULL,
  `fiyat` int(25) NOT NULL,
  `firmaadi` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `romork`
--

CREATE TABLE `romork` (
  `tip` varchar(25) NOT NULL,
  `kapasite` int(25) NOT NULL,
  `dingilsayisi` int(25) NOT NULL,
  `tekersayisi` int(25) NOT NULL,
  `uzunluk` int(25) NOT NULL,
  `genislik` int(25) NOT NULL,
  `yukseklik` int(25) NOT NULL,
  `lastikebatlari` varchar(25) NOT NULL,
  `markamodel` varchar(25) NOT NULL,
  `mensei` varchar(25) NOT NULL,
  `fiyat` int(25) NOT NULL,
  `firmaadi` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `rotovator`
--

CREATE TABLE `rotovator` (
  `tip` varchar(25) CHARACTER SET utf8mb4 NOT NULL,
  `agirlik` int(25) NOT NULL,
  `guc` int(25) NOT NULL,
  `isgenisligi` int(25) NOT NULL,
  `bicaksayisi` int(25) NOT NULL,
  `isderinligi` int(25) NOT NULL,
  `genislik` int(25) DEFAULT NULL,
  `yukseklik` int(25) DEFAULT NULL,
  `uzunluk` int(25) DEFAULT NULL,
  `markamodel` varchar(25) NOT NULL,
  `mensei` varchar(25) NOT NULL,
  `fiyat` int(25) NOT NULL,
  `firmaadi` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `tesviyekuregi`
--

CREATE TABLE `tesviyekuregi` (
  `tip` varchar(25) NOT NULL,
  `isgenisligi` int(25) NOT NULL,
  `sackalinligi` int(25) NOT NULL,
  `yonlendirme` int(25) NOT NULL,
  `uzunluk` int(25) NOT NULL,
  `genislik` int(25) NOT NULL,
  `yukseklik` int(25) NOT NULL,
  `agirlik` int(25) NOT NULL,
  `guc` int(25) DEFAULT NULL,
  `markamodel` varchar(25) NOT NULL,
  `mensei` varchar(25) NOT NULL,
  `fiyat` int(25) NOT NULL,
  `firmaadi` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `tirmik`
--

CREATE TABLE `tirmik` (
  `tip` varchar(25) NOT NULL,
  `agirlik` int(25) NOT NULL,
  `guc` int(25) NOT NULL,
  `genislik` int(25) NOT NULL,
  `uzunluk` int(25) NOT NULL,
  `yukseklik` int(25) NOT NULL,
  `isgenisligi` int(25) NOT NULL,
  `dissayisi` int(25) NOT NULL,
  `markamodel` varchar(25) NOT NULL,
  `mensei` varchar(25) NOT NULL,
  `fiyat` int(25) NOT NULL,
  `firmaadi` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `yuklemekepcesi`
--

CREATE TABLE `yuklemekepcesi` (
  `tip` varchar(25) NOT NULL,
  `isgenisligi` int(25) NOT NULL,
  `uzunluk` int(25) NOT NULL,
  `yukseklik` int(25) NOT NULL,
  `agirlik` int(25) NOT NULL,
  `markamodel` varchar(25) NOT NULL,
  `mensei` varchar(25) NOT NULL,
  `fiyat` int(25) NOT NULL,
  `firmaadi` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dökümü yapılmış tablolar için indeksler
--

--
-- Tablo için indeksler `bicmemakinesi`
--
ALTER TABLE `bicmemakinesi`
  ADD KEY `firmaadi` (`firmaadi`);

--
-- Tablo için indeksler `capamakinesi`
--
ALTER TABLE `capamakinesi`
  ADD KEY `firmaadi` (`firmaadi`);

--
-- Tablo için indeksler `dipkazan`
--
ALTER TABLE `dipkazan`
  ADD KEY `firmaadi` (`firmaadi`);

--
-- Tablo için indeksler `ekimmakinesi`
--
ALTER TABLE `ekimmakinesi`
  ADD KEY `firmaadi` (`firmaadi`);

--
-- Tablo için indeksler `firma`
--
ALTER TABLE `firma`
  ADD PRIMARY KEY (`firmaadi`);

--
-- Tablo için indeksler `goble`
--
ALTER TABLE `goble`
  ADD KEY `firmaadi` (`firmaadi`);

--
-- Tablo için indeksler `gubreserpmemakinesi`
--
ALTER TABLE `gubreserpmemakinesi`
  ADD KEY `firmaadi` (`firmaadi`);

--
-- Tablo için indeksler `ilaclamamakinesi`
--
ALTER TABLE `ilaclamamakinesi`
  ADD KEY `firmaadi` (`firmaadi`);

--
-- Tablo için indeksler `kultuvator`
--
ALTER TABLE `kultuvator`
  ADD KEY `firmaadi` (`firmaadi`);

--
-- Tablo için indeksler `merdane`
--
ALTER TABLE `merdane`
  ADD KEY `firmaadi` (`firmaadi`);

--
-- Tablo için indeksler `pulluk`
--
ALTER TABLE `pulluk`
  ADD KEY `firmaadi` (`firmaadi`);

--
-- Tablo için indeksler `romork`
--
ALTER TABLE `romork`
  ADD KEY `firmaadi` (`firmaadi`);

--
-- Tablo için indeksler `rotovator`
--
ALTER TABLE `rotovator`
  ADD KEY `firmaadi` (`firmaadi`);

--
-- Tablo için indeksler `tesviyekuregi`
--
ALTER TABLE `tesviyekuregi`
  ADD KEY `firmaadi` (`firmaadi`);

--
-- Tablo için indeksler `tirmik`
--
ALTER TABLE `tirmik`
  ADD KEY `firmaadi` (`firmaadi`);

--
-- Tablo için indeksler `yuklemekepcesi`
--
ALTER TABLE `yuklemekepcesi`
  ADD KEY `firmaadi` (`firmaadi`);

--
-- Dökümü yapılmış tablolar için kısıtlamalar
--

--
-- Tablo kısıtlamaları `bicmemakinesi`
--
ALTER TABLE `bicmemakinesi`
  ADD CONSTRAINT `bicmemakinesi_ibfk_1` FOREIGN KEY (`firmaadi`) REFERENCES `firma` (`firmaadi`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Tablo kısıtlamaları `capamakinesi`
--
ALTER TABLE `capamakinesi`
  ADD CONSTRAINT `capamakinesi_ibfk_1` FOREIGN KEY (`firmaadi`) REFERENCES `firma` (`firmaadi`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Tablo kısıtlamaları `dipkazan`
--
ALTER TABLE `dipkazan`
  ADD CONSTRAINT `dipkazan_ibfk_1` FOREIGN KEY (`firmaadi`) REFERENCES `firma` (`firmaadi`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Tablo kısıtlamaları `ekimmakinesi`
--
ALTER TABLE `ekimmakinesi`
  ADD CONSTRAINT `ekimmakinesi_ibfk_1` FOREIGN KEY (`firmaadi`) REFERENCES `firma` (`firmaadi`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Tablo kısıtlamaları `goble`
--
ALTER TABLE `goble`
  ADD CONSTRAINT `goble_ibfk_1` FOREIGN KEY (`firmaadi`) REFERENCES `firma` (`firmaadi`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Tablo kısıtlamaları `gubreserpmemakinesi`
--
ALTER TABLE `gubreserpmemakinesi`
  ADD CONSTRAINT `gubreserpmemakinesi_ibfk_1` FOREIGN KEY (`firmaadi`) REFERENCES `firma` (`firmaadi`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Tablo kısıtlamaları `ilaclamamakinesi`
--
ALTER TABLE `ilaclamamakinesi`
  ADD CONSTRAINT `ilaclamamakinesi_ibfk_1` FOREIGN KEY (`firmaadi`) REFERENCES `firma` (`firmaadi`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Tablo kısıtlamaları `kultuvator`
--
ALTER TABLE `kultuvator`
  ADD CONSTRAINT `kultuvator_ibfk_1` FOREIGN KEY (`firmaadi`) REFERENCES `firma` (`firmaadi`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Tablo kısıtlamaları `merdane`
--
ALTER TABLE `merdane`
  ADD CONSTRAINT `merdane_ibfk_1` FOREIGN KEY (`firmaadi`) REFERENCES `firma` (`firmaadi`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Tablo kısıtlamaları `pulluk`
--
ALTER TABLE `pulluk`
  ADD CONSTRAINT `pulluk_ibfk_1` FOREIGN KEY (`firmaadi`) REFERENCES `firma` (`firmaadi`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Tablo kısıtlamaları `romork`
--
ALTER TABLE `romork`
  ADD CONSTRAINT `romork_ibfk_1` FOREIGN KEY (`firmaadi`) REFERENCES `firma` (`firmaadi`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Tablo kısıtlamaları `rotovator`
--
ALTER TABLE `rotovator`
  ADD CONSTRAINT `rotovator_ibfk_1` FOREIGN KEY (`firmaadi`) REFERENCES `firma` (`firmaadi`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Tablo kısıtlamaları `tesviyekuregi`
--
ALTER TABLE `tesviyekuregi`
  ADD CONSTRAINT `tesviyekuregi_ibfk_1` FOREIGN KEY (`firmaadi`) REFERENCES `firma` (`firmaadi`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Tablo kısıtlamaları `tirmik`
--
ALTER TABLE `tirmik`
  ADD CONSTRAINT `tirmik_ibfk_1` FOREIGN KEY (`firmaadi`) REFERENCES `firma` (`firmaadi`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Tablo kısıtlamaları `yuklemekepcesi`
--
ALTER TABLE `yuklemekepcesi`
  ADD CONSTRAINT `yuklemekepcesi_ibfk_1` FOREIGN KEY (`firmaadi`) REFERENCES `firma` (`firmaadi`) ON DELETE CASCADE ON UPDATE CASCADE;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
