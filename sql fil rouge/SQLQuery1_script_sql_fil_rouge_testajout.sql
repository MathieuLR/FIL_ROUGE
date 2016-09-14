use master
go
drop database fil_rouge
go
create database fil_rouge
go

use fil_rouge
go

CREATE TABLE RubriqueDuProduit(
	IdentifiantRubrique			    BIGint IDENTITY PRIMARY KEY,
    NomRubrique                     VARCHAR(150) ,
	Rubrique_principale				BIGINT NULL REFERENCES RubriqueDuProduit(IdentifiantRubrique)
)
go
create index NomRubrique on RubriqueDuProduit(NomRubrique)
go
CREATE TABLE Produit(
	IdentifiantProduit           BIGINT PRIMARY KEY not null,
	LibelleCourtDuProduit        VARCHAR (200),
	LibelleLongDuProduit         VARCHAR (500),
	PhotoDuProduit               VARCHAR (250),
	PrixDachatDuProduit          MONEY,
	ProduitActif                 bit,
	PrixHorsTaxe                 MONEY,
	TVA                          BIGINT,
	IdentifiantRubrique BIGINT REFERENCES RubriqueDuProduit(IdentifiantRubrique)
	
)

go
create index IdentifiantDuProduit on Produit(IdentifiantProduit)
go

CREATE TABLE Fournisseur(
	IdentifiantFournisseur   BIGINT PRIMARY KEY NOT NULL,
	Importateur              bit,
	NomDuFournisseur         VARCHAR (250),
	AdresseDuFournisseur     VARCHAR (500),
	VilleDuFournisseur       VARCHAR (250),
	CodePostalDuFournisseur  BIGINT,
	AdresseMailDuFournisseur VARCHAR (250),
	TelephoneDuFournisseur   BIGINT
)

go
create index IdentifiantDuFournisseur on Fournisseur(IdentifiantFournisseur)
go
CREATE TABLE Service_Commercial(
	IdentifiantServiceCommercial BIGINT PRIMARY KEY NOT NULL,
	NomDuCommercial              VARCHAR (250),
	PrenomDuCommercial           VARCHAR (250),
	AdresseDuCommercial          VARCHAR (400),
	VilleDuCommercial            VARCHAR (250),
	CodePostalDuCommercial       BIGINT,
	TelephoneDuCommercial        BIGINT,
	ClientParticulier            bit,
	AdresseMailDuCommercial      VARCHAR (250)
	
	
)

go
create index IdentifiantDuServiceCommercial on Service_Commercial(IdentifiantServiceCommercial)
go
CREATE TABLE Client(
	IdentifiantClient   BIGINT PRIMARY KEY NOT NULL,
	ReferenceDuClient   BIGINT,
	NomDuClient         VARCHAR (250),
	PrenomDuClient      VARCHAR (250),
	Coefficient         BIGINT,
	AdresseDuClient     VARCHAR (250),
	VilleDuClient       VARCHAR (250),
	CodePostalDuClient  BIGINT,
	AdresseMailDuClient VARCHAR (250),
	TelephoneDuClient   BIGINT,
	NumeroSiret         BIGINT,
	NomEnseigne         VARCHAR (250),
	ComplementAdresse   VARCHAR (250),
	IdentifiantServiceCommercial BIGINT REFERENCES Service_Commercial(IdentifiantServiceCommercial)

)

go
create index IdentifiantDuClient on Client(IdentifiantClient)
go
CREATE TABLE Facture(
	NumeroFacture       BIGINT PRIMARY KEY NOT NULL,
	ModePaiementFacture VARCHAR (250),
	DateDeFacture       DATETIME
	
)

go
create index NumeroDeLaFacture on Facture(NumeroFacture)
go
CREATE TABLE Commande(
	IdentifiantCommande     BIGINT PRIMARY KEY NOT NULL,
	NumeroDeCommande        BIGINT,
	DateDeCommande          DATETIME,
	AdresseDeLivraison      VARCHAR (250) NOT NULL,
	VilleDeLivraison        VARCHAR (250) NOT NULL,
	CodePostalDeLivraison   VARCHAR (250) NOT NULL,
	PrixTotalCommande       MONEY,
	AdresseDeFacturation    VARCHAR (250) NOT NULL,
	VilleDeFacturation      VARCHAR (250) NOT NULL,
	CodePostalDeFacturation BIGINT  NOT NULL,
	IdentifiantClient       BIGINT REFERENCES Client(IdentifiantClient),
	NumeroFacture           BIGINT REFERENCES Facture(NumeroFacture)

)

go
create index IdentifiantDeLaCommande on Commande(IdentifiantCommande)

go
CREATE TABLE Livraison(
	IdentifiantLieuDeLivraison BIGINT PRIMARY KEY NOT NULL,
	LivraisonPartielle        bit,
	DateDeLivraison           DATETIME null default null,
	NumeroDeLivraison         BIGINT,
	BonDeLivraison            VARCHAR (250),
	IdentifiantCommande       BIGINT REFERENCES Commande(IdentifiantCommande)
	
)

go
create index IdentifiantDuLieuDeLivraison on Livraison(IdentifiantLieuDeLivraison)
go
CREATE TABLE vendre(
	ReferenceFournisseurDuProduit BIGINT,
	IdentifiantFournisseur        BIGINT REFERENCES Fournisseur(IdentifiantFournisseur)  NOT NULL,
	IdentifiantProduit            BIGINT REFERENCES Produit(IdentifiantProduit)  NOT NULL,
	PRIMARY KEY(IdentifiantFournisseur,IdentifiantProduit)
)

go
create index ReferenceDuFournisseur on vendre(ReferenceFournisseurDuProduit)
go
CREATE TABLE contenir(
	quantite            BIGINT,
	PrixDeVente         MONEY,
	IdentifiantProduit  BIGINT REFERENCES Produit(IdentifiantProduit)  NOT NULL,
	IdentifiantCommande BIGINT REFERENCES Commande(IdentifiantCommande)  NOT NULL,
	PRIMARY KEY(IdentifiantProduit,IdentifiantCommande)
)

go
CREATE TABLE composer(
	quantite_livrer           BIGINT,
	PrixVendu                 MONEY,
	IdentifiantProduit        BIGINT REFERENCES Produit(IdentifiantProduit)  NOT NULL,
	IdentfiantLieuDeLivraison BIGINT REFERENCES Livraison(IdentifiantLieuDeLivraison) NOT NULL,
	PRIMARY KEY(IdentifiantProduit,IdentfiantLieuDeLivraison)
)