--Cr�ez une proc�dure stock�e qui s�lectionne les commandes non sold�es (en cours
--de livraison), puis une autre qui renvoie le d�lai moyen entre la date de commande
--et la date de facturation. 
drop proc procedurepourfilrouge
create proc procedurepourfilrouge as
select client.NomDuClient,client.IdentifiantClient ,commande.IdentifiantCommande,datedecommande,DateDeLivraison
from commande
join livraison on livraison.IdentifiantCommande=commande.IdentifiantCommande
join client on commande.identifiantclient=client.identifiantclient
where DateDeLivraison is null

exec procedurepourfilrouge

create proc delaimoyencommande as
select commande.IdentifiantClient ,avg(datediff (dd,datedecommande,datedefacture))
from Commande
join Facture on commande.NumeroFacture=facture.NumeroFacture
group by  commande.IdentifiantClient

exec delaimoyencommande


--Cr�ez une vue correspondant � la jointure Produits - Fournisseurs :

create view ProduitsFournisseur as
select produit.identifiantproduit,LibelleLongDuProduit,NomDuFournisseur
from Produit
join vendre on produit.IdentifiantProduit=vendre.IdentifiantProduit
join fournisseur on vendre.IdentifiantFournisseur=fournisseur.IdentifiantFournisseur


select *
from ProduitsFournisseur