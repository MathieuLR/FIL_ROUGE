exec sp_addumpdevice 'disk','savFil_Rouge','C:\sauvegardeFil_Rouge\fil_rouge.bak'backup database fil_rouge to savFil_Rougealter database fil_rouge set restricted_user with rollback immediaterestore database fil_rouge from savFil_Rouge with replacealter database fil_rouge set multi_usersp_configure 'show advanced option',1
go

reconfigure
go

sp_configure 'Agent XPs',1
go

reconfigure
go