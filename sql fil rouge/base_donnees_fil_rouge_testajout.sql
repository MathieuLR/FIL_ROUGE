set dateformat ymd

USE [fil_rouge]
GO
SET IDENTITY_INSERT [dbo].[RubriqueDuProduit] ON 

GO
INSERT [dbo].[RubriqueDuProduit] ([IdentifiantRubrique], [NomRubrique], [Rubrique_principale]) VALUES (1, N'Guitare', NULL)
GO
INSERT [dbo].[RubriqueDuProduit] ([IdentifiantRubrique], [NomRubrique], [Rubrique_principale]) VALUES (2, N'Djembe', NULL)
GO
INSERT [dbo].[RubriqueDuProduit] ([IdentifiantRubrique], [NomRubrique], [Rubrique_principale]) VALUES (3, N'Batterie', NULL)
GO
INSERT [dbo].[RubriqueDuProduit] ([IdentifiantRubrique], [NomRubrique], [Rubrique_principale]) VALUES (4, N'Amplificateur', NULL)
GO
INSERT [dbo].[RubriqueDuProduit] ([IdentifiantRubrique], [NomRubrique], [Rubrique_principale]) VALUES (5, N'TableDeMixage', NULL)
GO
INSERT [dbo].[RubriqueDuProduit] ([IdentifiantRubrique], [NomRubrique], [Rubrique_principale]) VALUES (6, N'Guitare electrique', NULL)
GO
INSERT [dbo].[RubriqueDuProduit] ([IdentifiantRubrique], [NomRubrique], [Rubrique_principale]) VALUES (7, N'Guitare accoustique', NULL)
GO
SET IDENTITY_INSERT [dbo].[RubriqueDuProduit] OFF
GO
INSERT [dbo].[Produit] ([IdentifiantProduit], [LibelleCourtDuProduit], [LibelleLongDuProduit], [PhotoDuProduit], [PrixDachatDuProduit], [ProduitActif], [PrixHorsTaxe], [TVA], [IdentifiantRubrique]) VALUES (1898254564, N'Fen_Arms', N'Fender_Tim_Armstrong', NULL, 422.0000, NULL, 337.6000, 0, NULL)
GO
INSERT [dbo].[Produit] ([IdentifiantProduit], [LibelleCourtDuProduit], [LibelleLongDuProduit], [PhotoDuProduit], [PrixDachatDuProduit], [ProduitActif], [PrixHorsTaxe], [TVA], [IdentifiantRubrique]) VALUES (2472858823, N'Epi_Explo', N'Epiphone_1984_Explorer', NULL, 555.0000, NULL, 444.0000, 0, NULL)
GO
INSERT [dbo].[Produit] ([IdentifiantProduit], [LibelleCourtDuProduit], [LibelleLongDuProduit], [PhotoDuProduit], [PrixDachatDuProduit], [ProduitActif], [PrixHorsTaxe], [TVA], [IdentifiantRubrique]) VALUES (2978612479, N'Mille_Drum', N'Millenium_Drumset', NULL, 145.0000, NULL, 116.0000, 0, NULL)
GO
INSERT [dbo].[Produit] ([IdentifiantProduit], [LibelleCourtDuProduit], [LibelleLongDuProduit], [PhotoDuProduit], [PrixDachatDuProduit], [ProduitActif], [PrixHorsTaxe], [TVA], [IdentifiantRubrique]) VALUES (3126483282, N'Mack_Pro', N'Mackie_Pro_Fx', NULL, 965.0000, NULL, 772.0000, 0, NULL)
GO
INSERT [dbo].[Produit] ([IdentifiantProduit], [LibelleCourtDuProduit], [LibelleLongDuProduit], [PhotoDuProduit], [PrixDachatDuProduit], [ProduitActif], [PrixHorsTaxe], [TVA], [IdentifiantRubrique]) VALUES (3316815698, N'Sam_Mix', N'Samson_Mix_Pad', NULL, 268.0000, NULL, 214.4000, 0, NULL)
GO
INSERT [dbo].[Produit] ([IdentifiantProduit], [LibelleCourtDuProduit], [LibelleLongDuProduit], [PhotoDuProduit], [PrixDachatDuProduit], [ProduitActif], [PrixHorsTaxe], [TVA], [IdentifiantRubrique]) VALUES (3362775779, N'Chap_Gho', N'Chapman_Ghost', NULL, 969.0000, NULL, 775.2000, 0, NULL)
GO
INSERT [dbo].[Produit] ([IdentifiantProduit], [LibelleCourtDuProduit], [LibelleLongDuProduit], [PhotoDuProduit], [PrixDachatDuProduit], [ProduitActif], [PrixHorsTaxe], [TVA], [IdentifiantRubrique]) VALUES (3538915939, N'Aer_Comp', N'Aer_Compact_60', NULL, 995.0000, NULL, 796.0000, 0, NULL)
GO
INSERT [dbo].[Produit] ([IdentifiantProduit], [LibelleCourtDuProduit], [LibelleLongDuProduit], [PhotoDuProduit], [PrixDachatDuProduit], [ProduitActif], [PrixHorsTaxe], [TVA], [IdentifiantRubrique]) VALUES (3692378495, N'Thom_Djem', N'Thomann_Djembe', NULL, 138.0000, NULL, 110.4000, 0, NULL)
GO
INSERT [dbo].[Produit] ([IdentifiantProduit], [LibelleCourtDuProduit], [LibelleLongDuProduit], [PhotoDuProduit], [PrixDachatDuProduit], [ProduitActif], [PrixHorsTaxe], [TVA], [IdentifiantRubrique]) VALUES (3796468982, N'All_Hea', N'Allen_Heath', NULL, 244.0000, NULL, 195.2000, 0, NULL)
GO
INSERT [dbo].[Produit] ([IdentifiantProduit], [LibelleCourtDuProduit], [LibelleLongDuProduit], [PhotoDuProduit], [PrixDachatDuProduit], [ProduitActif], [PrixHorsTaxe], [TVA], [IdentifiantRubrique]) VALUES (4355998478, N'Beh_Xen', N'Behringer_Xenyx', NULL, 166.0000, NULL, 132.8000, 0, NULL)
GO
INSERT [dbo].[Produit] ([IdentifiantProduit], [LibelleCourtDuProduit], [LibelleLongDuProduit], [PhotoDuProduit], [PrixDachatDuProduit], [ProduitActif], [PrixHorsTaxe], [TVA], [IdentifiantRubrique]) VALUES (4899759848, N'Pear_Arct', N'Pearl_Arctic_Spar', NULL, 759.0000, NULL, 607.2000, 0, NULL)
GO
INSERT [dbo].[Produit] ([IdentifiantProduit], [LibelleCourtDuProduit], [LibelleLongDuProduit], [PhotoDuProduit], [PrixDachatDuProduit], [ProduitActif], [PrixHorsTaxe], [TVA], [IdentifiantRubrique]) VALUES (5319676538, N'Hel_Jun', N'Hellweg_Junior_CM', NULL, 215.0000, NULL, 172.0000, 0, NULL)
GO
INSERT [dbo].[Produit] ([IdentifiantProduit], [LibelleCourtDuProduit], [LibelleLongDuProduit], [PhotoDuProduit], [PrixDachatDuProduit], [ProduitActif], [PrixHorsTaxe], [TVA], [IdentifiantRubrique]) VALUES (6196385464, N'Rem_Acous', N'Remo_Tuned_Acousticon', NULL, 309.0000, NULL, 247.2000, 0, NULL)
GO
INSERT [dbo].[Produit] ([IdentifiantProduit], [LibelleCourtDuProduit], [LibelleLongDuProduit], [PhotoDuProduit], [PrixDachatDuProduit], [ProduitActif], [PrixHorsTaxe], [TVA], [IdentifiantRubrique]) VALUES (6348876411, N'Orte', N'Ortega_WR', NULL, 175.0000, NULL, 140.0000, 0, NULL)
GO
INSERT [dbo].[Produit] ([IdentifiantProduit], [LibelleCourtDuProduit], [LibelleLongDuProduit], [PhotoDuProduit], [PrixDachatDuProduit], [ProduitActif], [PrixHorsTaxe], [TVA], [IdentifiantRubrique]) VALUES (6729291892, N'Gibs_Explo', N'Gibson_Explorer', NULL, 1055.0000, NULL, 844.0000, 0, NULL)
GO
INSERT [dbo].[Produit] ([IdentifiantProduit], [LibelleCourtDuProduit], [LibelleLongDuProduit], [PhotoDuProduit], [PrixDachatDuProduit], [ProduitActif], [PrixHorsTaxe], [TVA], [IdentifiantRubrique]) VALUES (6766238824, N'Sound', N'Soundcraft_Ui', NULL, 544.0000, NULL, 435.2000, 0, NULL)
GO
INSERT [dbo].[Produit] ([IdentifiantProduit], [LibelleCourtDuProduit], [LibelleLongDuProduit], [PhotoDuProduit], [PrixDachatDuProduit], [ProduitActif], [PrixHorsTaxe], [TVA], [IdentifiantRubrique]) VALUES (7584131472, N'Yama_Mg', N'Yamaha_MG16', NULL, 476.0000, NULL, 380.8000, 0, NULL)
GO
INSERT [dbo].[Produit] ([IdentifiantProduit], [LibelleCourtDuProduit], [LibelleLongDuProduit], [PhotoDuProduit], [PrixDachatDuProduit], [ProduitActif], [PrixHorsTaxe], [TVA], [IdentifiantRubrique]) VALUES (9456541233, N'Schec_Mer', N'Schecter_Keith_Merrow', NULL, 1299.0000, NULL, 1039.2000, 0, NULL)
GO
INSERT [dbo].[Produit] ([IdentifiantProduit], [LibelleCourtDuProduit], [LibelleLongDuProduit], [PhotoDuProduit], [PrixDachatDuProduit], [ProduitActif], [PrixHorsTaxe], [TVA], [IdentifiantRubrique]) VALUES (9756492716, N'Jack_Rho', N'Jackson_', NULL, 298.0000, NULL, 238.4000, 0, NULL)
GO
INSERT [dbo].[Produit] ([IdentifiantProduit], [LibelleCourtDuProduit], [LibelleLongDuProduit], [PhotoDuProduit], [PrixDachatDuProduit], [ProduitActif], [PrixHorsTaxe], [TVA], [IdentifiantRubrique]) VALUES (9853744466, N'Yam_C40', N'Yamaha_C40', NULL, 129.0000, NULL, 103.2000, 0, NULL)
GO
INSERT [dbo].[Fournisseur] ([IdentifiantFournisseur], [Importateur], [NomDuFournisseur], [AdresseDuFournisseur], [VilleDuFournisseur], [CodePostalDuFournisseur], [AdresseMailDuFournisseur], [TelephoneDuFournisseur]) VALUES (8546545645, NULL, N'Bass Maniac', N'17 rue de Douai', N'Paris', 75009, N'bass,maniac@wanadoo,fr', 153219119)
GO
INSERT [dbo].[Fournisseur] ([IdentifiantFournisseur], [Importateur], [NomDuFournisseur], [AdresseDuFournisseur], [VilleDuFournisseur], [CodePostalDuFournisseur], [AdresseMailDuFournisseur], [TelephoneDuFournisseur]) VALUES (8646515341, NULL, N'Porchez Musique', N'56 avenue Général Leclerc', N'Foix', 9000, N'porchez,musique@wanadoo,fr', 561650150)
GO
INSERT [dbo].[Fournisseur] ([IdentifiantFournisseur], [Importateur], [NomDuFournisseur], [AdresseDuFournisseur], [VilleDuFournisseur], [CodePostalDuFournisseur], [AdresseMailDuFournisseur], [TelephoneDuFournisseur]) VALUES (8986214569, NULL, N'Colos music', N'17 rue Blanchers', N'Toulouse', 31000, N'colos,music@wanadoo,fr', 561221845)
GO
INSERT [dbo].[Fournisseur] ([IdentifiantFournisseur], [Importateur], [NomDuFournisseur], [AdresseDuFournisseur], [VilleDuFournisseur], [CodePostalDuFournisseur], [AdresseMailDuFournisseur], [TelephoneDuFournisseur]) VALUES (9656465468, NULL, N'Macca Music', N'avenue Michel Serres', N'Agen', 47000, N'maccca,music@wanadoo,fr', 553666014)
GO
INSERT [dbo].[vendre] ([ReferenceFournisseurDuProduit], [IdentifiantFournisseur], [IdentifiantProduit]) VALUES (111112, 9656465468, 3126483282)
GO
INSERT [dbo].[vendre] ([ReferenceFournisseurDuProduit], [IdentifiantFournisseur], [IdentifiantProduit]) VALUES (111112, 9656465468, 3316815698)
GO
INSERT [dbo].[vendre] ([ReferenceFournisseurDuProduit], [IdentifiantFournisseur], [IdentifiantProduit]) VALUES (142536, 8646515341, 2472858823)
GO
INSERT [dbo].[vendre] ([ReferenceFournisseurDuProduit], [IdentifiantFournisseur], [IdentifiantProduit]) VALUES (142536, 8646515341, 3362775779)
GO
INSERT [dbo].[vendre] ([ReferenceFournisseurDuProduit], [IdentifiantFournisseur], [IdentifiantProduit]) VALUES (142536, 8646515341, 4355998478)
GO
INSERT [dbo].[vendre] ([ReferenceFournisseurDuProduit], [IdentifiantFournisseur], [IdentifiantProduit]) VALUES (583669, 8546545645, 1898254564)
GO
INSERT [dbo].[vendre] ([ReferenceFournisseurDuProduit], [IdentifiantFournisseur], [IdentifiantProduit]) VALUES (583669, 8546545645, 5319676538)
GO
INSERT [dbo].[vendre] ([ReferenceFournisseurDuProduit], [IdentifiantFournisseur], [IdentifiantProduit]) VALUES (583669, 8546545645, 6348876411)
GO
INSERT [dbo].[vendre] ([ReferenceFournisseurDuProduit], [IdentifiantFournisseur], [IdentifiantProduit]) VALUES (785421, 8986214569, 2978612479)
GO
INSERT [dbo].[vendre] ([ReferenceFournisseurDuProduit], [IdentifiantFournisseur], [IdentifiantProduit]) VALUES (785421, 8986214569, 6766238824)
GO
INSERT [dbo].[vendre] ([ReferenceFournisseurDuProduit], [IdentifiantFournisseur], [IdentifiantProduit]) VALUES (785421, 8986214569, 9756492716)
GO
INSERT [dbo].[Service_Commercial] ([IdentifiantServiceCommercial], [NomDuCommercial], [PrenomDuCommercial], [AdresseDuCommercial], [VilleDuCommercial], [CodePostalDuCommercial], [TelephoneDuCommercial], [ClientParticulier], [AdresseMailDuCommercial]) VALUES (27354856975, N'Petit', N'Christophe', N'156 avenue de rien', N'Marseille', 13003, 458253698, 0, N'christophe,petit@wanadoo,fr')
GO
INSERT [dbo].[Service_Commercial] ([IdentifiantServiceCommercial], [NomDuCommercial], [PrenomDuCommercial], [AdresseDuCommercial], [VilleDuCommercial], [CodePostalDuCommercial], [TelephoneDuCommercial], [ClientParticulier], [AdresseMailDuCommercial]) VALUES (85234562156, N'Dupond', N'Jean', N'12 rue de l''impasse', N'Paris', 75016, 152369878, 1, N'dupond,jean@wanadoo,fr')
GO
INSERT [dbo].[Client] ([IdentifiantClient], [ReferenceDuClient], [NomDuClient], [PrenomDuClient], [Coefficient], [AdresseDuClient], [VilleDuClient], [CodePostalDuClient], [AdresseMailDuClient], [TelephoneDuClient], [IdentifiantServiceCommercial], [NumeroSiret], [NomEnseigne], [ComplementAdresse], [AdresseDeLivraisonClient], [ComplementAdresseClient], [VilleDeLivraisonClient], [CodePostalDeLivraisonClient], [ClientParticulier], [Sexe], [ClientActif]) VALUES (460446413, 123456, N'Fedner', N'Jean Pierre', NULL, N'17 rue du moulin de la pointe', N'Paris', 75013, N'jeanpierre,fedner@wanadoo,fr', 627943269, 27354856975, 5984123, N'Isavert', N'batiment 6', N'28 rue du poulin de la mointe', N'Cedex9', N'Lille', 59000, 1, 1, 1)
GO
INSERT [dbo].[Client] ([IdentifiantClient], [ReferenceDuClient], [NomDuClient], [PrenomDuClient], [Coefficient], [AdresseDuClient], [VilleDuClient], [CodePostalDuClient], [AdresseMailDuClient], [TelephoneDuClient], [IdentifiantServiceCommercial], [NumeroSiret], [NomEnseigne], [ComplementAdresse], [AdresseDeLivraisonClient], [ComplementAdresseClient], [VilleDeLivraisonClient], [CodePostalDeLivraisonClient], [ClientParticulier], [Sexe], [ClientActif]) VALUES (566546321, 789123, N'Rouillon', N'Camille', NULL, N'106 rue Cauderes', N'Bordeaux', 33800, N'camille,rouillon@wanadoo,fr', 533572888, 85234562156, NULL, NULL, NULL, N'108 rue du ulin de la prointe', N'Cedex6', N'Marseille', 13000, 0, 0, 1)
GO
INSERT [dbo].[Client] ([IdentifiantClient], [ReferenceDuClient], [NomDuClient], [PrenomDuClient], [Coefficient], [AdresseDuClient], [VilleDuClient], [CodePostalDuClient], [AdresseMailDuClient], [TelephoneDuClient], [IdentifiantServiceCommercial], [NumeroSiret], [NomEnseigne], [ComplementAdresse], [AdresseDeLivraisonClient], [ComplementAdresseClient], [VilleDeLivraisonClient], [CodePostalDeLivraisonClient], [ClientParticulier], [Sexe], [ClientActif]) VALUES (654130534, 456789, N'Rahem', N'Sarah', NULL, N'36 rue jacquemars gielee', N'Lille', 59800, N'sarah,rahem@wanadoo,fr', 359086381, 27354856975, NULL, NULL, NULL, N'14 avenue de la sinte', N'Cedexe5', N'Bordeaux', 33000, 0, 0, 1)
GO
INSERT [dbo].[Facture] ([NumeroFacture], [ModePaiementFacture], [DateDeFacture]) VALUES (141894, N'cheque', CAST(N'2016-04-02 00:00:00.000' AS DateTime))
GO
INSERT [dbo].[Facture] ([NumeroFacture], [ModePaiementFacture], [DateDeFacture]) VALUES (387784, N'carte bleue', CAST(N'2016-03-16 00:00:00.000' AS DateTime))
GO
INSERT [dbo].[Facture] ([NumeroFacture], [ModePaiementFacture], [DateDeFacture]) VALUES (731367, N'carte bleue', CAST(N'2016-05-12 00:00:00.000' AS DateTime))
GO
INSERT [dbo].[Commande] ([IdentifiantCommande], [NumeroDeCommande], [DateDeCommande], [AdresseDeLivraison], [VilleDeLivraison], [CodePostalDeLivraison], [PrixTotalCommande], [AdresseDeFacturation], [VilleDeFacturation], [CodePostalDeFacturation], [IdentifiantClient], [NumeroFacture]) VALUES (1797987187, 15338566, CAST(N'2016-05-03 00:00:00.000' AS DateTime), N'83 rue des cordelliers', N'Lille', N'59000', 450.0000, N'151 rue du compostel', N'Beauvais', 60000, 460446413, 141894)
GO
INSERT [dbo].[Commande] ([IdentifiantCommande], [NumeroDeCommande], [DateDeCommande], [AdresseDeLivraison], [VilleDeLivraison], [CodePostalDeLivraison], [PrixTotalCommande], [AdresseDeFacturation], [VilleDeFacturation], [CodePostalDeFacturation], [IdentifiantClient], [NumeroFacture]) VALUES (4548664388, 85365613, CAST(N'2016-04-23 00:00:00.000' AS DateTime), N'25 rue marcadet poissonier', N'Paris', N'75018', 325.0000, N'98 rue de derriere', N'Marseille', 13001, 566546321, 387784)
GO
INSERT [dbo].[Commande] ([IdentifiantCommande], [NumeroDeCommande], [DateDeCommande], [AdresseDeLivraison], [VilleDeLivraison], [CodePostalDeLivraison], [PrixTotalCommande], [AdresseDeFacturation], [VilleDeFacturation], [CodePostalDeFacturation], [IdentifiantClient], [NumeroFacture]) VALUES (6719877186, 98414573, CAST(N'2015-12-12 00:00:00.000' AS DateTime), N'12 rue de l''impasse', N'Amiens', N'80000', 3000.0000, N'12 rue de l''impasse', N'Amiens', 80000, 654130534, 731367)
GO
INSERT [dbo].[Commande] ([IdentifiantCommande], [NumeroDeCommande], [DateDeCommande], [AdresseDeLivraison], [VilleDeLivraison], [CodePostalDeLivraison], [PrixTotalCommande], [AdresseDeFacturation], [VilleDeFacturation], [CodePostalDeFacturation], [IdentifiantClient], [NumeroFacture]) VALUES (9894656464, 45781974, CAST(N'2016-04-12 00:00:00.000' AS DateTime), N'128 avenue des chandeliers', N'Strasbourg', N'67000', 2100.0000, N'414 boulevard des cappucines', N'Nice', 6000, 460446413, NULL)
GO
INSERT [dbo].[contenir] ([quantite], [PrixDeVente], [IdentifiantProduit], [IdentifiantCommande]) VALUES (4, 470.0000, 1898254564, 1797987187)
GO
INSERT [dbo].[contenir] ([quantite], [PrixDeVente], [IdentifiantProduit], [IdentifiantCommande]) VALUES (22, 470.0000, 1898254564, 6719877186)
GO
INSERT [dbo].[contenir] ([quantite], [PrixDeVente], [IdentifiantProduit], [IdentifiantCommande]) VALUES (8, 600.0000, 2472858823, 1797987187)
GO
INSERT [dbo].[contenir] ([quantite], [PrixDeVente], [IdentifiantProduit], [IdentifiantCommande]) VALUES (9, 56.0000, 2472858823, 4548664388)
GO
INSERT [dbo].[contenir] ([quantite], [PrixDeVente], [IdentifiantProduit], [IdentifiantCommande]) VALUES (1, 200.0000, 2978612479, 1797987187)
GO
INSERT [dbo].[contenir] ([quantite], [PrixDeVente], [IdentifiantProduit], [IdentifiantCommande]) VALUES (10, 1200.0000, 3538915939, 4548664388)
GO
INSERT [dbo].[contenir] ([quantite], [PrixDeVente], [IdentifiantProduit], [IdentifiantCommande]) VALUES (8, 1200.0000, 3538915939, 6719877186)
GO
INSERT [dbo].[contenir] ([quantite], [PrixDeVente], [IdentifiantProduit], [IdentifiantCommande]) VALUES (6, 170.0000, 3692378495, 1797987187)
GO
INSERT [dbo].[contenir] ([quantite], [PrixDeVente], [IdentifiantProduit], [IdentifiantCommande]) VALUES (3, 250.0000, 5319676538, 1797987187)
GO
INSERT [dbo].[contenir] ([quantite], [PrixDeVente], [IdentifiantProduit], [IdentifiantCommande]) VALUES (5, 250.0000, 5319676538, 4548664388)
GO
INSERT [dbo].[contenir] ([quantite], [PrixDeVente], [IdentifiantProduit], [IdentifiantCommande]) VALUES (5, 250.0000, 5319676538, 6719877186)
GO
INSERT [dbo].[contenir] ([quantite], [PrixDeVente], [IdentifiantProduit], [IdentifiantCommande]) VALUES (11, 1350.0000, 6729291892, 6719877186)
GO
INSERT [dbo].[contenir] ([quantite], [PrixDeVente], [IdentifiantProduit], [IdentifiantCommande]) VALUES (3, 500.0000, 7584131472, 4548664388)
GO
INSERT [dbo].[contenir] ([quantite], [PrixDeVente], [IdentifiantProduit], [IdentifiantCommande]) VALUES (6, 1400.0000, 7584131472, 6719877186)
GO
INSERT [dbo].[contenir] ([quantite], [PrixDeVente], [IdentifiantProduit], [IdentifiantCommande]) VALUES (2, 1400.0000, 9456541233, 1797987187)
GO
INSERT [dbo].[contenir] ([quantite], [PrixDeVente], [IdentifiantProduit], [IdentifiantCommande]) VALUES (4, 1400.0000, 9456541233, 4548664388)
GO
INSERT [dbo].[contenir] ([quantite], [PrixDeVente], [IdentifiantProduit], [IdentifiantCommande]) VALUES (8, 1400.0000, 9456541233, 6719877186)
GO
INSERT [dbo].[contenir] ([quantite], [PrixDeVente], [IdentifiantProduit], [IdentifiantCommande]) VALUES (7, 350.0000, 9756492716, 4548664388)
GO
INSERT [dbo].[Livraison] ([IdentifiantLieuDeLivraison], [LivraisonPartielle], [DateDeLivraison], [NumeroDeLivraison], [BonDeLivraison], [IdentifiantCommande]) VALUES (4522691367, NULL, CAST(N'2016-03-21 00:00:00.000' AS DateTime), 6842357, N'GHDOQE', 1797987187)
GO
INSERT [dbo].[Livraison] ([IdentifiantLieuDeLivraison], [LivraisonPartielle], [DateDeLivraison], [NumeroDeLivraison], [BonDeLivraison], [IdentifiantCommande]) VALUES (6597894646, NULL, NULL, 6842357, N'GHDOQE', 1797987187)
GO
INSERT [dbo].[Livraison] ([IdentifiantLieuDeLivraison], [LivraisonPartielle], [DateDeLivraison], [NumeroDeLivraison], [BonDeLivraison], [IdentifiantCommande]) VALUES (6985472315, NULL, CAST(N'2016-05-12 00:00:00.000' AS DateTime), 9512458, N'ONFSNF', 6719877186)
GO
