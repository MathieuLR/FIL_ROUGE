exec sp_addumpdevice 'disk','savFil_Rouge','C:\sauvegardeFil_Rouge\fil_rouge.bak'
go

reconfigure
go

sp_configure 'Agent XPs',1
go

reconfigure
go