-- phpMyAdmin SQL Dump
-- version 5.1.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Oct 17, 2021 at 08:21 PM
-- Server version: 10.4.21-MariaDB
-- PHP Version: 7.4.24

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `movie`
--

-- --------------------------------------------------------

--
-- Table structure for table `aspnetroleclaims`
--

CREATE TABLE `aspnetroleclaims` (
  `Id` int(11) NOT NULL,
  `RoleId` varchar(255) NOT NULL,
  `ClaimType` longtext DEFAULT NULL,
  `ClaimValue` longtext DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `aspnetroles`
--

CREATE TABLE `aspnetroles` (
  `Id` varchar(255) NOT NULL,
  `Name` varchar(256) DEFAULT NULL,
  `NormalizedName` varchar(256) DEFAULT NULL,
  `ConcurrencyStamp` longtext DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `aspnetuserclaims`
--

CREATE TABLE `aspnetuserclaims` (
  `Id` int(11) NOT NULL,
  `UserId` varchar(255) NOT NULL,
  `ClaimType` longtext DEFAULT NULL,
  `ClaimValue` longtext DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `aspnetuserlogins`
--

CREATE TABLE `aspnetuserlogins` (
  `LoginProvider` varchar(128) NOT NULL,
  `ProviderKey` varchar(128) NOT NULL,
  `ProviderDisplayName` longtext DEFAULT NULL,
  `UserId` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `aspnetuserroles`
--

CREATE TABLE `aspnetuserroles` (
  `UserId` varchar(255) NOT NULL,
  `RoleId` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `aspnetusers`
--

CREATE TABLE `aspnetusers` (
  `Id` varchar(255) NOT NULL,
  `UserName` varchar(256) DEFAULT NULL,
  `NormalizedUserName` varchar(256) DEFAULT NULL,
  `Email` varchar(256) DEFAULT NULL,
  `NormalizedEmail` varchar(256) DEFAULT NULL,
  `EmailConfirmed` tinyint(1) NOT NULL,
  `PasswordHash` longtext DEFAULT NULL,
  `SecurityStamp` longtext DEFAULT NULL,
  `ConcurrencyStamp` longtext DEFAULT NULL,
  `PhoneNumber` longtext DEFAULT NULL,
  `PhoneNumberConfirmed` tinyint(1) NOT NULL,
  `TwoFactorEnabled` tinyint(1) NOT NULL,
  `LockoutEnd` datetime(6) DEFAULT NULL,
  `LockoutEnabled` tinyint(1) NOT NULL,
  `AccessFailedCount` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `aspnetusers`
--

INSERT INTO `aspnetusers` (`Id`, `UserName`, `NormalizedUserName`, `Email`, `NormalizedEmail`, `EmailConfirmed`, `PasswordHash`, `SecurityStamp`, `ConcurrencyStamp`, `PhoneNumber`, `PhoneNumberConfirmed`, `TwoFactorEnabled`, `LockoutEnd`, `LockoutEnabled`, `AccessFailedCount`) VALUES
('67fcab37-8024-41df-9d5f-bbe8254cd04a', 'yusril', 'YUSRIL', 'yusril@gmail.com', 'YUSRIL@GMAIL.COM', 0, 'AQAAAAEAACcQAAAAEAtNpkzUSQdlbLNGxIjwxpub/p9fQ9Y3hUcGPmCZtVeXo9zEDx8EvTJwu4Di90DNcw==', 'PHL22CYUXL3SUOC4RWOVJS74S4JP3ZKL', 'c5b69d6d-4208-4acd-93f2-3ba1bb6933b6', NULL, 0, 0, NULL, 1, 0),
('a6078e52-56dd-4f47-bf82-c795232543ec', 'john', 'JOHN', 'john@gmail.com', 'JOHN@GMAIL.COM', 0, 'AQAAAAEAACcQAAAAEFdTIMxpKrY71yvXYsD4LiobJw38fIe1/kW8gi/v60afjA1d4rPalPQmOdWBVQ4diQ==', 'DK25J4DAF76YISOC3RWXMVXZXRKWCLTW', 'f18e0f06-a1fa-45b6-a349-2bc7f7c7f873', NULL, 0, 0, NULL, 1, 0),
('ab66514f-3530-431f-88ad-960db9969499', 'rakha', 'RAKHA', 'rakha@gmail.com', 'RAKHA@GMAIL.COM', 0, 'AQAAAAEAACcQAAAAENjLC2Y9OwLQRjOvmnGVr1jG/z2vzdPv1IvUHkBxbQDEq5Fng4Oj1dCJ3fXOnqTd4w==', 'ABP7OJEPSTFPLKMXVRTEF4T6V4GWVRCC', '197b61c4-2078-48bd-999b-4b88f2779e73', NULL, 0, 0, NULL, 1, 0),
('bc769fe2-ec01-4a71-bbdb-0d5c979fdbfe', 'gebby', 'GEBBY', 'gebby@gmail.com', 'GEBBY@GMAIL.COM', 0, 'AQAAAAEAACcQAAAAEFU44nJnrXa2ZtNeuyL75wf2jk/McFggxs4TH+yQLZGDypBdcQI+gc7ffYSZNxmyHQ==', 'RC5YWYOFECKUXIQZU6ZRRNOCCYPTIIUH', 'cd361f6a-a7ef-4dab-a9e1-046c63504700', NULL, 0, 0, NULL, 1, 0),
('e1a1aa6b-25ce-40d6-8d2b-a99fa5a6e802', 'yudha', 'YUDHA', 'yudha@yudha.com', 'YUDHA@YUDHA.COM', 0, 'AQAAAAEAACcQAAAAEIon620++JXOEXNYu7E1xRD56NbPOMmaumqgpu823ObySmaRwbt9qohc9DnmyIyEuQ==', '4XJTFCULCWBJZAURH3KBTJNGUKRK75DS', '673141c8-8f33-4d4f-82b0-75ed453d5d09', NULL, 0, 0, NULL, 1, 0),
('fc89958f-41da-4c91-a1a7-0d3a6894916d', 'ypran', 'YPRAN', 'ypran@gmail.com', 'YPRAN@GMAIL.COM', 0, 'AQAAAAEAACcQAAAAEBF67odQKGO+W4Y7ixeIk6cO9qd29VWIUtPMTsn4ON5nwFrjac2MU93FHzZJ5VjRxQ==', 'OD25URLFHMAQQXCMLARWNCAU6C4DP5D6', '70a57054-5197-431a-9e90-14809bd37717', NULL, 0, 0, NULL, 1, 0);

-- --------------------------------------------------------

--
-- Table structure for table `aspnetusertokens`
--

CREATE TABLE `aspnetusertokens` (
  `UserId` varchar(255) NOT NULL,
  `LoginProvider` varchar(128) NOT NULL,
  `Name` varchar(128) NOT NULL,
  `Value` longtext DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `movies`
--

CREATE TABLE `movies` (
  `id` int(11) NOT NULL,
  `title` longtext DEFAULT NULL,
  `overview` longtext DEFAULT NULL,
  `adult` tinyint(1) NOT NULL,
  `voteAverage` double NOT NULL,
  `voteCount` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `movies`
--

INSERT INTO `movies` (`id`, `title`, `overview`, `adult`, `voteAverage`, `voteCount`) VALUES
(1, 'The Addams Family 2', 'The Addams get tangled up in more wacky adventures and find themselves involved in hilarious run-ins with all sorts of unsuspecting characters.', 1, 7.6, 293),
(2, 'The Many Saints of Newark', 'Young Anthony Soprano is growing up in one of the most tumultuous eras in Newark, N.J., history, becoming a man just as rival gangsters start to rise up and challenge the all-powerful DiMeo crime family. Caught up in the changing times is the uncle he idolizes, Dickie Moltisanti, whose influence over his nephew will help shape the impressionable teenager into the all-powerful mob boss, Tony Soprano.', 0, 6.7, 118),
(3, 'Halloween Kills', 'Minutes after Laurie Strode, her daughter Karen and granddaughter Allyson left masked monster Michael Myers caged and burning in Laurie\'s basement, Laurie is rushed to the hospital with life-threatening injuries, believing she finally killed her lifelong tormentor. But when Michael manages to free himself from Laurie\'s trap, his ritual bloodbath resumes. As Laurie fights her pain and prepares to defend herself against him, she inspires all of Haddonfield to rise up against their unstoppable monster. The Strode women join a group of other survivors of Michael\'s first rampage who decide to take matters into their own hands, forming a vigilante mob that sets out to hunt Michael down, once and for all.', 0, 7.7, 211);

-- --------------------------------------------------------

--
-- Table structure for table `refreshtokens`
--

CREATE TABLE `refreshtokens` (
  `Id` int(11) NOT NULL,
  `UserId` varchar(255) DEFAULT NULL,
  `Token` longtext DEFAULT NULL,
  `JwtId` longtext DEFAULT NULL,
  `IsUsed` tinyint(1) NOT NULL,
  `IsRevorked` tinyint(1) NOT NULL,
  `AddedDate` datetime(6) NOT NULL,
  `ExpiryDate` datetime(6) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `refreshtokens`
--

INSERT INTO `refreshtokens` (`Id`, `UserId`, `Token`, `JwtId`, `IsUsed`, `IsRevorked`, `AddedDate`, `ExpiryDate`) VALUES
(1, '67fcab37-8024-41df-9d5f-bbe8254cd04a', 'PGHP5YNGBNW43TNRM5UV41D2TJ0BXFK46ROb1c98778-552b-4c09-9f2c-6f4727d02eda', '8962c459-12e8-4bbd-a152-397e4e0d17e5', 0, 0, '2021-10-17 16:24:39.729694', '2022-04-17 16:24:39.729755'),
(3, '67fcab37-8024-41df-9d5f-bbe8254cd04a', 'BLRL6SKVPU6J9Y1PYJND0ULPERHNHUA7G26f2974d8b-d05b-479c-b208-03098ed8af15', '784614ec-db94-410b-956f-b88a3d9d9c92', 0, 0, '2021-10-17 16:33:23.021174', '2022-04-17 16:33:23.021226'),
(4, '67fcab37-8024-41df-9d5f-bbe8254cd04a', '10WFJMVKADDDXKTLXQW9Q399T4K86P9OUDGa91a6c11-9be8-4c62-be5a-d708ec611166', 'a14f7294-afff-428d-943d-f7febe61fba7', 0, 0, '2021-10-17 16:40:05.400781', '2022-04-17 16:40:05.400839'),
(5, '67fcab37-8024-41df-9d5f-bbe8254cd04a', 'NLGDKERVNDKNYZPDNLJRBFD6HE3FBG4CZUDf30c7e96-acc6-485f-9685-35937ee462f9', '4058a867-a1fb-495b-8b23-fa65381f5a5d', 0, 0, '2021-10-17 16:40:50.509201', '2022-04-17 16:40:50.509201'),
(6, '67fcab37-8024-41df-9d5f-bbe8254cd04a', 'ZOVXQIA16GZS0DPCE4QW4O4IOXWIVHC0U314ba9df64-d355-4f93-9b35-26e34d5d6742', '116f5805-4977-4298-9903-e4a4b2e6fd53', 0, 0, '2021-10-17 16:42:06.245340', '2022-04-17 16:42:06.245341'),
(7, '67fcab37-8024-41df-9d5f-bbe8254cd04a', 'VSLKML8B9CW46A9SXAQEG6Z9J067MG6U0512dfef8bf-eb6d-411d-a153-59e2c81619d2', 'ce351387-1892-4ff3-b3ce-4b11006e71be', 0, 0, '2021-10-17 16:44:39.255615', '2022-04-17 16:44:39.255667'),
(8, '67fcab37-8024-41df-9d5f-bbe8254cd04a', 'LUYRYZDZJ95F12K3IWWU8IAH4JR54AGOU0Ycdb7e603-0209-4286-ac7a-ec8c0893dd9f', '4e103b58-b0df-4283-84cd-0204dd5120ca', 0, 0, '2021-10-17 16:51:59.637424', '2022-04-17 16:51:59.637527'),
(9, '67fcab37-8024-41df-9d5f-bbe8254cd04a', 'K6WH5L7QT6SIFEYYZXT6HHOVC4BSSY8RP5Ud22abd91-033e-4cc6-95ed-16f84bd29e12', '151bc376-141d-4dcc-9bb7-daf80e6d1ab2', 0, 0, '2021-10-17 17:05:27.552420', '2022-04-17 17:05:27.552480'),
(10, '67fcab37-8024-41df-9d5f-bbe8254cd04a', 'P2EWU2A2RPVLLD4GEL52EYQ0T4052KGY48Q54862d74-09d2-4437-a2d8-b97c6fc73585', 'c12891f8-f310-4b6d-b814-c857cc1b8936', 0, 0, '2021-10-17 17:18:40.644842', '2022-04-17 17:18:40.644924'),
(12, '67fcab37-8024-41df-9d5f-bbe8254cd04a', 'R58F3CXQ39ANL8A64CI0LAITURII9EN79VE1a38c5cf-710e-4bbb-b2c4-80e7e0c63520', '63349985-ae75-433c-9638-4aef1338c33a', 0, 0, '2021-10-17 17:22:37.725684', '2022-04-17 17:22:37.725735'),
(13, '67fcab37-8024-41df-9d5f-bbe8254cd04a', 'FD5D6R2A3MJXOTZ252YR1DMQ5BHG866A1CU7a1036fa-eb67-4fbb-812c-1cbb8f2aef43', '70a2911f-bdb4-45fa-a836-df3c0a3465ea', 0, 0, '2021-10-17 17:23:39.445643', '2022-04-17 17:23:39.445722'),
(14, '67fcab37-8024-41df-9d5f-bbe8254cd04a', '7FJ5WHQ535PPWK1U612EVJ8YWSD5FQ6GPU2b6714fa4-fb22-427c-baf8-566d0637005d', 'd7649005-9abe-41cb-832b-bd9d108dc67b', 0, 0, '2021-10-17 17:24:30.484454', '2022-04-17 17:24:30.484454'),
(15, '67fcab37-8024-41df-9d5f-bbe8254cd04a', '8MV97UH8GYH6QMZUBC8UCYN2NTBPGYB5VRFc337753b-d324-4aa8-9be8-88da94cb7dca', 'bbb53fa5-e18c-4217-928b-130f396a7743', 0, 0, '2021-10-17 17:24:34.107025', '2022-04-17 17:24:34.107026'),
(16, 'ab66514f-3530-431f-88ad-960db9969499', '3L6FPRMXVXW0QCXF49UGQ0A1NA2V3WIXO7X6b1e6d2f-121e-47c1-92de-a96862b39aed', 'e7a2a7a2-ee94-474d-8fe1-0f79f286437f', 0, 0, '2021-10-17 17:29:17.615232', '2022-04-17 17:29:17.615233'),
(17, 'a6078e52-56dd-4f47-bf82-c795232543ec', '8Q8RIVDR2DLSAPIAKPVWP6H6LGKLOKCXJKLa726e8f1-a450-413e-90a2-efb3ba900a56', 'cc23c1e4-3a57-4c10-b793-71299e75a248', 0, 0, '2021-10-17 17:31:38.301623', '2022-04-17 17:31:38.301624'),
(18, 'a6078e52-56dd-4f47-bf82-c795232543ec', 'NFHEIOCSK9Q1VL3DJ55B18332BUZFZAZH114c75a8dd-ce1e-41d3-9ba1-2597ebd3821a', '8f55eae2-bdfd-4ea8-86e6-5a41be5fc9fc', 0, 0, '2021-10-17 17:32:40.352528', '2022-04-17 17:32:40.352530'),
(19, 'a6078e52-56dd-4f47-bf82-c795232543ec', 'TLRMATHV7JN3YRQ5U9AGBTTY7DET12YAPXGf79a8063-bf0e-4a12-b908-5b0ec29851a4', '2a2ebbe6-5a86-4e87-83f4-b607dc0cb0c0', 0, 0, '2021-10-17 17:38:59.991264', '2021-10-17 17:39:29.991324'),
(20, 'a6078e52-56dd-4f47-bf82-c795232543ec', 'MR0BWT0JC4QOB1KZBJY069HIZCX343N14837f243d19-9d57-4757-bcc8-da3c657aa93f', 'a8693bc8-3382-400b-8259-35399171276c', 0, 0, '2021-10-17 17:48:02.058912', '2021-10-17 17:48:32.058913'),
(21, 'a6078e52-56dd-4f47-bf82-c795232543ec', 'TJD9WUAZ5O91G6FKOYA1V7EA60RXYBILIRJ017bf426-3fd3-4292-9452-10683c521412', 'c11f7288-eda9-4ef8-9f86-f9dd4ba594b7', 0, 0, '2021-10-17 17:49:53.751323', '2021-10-17 17:50:23.751324'),
(22, 'a6078e52-56dd-4f47-bf82-c795232543ec', '43QRP12TJJ0L0J8A2J2K8QXU0DZ967Q2F2472e0f4c1-839a-4b34-bc5c-3053cacd29c8', '492308f8-c98b-4ad9-96cb-66be5f394db3', 0, 0, '2021-10-17 17:50:51.185131', '2021-10-17 17:51:21.185133'),
(23, 'a6078e52-56dd-4f47-bf82-c795232543ec', 'FM60BBSQI06KYIMG5YDBHJRL3KWPTRSVEJO6e3bedec-5c00-4633-97ab-ec70dcf32c32', 'd3fdace1-0367-488a-8fbd-ea7bedd7971a', 0, 0, '2021-10-17 17:53:20.769712', '2021-10-17 17:53:50.769714'),
(24, 'a6078e52-56dd-4f47-bf82-c795232543ec', 'AIIS9KBYKO6ZFWKNSOMFR5Q217P206F0XE4a122dbf0-1ab0-46cb-b53b-4b303a194559', 'd8658be1-58bc-43bf-83af-2d3bd73a1744', 0, 0, '2021-10-17 17:55:57.531740', '2021-10-17 17:56:27.531741'),
(25, 'a6078e52-56dd-4f47-bf82-c795232543ec', 'NGE09KRBV5C204NU16IH0DPG4QKD9TEY5NM647248f2-f480-4f6d-90ed-17e7c34e3c84', '3c6b6bc0-8372-480f-ba42-405bdbbef9bc', 0, 0, '2021-10-17 17:57:58.234781', '2021-10-17 17:58:28.234785'),
(26, 'a6078e52-56dd-4f47-bf82-c795232543ec', '92KU4JK8K0L7Q6VLIER0DS497TUTQLBQ14I7cf6c7a3-8df5-4068-b4a5-329d1485ae88', '380dfc16-4f72-42d4-bac4-5afc503c68dd', 0, 0, '2021-10-17 17:59:03.820945', '2021-10-17 17:59:33.820945');

-- --------------------------------------------------------

--
-- Table structure for table `__efmigrationshistory`
--

CREATE TABLE `__efmigrationshistory` (
  `MigrationId` varchar(150) NOT NULL,
  `ProductVersion` varchar(32) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `__efmigrationshistory`
--

INSERT INTO `__efmigrationshistory` (`MigrationId`, `ProductVersion`) VALUES
('20211017151251_Init Migrations', '5.0.11'),
('20211017154932_Addig authentication to our Api', '5.0.11'),
('20211017161940_Added refresh tokens table', '5.0.11');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `aspnetroleclaims`
--
ALTER TABLE `aspnetroleclaims`
  ADD PRIMARY KEY (`Id`),
  ADD KEY `IX_AspNetRoleClaims_RoleId` (`RoleId`);

--
-- Indexes for table `aspnetroles`
--
ALTER TABLE `aspnetroles`
  ADD PRIMARY KEY (`Id`),
  ADD UNIQUE KEY `RoleNameIndex` (`NormalizedName`);

--
-- Indexes for table `aspnetuserclaims`
--
ALTER TABLE `aspnetuserclaims`
  ADD PRIMARY KEY (`Id`),
  ADD KEY `IX_AspNetUserClaims_UserId` (`UserId`);

--
-- Indexes for table `aspnetuserlogins`
--
ALTER TABLE `aspnetuserlogins`
  ADD PRIMARY KEY (`LoginProvider`,`ProviderKey`),
  ADD KEY `IX_AspNetUserLogins_UserId` (`UserId`);

--
-- Indexes for table `aspnetuserroles`
--
ALTER TABLE `aspnetuserroles`
  ADD PRIMARY KEY (`UserId`,`RoleId`),
  ADD KEY `IX_AspNetUserRoles_RoleId` (`RoleId`);

--
-- Indexes for table `aspnetusers`
--
ALTER TABLE `aspnetusers`
  ADD PRIMARY KEY (`Id`),
  ADD UNIQUE KEY `UserNameIndex` (`NormalizedUserName`),
  ADD KEY `EmailIndex` (`NormalizedEmail`);

--
-- Indexes for table `aspnetusertokens`
--
ALTER TABLE `aspnetusertokens`
  ADD PRIMARY KEY (`UserId`,`LoginProvider`,`Name`);

--
-- Indexes for table `movies`
--
ALTER TABLE `movies`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `refreshtokens`
--
ALTER TABLE `refreshtokens`
  ADD PRIMARY KEY (`Id`),
  ADD KEY `IX_RefreshTokens_UserId` (`UserId`);

--
-- Indexes for table `__efmigrationshistory`
--
ALTER TABLE `__efmigrationshistory`
  ADD PRIMARY KEY (`MigrationId`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `aspnetroleclaims`
--
ALTER TABLE `aspnetroleclaims`
  MODIFY `Id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `aspnetuserclaims`
--
ALTER TABLE `aspnetuserclaims`
  MODIFY `Id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `movies`
--
ALTER TABLE `movies`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- AUTO_INCREMENT for table `refreshtokens`
--
ALTER TABLE `refreshtokens`
  MODIFY `Id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=27;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `aspnetroleclaims`
--
ALTER TABLE `aspnetroleclaims`
  ADD CONSTRAINT `FK_AspNetRoleClaims_AspNetRoles_RoleId` FOREIGN KEY (`RoleId`) REFERENCES `aspnetroles` (`Id`) ON DELETE CASCADE;

--
-- Constraints for table `aspnetuserclaims`
--
ALTER TABLE `aspnetuserclaims`
  ADD CONSTRAINT `FK_AspNetUserClaims_AspNetUsers_UserId` FOREIGN KEY (`UserId`) REFERENCES `aspnetusers` (`Id`) ON DELETE CASCADE;

--
-- Constraints for table `aspnetuserlogins`
--
ALTER TABLE `aspnetuserlogins`
  ADD CONSTRAINT `FK_AspNetUserLogins_AspNetUsers_UserId` FOREIGN KEY (`UserId`) REFERENCES `aspnetusers` (`Id`) ON DELETE CASCADE;

--
-- Constraints for table `aspnetuserroles`
--
ALTER TABLE `aspnetuserroles`
  ADD CONSTRAINT `FK_AspNetUserRoles_AspNetRoles_RoleId` FOREIGN KEY (`RoleId`) REFERENCES `aspnetroles` (`Id`) ON DELETE CASCADE,
  ADD CONSTRAINT `FK_AspNetUserRoles_AspNetUsers_UserId` FOREIGN KEY (`UserId`) REFERENCES `aspnetusers` (`Id`) ON DELETE CASCADE;

--
-- Constraints for table `aspnetusertokens`
--
ALTER TABLE `aspnetusertokens`
  ADD CONSTRAINT `FK_AspNetUserTokens_AspNetUsers_UserId` FOREIGN KEY (`UserId`) REFERENCES `aspnetusers` (`Id`) ON DELETE CASCADE;

--
-- Constraints for table `refreshtokens`
--
ALTER TABLE `refreshtokens`
  ADD CONSTRAINT `FK_RefreshTokens_AspNetUsers_UserId` FOREIGN KEY (`UserId`) REFERENCES `aspnetusers` (`Id`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
