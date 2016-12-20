drop table if exists ProduseSoftware;
drop table if exists valoriNiveluri;
drop table if exists denumiriNiveluri;
drop table if exists Structuri;
drop table if exists Utilizatori;
drop table if exists Functii;

create table Functii(
codFunctie numeric(6) constraint pkidFunctie primary key,
denumireFunctie varchar(50),
nivelFunctie numeric (2),
activareFunctie boolean
);

create table Utilizatori(
idUser numeric(6) constraint pkiduser primary key,
numeUser varchar(50),
functieUser numeric(6) constraint fkfunctieUser references Functii(codFunctie),
numefunctieUser varchar(50) constraint fknumefunctieUser references Functii(denumireFunctie),
activareUser boolean
);

create table ProduseSoftware (
codProdus numeric(6) constraint pkCodProdus primary key,
denumireProdus varchar(50),
dataAdaugareProd date,
descriereProdus varchar(100),
produsActiv boolean
);

create table Structuri (
codStructura numeric(6) constraint pkCodStructura primary key,
denumireStructura varchar(50),
dataAdaugareStruct date
);

create table denumiriNiveluri (
codStrucDenumiriNiv numeric(6) constraint fkcodStrucDenumiriNiv references Structuri(codStructura),
nrNiveluri numeric(2) NULL,
nivelA varchar(50) NULL,
nivelB varchar(50) NULL,
nivelC varchar(50) NULL,
nivelD varchar(50) NULL,
nivelE varchar(50) NULL,
nivelF varchar(50) NULL,
nivelG varchar(50) NULL,
nivelH varchar(50) NULL,
nivelI varchar(50) NULL,
nivelJ varchar(50) NULL,
nivelK varchar(50) NULL,
nivelL varchar(50) NULL,
nivelM varchar(50) NULL,
nivelN varchar(50) NULL,
nivelO varchar(50) NULL
);

create table valoriNiveluri (
codStrucValoriNiv numeric(6) constraint fkcodStrucValoriNiv references Structuri(codStructura),
nrNiveluri numeric(2) NULL,
nivelA varchar(50) NULL,
nivelB varchar(50) NULL,
nivelC varchar(50) NULL,
nivelD varchar(50) NULL,
nivelE varchar(50) NULL,
nivelF varchar(50) NULL,
nivelG varchar(50) NULL,
nivelH varchar(50) NULL,
nivelI varchar(50) NULL,
nivelJ varchar(50) NULL,
nivelK varchar(50) NULL,
nivelL varchar(50) NULL,
nivelM varchar(50) NULL,
nivelN varchar(50) NULL,
nivelO varchar(50) NULL
);








