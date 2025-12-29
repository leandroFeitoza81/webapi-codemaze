CREATE DATABASE IF NOT EXISTS AccountOwnerDb
  CHARACTER SET utf8mb4
  COLLATE utf8mb4_unicode_ci;

USE AccountOwnerDb;

-- Tabela Owner
CREATE TABLE Owner (
    OwnerId CHAR(36) NOT NULL,
    Name NVARCHAR(60) NOT NULL,
    DateOfBirth DATE NOT NULL,
    Address NVARCHAR(100),
    CONSTRAINT PK_Owner PRIMARY KEY (OwnerId)
);

-- Tabela Account
CREATE TABLE Account (
    AccountId CHAR(36) NOT NULL,
    DateOfCreated DATE NOT NULL,
    AccountType NVARCHAR(45) NOT NULL,
    OwnerId CHAR(36) NOT NULL,
    CONSTRAINT PK_Account PRIMARY KEY (AccountId),
    CONSTRAINT FK_Account_Owner
        FOREIGN KEY (OwnerId)
        REFERENCES Owner(OwnerId)
        ON DELETE CASCADE
        ON UPDATE CASCADE
);

-- Tabela Owner
CREATE TABLE Owner (
    OwnerId CHAR(36) NOT NULL,
    Name NVARCHAR(60) NOT NULL,
    DateOfBirth DATE NOT NULL,
    Address NVARCHAR(100),
    CONSTRAINT PK_Owner PRIMARY KEY (OwnerId)
);

-- Tabela Account
CREATE TABLE Account (
    AccountId CHAR(36) NOT NULL,
    DateOfCreated DATE NOT NULL,
    AccountType NVARCHAR(45) NOT NULL,
    OwnerId CHAR(36) NOT NULL,
    CONSTRAINT PK_Account PRIMARY KEY (AccountId),
    CONSTRAINT FK_Account_Owner
        FOREIGN KEY (OwnerId)
        REFERENCES Owner(OwnerId)
        ON DELETE CASCADE
        ON UPDATE CASCADE
);