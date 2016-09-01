-- Chiffre d'affaire généré pour l'ensemble et par fournisseur

select sum(quantite*prixdevente) as 'chiffre d''affaire total'
from contenir


select fournisseur.IdentifiantFournisseur,NomDuFournisseur,sum(quantite*prixdevente) as 'chiffre d''affaire'
from contenir
join produit on contenir.IdentifiantProduit=produit.IdentifiantProduit
join vendre on produit.IdentifiantProduit=vendre.IdentifiantProduit
join fournisseur on vendre.IdentifiantFournisseur=Fournisseur.IdentifiantFournisseur
group by fournisseur.IdentifiantFournisseur,NomDuFournisseur
order by 'chiffre d''affaire'


-- Liste des produits commandés (ref produit, qte commandé)

select produit.identifiantproduit,contenir.quantite
from produit
join contenir on contenir.IdentifiantProduit=produit.IdentifiantProduit


-- Liste des commandes pour un client (date, ref client, montant)

drop proc UnSeulClient
create proc UnSeulClient 
@NomDuClient VARCHAR (200) as
select  distinct NomDuClient,datedecommande,referenceduclient,prixtotalcommande
from Commande
join Client on client.IdentifiantClient=commande.IdentifiantClient
where NomDuClient like @NomDuClient
exec UnSeulClient 'fedner'

-- Répartition du chiffre d'affaire par type de client

select
	CASE
		WHEN service_commercial.clientparticulier=0 THEN 'Pro'
		WHEN service_commercial.clientparticulier=1 THEN 'Par'
	END
,sum(quantite*prixdevente) as 'chiffre d''affaire'
from contenir
join commande on contenir.identifiantcommande=commande.identifiantcommande
join client on commande.identifiantclient=client.identifiantclient
join service_commercial on client.IdentifiantServiceCommercial=Service_Commercial.IdentifiantServiceCommercial
group by service_commercial.clientparticulier


-- Lister les commandes en cours de livraison
select commande.IdentifiantCommande,datedecommande,DateDeLivraison
from commande
join livraison on livraison.IdentifiantCommande=commande.IdentifiantCommande
where DateDeLivraison is null



