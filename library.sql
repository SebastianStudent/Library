-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Czas generowania: 28 Maj 2023, 14:26
-- Wersja serwera: 10.4.27-MariaDB
-- Wersja PHP: 8.2.0

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Baza danych: `library`
--

-- --------------------------------------------------------

--
-- Struktura tabeli dla tabeli `books`
--

CREATE TABLE `books` (
  `Id_Book` int(11) NOT NULL,
  `Name` varchar(100) NOT NULL,
  `Last name` varchar(100) NOT NULL,
  `Title` varchar(100) NOT NULL,
  `Count` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Zrzut danych tabeli `books`
--

INSERT INTO `books` (`Id_Book`, `Name`, `Last name`, `Title`, `Count`) VALUES
(1, 'Henry', 'Haggard', 'She: A History of Adventure', 10),
(2, 'Lewis', 'Carroll', 'Alice s Adventures in Wonderland', 21),
(3, 'Clive', 'Staples', 'The Lion, The Witch, and the Wardrobe', 15),
(4, 'John', 'Tolkien', 'The Hobbit', 51),
(5, 'Agatha', 'Christie', 'And Then There Were None', 30),
(6, 'Joanne', 'Murray', 'Harry Potter and the Philosopher s Stone', 35),
(7, 'Antoine', 'Saint-Exupery', 'The Little Prince', 40),
(8, 'John', 'Tolkien', 'The Lord of the Rings', 48),
(9, 'Charles', 'Dickens', 'A Tale of Two Cities', 50),
(10, 'Miguel', 'Cervantes', 'Don Quixote', 55);

-- --------------------------------------------------------

--
-- Struktura tabeli dla tabeli `customer`
--

CREATE TABLE `customer` (
  `Id_customer` int(11) NOT NULL,
  `Name` varchar(100) NOT NULL,
  `Last name` varchar(100) NOT NULL,
  `Date of birth` varchar(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Zrzut danych tabeli `customer`
--

INSERT INTO `customer` (`Id_customer`, `Name`, `Last name`, `Date of birth`) VALUES
(1, 'Leon', 'Mercado', '14.01.2018'),
(2, 'Katelyn', 'Frazier', '13.06.2002'),
(3, 'Aisha', 'Levy', '26.10.1969'),
(4, 'Annika', 'Marks', '13.08.1982'),
(5, 'Jonas', 'Solis', '05.12.1961'),
(6, 'Kajus', 'Fuller', '21.03.2019'),
(7, 'Rocco', 'Berg', '31.12.1991'),
(8, 'Maximillian', 'Wilkerson', '22.09.1978'),
(9, 'Heath', 'Silva', '08.03.2009'),
(10, 'Jimmy', 'Chapman', '10.12.2003');

-- --------------------------------------------------------

--
-- Struktura tabeli dla tabeli `library`
--

CREATE TABLE `library` (
  `Id` int(11) NOT NULL,
  `Id_customer` int(11) NOT NULL,
  `Id_book` int(11) NOT NULL,
  `Count of borrow` int(11) NOT NULL,
  `Delivery date` varchar(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Zrzut danych tabeli `library`
--

INSERT INTO `library` (`Id`, `Id_customer`, `Id_book`, `Count of borrow`, `Delivery date`) VALUES
(1, 2, 8, 1, '26.05.2023'),
(3, 1, 2, 1, '27.05.2023'),
(4, 3, 3, 2, '27.05.2023'),
(5, 8, 9, 6, '03.06.2023'),
(6, 4, 8, 3, '08.06.2023'),
(7, 5, 5, 3, '27.05.2023'),
(8, 4, 8, 3, '08.06.2023'),
(10, 7, 5, 1, '26.05.2023'),
(11, 2, 2, 2, '27.05.2023');

--
-- Indeksy dla zrzutów tabel
--

--
-- Indeksy dla tabeli `books`
--
ALTER TABLE `books`
  ADD PRIMARY KEY (`Id_Book`);

--
-- Indeksy dla tabeli `customer`
--
ALTER TABLE `customer`
  ADD PRIMARY KEY (`Id_customer`);

--
-- Indeksy dla tabeli `library`
--
ALTER TABLE `library`
  ADD PRIMARY KEY (`Id`),
  ADD KEY `id_customer` (`Id_customer`,`Id_book`),
  ADD KEY `Id_book` (`Id_book`);

--
-- AUTO_INCREMENT dla zrzuconych tabel
--

--
-- AUTO_INCREMENT dla tabeli `books`
--
ALTER TABLE `books`
  MODIFY `Id_Book` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=12;

--
-- AUTO_INCREMENT dla tabeli `customer`
--
ALTER TABLE `customer`
  MODIFY `Id_customer` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=12;

--
-- AUTO_INCREMENT dla tabeli `library`
--
ALTER TABLE `library`
  MODIFY `Id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=13;

--
-- Ograniczenia dla zrzutów tabel
--

--
-- Ograniczenia dla tabeli `library`
--
ALTER TABLE `library`
  ADD CONSTRAINT `library_ibfk_1` FOREIGN KEY (`Id_book`) REFERENCES `books` (`Id_Book`),
  ADD CONSTRAINT `library_ibfk_2` FOREIGN KEY (`id_customer`) REFERENCES `customer` (`Id_customer`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
