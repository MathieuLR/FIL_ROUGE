create login equipegestion with password = 'equipegestion', DEFAULT_DATABASE=[master],CHECK_EXPIRATION=OFF, CHECK_POLICY=OFF
go
create login equipegestion_1 with password = 'equipegestion_1', DEFAULT_DATABASE=[master],CHECK_EXPIRATION=OFF, CHECK_POLICY=OFF
go
create login equipegestion_2 with password = 'equipegestion_2', DEFAULT_DATABASE=[master],CHECK_EXPIRATION=OFF, CHECK_POLICY=OFF
go

use fil_rouge
go
create user equipegestion for login equipegestion
create user equipegestion_1 for login equipegestion_1
create user equipegestion_2 for login equipegestion_2

go

create role gestionbase
grant select on produit to gestionbase
grant select on RubriqueDuProduit to gestionbase
grant insert on produit to gestionbase
grant insert on RubriqueDuProduit to gestionbase
grant update on produit to gestionbase
grant update on RubriqueDuProduit to gestionbase
grant delete on produit to gestionbase
grant delete on RubriqueDuProduit to gestionbase

go

execute sp_addrolemember 'gestionbase','equipegestion'
execute sp_addrolemember 'gestionbase','equipegestion_1'
execute sp_addrolemember 'gestionbase','equipegestion_2'

go

create login servicecommercial with password = 'servicecommercial', DEFAULT_DATABASE=[master],CHECK_EXPIRATION=OFF, CHECK_POLICY=OFF
create login servicecommercial_1 with password = 'servicecommercial_1', DEFAULT_DATABASE=[master],CHECK_EXPIRATION=OFF, CHECK_POLICY=OFF
create login servicecommercial_2 with password = 'servicecommercial_2', DEFAULT_DATABASE=[master],CHECK_EXPIRATION=OFF, CHECK_POLICY=OFF

go

create user servicecommercial for login servicecommercial
create user servicecommercial_1 for login servicecommercial_1
create user servicecommercial_2 for login servicecommercial_2

go

create role gestionclient
grant select on fournisseur to gestionclient
grant select on client to gestionclient
grant select on service_commercial to gestionclient
grant select on vendre to gestionclient
grant select on contenir to gestionclient
grant select on commande to gestionclient
grant insert on fournisseur to gestionclient
grant insert on client to gestionclient
grant insert on service_commercial to gestionclient
grant insert on vendre to gestionclient
grant insert on contenir to gestionclient
grant insert on commande to gestionclient
grant update on fournisseur to gestionclient
grant update on client to gestionclient
grant update on service_commercial to gestionclient
grant update on vendre to gestionclient
grant update on contenir to gestionclient
grant update on commande to gestionclient
grant delete on fournisseur to gestionclient
grant delete on client to gestionclient
grant delete on service_commercial to gestionclient
grant delete on vendre to gestionclient
grant delete on contenir to gestionclient
grant delete on commande to gestionclient

go

execute sp_addrolemember 'gestionclient','servicecommercial'
execute sp_addrolemember 'gestionclient','servicecommercial_1'
execute sp_addrolemember 'gestionclient','servicecommercial_2'

go

create login equipecomptabilite with password = 'equipecomptabilite', DEFAULT_DATABASE=[master],CHECK_EXPIRATION=OFF, CHECK_POLICY=OFF
create login equipecomptabilite_1 with password = 'equipecomptabilite_1', DEFAULT_DATABASE=[master],CHECK_EXPIRATION=OFF, CHECK_POLICY=OFF
create login equipecomptabilite_2 with password = 'equipecomptabilite_2', DEFAULT_DATABASE=[master],CHECK_EXPIRATION=OFF, CHECK_POLICY=OFF

go

create user equipecomptabilite for login equipecomptabilite
create user equipecomptabilite_1 for login equipecomptabilite_1
create user equipecomptabilite_2 for login equipecomptabilite_2

go

create role gestioncomptabilite
grant select on commande to gestioncomptabilite
grant select on contenir to gestioncomptabilite
grant select on client to gestioncomptabilite
grant insert on commande to gestioncomptabilite
grant update on commande to gestioncomptabilite
grant delete on commande to gestioncomptabilite

go

execute sp_addrolemember 'gestioncomptabilite','equipecomptabilite'
execute sp_addrolemember 'gestioncomptabilite','equipecomptabilite_1'
execute sp_addrolemember 'gestioncomptabilite','equipecomptabilite_2'

go

create login serviceapresvente with password = 'serviceapresvente', DEFAULT_DATABASE=[master],CHECK_EXPIRATION=OFF, CHECK_POLICY=OFF
create login serviceapresvente_1 with password = 'serviceapresvente_1', DEFAULT_DATABASE=[master],CHECK_EXPIRATION=OFF, CHECK_POLICY=OFF
create login serviceapresvente_2 with password = 'serviceapresvente_2', DEFAULT_DATABASE=[master],CHECK_EXPIRATION=OFF, CHECK_POLICY=OFF

go

create user serviceapresvente for login serviceapresvente
create user serviceapresvente_1 for login serviceapresvente_1
create user serviceapresvente_2 for login serviceapresvente_2

go

create role gestionapresvente
grant select on livraison to gestionapresvente
grant select on commande to gestionapresvente
grant select on facture to gestionapresvente
grant select on client to gestionapresvente

go

execute sp_addrolemember 'gestionapresvente','serviceapresvente'
execute sp_addrolemember 'gestionapresvente','serviceapresvente_1'
execute sp_addrolemember 'gestionapresvente','serviceapresvente_2'

go

create login client with password = 'client', DEFAULT_DATABASE=[master],CHECK_EXPIRATION=OFF, CHECK_POLICY=OFF

go

create user client for login client
create role LeClient
grant select, update on client to client
 
go

execute sp_addrolemember 'Leclient','client'

go

create role visiteur
grant select on produit to visiteur
grant select, insert on client to visiteur
revoke select on produit(PrixDachatDuProduit) to visiteur


